using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP01EF2024.Entidades;
using TP01EF2024.Servicios.Interfaces;
using TP01EF2024.Windows.Helpers;
using Size = TP01EF2024.Entidades.Size;

namespace TP01EF2024.Windows.Shoes
{
    public partial class frmShoesDetalles : Form
    {
        private readonly IShoesService _servicioShoes;

        Shoe? shoe;

        List<Size>? sizes;

        List<ShoeSize> shoesSizes = new List<ShoeSize>();

        List<ShoeSize> shoesSizesPaginados = new List<ShoeSize>();

        private int cantidadPaginas;
        private int pageSize = 7;
        private int pageNum = 0;
        private int cantidadRegistros;

        public frmShoesDetalles(Shoe shoe, IShoesService service)
        {
            InitializeComponent();

            this.shoe = shoe;

            _servicioShoes = service;

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (shoe != null)
            {
                sizes = _servicioShoes.GetSizesForShoe(shoe.ShoeId);

                shoesSizes.Clear();

                GetShoesSizes(sizes);

                cantidadRegistros = shoesSizes.Count();

                cantidadPaginas = FormHelpers.CalcularPaginas(cantidadRegistros, pageSize);

                PaginaActualLbl.Text = (pageNum + 1).ToString();

                CantidadPaginasLbl.Text = cantidadPaginas.ToString();

                RecargarGrilla();
            }
            ModeloLbl.Text = shoe.Model;
            MarcaLbl.Text = shoe.Brand.BrandName;
            DeporteLbl.Text = shoe.Sport.SportName;
            GeneroLbl.Text = shoe.Genre.GenreName;
            ColorLbl.Text = shoe.Colour.ColourName;
            PrecioLbl.Text = shoe.Price.ToString();
            DescripcionTxt.Text = shoe.Description;
        }

        private void GetShoesSizes(List<Size> sizes)
        {
            foreach (var s in sizes)
            {
                var ss = _servicioShoes.GetShoeSize(shoe, s);
                if (ss != null)
                {
                    shoesSizes.Add(ss);
                }
            }
        }


        private void RecargarGrilla()
        {
            shoesSizesPaginados = _servicioShoes.GetShoesSizesPaginados(pageNum, pageSize, shoe);

            GridHelpers.MostrarDatosEnGrilla<ShoeSize>(shoesSizesPaginados, DgvShoesSizes);
        }

        private void AgregarTalleBtn_Click(object sender, EventArgs e)
        {
            frmShoesSizesAE frm = new frmShoesSizesAE(shoe);

            DialogResult dr = frm.ShowDialog(this);

            if (dr == DialogResult.Cancel) { return; }
            try
            {
                ShoeSize shoesize = frm.GetShoeSize();

                if (shoesize is null) return;

                if (!_servicioShoes.ExisteShoeSize(shoesize))
                {
                    _servicioShoes.AgregarShoeSize(shoesize);

                    shoesSizes.Clear();

                    RecargarGrilla();

                    MessageBox.Show("Registro agregado", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El registro ya existe, no es posible agregarlo nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EditarTalleBtn_Click(object sender, EventArgs e)
        {
            if (DgvShoesSizes.SelectedRows.Count == 0) { return; }

            var r = DgvShoesSizes.SelectedRows[0];

            ShoeSize shoeSize = (ShoeSize)r.Tag;

            if (shoeSize == null) return;

            frmShoesSizesAE frm = new frmShoesSizesAE(shoe);

            frm.SetShoeSize(shoeSize);

            DialogResult dr = frm.ShowDialog(this);

            if (dr == DialogResult.Cancel) { return; }

            try
            {

                ShoeSize shoesize = frm.GetShoeSize();

                if (shoesize is null) return;

                if (!_servicioShoes.ExisteShoeSize(shoesize))
                {
                    _servicioShoes.ActualizarShoeSize(shoesize);

                    MessageBox.Show("Registro actualizado", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    shoesSizes.Clear();

                    RecargarGrilla();
                }
                else
                {
                    MessageBox.Show("El registro ya existe, no es posible agregarlo nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void EliminarTalleBtn_Click(object sender, EventArgs e)
        {
            if (DgvShoesSizes.SelectedRows.Count == 0) { return; }

            var r = DgvShoesSizes.SelectedRows[0];

            if (r.Tag is not null)
            {
                ShoeSize shoeSize = (ShoeSize)r.Tag;

                DialogResult dr = MessageBox.Show($"¿Desea dar de baja el talle {shoeSize.Size.SizeNumber}?",
                    "Confirmar Operación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.No) { return; }

                try
                {
                    _servicioShoes.EliminarShoeSize(shoeSize);

                    shoesSizes.Clear();

                    RecargarGrilla();

                    MessageBox.Show("Registro eliminado satisfactoriamente!", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }

        private void PagSiguienteBtn_Click(object sender, EventArgs e)
        {
            pageNum++;
            if (pageNum > cantidadPaginas - 1) { pageNum = cantidadPaginas - 1; }
            PaginaActualLbl.Text = (pageNum + 1).ToString();
            RecargarGrilla();

        }

        private void PagAnteriorBtn_Click(object sender, EventArgs e)
        {
            pageNum--;
            if (pageNum < 0) { pageNum = 0; }
            PaginaActualLbl.Text = (pageNum + 1).ToString();
            RecargarGrilla();

        }
    }
}

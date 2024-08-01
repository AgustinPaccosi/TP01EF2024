using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP01EF2024.Entidades.Enum;
using TP01EF2024.Entidades;
using TP01EF2024.Windows.Helpers;
using TP01EF2024.Servicios.Interfaces;
using TP01EF2024.Entidades.Dtos;

namespace TP01EF2024.Windows.Shoes
{
    public partial class frmShoes : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IShoesService _servicio;
        private List<ShoeDto>? lista;
        private Orden orden = Orden.SinOrden;


        private Brand? brandFiltro = null;
        private Genre? genreFiltro = null;

        private bool FilterOn = false;

        private int pageCount;
        private int pageSize = 2;
        private int pageNum = 0;
        private int recordCount;

        public frmShoes(IShoesService servicioShoe,
            IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _servicio = servicioShoe;
            _serviceProvider = serviceProvider;
        }


        private void frmShoes_Load(object sender, EventArgs e)
        {
            MostrarCantidadRegistros();
            RecargarGrilla();

        }
        private void RecargarGrilla()
        {
            try
            {
                recordCount = _servicio.GetCantidad();
                pageCount = FormHelpers.CalcularPaginas(recordCount, pageSize);
                TxbCantRegistros.Text = pageCount.ToString();
                CombosHelpers.CargarCombosPaginas(pageCount, ref ComboBoxPaginas);
                lista = _servicio.GetListaPaginadaOrdenada(pageNum, pageSize);
                MostrarDatosEnGrilla();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MostrarDatosEnGrilla()
        {
            GridHelpers.LimpiarGrilla(dgvDatos);
            if (lista is not null)
            {
                foreach (var item in lista)
                {
                    DataGridViewRow r = GridHelpers.ConstruirFila(dgvDatos);
                    GridHelpers.SetearFila(r, item);
                    GridHelpers.AgregarFila(r, dgvDatos);
                }
            }
        }

        private void MostrarCantidadRegistros()
        {
            lblRegistros.Text = _servicio.GetCantidad().ToString();
        }

        private void ToolButtonNuevo_Click(object sender, EventArgs e)
        {
            frmShoesAE frm = new frmShoesAE(_serviceProvider);
            DialogResult df = frm.ShowDialog(this);
            if (df == DialogResult.Cancel) { return; }
            try
            {
                var shoe = frm.GetShoe();
                if (shoe == null) return;
                if (!_servicio.Existe(shoe))
                {
                    _servicio.Guardar(shoe);
                    ActualizarAgregar(shoe);
                    MessageBox.Show("Registro Agregado!!!", "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    MostrarCantidadRegistros();
                }
                else
                {
                    MessageBox.Show("Planta existente!!!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void ActualizarAgregar(Shoe shoe)
        {
            int paginaActual = pageNum;
            lista = _servicio.GetListaPaginadaOrdenada(paginaActual, pageSize);
            MostrarDatosEnGrilla();
            bool shoeAgregadoEnPaginaActual = lista
                .Any(p => p.ShoeId == shoe.ShoeId);

            if (!shoeAgregadoEnPaginaActual)
            {
                pageNum = pageCount - 1;
                ComboBoxPaginas.SelectedIndex = pageNum;
                lista = _servicio.GetListaPaginadaOrdenada(pageNum, pageSize);
                MostrarDatosEnGrilla();
            }
        }

        private void TsButtonBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            ShoeDto? shoeDto = r.Tag as ShoeDto;
            if (shoeDto == null) return;
            Shoe? shoe = _servicio.GetShoePorId(shoeDto.ShoeId);
            DialogResult dr = MessageBox.Show($"¿Desea dar de baja el registro?",
                "Confirmar Operación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            try
            {
                if (shoe == null) return;
                _servicio.Eliminar(shoe);
                GridHelpers.QuitarFila(r, dgvDatos);
                MessageBox.Show("Registro Borrado!!!", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                RercargarListaPaginada();
                MostrarCantidadRegistros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TsButtonEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) { return; }
            var r = dgvDatos.SelectedRows[0];
            ShoeDto? shoeDto = r.Tag as ShoeDto;
            if (shoeDto == null) return;
            Shoe? shoe = _servicio.GetShoePorId(shoeDto.ShoeId);
            frmShoesAE frm = new frmShoesAE(_serviceProvider)
            { Text = "Editar Shoe" };
            frm.SetShoe(shoe);
            DialogResult dr = frm.ShowDialog(this);
            try
            {
                shoe = frm.GetShoe();
                if (shoe == null) return;
                if (!_servicio.Existe(shoe))
                {
                    _servicio.Guardar(shoe);
                    MessageBox.Show("Registro Editado!!!", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //ActualizarListaDespuesAgregar(shoe);
                    RercargarListaPaginada();
                }
                else
                {
                    MessageBox.Show("Shoe existente!!!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void TsButtonFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void TsButtonActualizar_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonPrimero_Click(object sender, EventArgs e)
        {
            pageNum = 0;
            ComboBoxPaginas.SelectedIndex = pageNum;
            RercargarListaPaginada();

        }

        private void RercargarListaPaginada()
        {
            lista = _servicio.GetListaPaginadaOrdenada(pageNum, pageSize);
            MostrarDatosEnGrilla();

        }

        private void ButtonAnterior_Click(object sender, EventArgs e)
        {
            pageNum--;
            if (pageNum < 0) { pageNum = 0; }
            ComboBoxPaginas.SelectedIndex = pageNum;
            RercargarListaPaginada();
        }

        private void ButtonSiguiente_Click(object sender, EventArgs e)
        {
            pageNum = pageCount - 1;
            ComboBoxPaginas.SelectedIndex = pageNum;
            RercargarListaPaginada();
        }

        private void ButtonUltimo_Click(object sender, EventArgs e)
        {
            pageNum++;
            if (pageNum > pageCount - 1) { pageNum = pageCount - 1; }
            ComboBoxPaginas.SelectedIndex = pageNum;
            RercargarListaPaginada();
        }

        private void tlbuttonDetalles_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) { return; }

            var r = dgvDatos.SelectedRows[0];

            ShoeDto shoeDto = (ShoeDto)r.Tag;

            Shoe shoe = _servicio.GetShoePorId(shoeDto.ShoeId);

            frmShoesDetalles frm = new frmShoesDetalles(shoe, _servicio);

            frm.Show();

        }
    }
}

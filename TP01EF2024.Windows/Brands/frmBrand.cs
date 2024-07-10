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
using TP01EF2024.Entidades.Dtos;
using TP01EF2024.Servicios.Interfaces;
using TP01EF2024.Windows.Helpers;

namespace TP01EF2024.Windows.Brands
{
    public partial class frmBrand : Form
    {
        private readonly IBrandsService _servicioBrand;
        private readonly IShoesService _servicioShoe;
        private List<Brand>? listaBrands;
        private List<ShoeDto>? listaShoesDto;
        private List<Shoe>? listaShoes;
        public frmBrand(IBrandsService servicio,
            IShoesService servicioShoe)
        {
            InitializeComponent();
            _servicioBrand = servicio;
            _servicioShoe = servicioShoe;
        }

        private void FrmBrands_Load(object sender, EventArgs e)
        {
            MostrarCantidadRegistros();
            RecargarGrilla();
        }

        private void MostrarCantidadRegistros()
        {
            TextBoxCantRegistros.Text = _servicioBrand.GetCantidad().ToString();
        }

        private void RecargarGrilla()
        {
            try
            {
                listaBrands = _servicioBrand.GetBrands();
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
            if (listaBrands is not null)
            {
                foreach (var item in listaBrands)
                {
                    DataGridViewRow r = GridHelpers.ConstruirFila(dgvDatos);
                    GridHelpers.SetearFila(r, item);
                    GridHelpers.AgregarFila(r, dgvDatos);
                }
            }
        }

        private void ToolButtonNuevo_Click_1(object sender, EventArgs e)
        {
            frmBrandAE frm = new frmBrandAE() { Text = "Agregar Marca" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                Brand? brand = frm.GetBrand();
                if (brand == null) return;
                if (!_servicioBrand.Existe(brand))
                {
                    _servicioBrand.Guardar(brand);
                    var r = GridHelpers.ConstruirFila(dgvDatos);
                    GridHelpers.SetearFila(r, brand);
                    GridHelpers.AgregarFila(r, dgvDatos);
                    MessageBox.Show("Registro Agregado", "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    MostrarCantidadRegistros();
                }
                else
                {
                    MessageBox.Show("Registro Duplicado", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void TsButtonBorrar_Click_1(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            Brand? brand = r.Tag as Brand;
            DialogResult dr = MessageBox.Show($"¿Desea dar de baja a la marca {brand?.BrandName}?",
                "Confirmar Operación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            try
            {
                if (brand == null) return;
                if (!_servicioBrand.EstaRelacionado(brand))
                {
                    _servicioBrand.Eliminar(brand);
                    GridHelpers.QuitarFila(r, dgvDatos);
                    MessageBox.Show("Registro Borrado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarCantidadRegistros();
                }
                else
                {
                    MessageBox.Show("Registro Relacionado, Imposible dar de baja!!!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TsButtonEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            Brand? brand = r.Tag as Brand;
            frmBrandAE frm = new frmBrandAE() { Text = "Editar Marca" };
            frm.SetBrand(brand);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                brand = frm.GetBrand();
                if (brand == null) return;
                if (!_servicioBrand.Existe(brand))
                {
                    _servicioBrand.Guardar(brand);
                    GridHelpers.SetearFila(r, brand);
                    MessageBox.Show("Registro Editado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro duplicado", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TsButtonFiltrar_Click_1(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;

            var r = dgvDatos.SelectedRows[0];
            Brand? brand = r.Tag as Brand;
            if (brand == null) return;
            var brandEnDB = _servicioBrand.GetBrandPorId(brand.BrandId);
            listaShoes = _servicioBrand.GetShoes(brandEnDB);
            if (listaShoes == null) return;
            listaShoesDto = _servicioShoe.PasarListaDto(listaShoes);
            //frmMostrarShoes frm = new frmMostrarShoes();
            //frm.SetLista(listaShoesDto);
            //frm.ShowDialog(this);

        }

        private void TsButtonSalir_Click_1(object sender, EventArgs e)
        {
            Close();

        }
    }
}

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
using TP01EF2024.Windows.Colours;
using TP01EF2024.Windows.Helpers;

namespace TP01EF2024.Windows.Colors
{
    public partial class frmColour : Form
    {
        private readonly IColoursService _servicioColour;
        private readonly IShoesService _servicioShoe;
        private List<Colour>? listaColours;
        private List<ShoeDto>? listaShoesDto;
        private List<Shoe>? listaShoes;
        public frmColour(IColoursService servicio,
            IShoesService servicioShoe)
        {
            InitializeComponent();
            _servicioColour = servicio;
            _servicioShoe = servicioShoe;
        }


        private void ToolButtonNuevo_Click(object sender, EventArgs e)
        {
            frmColoursAE frm = new frmColoursAE() { Text = "Agregar Color" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                Colour? colour = frm.GetColour();
                if (colour == null) return;
                if (!_servicioColour.Existe(colour))
                {
                    _servicioColour.Guardar(colour);
                    var r = GridHelpers.ConstruirFila(dgvDatos);
                    GridHelpers.SetearFila(r, colour);
                    GridHelpers.AgregarFila(r, dgvDatos);
                    MessageBox.Show("Registro Agregado!!!", "Mensaje",
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

        private void TsButtonBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            Colour? colour = r.Tag as Colour;
            DialogResult dr = MessageBox.Show($"¿Desea dar de baja al color {colour?.ColourName}?",
                "Confirmar Operación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            try
            {
                if (colour == null) return;
                if (!_servicioColour.EstaRelacionado(colour))
                {
                    _servicioColour.Eliminar(colour);
                    GridHelpers.QuitarFila(r, dgvDatos);
                    MessageBox.Show("Registro Borrado!!!", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarCantidadRegistros();
                }
                else
                {
                    MessageBox.Show("Registro Relacionado...Baja denegada!!!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TsButtonEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            Colour? colour = r.Tag as Colour;
            frmColoursAE frm = new frmColoursAE() { Text = "Editar Color" };
            frm.SetColour(colour);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                colour = frm.GetColour();
                if (colour == null) return;
                if (!_servicioColour.Existe(colour))
                {
                    _servicioColour.Guardar(colour);
                    GridHelpers.SetearFila(r, colour);
                    MessageBox.Show("Registro Editado!!!", "Mensaje",
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

        private void TsButtonFiltrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            Colour? colour = r.Tag as Colour;
            if (colour == null) return;
            var colourEnDB = _servicioColour.GetColourPorId(colour.ColourId);
            listaShoes = _servicioColour.GetShoes(colourEnDB);
            if (listaShoes == null) return;
            listaShoesDto = _servicioShoe.PasarListaDto(listaShoes);
            //FrmMostrarShoes frm = new FrmMostrarShoes();
            //frm.SetLista(listaShoesDto);
            //frm.ShowDialog(this);

        }

        private void TsButtonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmColour_Load(object sender, EventArgs e)
        {
            MostrarCantidadRegistros();
            RecargarGrilla();

        }
        private void RecargarGrilla()
        {
            try
            {
                listaColours = _servicioColour.GetColours();
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
            if (listaColours is not null)
            {
                foreach (var item in listaColours)
                {
                    DataGridViewRow r = GridHelpers.ConstruirFila(dgvDatos);
                    GridHelpers.SetearFila(r, item);
                    GridHelpers.AgregarFila(r, dgvDatos);
                }
            }
        }

        private void MostrarCantidadRegistros()
        {
            lblRegistros.Text = _servicioColour.GetCantidad().ToString();
        }

    }
}

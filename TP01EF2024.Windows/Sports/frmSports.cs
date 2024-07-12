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
using TP01EF2024.Windows.Shoes;

namespace TP01EF2024.Windows.Sports
{
    public partial class frmSports : Form
    {
        private readonly ISportsService _servicioSport;
        private readonly IShoesService _servicioShoe;
        private List<Sport>? listaSports;
        private List<ShoeDto>? listaShoesDto;
        private List<Shoe>? listaShoes;
        public frmSports(ISportsService servicio,
            IShoesService servicioShoe)
        {
            InitializeComponent();
            _servicioSport = servicio;
            _servicioShoe = servicioShoe;
        }


        private void ToolButtonNuevo_Click(object sender, EventArgs e)
        {
            frmSportsAE frm = new frmSportsAE() { Text = "Agregar Deporte" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                Sport? sport = frm.GetSport();
                if (sport == null) return;
                if (!_servicioSport.Existe(sport))
                {
                    _servicioSport.Guardar(sport);
                    var r = GridHelpers.ConstruirFila(dgvDatos);
                    GridHelpers.SetearFila(r, sport);
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
            Sport? sport = r.Tag as Sport;
            DialogResult dr = MessageBox.Show($"¿Desea dar de baja el deporte {sport?.SportName}?",
                "Confirmar Operación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            try
            {
                if (sport == null) return;
                if (!_servicioSport.EstaRelacionado(sport))
                {
                    _servicioSport.Eliminar(sport);
                    GridHelpers.QuitarFila(r, dgvDatos);
                    MessageBox.Show("Registro Borrado!!!", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarCantidadRegistros();
                }
                else
                {
                    MessageBox.Show("Registro Relacionado...Baja denegada!",
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
            Sport? sport = r.Tag as Sport;
            frmSportsAE frm = new frmSportsAE() { Text = "Editar Deporte" };
            frm.SetSport(sport);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                sport = frm.GetSport();
                if (sport == null) return;
                if (!_servicioSport.Existe(sport))
                {
                    _servicioSport.Guardar(sport);
                    GridHelpers.SetearFila(r, sport);
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
            Sport? sport = r.Tag as Sport;
            if (sport == null) return;
            var sportEnDB = _servicioSport.GetSportPorId(sport.SportId);
            listaShoes = _servicioSport.GetShoes(sportEnDB);
            if (listaShoes == null) return;
            listaShoesDto = _servicioShoe.PasarListaDto(listaShoes);
            frmFiltrosShoes frm = new frmFiltrosShoes();
            frm.SetLista(listaShoesDto);
            frm.ShowDialog(this);

        }

        private void TsButtonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSports_Load(object sender, EventArgs e)
        {
            MostrarCantidadRegistros();
            RecargarGrilla();

        }
        private void RecargarGrilla()
        {
            try
            {
                listaSports = _servicioSport.GetSports();
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
            if (listaSports is not null)
            {
                foreach (var item in listaSports)
                {
                    DataGridViewRow r = GridHelpers.ConstruirFila(dgvDatos);
                    GridHelpers.SetearFila(r, item);
                    GridHelpers.AgregarFila(r, dgvDatos);
                }
            }
        }

        private void MostrarCantidadRegistros()
        {
            lblRegistros.Text = _servicioSport.GetCantidad().ToString();

        }


    }
}

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

namespace TP01EF2024.Windows.Genres
{
    public partial class frmGenres : Form
    {
        private readonly IGenresService _servicioGenre;
        private readonly IShoesService _servicioShoe;
        private List<Genre>? listaGenres;
        private List<ShoeDto>? listaShoesDto;
        private List<Shoe>? listaShoes;
        public frmGenres(IGenresService servicio,
            IShoesService servicioShoe)
        {
            InitializeComponent();
            _servicioGenre = servicio;
            _servicioShoe = servicioShoe;
        }

        private void ToolButtonNuevo_Click(object sender, EventArgs e)
        {
            frmGenresAE frm = new frmGenresAE() { Text = "Agregar Genero" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                Genre? genre = frm.GetGenre();
                if (genre == null) return;
                if (!_servicioGenre.Existe(genre))
                {
                    _servicioGenre.Guardar(genre);
                    var r = GridHelpers.ConstruirFila(dgvDatos);
                    GridHelpers.SetearFila(r, genre);
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
            Genre? genre = r.Tag as Genre;
            DialogResult dr = MessageBox.Show($"¿Desea dar de baja el genero {genre?.GenreName}?",
                "Confirmar Operación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            try
            {
                if (genre == null) return;
                if (!_servicioGenre.EstaRelacionado(genre))
                {
                    _servicioGenre.Eliminar(genre);
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
            Genre? genre = r.Tag as Genre;
            frmGenresAE frm = new frmGenresAE() { Text = "Editar Genero" };
            frm.SetGenre(genre);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                genre = frm.GetGenre();
                if (genre == null) return;
                if (!_servicioGenre.Existe(genre))
                {
                    _servicioGenre.Guardar(genre);
                    GridHelpers.SetearFila(r, genre);
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
            Genre? genre = r.Tag as Genre;
            if (genre == null) return;
            var genreEnDB = _servicioGenre.GetGenrePorId(genre.GenreId);
            
            listaShoes = _servicioGenre.GetShoes(genreEnDB);
            if (listaShoes == null) return;
            listaShoesDto = _servicioShoe.PasarListaDto(listaShoes);
            //frmMostrarShoes frm = new frmMostrarShoes();
            //frm.SetLista(listaShoesDto);
            //frm.ShowDialog(this);

        }

        private void TsButtonSalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void frmGenres_Load(object sender, EventArgs e)
        {
            MostrarCantidadRegistros();
            RecargarGrilla();

        }
        private void MostrarCantidadRegistros()
        {
            lblRegistros.Text = _servicioGenre.GetCantidad().ToString();

        }

        private void RecargarGrilla()
        {
            try
            {
                listaGenres = _servicioGenre.GetGenres();
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
            if (listaGenres is not null)
            {
                foreach (var item in listaGenres)
                {
                    DataGridViewRow r = GridHelpers.ConstruirFila(dgvDatos);
                    GridHelpers.SetearFila(r, item);
                    GridHelpers.AgregarFila(r, dgvDatos);
                }
            }
        }

    }
}

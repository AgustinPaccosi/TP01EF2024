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

namespace TP01EF2024.Windows.Genres
{
    public partial class frmGenresAE : Form
    {
        public frmGenresAE()
        {
            InitializeComponent();
        }
        private Genre? genre;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (genre != null)
            {
                TextBoxGenreName.Text = genre.GenreName;
            }
        }

        public Genre? GetGenre()
        {
            return genre;
        }

        public void SetGenre(Genre? genree)
        {
            genre = genree;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (genre == null)
                {
                    genre = new Genre();

                }
                genre.GenreName = TextBoxGenreName.Text;

                DialogResult = DialogResult.OK;
            }

        }
        private bool ValidarDatos()
        {
            bool valid = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TextBoxGenreName.Text))
            {
                valid = false;
                errorProvider1.SetError(TextBoxGenreName, "El genero es requerido!!!");
            }
            else if (double.TryParse(TextBoxGenreName.Text, out _))
            {
                valid = false;
                errorProvider1.SetError(TextBoxGenreName, "El genero no debe ser un número!!!");
            }
            return valid;
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
    }
}

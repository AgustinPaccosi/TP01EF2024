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

namespace TP01EF2024.Windows.Sports
{
    public partial class frmSportsAE : Form
    {
        public frmSportsAE()
        {
            InitializeComponent();
        }
        private Sport? sports;
        public Sport? GetSport()
        {
            return sports;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (sports != null)
            {
                TextBoxSportName.Text = sports.SportName;
            }
        }

        public void SetSport(Sport? sportt)
        {
            sports = sportt;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (sports == null)
                {
                    sports = new Sport();

                }
                sports.SportName = TextBoxSportName.Text;

                DialogResult = DialogResult.OK;
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
        private bool ValidarDatos()
        {
            bool valid = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TextBoxSportName.Text))
            {
                valid = false;
                errorProvider1.SetError(TextBoxSportName, "El deporte es requerido!!!");
            }
            else if (double.TryParse(TextBoxSportName.Text, out _))
            {
                valid = false;
                errorProvider1.SetError(TextBoxSportName, "El deporte no debe ser un número!!!");
            }
            return valid;
        }

    }
}

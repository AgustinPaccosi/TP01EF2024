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

namespace TP01EF2024.Windows.Colours
{
    public partial class frmColoursAE : Form
    {
        private Colour? colour;

        public frmColoursAE()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (colour != null)
            {
                TextBoxColorName.Text = colour.ColourName;
            }
        }

        public Colour? GetColour()
        {
            return colour;
        }

        public void SetColour(Colour? colourC)
        {
            colour = colourC;
        }


        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (colour == null)
                {
                    colour = new Colour();

                }
                colour.ColourName = TextBoxColorName.Text;

                DialogResult = DialogResult.OK;
            }

        }
        private bool ValidarDatos()
        {
            bool valid = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TextBoxColorName.Text))
            {
                valid = false;
                errorProvider1.SetError(TextBoxColorName, "El color es requerido!!!");
            }
            else if (double.TryParse(TextBoxColorName.Text, out _))
            {
                valid = false;
                errorProvider1.SetError(TextBoxColorName, "El color no debe ser un número!!!");
            }
            return valid;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

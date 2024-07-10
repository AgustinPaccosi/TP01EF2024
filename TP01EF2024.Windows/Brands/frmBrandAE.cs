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

namespace TP01EF2024.Windows.Brands
{
    public partial class frmBrandAE : Form
    {
        public frmBrandAE()
        {
            InitializeComponent();
        }

        private Brand? brand;
        public Brand? GetBrand()
        {
            return brand;
        }

        public void SetBrand(Brand? brandd)
        {
            brand = brandd;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (brand != null)
            {
                TextBoxBrandName.Text = brand.BrandName;
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (brand == null)
                {
                    brand = new Brand();

                }
                brand.BrandName = TextBoxBrandName.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valid = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TextBoxBrandName.Text))
            {
                valid = false;
                errorProvider1.SetError(TextBoxBrandName, "La marca es requerido!!!");
            }
            else if (double.TryParse(TextBoxBrandName.Text, out _))
            {
                valid = false;
                errorProvider1.SetError(TextBoxBrandName, "La marca no debe ser un número!!!");
            }
            return valid;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

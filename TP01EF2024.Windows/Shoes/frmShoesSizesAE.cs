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
using TP01EF2024.InversionOfControl;
using TP01EF2024.Windows.Helpers;
using Size = TP01EF2024.Entidades.Size;

namespace TP01EF2024.Windows.Shoes
{
    public partial class frmShoesSizesAE : Form
    {
        private readonly IServiceProvider _serviceProvider = DI.ConfigurarServicios();

        ShoeSize? shoeSize;

        Shoe? shoe;

        Size size;


        public frmShoesSizesAE(Shoe? shoe)
        {
            InitializeComponent();
            this.shoe = shoe;

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelpers.CargarComboTalles(_serviceProvider, ref ComboTalles);
            if (shoeSize != null)
            {
                ComboTalles.SelectedValue = shoeSize.SizeId;
                StockTxt.Text = shoeSize.QuantityInStock.ToString();
                ComboTalles.Enabled = false;
            }
        }


        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (shoeSize == null)
                {
                    shoeSize = new ShoeSize();
                }

                shoeSize.ShoeId = shoe.ShoeId;
                shoeSize.SizeId = size.SizeId;
                shoeSize.QuantityInStock = int.Parse(StockTxt.Text);

                DialogResult = DialogResult.OK;
            }

        }
        private bool ValidarDatos()
        {
            bool valido = true;

            errorProvider1.Clear();

            if (string.IsNullOrEmpty(StockTxt.Text) || string.IsNullOrWhiteSpace(StockTxt.Text))
            {
                valido = false;
                errorProvider1.SetError(StockTxt, "El stock es requerido.");
            }
            if (!int.TryParse(StockTxt.Text, out int stock) || (stock < 0))
            {
                valido = false;
                errorProvider1.SetError(StockTxt, "Stock no válido o mal ingresado");
            }
            if (ComboTalles.SelectedIndex == 0 && size == null)
            {
                valido = false;
                errorProvider1.SetError(ComboTalles, "Debe seleccionar un talle");
            }

            return valido;
        }

        private void ComboTalles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboTalles.SelectedIndex > 0)
            {
                size = (Size?)ComboTalles.SelectedItem;
            }
            else
            {
                size = null;
            }

        }
        internal ShoeSize GetShoeSize()
        {
            return shoeSize;
        }

        internal void SetShoeSize(ShoeSize shoeSize)
        {
            this.shoeSize = shoeSize;
        }

    }
}

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP01EF2024.Servicios.Interfaces;
using TP01EF2024.Windows.Brands;
using TP01EF2024.Windows.Colors;
using TP01EF2024.Windows.Genres;
using TP01EF2024.Windows.Shoes;
using TP01EF2024.Windows.Sports;

namespace TP01EF2024.Windows
{
    public partial class MenuPrincipal : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public MenuPrincipal(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void ButtonBrands_Click(object sender, EventArgs e)
        {
            var servicioBrand = _serviceProvider
                    .GetService<IBrandsService>();
            var servicioShoe = _serviceProvider
                .GetService<IShoesService>();
            if (servicioBrand == null || servicioShoe == null)
            {
                MessageBox.Show("El servicio no está registrado o no se pudo resolver."
                    , "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            frmBrand frm = new frmBrand(servicioBrand, servicioShoe);
            frm.ShowDialog();

        }

        private void ButtonGenres_Click(object sender, EventArgs e)
        {
            var servicioGenres = _serviceProvider
                    .GetService<IGenresService>();
            var servicioShoe = _serviceProvider
                .GetService<IShoesService>();
            if (servicioGenres == null || servicioShoe == null)
            {
                MessageBox.Show("El servicio no está registrado o no se pudo resolver."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmGenres frm = new frmGenres(servicioGenres, servicioShoe);
            frm.ShowDialog();

        }

        private void ButtonShoes_Click(object sender, EventArgs e)
        {
            var servicioShoes = _serviceProvider
                    .GetService<IShoesService>();
            if (servicioShoes == null)
            {
                MessageBox.Show("El servicio no está registrado o no se pudo resolver."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmShoes frm = new frmShoes(servicioShoes, _serviceProvider);
            frm.ShowDialog();

        }

        private void ButtonSports_Click(object sender, EventArgs e)
        {
            var servicioSports = _serviceProvider
                    .GetService<ISportsService>();
            var servicioShoe = _serviceProvider
                .GetService<IShoesService>();
            if (servicioSports == null || servicioShoe == null)
            {
                MessageBox.Show("El servicio no está registrado o no se pudo resolver."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmSports frm = new frmSports(servicioSports, servicioShoe);
            frm.ShowDialog();

        }

        private void ButtonColours_Click(object sender, EventArgs e)
        {
            var servicioColors = _serviceProvider
                    .GetService<IColoursService>();
            var servicioShoe = _serviceProvider
                .GetService<IShoesService>();
            if (servicioColors == null || servicioShoe == null)
            {
                MessageBox.Show("El servicio no está registrado o no se pudo resolver."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmColour frm = new frmColour(servicioColors, servicioShoe);
            frm.ShowDialog();

        }
    }
}

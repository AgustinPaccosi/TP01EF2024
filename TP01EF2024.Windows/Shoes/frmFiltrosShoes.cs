using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP01EF2024.Entidades.Dtos;
using TP01EF2024.Windows.Helpers;

namespace TP01EF2024.Windows.Shoes
{
    public partial class frmFiltrosShoes : Form
    {
        private List<ShoeDto>? lista;

        public frmFiltrosShoes()
        {
            InitializeComponent();
        }
        public void SetLista(List<ShoeDto>? listaShoes)
        {
            lista = listaShoes;
        }

        private void frmFiltrosShoes_Load(object sender, EventArgs e)
        {
            if (lista != null)
            {
                lblRegistros.Text = lista.Count().ToString();
                MostrarShoesEnGrilla();
            }

        }
        private void MostrarShoesEnGrilla()
        {
            if (lista == null) return;
            GridHelpers.LimpiarGrilla(dgvDatos);
            foreach (var item in lista)
            {
                var r = GridHelpers.ConstruirFila(dgvDatos);
                GridHelpers.SetearFila(r, item);
                GridHelpers.AgregarFila(r, dgvDatos);
            }
        }

    }
}

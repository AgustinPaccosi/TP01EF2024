using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Dtos;

namespace TP01EF2024.Windows.Helpers
{
    public static class GridHelpers
    {
        public static void LimpiarGrilla(DataGridView dgv)
        {
            dgv.Rows.Clear();
        }

        public static DataGridViewRow ConstruirFila(DataGridView dgv)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgv);
            return r;

        }

        public static void QuitarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Remove(r);
        }
        public static void SetearFila(DataGridViewRow r, object item)
        {
            switch (item)
            {
                case Brand brand:
                    r.Cells[0].Value = brand.BrandName;
                    break;
                case Colour colour:
                    r.Cells[0].Value = colour.ColourName;
                    break;
                case Genre genre:
                    r.Cells[0].Value = genre.GenreName;
                    break;
                case Sport sport:
                    r.Cells[0].Value = sport.SportName;
                    break;
                case ShoeDto shoeDto:
                    r.Cells[0].Value = shoeDto.Brand;
                    r.Cells[1].Value = shoeDto.Genre;
                    r.Cells[2].Value = shoeDto.Color;
                    r.Cells[3].Value = shoeDto.Sport;
                    r.Cells[4].Value = shoeDto.Price.ToString("C");
                    break;
                default:
                    break;

            }
            r.Tag = item;
        }

        public static void AgregarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Add(r);
        }

    }
}

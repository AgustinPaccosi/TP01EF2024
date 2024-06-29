using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades;

namespace TP01EF2024.Servicios.Interfaces
{
    public interface ISizesService
    {
        void Guardar(Size size);
        void Eliminar(Size size);
        bool EstaRelacionado(Size size);
        bool Existe(Size size);
        Size? GetSizePorId(int id);
        List<Size> GetSizes();
        int GetCantidad();
        List<Shoe>? GetShoesForSize(int sizeId);

    }
}

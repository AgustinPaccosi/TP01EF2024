using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades;

namespace TP01EF2024.Servicios.Interfaces
{
    public interface IBrandsService
    {
        void Guardar(Brand brand);
        void Eliminar(Brand brand);
        bool Existe(Brand brand);
        bool EstaRelacionado(Brand brand);
        Brand? GetBrandPorId(int id);
        List<Brand> GetBrands();
        int GetCantidad();

    }
}


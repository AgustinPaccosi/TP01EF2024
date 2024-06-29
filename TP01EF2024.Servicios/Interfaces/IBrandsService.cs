using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Enum;

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
        List<Shoe>? GetShoes(Brand? brand);
        List<Brand> GetListaPaginadaOrdenada(int page, int pageSize, Orden? orden = null);


    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Dtos;
using TP01EF2024.Entidades.Enum;

namespace TP01EF2024.Servicios.Interfaces
{
    public interface IShoesService
    {
        void Guardar(Shoe shoe);
        void Eliminar(Shoe shoe);
        bool Existe(Shoe shoe);
        bool EstaRelacionado(Shoe shoe);
        Shoe? GetShoePorId(int id);
        List<Shoe> GetShoes();
        int GetCantidad();
        List<ShoeDto> GetListaDto();
        List<ShoeDto> PasarListaDto(List<Shoe> listaShoes);
        List<ShoeDto> GetListaPaginadaOrdenada(int page, int pageSize, Orden? orden = null);

        List<Size> GetSizesForShoe(int shoeId);
        void AsignarTalle(Shoe shoe, Size size, int stock);
        int GetStockShoeSize(Shoe shoe, Size size);
        List<Shoe> GetListaPaginadaOrdenadaFiltrada(
            bool paginar,
            int page,
            int pageSize,
            Orden? orden = null,
            Brand? brand = null,
            Sport? sport = null,
            Genre? genre = null,
            Colour? colour = null,
            decimal? maximo = null,
            decimal? minimo = null);
        int GetCantidadFiltrada(Brand? brand = null,
            Sport? sport = null,
            Genre? genre = null,
            Colour? colour = null,
            decimal? maximo = null,
            decimal? minimo = null);
    }
}


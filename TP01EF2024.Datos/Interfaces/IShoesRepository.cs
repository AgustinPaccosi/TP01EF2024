using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Dtos;
using TP01EF2024.Entidades.Enum;

namespace TP01EF2024.Datos.Interfaces
{
    public interface IShoesRepository
    {
        void Agregar(Shoe shoe);
        void Editar(Shoe shoe);
        void Eliminar(Shoe shoe);
        bool EstaRelacionado(Shoe shoe);
        bool Existe(Shoe shoe);
        Shoe? GetShoePorId(int id);
        List<Shoe> GetShoes();
        int GetCantidad();
        void AgregarShoeSize(ShoeSize nuevaRelacion);

        ShoeSize? ExisteShoeSize(Shoe shoe, Size size);
        void ActualizarShoeSize(ShoeSize shoeSize);

        List<Size> GetSizesForShoe(int shoeId);
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
        List<ShoeDto> GetListaDto();
        List<ShoeDto> PasarListaDto(List<Shoe> listaShoes);
        List<ShoeDto> GetListaPaginadaOrdenada(int page, int pageSize,
            Orden? orden = null);
    }
}

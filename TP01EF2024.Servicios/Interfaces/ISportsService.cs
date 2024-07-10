using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Enum;

namespace TP01EF2024.Servicios.Interfaces
{
    public interface ISportsService
    {
        void Guardar(Sport sport);
        void Eliminar(Sport sport);
        bool Existe(Sport sport);
        bool EstaRelacionado(Sport sport);
        Sport? GetSportPorId(int id);
        List<Sport> GetSports();
        List<Shoe>? GetShoes(Sport? sport);

        int GetCantidad();
        List<Sport>? GetListaPaginadaOrdenada(int page, int pageSize, Orden? orden = null);
    }
}


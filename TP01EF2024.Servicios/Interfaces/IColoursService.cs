using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades;

namespace TP01EF2024.Servicios.Interfaces
{
    public interface IColoursService
    {
        void Guardar(Colour colour);
        void Eliminar(Colour colour);
        bool Existe(Colour colour);
        bool EstaRelacionado(Colour colour);
        Colour? GetColourPorId(int id);
        List<Colour> GetColours();
        int GetCantidad();

    }
}


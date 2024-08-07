﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Enum;

namespace TP01EF2024.Datos.Interfaces
{
    public interface IGenresRepository
    {
        void Agregar(Genre genre);
        void Editar(Genre genre);
        void Eliminar(Genre genre);
        bool EstaRelacionado(Genre genre);
        List<Shoe>? GetShoes(Genre? genre);

        bool Existe(Genre genre);
        Genre? GetGenrePorId(int id);
        List<Genre> GetGenres();
        int GetCantidad();
        List<Genre>? GetListaPaginadaOrdenada(int page, int pageSize, Orden? orden = null);
    }
}

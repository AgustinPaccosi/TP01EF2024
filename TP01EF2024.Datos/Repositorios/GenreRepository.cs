using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Datos.Interfaces;
using TP01EF2024.Entidades;

namespace TP01EF2024.Datos.Repositorios
{
    public class GenreRepository:IGenreRepository
    {
        public readonly TPDbContext _Context;
        public GenreRepository(TPDbContext context)
        {
            _Context = context;
        }

        public void Agregar(Genre genre)
        {
            throw new NotImplementedException();
        }

        public void Editar(Genre genre)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(Genre genre)
        {
            throw new NotImplementedException();
        }

        public bool EstaRelacionado(Genre genre)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Genre genre)
        {
            throw new NotImplementedException();
        }

        public int GetCantidad()
        {
            throw new NotImplementedException();
        }

        public Genre? GetGenrePorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Genre> GetGenres()
        {
            throw new NotImplementedException();
        }
        //public void Agregar (Genre)
    }
}

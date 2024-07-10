using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Datos.Interfaces;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Enum;

namespace TP01EF2024.Datos.Repositorios
{
    public class GenresRepository:IGenresRepository
    {
        public readonly TPDbContext _context;
        public GenresRepository(TPDbContext context)
        {
            _context = context;
        }

        public void Agregar(Genre genre)
        {
            _context.Genres.Add(genre);
        }

        public void Editar(Genre genre)
        {
            _context.Genres.Update(genre);
        }

        public void Eliminar(Genre genre)
        {
            _context.Genres.Remove(genre);
        }

        public bool EstaRelacionado(Genre genre) 
        {
            return _context.Shoes.Any(s=>s.GenreId==genre.GenreId);
        }

        public bool Existe(Genre genre)
        {
            if(genre.GenreId == 0)
            {
                return _context.Genres.Any(g => g.GenreName == genre.GenreName);

            } 
            return _context.Genres.Any(g => g.GenreName == genre.GenreName && g.GenreId != genre.GenreId);
        }

        public int GetCantidad()
        {
            return _context.Genres.Count();
        }

        public Genre? GetGenrePorId(int id)
        {
            return _context.Genres.SingleOrDefault(g=>g.GenreId==id);

        }

        public List<Genre> GetGenres()
        {
            return _context.Genres.OrderBy(g=>g.GenreId).AsNoTracking().ToList();
        }

        public List<Genre>? GetListaPaginadaOrdenada(int page, int pageSize, Orden? orden = null)
        {
            IQueryable<Genre> query = _context.Genres.AsNoTracking();

            if (orden != null)
            {
                switch (orden)
                {
                    case Orden.AZ:
                        query = query.OrderBy(b => b.GenreName);
                        break;
                    case Orden.ZA:
                        query = query.OrderByDescending(b => b.GenreName);
                        break;
                    default:
                        break;
                }
            }
            List<Genre> listaPaginada = query
                .Skip(page * pageSize)
                .Take(pageSize)
                .ToList();

            return listaPaginada;

        }

        public List<Shoe>? GetShoes(Genre? genre)
        {
            if (genre != null)
            {
                _context.Entry(genre)
                                .Collection(tp => tp.Shoes)
                                .Query()
                                .Include(p => p.Brand)
                                .Include(p => p.Sport)
                                .Include(p => p.Genre)
                                .Include(p => p.Colour)
                                .Load();
                var shoes = genre.Shoes.ToList();

                return shoes;
            }
            return null;

        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Datos.Interfaces;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Enum;

namespace TP01EF2024.Datos.Repositorios
{
    public class SportsRepository : ISportsRepository
    {
        private readonly TPDbContext _context;
        public SportsRepository(TPDbContext context)
        {
            _context = context;
        }

        public void Agregar(Sport sport)
        {
            sport.Active = true;
            _context.Sports.Add(sport);
        }

        public void Editar(Sport sport)
        {
            _context.Sports.Update(sport);
        }

        public void Eliminar(Sport sport)
        {
            _context.Sports.Remove(sport);
        }

        public bool EstaRelacionado(Sport sport)
        {
            return _context.Shoes.Any(s => s.SportId == sport.SportId);
        }

        public bool Existe(Sport sport)
        {
            if (sport.SportId == 0)
            {
                return _context.Sports.Any(s => s.SportName == sport.SportName);
            }
            return _context.Sports.Any(s => s.SportName == sport.SportName && s.SportId != sport.SportId);
        }

        public int GetCantidad()
        {
            return _context.Sports.Count();
        }

        public List<Sport>? GetListaPaginadaOrdenada(int page, int pageSize, Orden? orden = null)
        {
            IQueryable<Sport> query = _context.Sports.AsNoTracking();

            if (orden != null)
            {
                switch (orden)
                {
                    case Orden.AZ:
                        query = query.OrderBy(b => b.SportName);
                        break;
                    case Orden.ZA:
                        query = query.OrderByDescending(b => b.SportName);
                        break;
                    default:
                        break;
                }
            }

            List<Sport> listaPaginada = query
                .Skip(page * pageSize)
                .Take(pageSize)
                .ToList();

            return listaPaginada;

        }

        public Sport? GetSportPorId(int id)
        {
            return _context.Sports.SingleOrDefault(s => s.SportId == id);
        }

        public List<Sport> GetSports()
        {
            return _context.Sports.OrderBy(s => s.SportId).ToList();
        }

    }
}

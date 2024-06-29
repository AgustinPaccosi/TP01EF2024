using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Datos.Interfaces;
using TP01EF2024.Entidades;

namespace TP01EF2024.Datos.Repositorios
{
    public class SizesRepository : ISizesRepository
    {
        private readonly TPDbContext _context;
        public SizesRepository(TPDbContext  context)
        {
            _context = context;
        }
        public void Agregar(Size size)
        {
            _context.Sizes.Add(size);
        }

        public void Editar(Size size)
        {
            _context.Sizes.Update(size);
        }

        public void Eliminar(Size size)
        {
            _context.Sizes.Remove(size);
        }

        public bool EstaRelacionado(Size size)
        {
            return _context.ShoesSizes.Any(ss => ss.SizeId == size.SizeId);

        }

        public bool Existe(Size size)
        {
            if (size.SizeId == 0)
            {
                return _context.Sizes.Any(s => s.SizeNumber == size.SizeNumber);
            }
            return _context.Sizes.Any(s => s.SizeNumber == size.SizeNumber && s.SizeId != size.SizeId);

        }

        public int GetCantidad()
        {
            return _context.Sizes.Count();
        }

        public List<Shoe>? GetShoesForSize(int sizeId)
        {
            return _context.ShoesSizes
                .Include(ss => ss.Shoe).ThenInclude(s => s.Brand)
                .Include(ss => ss.Shoe).ThenInclude(s => s.Genre)
                .Include(ss => ss.Shoe).ThenInclude(s => s.Sport)
                .Include(ss => ss.Shoe).ThenInclude(s => s.Colour)
                .Where(ss => ss.SizeId == sizeId)
                .Select(ss => ss.Shoe)
                .ToList();
        }

        public Size? GetSizePorId(int id)
        {
            return _context.Sizes.SingleOrDefault(s => s.SizeId == id);
        }

        public List<Size> GetSizes()
        {
            return _context.Sizes.AsNoTracking().ToList();
        }
    }
}

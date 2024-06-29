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
    public class ShoesRepository:IShoesRepository
    {
        private readonly TPDbContext _context;
        public ShoesRepository(TPDbContext context)
        {
            _context = context;
        }

        public void ActualizarShoeSize(ShoeSize shoeSize)
        {
            _context.Set<ShoeSize>().Update(shoeSize);
        }

        public void Agregar(Shoe shoe)
        {
            _context.Shoes.Add(shoe);
        }

        public void AgregarShoeSize(ShoeSize relacion)
        {
            _context.Set<ShoeSize>().Add(relacion);
        }

        public void Editar(Shoe shoe)
        {
            _context.Shoes.Update(shoe);
        }

        public void Eliminar(Shoe shoe)
        {
            _context.Shoes.Remove(shoe);
        }

        public bool EstaRelacionado(Shoe shoe)
        {
            return _context.ShoesSizes.Any(ss => ss.ShoeId == shoe.ShoeId);
        }

        public bool Existe(Shoe shoe)
        {
            if (shoe.ShoeId==0)
            {
                return _context.Shoes.Any(s => s.BrandId == shoe.BrandId
                                          && s.SportId == shoe.SportId
                                          && s.GenreId == shoe.GenreId
                                          && s.Model==shoe.Model);
            }
            return _context.Shoes.Any(s => s.BrandId == shoe.BrandId
                                          && s.SportId == shoe.SportId
                                          && s.GenreId == shoe.GenreId
                                          && s.Model == shoe.Model
                                          && s.ShoeId==shoe.ShoeId);
        }

        public ShoeSize? ExisteShoeSize(Shoe shoe, Size size)
        {
            return _context.ShoesSizes.FirstOrDefault(ss => ss.ShoeId == shoe.ShoeId && ss.SizeId == size.SizeId);
        }

        public int GetCantidad()
        {
            return _context.Shoes.Count();
        }

        public Shoe? GetShoePorId(int id)
        {
            return _context.Shoes.SingleOrDefault(s => s.ShoeId == id);
        }

        public List<Shoe> GetShoes()
        {
            return _context.Shoes.
                Include(s=>s.Brand).
                Include(s=>s.Sport).
                Include(s=>s.Genre).
                Include(s=>s.Colour).
                OrderBy(s => s.ShoeId).AsNoTracking().ToList();
        }

        public List<Size> GetSizesForShoe(int shoeId)
        {
            return _context.ShoesSizes
                .Include(ss => ss.Size)
                .Where(ss => ss.ShoeId == shoeId)
                .Select(ss => ss.Size)
                .ToList();
        }
    }
}

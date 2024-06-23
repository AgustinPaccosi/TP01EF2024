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

        public void Agregar(Shoe shoe)
        {
            _context.Shoes.Add(shoe);
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
            return true; //_context.shoesColours;
        }

        public bool Existe(Shoe shoe)
        {
            throw new NotImplementedException();
        }

        public int GetCantidad()
        {
            throw new NotImplementedException();
        }

        public Shoe? GetShoePorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Shoe> GetShoes()
        {
            throw new NotImplementedException();
        }
    }
}

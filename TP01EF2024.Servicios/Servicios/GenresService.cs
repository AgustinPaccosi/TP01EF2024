using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Datos.Interfaces;
using TP01EF2024.Datos.Repositorios;
using TP01EF2024.Entidades;
using TP01EF2024.Servicios.Interfaces;

namespace TP01EF2024.Servicios.Servicios
{
    public class GenresService : IGenresService
    {
        private readonly IGenresRepository _reposiroty;
        private readonly IUnitOfWork _unitOfWork;

        public GenresService(IGenresRepository repository, IUnitOfWork unitOfWork)
        {
            _reposiroty = repository;
            _unitOfWork = unitOfWork;
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

        public void Guardar(Genre genre)
        {
            throw new NotImplementedException();
        }
    }
}

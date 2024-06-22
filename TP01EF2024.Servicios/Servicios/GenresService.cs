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
            try
            {
                _unitOfWork.BeginTransaction();
                _reposiroty.Eliminar(genre);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.RollBack();
                throw;
            }
        }

        public bool EstaRelacionado(Genre genre)
        {
            try
            {
                return _reposiroty.EstaRelacionado(genre);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Genre genre)
        {
            try
            {
                return _reposiroty.Existe(genre);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad()
        {
            return _reposiroty.GetCantidad();
        }

        public Genre? GetGenrePorId(int id)
        {
            try
            {
                return _reposiroty.GetGenrePorId(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Genre> GetGenres()
        {
            try
            {
                return _reposiroty.GetGenres();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Genre genre)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                if (genre.GenreId==0)
                {
                    _reposiroty.Agregar(genre);
                }
                else
                {
                    _reposiroty.Editar(genre);
                }
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.RollBack();
                throw;
            }
        }
    }
}

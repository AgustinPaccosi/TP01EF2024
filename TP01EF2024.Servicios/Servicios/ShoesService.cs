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
    public class ShoesService : IShoesService
    {
        private readonly IShoesRepository _reposiroty;
        private readonly IUnitOfWork _unitOfWork;

        public ShoesService(IShoesRepository repository, IUnitOfWork unitOfWork)
        {
            _reposiroty = repository;
            _unitOfWork = unitOfWork;
        }
        public void Eliminar(Shoe shoe)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _reposiroty.Eliminar(shoe);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.RollBack();
                throw;
            }
        }

        public bool EstaRelacionado(Shoe shoe)
        {
            try
            {
                return _reposiroty.EstaRelacionado(shoe);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Shoe shoe)
        {
            try
            {
                return _reposiroty.Existe(shoe);
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

        public Shoe? GetShoePorId(int id)
        {
            try
            {
                return _reposiroty.GetShoePorId(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Shoe> GetShoes()
        {
            try
            {
                return _reposiroty.GetShoes();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Shoe shoe)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                if (shoe.ShoeId==0)
                {
                    _reposiroty.Agregar(shoe);
                }
                else
                {
                    _reposiroty.Editar(shoe);
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

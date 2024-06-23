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
    public class ColoursService : IColoursService
    {
        private readonly IColoursRepository _reposiroty;
        private readonly IUnitOfWork _unitOfWork;

        public ColoursService(IColoursRepository repository, IUnitOfWork unitOfWork)
        {
            _reposiroty = repository;
            _unitOfWork = unitOfWork;
        }
        public void Eliminar(Colour colour)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _reposiroty.Eliminar(colour);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.RollBack();
                throw;
            }
        }

        public bool EstaRelacionado(Colour colour)
        {
            try
            {
                return _reposiroty.EstaRelacionado(colour);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Colour colour)
        {
            try
            {
                return _reposiroty.Existe(colour);
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

        public Colour? GetColourPorId(int id)
        {
            try
            {
                return _reposiroty.GetColourPorId(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Colour> GetColours()
        {
            try
            {
                return _reposiroty.GetColours();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Colour colour)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                if (colour.ColourId==0)
                {
                    _reposiroty.Agregar(colour);
                }
                else
                {
                    _reposiroty.Editar(colour);
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

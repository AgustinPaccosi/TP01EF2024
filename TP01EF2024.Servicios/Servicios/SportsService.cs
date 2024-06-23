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
    public class SportsService : ISportsService
    {
        private readonly ISportsRepository _reposiroty;
        private readonly IUnitOfWork _unitOfWork;

        public SportsService(ISportsRepository repository, IUnitOfWork unitOfWork)
        {
            _reposiroty = repository;
            _unitOfWork = unitOfWork;
        }
        public void Eliminar(Sport sport)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _reposiroty.Eliminar(sport);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.RollBack();
                throw;
            }
        }

        public bool EstaRelacionado(Sport sport)
        {
            try
            {
                return _reposiroty.EstaRelacionado(sport);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Sport sport)
        {
            try
            {
                return _reposiroty.Existe(sport);
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

        public Sport? GetSportPorId(int id)
        {
            try
            {
                return _reposiroty.GetSportPorId(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Sport> GetSports()
        {
            try
            {
                return _reposiroty.GetSports();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Sport sport)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                if (sport.SportId==0)
                {
                    _reposiroty.Agregar(sport);
                }
                else
                {
                    _reposiroty.Editar(sport);
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

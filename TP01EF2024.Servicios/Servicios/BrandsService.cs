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
    public class BrandsService : IBrandsService
    {
        private readonly IBrandsRepository _reposiroty;
        private readonly IUnitOfWork _unitOfWork;

        public BrandsService(IBrandsRepository repository, IUnitOfWork unitOfWork)
        {
            _reposiroty = repository;
            _unitOfWork = unitOfWork;
        }
        public void Eliminar(Brand brand)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _reposiroty.Eliminar(brand);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.RollBack();
                throw;
            }
        }

        public bool EstaRelacionado(Brand brand)
        {
            try
            {
                return _reposiroty.EstaRelacionado(brand);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Brand brand)
        {
            try
            {
                return _reposiroty.Existe(brand);
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

        public Brand? GetBrandPorId(int id)
        {
            try
            {
                return _reposiroty.GetBrandPorId(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Brand> GetBrands()
        {
            try
            {
                return _reposiroty.GetBrands();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Brand brand)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                if (brand.BrandId==0)
                {
                    _reposiroty.Agregar(brand);
                }
                else
                {
                    _reposiroty.Editar(brand);
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

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
        private readonly IShoesRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public ShoesService(IShoesRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void AsignarTalle(Shoe shoe, Size size, int stock)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var existeRelacion = _repository.ExisteShoeSize(shoe, size);
                if (existeRelacion!=null)
                {
                    existeRelacion.QuantityInStock += stock;
                    //_reposiroty.ActualizarShoeSize(existeRelacion);
                }
                else
                {
                    ShoeSize relacionNueva = new ShoeSize()
                    {
                        Shoe = shoe,
                        Size = size,
                        QuantityInStock = stock
                    };
                    _repository.AgregarShoeSize(relacionNueva);
                }
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.RollBack();

                throw;
            }
        }

        public void Eliminar(Shoe shoe)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _repository.Eliminar(shoe);
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
                return _repository.EstaRelacionado(shoe);
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
                return _repository.Existe(shoe);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad()
        {
            return _repository.GetCantidad();
        }

        public Shoe? GetShoePorId(int id)
        {
            try
            {
                return _repository.GetShoePorId(id);
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
                return _repository.GetShoes();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Size> GetSizesForShoe(int shoeId)
        {
            try
            {
                return _repository.GetSizesForShoe(shoeId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetStockShoeSize(Shoe shoe, Size size)
        {
            var shoeSize = _repository.ExisteShoeSize(shoe, size);

            if (shoeSize != null)
            {
                return shoeSize.QuantityInStock;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public void Guardar(Shoe shoe)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                if (shoe.ShoeId==0)
                {
                    _repository.Agregar(shoe);
                }
                else
                {
                    _repository.Editar(shoe);
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

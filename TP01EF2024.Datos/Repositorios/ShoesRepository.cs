using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Datos.Interfaces;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Dtos;
using TP01EF2024.Entidades.Enum;

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
            //_context.Set<ShoeSize>().Update(shoeSize);
            var trackedEntity = _context.Set<ShoeSize>().Local
                .FirstOrDefault(entry => entry.ShoeSizeId == shoeSize.ShoeSizeId);

            if (trackedEntity != null)
            {
                _context.Entry(trackedEntity).State = EntityState.Detached;
            }

            _context.Set<ShoeSize>().Update(shoeSize);
        }

        public void Agregar(Shoe shoe)
        {
            //shoe.Active= true;
            //_context.Shoes.Add(shoe);
            var brandExistenteBd = _context.Brands.
                FirstOrDefault(b => b.BrandId == shoe.BrandId);
            if (brandExistenteBd != null)
            {
                _context.Attach(brandExistenteBd);
                shoe.Brand = brandExistenteBd;
            }

            var genreExistenteBd = _context.Genres.
                FirstOrDefault(b => b.GenreId == shoe.GenreId);
            if (genreExistenteBd != null)
            {
                _context.Attach(genreExistenteBd);
                shoe.Genre = genreExistenteBd;
            }

            var colorExistenteBd = _context.Colours.
                FirstOrDefault(b => b.ColourId == shoe.ColourId);
            if (colorExistenteBd != null)
            {
                _context.Attach(colorExistenteBd);
                shoe.Colour = colorExistenteBd;
            }

            var sportExistenteBd = _context.Sports.
                FirstOrDefault(b => b.SportId == shoe.SportId);
            if (sportExistenteBd != null)
            {
                _context.Attach(sportExistenteBd);
                shoe.Sport = sportExistenteBd;
            }

            _context.Shoes.Add(shoe);

        }

        public void AgregarShoeSize(ShoeSize relacion)
        {
            _context.Set<ShoeSize>().Add(relacion);
        }

        public void Editar(Shoe shoe)
        {
            //_context.Shoes.Update(shoe);
            var brandExistenteBd = _context.Brands.
    FirstOrDefault(b => b.BrandId == shoe.BrandId);
            if (brandExistenteBd != null)
            {
                _context.Attach(brandExistenteBd);
                shoe.Brand = brandExistenteBd;
            }

            var genreExistenteBd = _context.Genres.
                FirstOrDefault(b => b.GenreId == shoe.GenreId);
            if (genreExistenteBd != null)
            {
                _context.Attach(genreExistenteBd);
                shoe.Genre = genreExistenteBd;
            }

            var colorExistenteBd = _context.Colours.
                FirstOrDefault(b => b.ColourId == shoe.ColourId);
            if (colorExistenteBd != null)
            {
                _context.Attach(colorExistenteBd);
                shoe.Colour = colorExistenteBd;
            }

            var sportExistenteBd = _context.Sports.
                FirstOrDefault(b => b.SportId == shoe.SportId);
            if (sportExistenteBd != null)
            {
                _context.Attach(sportExistenteBd);
                shoe.Sport = sportExistenteBd;
            }

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

        public List<Shoe> GetListaPaginadaOrdenadaFiltrada(
            bool paginar,
            int page,
            int pageSize,
            Orden? orden = null,
            Brand? brand = null,
            Sport? sport = null,
            Genre? genre = null,
            Colour? colour = null,
            decimal? maximo = null,
            decimal? minimo = null)
        {
            IQueryable<Shoe> query = _context.Shoes
                .Include(s => s.Brand)
                .Include(s => s.Sport)
                .Include(s => s.Genre)
                .Include(s => s.Colour)
                .AsNoTracking();

            
            if (brand != null)
            {
                query = query
                    .Where(s => s.BrandId == brand.BrandId);
            }
            if (sport != null)
            {
                query = query
                    .Where(s => s.SportId == sport.SportId);
            }
            if (genre != null)
            {
                query = query
                    .Where(s => s.GenreId == genre.GenreId);
            }
            if (colour != null)
            {
                query = query
                    .Where(s => s.ColourId == colour.ColourId);
            }

            
            if (orden != null)
            {
                switch (orden)
                {
                    case Orden.AZ:
                        query = query.OrderBy(s => s.Model);
                        break;
                    case Orden.ZA:
                        query = query.OrderByDescending(s => s.Model);
                        break;
                    case Orden.MenorPrecio:
                        query = query.OrderBy(s => s.Price);
                        break;
                    case Orden.MayorPrecio:
                        query = query.OrderByDescending(s => s.Price);
                        break;
                    default:
                        break;
                }
            }

            
            if (maximo != null && minimo != null)
            {
                query = query
                    .Where(s => s.Price <= maximo)
                    .Where(s => s.Price >= minimo);
            }

            
            if (paginar)
            {
                List<Shoe> listaPaginada = query.AsNoTracking()
                .Skip(page * pageSize)//Saltea estos registros
                .Take(pageSize)//Muestra estos
                .ToList();
                return listaPaginada;
            }
            else
            {
                return query.ToList();
            }
        }

        public int GetCantidadFiltrada(Brand? brand = null,
            Sport? sport = null,
            Genre? genre = null,
            Colour? colour = null,
            decimal? maximo = null,
            decimal? minimo = null)
        {
            IQueryable<Shoe> query = _context.Shoes.AsNoTracking();
            
            if (brand != null)
            {
                query = query
                    .Where(s => s.BrandId == brand.BrandId);
            }
            if (sport != null)
            {
                query = query
                    .Where(s => s.SportId == sport.SportId);
            }
            if (genre != null)
            {
                query = query
                    .Where(s => s.GenreId == genre.GenreId);
            }
            if (colour != null)
            {
                query = query
                    .Where(s => s.ColourId == colour.ColourId);
            }

            if (maximo != null && minimo != null)
            {
                query = query
                    .Where(s => s.Price <= maximo)
                    .Where(s => s.Price >= minimo);
            }

            return query.Count();
        }

        public Shoe? GetShoePorId(int id)
        {
            //return _context.Shoes.SingleOrDefault(s => s.ShoeId == id);
            return _context.Shoes.
                Include(s => s.Brand).
                Include(s => s.Genre).
                Include(s => s.Sport).
                Include(s => s.Colour).
                AsNoTracking().
                SingleOrDefault(s => s.ShoeId == id);

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
                .AsNoTracking()
                .ToList();
        }

        public List<ShoeDto> GetListaDto()
        {
            return _context.Shoes
                .Include(p => p.Brand)
                .Include(p => p.Genre)
                .Include(p => p.Colour)
                .Include(p => p.Sport)
                .Select(n => new ShoeDto
                {
                    ShoeId=n.ShoeId,
                    Brand=n.Brand !=null ? n.Brand.BrandName : string.Empty,
                    Genre = n.Genre != null ? n.Genre.GenreName : string.Empty,
                    Colour = n.Colour != null ? n.Colour.ColourName : string.Empty,
                    Sport = n.Sport != null ? n.Sport.SportName : string.Empty,
                    Model=n.Model,
                    Description=n.Description,
                    Price=n.Price,
                }).ToList(); ;
        
        }

        public List<ShoeDto> PasarListaDto(List<Shoe> listaShoes)
        {
            List<ShoeDto> listaDto = new List<ShoeDto>();
            foreach (var shoe in listaShoes)
            {
                ShoeDto dto = new ShoeDto
                {
                    ShoeId = shoe.ShoeId,
                    Brand = shoe.Brand?.BrandName ?? "",
                    Sport = shoe.Sport?.SportName ?? "",
                    Genre = shoe.Genre?.GenreName ?? "",
                    Colour = shoe.Colour?.ColourName ?? "",
                    Model = shoe.Model,
                    Description = shoe.Description,
                    Price = shoe.Price
                };

                listaDto.Add(dto);
            }
            return listaDto;
        }

        public List<ShoeDto> GetListaPaginadaOrdenada(int page, int pageSize, Orden? orden = null)
        {
            IQueryable<Shoe> query = _context.Shoes
            .Include(s => s.Colour)
            .Include(s => s.Genre)
            .Include(s => s.Sport)
            .Include(s => s.Brand)
            .AsNoTracking();

            // Aplicar orden si se proporciona
            if (orden != null)
            {
                switch (orden)
                {
                    case Orden.AZ:
                        query = query.OrderBy(s => s.Brand != null ? s.Brand.BrandName : string.Empty);
                        break;
                    case Orden.ZA:
                        query = query.OrderByDescending(s => s.Brand != null ? s.Brand.BrandName : string.Empty);
                        break;
                    case Orden.MenorPrecio:
                        query = query.OrderBy(s => s.Price);
                        break;
                    case Orden.MayorPrecio:
                        query = query.OrderByDescending(s => s.Price);
                        break;
                    default:
                        break;
                }
            }

            // Paginar los resultados
            List<Shoe> listaPaginada = query
                .Skip(page * pageSize)
                .Take(pageSize)
                .ToList();

            // Mapear los resultados a ShoeListDto
            List<ShoeDto> listaDto = listaPaginada
                .Select(s => new ShoeDto
                {
                    ShoeId = s.ShoeId,
                    Description = s.Description,
                    Colour = s.Colour?.ColourName ?? "",
                    Genre = s.Genre?.GenreName ?? "",
                    Sport = s.Sport?.SportName ?? "",
                    Brand = s.Brand?.BrandName ?? "",
                    Price = s.Price
                })
                .ToList();

            return listaDto;
        }

        public ShoeSize? GetShoeSize(Shoe shoe, Size size)
        {
            return _context.ShoesSizes
                .Include(ss => ss.Shoe)
                .Include(ss => ss.Size)
                .AsNoTracking()
                .FirstOrDefault(ss => ss.ShoeId == shoe.ShoeId && ss.SizeId == size.SizeId);

        }

        public List<ShoeSize> GetShoesSizesPaginados(int page, int pageSize, Shoe shoe)
        {
            return _context.ShoesSizes
                    .Include(ss => ss.Shoe)
                    .Include(ss => ss.Size)
                    .Where(ss => ss.ShoeId == shoe.ShoeId)
                    .OrderBy(ss => ss.Size.SizeNumber)
                    .AsNoTracking()
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .ToList();

        }

        public bool GetBoolShoeSize(ShoeSize shoesize)
        {
            if (shoesize.ShoeSizeId == 0)
            {
                return _context.ShoesSizes.Any(ss => ss.ShoeId == shoesize.ShoeId
                            && ss.SizeId == shoesize.SizeId);
            }
            else
            {
                return _context.ShoesSizes.Any(ss => ss.ShoeId == shoesize.ShoeId
                            && ss.QuantityInStock == shoesize.QuantityInStock
                            && ss.SizeId == shoesize.SizeId);
            }

        }

        public void EliminarShoeSize(ShoeSize shoeSize)
        {
            var existingEntity = _context.ShoesSizes.Local
                .FirstOrDefault(s => s.ShoeSizeId == shoeSize.ShoeSizeId);

            if (existingEntity != null)
            {
                _context.Entry(existingEntity).State = EntityState.Detached;
            }

            _context.ShoesSizes.Remove(shoeSize);
            //var shoeExist = _context.Shoes.Local.FirstOrDefault(s => s.ShoeId == shoeSize.ShoeId);

            //if (shoeExist != null)
            //{
            //    _context.Entry(shoeExist).State = EntityState.Detached;
            //}

            //_context.ShoesSizes.Remove(shoeSize);

        }
    }
    
}

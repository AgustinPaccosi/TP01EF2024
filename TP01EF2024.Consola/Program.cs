using ConsoleTables;
using Microsoft.Extensions.DependencyInjection;
using TP01EF2024.Entidades;
using TP01EF2024.InversionOfControl;
using TP01EF2024.Servicios.Interfaces;
using TP01EF2024.Shared;

namespace TP01EF2024.Consola
{
    internal class Program
    {

        private static IServiceProvider? servicioProvider;
        static void Main(string[] args)
        {

            servicioProvider = DI.ConfigurarServicios();
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("MENÚ PRINCIPAL:");
                Console.WriteLine();
                Console.WriteLine("----------");
                Console.WriteLine("1. Ver todos los Generos");
                Console.WriteLine("2. Agregar un Genero");
                Console.WriteLine("3. Editar un Genero");
                Console.WriteLine("4. Eliminar un Genero");
                Console.WriteLine("----------");
                Console.WriteLine("5. Ver todas las Marcas");
                Console.WriteLine("6. Agregar una Marca");
                Console.WriteLine("7. Editar una Marca");
                Console.WriteLine("8. Eliminar una Marca");
                Console.WriteLine("----------");
                Console.WriteLine("9. Ver todos los Deportes");
                Console.WriteLine("10. Agregar un Deporte");
                Console.WriteLine("11. Editar un Deports");
                Console.WriteLine("12. Eliminar un Deporte");
                Console.WriteLine("----------");
                Console.WriteLine("13. Ver todos los Colores");
                Console.WriteLine("14. Agregar un Color");
                Console.WriteLine("15. Editar un Color");
                Console.WriteLine("16. Eliminar un Color");
                Console.WriteLine("----------");
                Console.WriteLine("17. Ver todas las Zapatillas");
                Console.WriteLine("18. Agregar una Zapatilla");
                Console.WriteLine("19. Editar una Zapatilla");
                Console.WriteLine("20. Eliminar una Zapatilla");
                Console.WriteLine("----------");


                Console.WriteLine("PRESIONE X PARA SALIR");
                Console.Write("Por favor, seleccione una opción: ");
                string? input = Console.ReadLine();

                switch (input)
                {
                    case "1"://GENEROS
                        Console.Clear();
                        MostrarGeneros();
                        ConsoleExtensions.Enter();
                        break;
                    case "2":
                        Console.Clear();
                        AgregarGenero();
                        ConsoleExtensions.Enter();
                        break;
                    case "3":
                        Console.Clear();
                        EditarGenero();
                        ConsoleExtensions.Enter();
                        break;
                    case "4":
                        Console.Clear();
                        EliminarGenero();
                        ConsoleExtensions.Enter();
                        break;
                    case "5"://MARCAS
                        Console.Clear();
                        MostrarMarcas();
                        ConsoleExtensions.Enter();
                        break;
                    case "6":
                        Console.Clear();
                        AgregarMarca();
                        ConsoleExtensions.Enter();
                        break;
                    case "7":
                        Console.Clear();
                        EditarMarca();
                        ConsoleExtensions.Enter();
                        break;
                    case "8":
                        Console.Clear();
                        EliminarMarca();
                        ConsoleExtensions.Enter();
                        break;
                    case "9"://DEPORTES
                        Console.Clear();
                        MostrarDeportes();
                        ConsoleExtensions.Enter();
                        break;
                    case "10":
                        Console.Clear();
                        AgregarDeporte();
                        ConsoleExtensions.Enter();
                        break;
                    case "11":
                        Console.Clear();
                        EditarDeporte();
                        ConsoleExtensions.Enter();
                        break;
                    case "12":
                        Console.Clear();
                        EliminarDeporte();
                        ConsoleExtensions.Enter();
                        break;
                    case "13"://COLORES
                        Console.Clear();
                        MostrarColores();
                        ConsoleExtensions.Enter();
                        break;
                    case "14":
                        Console.Clear();
                        AgregarColores();
                        ConsoleExtensions.Enter();
                        break;
                    case "15":
                        Console.Clear();
                        EditarColores();
                        ConsoleExtensions.Enter();
                        break;
                    case "16":
                        Console.Clear();
                        EliminarColores ();
                        ConsoleExtensions.Enter();
                        break;
                    case "17"://Zapatillas
                        Console.Clear();
                        MostrarZapatillas();
                        ConsoleExtensions.Enter();
                        break;
                    case "18":
                        Console.Clear();
                        AgregarZapatillas();
                        ConsoleExtensions.Enter();
                        break;
                    case "19":
                        Console.Clear();
                        EditarZapatillas();
                        ConsoleExtensions.Enter();
                        break;
                    case "20":
                        Console.Clear();
                        EliminarZapatillas();
                        ConsoleExtensions.Enter();
                        break;


                }
            }
        }

        private static void EliminarZapatillas()
        {
            throw new NotImplementedException();
        }

        private static void EditarZapatillas()
        {
            throw new NotImplementedException();
        }

        private static void AgregarZapatillas()
        {
            throw new NotImplementedException();
        }

        private static void MostrarZapatillas()
        {
            var servicio=servicioProvider?.GetService<IShoesService>();
            var shoes=servicio?.GetShoes();

            Console.WriteLine("Listado De Zapatillas");

            var tabla=new ConsoleTable("ID","MARCA","MODELO","DESCRIPCION","DEPORTE","COLOR","GENERO","PRECIO");

            if (shoes!=null)
            {
                foreach (var s in shoes)
                {
                    tabla.AddRow(s.ShoeId, s.Brand.BrandName, s.Model, s.Description, s.Sport.SportName, s.Colour.ColourName,
                        s.Genre.GenreName, s.Price);
                }
            }
            tabla.Options.EnableCount = false;
            tabla.Write();
            Console.WriteLine($"Cantidad: {servicio?.GetCantidad()}");
        }
        //COLORES
        private static void EliminarColores()
        {
            Console.WriteLine("Elimar Color");
            MostrarColores();
            var id = ConsoleExtensions.ReadInt("Ingrese el ID a Eliminar: ");
            try
            {
                var servicio = servicioProvider?.GetService<IColoursService>();
                var colour = servicio?.GetColourPorId(id);
                if (colour != null)
                {
                    if (servicio != null)
                    {
                        if (!servicio.EstaRelacionado(colour))
                        {
                            servicio.Eliminar(colour);
                            Console.WriteLine("Registro eliminado.");
                        }
                        else
                        {
                            Console.WriteLine("El registro esta relacionado, No se puede eliminar");
                        }
                    }
                    else
                    {
                        throw new Exception("El servicio no esta disponible");
                    }
                }
                else
                {
                    Console.WriteLine("El registro que desea eliminar no existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            Thread.Sleep(2000);
        }
        private static void EditarColores()
        {
            var servicio = servicioProvider?.GetService<IColoursService>();
            Console.WriteLine("Editar COLORES: ");
            MostrarColores();

            var id = ConsoleExtensions.ReadInt("Ingrese el ID del Color a editar");
            var colour = servicio?.GetColourPorId(id);
            if (colour != null)
            {
                Console.WriteLine($"Color a editar: {colour.ColourName}");
                var newColour = ConsoleExtensions.ReadString("Ingrese el nuevo Color: ");
                colour.ColourName = newColour;
                servicio?.Guardar(colour);
                Console.WriteLine("Se edito el COLOR correctamente.");


            }
            else
            {
                Console.WriteLine("No se encuentra el ID Ingresado.");
            }
            Thread.Sleep(3000);
        }
        private static void AgregarColores()
        {
            var servicio = servicioProvider?.GetService<IColoursService>();

            Console.WriteLine("Agregar Un Color: ");
            MostrarColores();

            var colourName = ConsoleExtensions.ReadString("Nombre Del Color: ");

            var colour = new Colour
            {
                ColourName = colourName
            };

            if (servicio != null)
            {
                if (!servicio.Existe(colour))
                {
                    servicio.Guardar(colour);
                    Console.WriteLine("Color Agregado");
                }
                else
                {
                    Console.WriteLine("El Color que desea ingresar ya existe.");
                }
            }
            else
            {
                Console.WriteLine("Servicio no disponible");
            }

            Thread.Sleep(2000);
        }
        private static void MostrarColores()
        {
            var servicio = servicioProvider?.GetService<IColoursService>();
            var colours = servicio?.GetColours();

            Console.WriteLine("LISTADO DE COLORES ");

            var tabla = new ConsoleTable("ID", "COLOR");
            if (colours != null)
            {
                foreach (var item in colours)
                {
                    tabla.AddRow(item.ColourId, item.ColourName);
                }
            }
            tabla.Options.EnableCount = false;
            tabla.Write();
            Console.WriteLine($"Cantidad: {servicio?.GetCantidad()}");
        }
        //DEPORTES
        private static void EliminarDeporte()
        {
            Console.WriteLine("Elimar Deporte");
            MostrarGeneros();
            var id = ConsoleExtensions.ReadInt("Ingrese el ID a Eliminar: ");
            try
            {
                var servicio = servicioProvider?.GetService<ISportsService>();
                var sport = servicio?.GetSportPorId(id);
                if (sport != null)
                {
                    if (servicio != null)
                    {
                        if (!servicio.EstaRelacionado(sport))
                        {
                            servicio.Eliminar(sport);
                            Console.WriteLine("Registro eliminado.");
                        }
                        else
                        {
                            Console.WriteLine("El registro esta relacionado, No se puede eliminar");
                        }
                    }
                    else
                    {
                        throw new Exception("El servicio no esta disponible");
                    }
                }
                else
                {
                    Console.WriteLine("El registro que desea eliminar no existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            Thread.Sleep(2000);
        }
        private static void EditarDeporte()
        {
            var servicio = servicioProvider?.GetService<ISportsService>();
            Console.WriteLine("Editar DEPORTE: ");
            MostrarDeportes();

            var id = ConsoleExtensions.ReadInt("Ingrese el ID del DEPORTE a editar");
            var sport = servicio?.GetSportPorId(id);
            if (sport != null)
            {
                Console.WriteLine($"Deporte a editar: {sport.SportName}");
                var newSport = ConsoleExtensions.ReadString("Ingrese el nuevo Deporte: ");
                sport.SportName = newSport;
                servicio?.Guardar(sport);
                Console.WriteLine("Se edito el DEPORTE correctamente.");


            }
            else
            {
                Console.WriteLine("No se encuentra el ID Ingresado.");
            }
            Thread.Sleep(3000);
        }
        private static void AgregarDeporte()
        {
            var servicio = servicioProvider?.GetService<ISportsService>();

            Console.WriteLine("Agregar Un Deporte: ");
            MostrarGeneros();

            var sportName = ConsoleExtensions.ReadString("Nombre Del Deporte: ");

            var sport = new Sport
            {
                SportName = sportName
            };

            if (servicio != null)
            {
                if (!servicio.Existe(sport))
                {
                    servicio.Guardar(sport);
                    Console.WriteLine("Deporte Agregado");
                }
                else
                {
                    Console.WriteLine("El Deporte que desea ingresar ya existe.");
                }
            }
            else
            {
                Console.WriteLine("Servicio no disponible");
            }

            Thread.Sleep(2000);
        }
        private static void MostrarDeportes()
        {
            {
                var servicio = servicioProvider?.GetService<ISportsService>();
                var sports = servicio?.GetSports();

                Console.WriteLine("LISTADO DE Deportes ");

                var tabla = new ConsoleTable("ID", "Deporte");
                if (sports != null)
                {
                    foreach (var item in sports)
                    {
                        tabla.AddRow(item.SportId, item.SportName);
                    }
                }
                tabla.Options.EnableCount = false;
                tabla.Write();
                Console.WriteLine($"Cantidad: {servicio?.GetCantidad()}");
            }
        }
        //MARCAS
        private static void EliminarMarca()
        {
            Console.WriteLine("Elimar Marca");
            MostrarGeneros();
            var id = ConsoleExtensions.ReadInt("Ingrese el ID a Eliminar: ");
            try
            {
                var servicio = servicioProvider?.GetService<IBrandsService>();
                var brand = servicio?.GetBrandPorId(id);
                if (brand != null)
                {
                    if (servicio != null)
                    {
                        if (!servicio.EstaRelacionado(brand))
                        {
                            servicio.Eliminar(brand);
                            Console.WriteLine("Registro eliminado.");
                        }
                        else
                        {
                            Console.WriteLine("El registro esta relacionado, No se puede eliminar");
                        }
                    }
                    else
                    {
                        throw new Exception("El servicio no esta disponible");
                    }
                }
                else
                {
                    Console.WriteLine("El registro que desea eliminar no existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            Thread.Sleep(2000);
        }
        private static void EditarMarca()
        {
            var servicio = servicioProvider?.GetService<IBrandsService>();
            Console.WriteLine("Editar Marca: ");
            MostrarMarcas();

            var id = ConsoleExtensions.ReadInt("Ingrese el ID de la MARCA a editar");
            var brand = servicio?.GetBrandPorId(id);
            if (brand != null)
            {
                Console.WriteLine($"Marca a editar: {brand.BrandName}");
                var newBrand = ConsoleExtensions.ReadString("Ingrese la nueva Marca: ");
                brand.BrandName = newBrand;
                servicio?.Guardar(brand);
                Console.WriteLine("Se edito la MARCA correctamente.");


            }
            else
            {
                Console.WriteLine("No se encuentra el ID Ingresado.");
            }
            Thread.Sleep(3000);
        }
        private static void AgregarMarca()
        {
            var servicio = servicioProvider?.GetService<IBrandsService>();

            Console.WriteLine("Agregar Una Marca: ");
            MostrarGeneros();

            var brandName = ConsoleExtensions.ReadString("Nombre De La Marca: ");

            var brand = new Brand
            {
                BrandName = brandName
            };

            if (servicio != null)
            {
                if (!servicio.Existe(brand))
                {
                    servicio.Guardar(brand);
                    Console.WriteLine("Marca Agregada");
                }
                else
                {
                    Console.WriteLine("La Marca que desea ingresar ya existe.");
                }
            }
            else
            {
                Console.WriteLine("Servicio no disponible");
            }

            Thread.Sleep(2000);
        }
        private static void MostrarMarcas()
        {
            var servicio = servicioProvider?.GetService<IBrandsService>();
            var brand = servicio?.GetBrands();

            Console.WriteLine("LISTADO DE MARCAS ");

            var tabla = new ConsoleTable("ID", "MARCA");
            if (brand != null)
            {
                foreach (var item in brand)
                {
                    tabla.AddRow(item.BrandId, item.BrandName);
                }
            }
            tabla.Options.EnableCount = false;
            tabla.Write();
            Console.WriteLine($"Cantidad: {servicio?.GetCantidad()}");
        }
        //GENEROS
        private static void EliminarGenero()
        {
            Console.WriteLine("Elimar Genero");
            MostrarGeneros();
            var id = ConsoleExtensions.ReadInt("Ingrese el ID a Eliminar: ");
            try
            {
                var servicio = servicioProvider?.GetService<IGenresService>();
                var genre = servicio?.GetGenrePorId(id);
                if (genre != null)
                {
                    if (servicio != null)
                    {
                        if (!servicio.EstaRelacionado(genre))
                        {
                            servicio.Eliminar(genre);
                            Console.WriteLine("Registro eliminado.");
                        }
                        else
                        {
                            Console.WriteLine("El registro esta relacionado, No se puede eliminar");
                        }
                    }
                    else
                    {
                        throw new Exception("El servicio no esta disponible");
                    }
                }
                else
                {
                    Console.WriteLine("El registro que desea eliminar no existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            Thread.Sleep(2000);
        }
        private static void EditarGenero()
        {
            var servicio = servicioProvider?.GetService<IGenresService>();
            Console.WriteLine("Editar Genero: ");
            MostrarGeneros();

            var id = ConsoleExtensions.ReadInt("Ingrese el ID del Genero a editar: ");
            var genre = servicio?.GetGenrePorId(id);
            if (genre != null)
            {
                Console.WriteLine($"Genero a editar: {genre.GenreName}");
                var newGenre = ConsoleExtensions.ReadString("Ingrese el nuevo genero: ");
                genre.GenreName = newGenre;
                servicio?.Guardar(genre);
                Console.WriteLine("Se edito el genero correctamente.");


            }
            else
            {
                Console.WriteLine("No se encuentra el ID Genero Ingresado.");
            }
            Thread.Sleep(3000);
        }
        private static void AgregarGenero()
        {
            var servicio = servicioProvider?.GetService<IGenresService>();

            Console.WriteLine("Agregar Un Genero: ");
            MostrarGeneros();

            var genreName = ConsoleExtensions.ReadString("Nombre Del Genero: ");

            var genre = new Genre
            {
                GenreName = genreName
            };

            if (servicio != null)
            {
                if (!servicio.Existe(genre))
                {
                    servicio.Guardar(genre);
                    Console.WriteLine("Genero Agregado");
                }
                else
                {
                    Console.WriteLine("El genero que desea ingresar ya existe.");
                }
            }
            else
            {
                Console.WriteLine("Servicio no disponible");
            }

            Thread.Sleep(2000);
        }
        private static void MostrarGeneros()
        {
            var servicio = servicioProvider?.GetService<IGenresService>();
            var genres = servicio?.GetGenres();

            Console.WriteLine("LISTADO DE GENEROS ");

            var tabla = new ConsoleTable("ID", "GENERO");
            if (genres != null)
            {
                foreach (var item in genres)
                {
                    tabla.AddRow(item.GenreId, item.GenreName);
                }
            }
            tabla.Options.EnableCount = false;
            tabla.Write();
            Console.WriteLine($"Cantidad: {servicio?.GetCantidad()}");
        }
        
    }
}

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
                Console.WriteLine("9. Ver todas las Deportes");
                Console.WriteLine("10. Agregar una Deportes");
                Console.WriteLine("11. Editar una Deportes");
                Console.WriteLine("12. Eliminar una Deportes");
                Console.WriteLine("----------");
                Console.WriteLine("13. Ver todas las Colores");
                Console.WriteLine("14. Agregar una Colores");
                Console.WriteLine("15. Editar una Colores");
                Console.WriteLine("16. Eliminar una Colores");
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


                }
            }
        }
        //COLORES
        private static void EliminarColores()
        {
            throw new NotImplementedException();
        }

        private static void EditarColores()
        {
            throw new NotImplementedException();
        }

        private static void AgregarColores()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        private static void EditarDeporte()
        {
            throw new NotImplementedException();
        }

        private static void AgregarDeporte()
        {
            throw new NotImplementedException();
        }

        private static void MostrarDeportes()
        {
            {
                var servicio = servicioProvider?.GetService<ISportsService>();
                var sports = servicio?.GetSports();

                Console.WriteLine("LISTADO DE GENEROS ");

                var tabla = new ConsoleTable("ID", "GENERO");
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
            throw new NotImplementedException();
        }

        private static void EditarMarca()
        {
            throw new NotImplementedException();
        }

        private static void AgregarMarca()
        {
            throw new NotImplementedException();
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

            var id = ConsoleExtensions.ReadInt("Ingrese el ID del Genero a editar");
            var genre = servicio?.GetGenrePorId(id);
            if (genre != null)
            {
                Console.WriteLine($"Genero a editar: {genre.GenreName}");
                var nuevoGenre = ConsoleExtensions.ReadString("Ingrese el nuevo genero: ");
                genre.GenreName = nuevoGenre;
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

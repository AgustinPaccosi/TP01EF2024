using ConsoleTables;
using Microsoft.Extensions.DependencyInjection;
using TP01EF2024.Datos.Migrations;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Enum;
using TP01EF2024.InversionOfControl;
using TP01EF2024.Servicios.Interfaces;
using TP01EF2024.Servicios.Servicios;
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
                LimpiarConsola();
                MenuPrincipal();

                //Variables para Filtrar
                var precioMin = 0m;
                var precioMax = 0m;

                string? input = Console.ReadLine();
                
                switch (input)
                {
                    //GENEROS
                    case "1":
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
                    //---------------------------------------------------------------------------------------------

                    //MARCAS
                    case "5":
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
                    //---------------------------------------------------------------------------------------------

                    //DEPORTES
                    case "9":
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
                    //---------------------------------------------------------------------------------------------

                    //COLORES
                    case "13":
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
                    //---------------------------------------------------------------------------------------------

                    //ZAPATILLAS
                    case "17":
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
                    //---------------------------------------------------------------------------------------------

                    //TALLES
                    case "21":
                        Console.Clear();
                        MostrarTalles();
                        ConsoleExtensions.Enter();
                        break;
                    case "22":
                        Console.Clear();
                        AgregarTalle();
                        ConsoleExtensions.Enter();
                        break;
                    case "23":
                        Console.Clear();
                        EditarTalle(); 
                        ConsoleExtensions.Enter();
                        break;
                    case "24":
                        Console.Clear();
                        EliminarTalle();
                        ConsoleExtensions.Enter();
                        break;
                    //---------------------------------------------------------------------------------------------

                    //LISTADOS PAGINADOS
                    case "25":
                        Console.Clear();
                        ListarGenerosPaginado();
                        ConsoleExtensions.Enter();
                        break;
                    case "26":
                        Console.Clear();
                        ListarDeportesPaginado();
                        ConsoleExtensions.Enter();
                        break;
                    case "27":
                        Console.Clear();
                        ListarMarcasPaginado();
                        ConsoleExtensions.Enter();
                        break;
                    case "28":
                        Console.Clear();
                        ListarTallesPaginado();
                        ConsoleExtensions.Enter();
                        break;
                    //---------------------------------------------------------------------------------------------
                    
                    //Listados Filtrados Paginados
                    case "29":
                        Console.Clear();
                        ListarZapatillasPorMarcaPaginado(null, null);
                        ConsoleExtensions.Enter();
                        break;
                    case "30":
                        Console.Clear();
                        ListarZapatillasPorDeportePaginado(null, null);
                        ConsoleExtensions.Enter();
                        break;
                    case "31":
                        Console.Clear();
                        ListarZapatillasPorGeneroPaginado(null, null);
                        ConsoleExtensions.Enter();
                        break;
                    case "32":
                        Console.Clear();
                        ListarZapatillasPorColorPaginado(null, null);
                        ConsoleExtensions.Enter();
                        break;
                    //---------------------------------------------------------------------------------------------

                    //Listados Filtrados por precio Paginados
                    case "33":
                        Console.Clear();
                        precioMin = ConsoleExtensions.ReadDecimal("Ingrese el precio Minimo: ");
                        precioMax = ConsoleExtensions.ReadDecimal("Ingrese el precio Maximo: ");
                        ListarZapatillasPorMarcaPaginado(precioMin, precioMax);
                        Console.WriteLine("Lista Finalizada");
                        ConsoleExtensions.Enter();
                        break;
                    //---------------------------------------------------------------------------------------------

                    //Filtrados por Talles y zapatillas
                    case "34":
                        Console.Clear();
                        AsignarTalles(); ;
                        ConsoleExtensions.Enter();
                        break;
                    case "35":
                        Console.Clear();
                        ListarZapatillasPorTalle();
                        ConsoleExtensions.Enter();
                        break;
                    case "36":
                        Console.Clear();
                        ListarTallesPorZapatillas();
                        ConsoleExtensions.Enter();
                        break;


                    case "x" or "X":
                        exit = true;
                        break;

                }
            }
        }



        //Limpiar Consola
        private static void LimpiarConsola()
        {
            Console.Clear();
            //// Escribir líneas en blanco para limpiar la consola
            //int lines = Console.WindowHeight;
            //for (int i = 0; i < lines; i++)
            //{
            //    Console.WriteLine(new string(' ', Console.WindowWidth));
            //}
            //// Mover el cursor a la posición superior izquierda
            //Console.SetCursorPosition(0, 0);
        }
        //---------------------------------------------------------------------------------------------

        //Menu Principal
        private static void MenuPrincipal()
        {
            Console.WriteLine("MENÚ PRINCIPAL:");
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("1. Ver Generos");
            Console.WriteLine("2. Agregar un Genero");
            Console.WriteLine("3. Editar un Genero");
            Console.WriteLine("4. Eliminar un Genero");
            Console.WriteLine("----------");
            Console.WriteLine("5. Ver Marcas");
            Console.WriteLine("6. Agregar una Marca");
            Console.WriteLine("7. Editar una Marca");
            Console.WriteLine("8. Eliminar una Marca");
            Console.WriteLine("----------");
            Console.WriteLine("9. Ver Deportes");
            Console.WriteLine("10. Agregar un Deporte");
            Console.WriteLine("11. Editar un Deports");
            Console.WriteLine("12. Eliminar un Deporte");
            Console.WriteLine("----------");
            Console.WriteLine("13. Ver Colores");
            Console.WriteLine("14. Agregar un Color");
            Console.WriteLine("15. Editar un Color");
            Console.WriteLine("16. Eliminar un Color");
            Console.WriteLine("----------");
            Console.WriteLine("17. Ver Zapatillas");
            Console.WriteLine("18. Agregar una Zapatilla");
            Console.WriteLine("19. Editar una Zapatilla");
            Console.WriteLine("20. Eliminar una Zapatilla");
            Console.WriteLine("----------");
            Console.WriteLine("21. Ver Talles");
            Console.WriteLine("22. Agregar Talle");
            Console.WriteLine("23. Editar Talle");
            Console.WriteLine("24. Eliminar Talle");
            Console.WriteLine("----------");
            Console.WriteLine("25. Paginado Generos");
            Console.WriteLine("26. Paginado Deportes");
            Console.WriteLine("27. Paginado Marcas");
            Console.WriteLine("28. Paginado Talles");
            Console.WriteLine("----------");
            Console.WriteLine("29. Zapatillas Por Marca Paginado");
            Console.WriteLine("30. Zapatillas Por Deporte Paginado");
            Console.WriteLine("31. Zapatillas Por Genero Paginado");
            Console.WriteLine("32. Zapatillas Por Color Paginado");
            Console.WriteLine("----------");
            Console.WriteLine("33. Zapatillas Por Marca Entre Precios Paginado");
            Console.WriteLine("----------");
            Console.WriteLine("34. Asignar Talles a Zapatillas");
            Console.WriteLine("35. Zapatillas Por Talle");
            Console.WriteLine("36. Talle Por Zapatillas");
            Console.WriteLine("----------");



            Console.WriteLine("PRESIONE X PARA SALIR");
            Console.Write("Por favor, seleccione una opción: ");

        }
        //---------------------------------------------------------------------------------------------


        //Colores
        private static void EliminarColores()
        {
            Console.WriteLine("Elimar Color");
            MostrarColores();
            var id = ConsoleExtensions.ReadInt("Ingrese el ID a Eliminar: ", 0, 9999);
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
            Console.WriteLine("Editar un Color: ");
            MostrarColores();

            var id = ConsoleExtensions.ReadInt("Ingrese el ID del Color a editar", 0, 9999);
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

            Console.WriteLine("LListado de Colores ");

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
        //---------------------------------------------------------------------------------------------

        //Deportes
        private static void EliminarDeporte()
        {
            Console.WriteLine("Elimar Deporte");
            MostrarGeneros();
            var id = ConsoleExtensions.ReadInt("Ingrese el ID a Eliminar: ",0, 9999);
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
            Console.WriteLine("Editar Deporte: ");
            MostrarDeportes();

            var id = ConsoleExtensions.ReadInt("Ingrese el ID del DEPORTE a editar", 0, 9999);
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

                Console.WriteLine("Listado DE Deportes ");

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
        //---------------------------------------------------------------------------------------------

        //Marcas
        private static void EliminarMarca()
        {
            Console.WriteLine("Elimar Marca");
            MostrarGeneros();
            var id = ConsoleExtensions.ReadInt("Ingrese el ID a Eliminar: ", 0, 9999);
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

            var id = ConsoleExtensions.ReadInt("Ingrese el ID de la MARCA a editar", 0, 9999);
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

            Console.WriteLine("Listado de Marcas ");

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
        //---------------------------------------------------------------------------------------------

        //Generos
        private static void EliminarGenero()
        {
            Console.WriteLine("Elimar Genero");
            MostrarGeneros();
            var id = ConsoleExtensions.ReadInt("Ingrese el ID a Eliminar: ", 0, 9999);
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

            var id = ConsoleExtensions.ReadInt("Ingrese el ID del Genero a editar: ", 0, 9999);
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

            Console.WriteLine("Listado de Generos ");

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
        //---------------------------------------------------------------------------------------------

        //Zapatillas
        private static void EliminarZapatillas()
        {
            Console.WriteLine("Eliminar Una zapatilla");
            MostrarZapatillas();
            var id = ConsoleExtensions.ReadInt("Ingrese el ID de la Zapatilla que desea eliminar: ", 0, 9999);
            try
            {
                var servicio = servicioProvider?.GetService<IShoesService>();
                var shoe = servicio?.GetShoePorId(id);

                if (shoe != null)
                {
                    if (servicio != null)
                    {
                        if (!servicio.EstaRelacionado(shoe))
                        {
                            servicio.Eliminar(shoe);
                            Console.WriteLine("Registro eliminado satisfactoriamente.");

                        }
                        else
                        {
                            Console.WriteLine("El registro no puede ser eliminado porque se encuentra relacionado.");
                        }

                    }
                    else
                    {
                        throw new Exception("Servicio no disponible.");
                    }
                }
                else
                {
                    Console.WriteLine("El registro que desea eliminar no existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); ;
            }

            Thread.Sleep(5000);
        }
        private static void EditarZapatillas()
        {
            var servicio = servicioProvider?.GetService<IShoesService>();

            Console.WriteLine("Editar una Zapatilla: ");
            MostrarZapatillas();
            var id = ConsoleExtensions.ReadInt("ID del zapatilla a editar: ", 0, 9999);
            var shoe = servicio?.GetShoePorId(id);

            if (shoe != null)
            {
                Console.WriteLine($"Zapatilla a editar: ID: {shoe.ShoeId}, Marca: , Modelo:{shoe.Model}, Descripcion: {shoe.Description} ");
                var model = ConsoleExtensions.ReadString("Ingrese el modelo de la zapatilla: ");
                var description = ConsoleExtensions.ReadString("Ingrese la descripcion de la zapatilla: ");
                var precio = ConsoleExtensions.ReadDecimal("Ingrese el precio de la zapatilla: ");
                MostrarMarcas();
                var marca = ConsoleExtensions.ReadInt("Ingrese el ID de la marca de la zapatilla: ", 0, 9999);
                MostrarDeportes();
                var deporte = ConsoleExtensions.ReadInt("Ingrese el ID del deporte de la zapatilla: ", 0, 9999);
                MostrarGeneros();
                var genero = ConsoleExtensions.ReadInt("Ingrese el ID del genero de la zapatilla: ", 0, 9999);

                shoe.Model = model;
                shoe.Description = description;
                shoe.Price = precio;
                shoe.BrandId = marca;
                shoe.SportId = deporte;
                shoe.GenreId = genero;

                servicio?.Guardar(shoe);
                Console.WriteLine("Zapatilla editada satisfactoriamente.");
            }
            else
            {
                Console.WriteLine("La Zapatilla que desea editar no existe.");
            }
            Thread.Sleep(2000);


        }
        private static void AgregarZapatillas()
        {
            var servicio = servicioProvider?.GetService<IShoesService>();

            Console.WriteLine("Agregar Zapatilla");

            var model = ConsoleExtensions.ReadString("Ingrese el modelo de la zapatilla: ");
            var description = ConsoleExtensions.ReadString("Ingrese la descripcion de la zapatilla: ");
            var precio = ConsoleExtensions.ReadDecimal("Ingrese el precio del zapatilla: ");

            Console.Clear();
            MostrarMarcas();
            var marca = ConsoleExtensions.ReadInt("Ingrese el ID de la marca de la zapatilla: ", 0, 9999);

            Console.Clear();
            MostrarDeportes();
            var deporte = ConsoleExtensions.ReadInt("Ingrese el ID del deporte de la zapatilla: ", 0, 9999);

            Console.Clear();
            MostrarGeneros();
            var genero = ConsoleExtensions.ReadInt("Ingrese el ID del genero de la zapatilla: ", 0, 9999);

            Console.Clear();
            MostrarColores();
            var colourId = ConsoleExtensions.ReadInt("Ingrese el ID del Color de la zapatilla: ", 0, 9999);

            var shoe = new Shoe
            {
                BrandId = marca,
                SportId = deporte,
                GenreId = genero,
                Model = model,
                Description = description,
                Price = precio,
                ColourId = colourId
            };

            if (servicio != null)
            {
                if (!servicio.Existe(shoe))
                {
                    servicio.Guardar(shoe);
                    Console.WriteLine("Zapatilla agregado satisfactoriamente.");
                }
                else
                {
                    Console.WriteLine("El zapatilla que desea ingresar ya existe.");
                }
            }
            else
            {
                Console.WriteLine("Servicio no disponible");
            }

            Thread.Sleep(2000);
        }
        private static void MostrarZapatillas()
        {
            var servicio = servicioProvider?.GetService<IShoesService>();
            var shoes = servicio?.GetShoes();

            Console.WriteLine("Listado De Zapatillas");

            var tabla = new ConsoleTable("ID", "MARCA", "MODELO", "DESCRIPCION", "DEPORTE", "COLOR", "GENERO", "PRECIO");

            if (shoes != null)
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
        //---------------------------------------------------------------------------------------------

        //Talles
        private static void EliminarTalle()
        {
            Console.WriteLine("Eliminar Un Talle");
            MostrarTalles();
            var id = ConsoleExtensions.ReadInt("Ingrese el ID del talle que desea eliminar: ", 0, 9999);
            try
            {
                var servicio = servicioProvider?.GetService<ISizesService>();
                var size = servicio?.GetSizePorId(id);

                if (size != null)
                {
                    if (servicio != null)
                    {
                        if (!servicio.EstaRelacionado(size))
                        {
                            servicio.Eliminar(size);
                            Console.WriteLine("Registro eliminado satisfactoriamente.");

                        }
                        else
                        {
                            Console.WriteLine("El registro no puede ser eliminado porque se encuentra relacionado.");
                        }

                    }
                    else
                    {
                        throw new Exception("Servicio no disponible.");
                    }
                }
                else
                {
                    Console.WriteLine("El registro que desea eliminar no existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); ;
            }

            Thread.Sleep(5000);
        }
        private static void EditarTalle()
        {
            var servicio = servicioProvider?.GetService<ISizesService>();

            Console.WriteLine("Editar talle");
            MostrarTalles();

            var id = ConsoleExtensions.ReadInt("Ingrese el ID del talle que desea editar: ", 0, 9999);
            var size = servicio?.GetSizePorId(id);

            if (size != null)
            {
                Console.WriteLine($"Talle Anterior: {size.SizeNumber}");
                var nuevoNumber = ConsoleExtensions.ReadDecimal("Ingrese el nuevo talle: ");
                size.SizeNumber = nuevoNumber;
                servicio?.Guardar(size);
                Console.WriteLine("Talle editado satisfactoriamente.");
            }
            else
            {
                Console.WriteLine("El talle que desea editar no existe.");
            }
            Thread.Sleep(2000);
        }
        private static void AgregarTalle()
        {
            var servicio = servicioProvider?.GetService<ISizesService>();

            Console.WriteLine("Agregar Un talle");

            var sizeNumber = ConsoleExtensions.ReadDecimal("Ingrese el número del talle: ");

            var size = new Size
            {
                SizeNumber = sizeNumber
            };

            if (servicio != null)
            {
                if (!servicio.Existe(size))
                {
                    servicio.Guardar(size);
                    Console.WriteLine("Talle agregado.");
                }
                else
                {
                    Console.WriteLine("El talle que desea ingresar ya existe.");
                }
            }
            else
            {
                Console.WriteLine("Servicio no disponible");
            }

            Thread.Sleep(2000);
        }
        private static void MostrarTalles()
        {
            var servicio = servicioProvider?.GetService<ISizesService>();
            var sizes = servicio?.GetSizes();
            Console.WriteLine("Listado De Talles");

            var tabla = new ConsoleTable("ID", "TALLE");

            if (sizes != null)
            {
                foreach (var s in sizes)
                {
                    tabla.AddRow(s.SizeId, s.SizeNumber);
                }
            }
            tabla.Options.EnableCount = false;
            tabla.Write();
            Console.WriteLine($"Cantidad: {servicio?.GetCantidad()}");
        }
        //---------------------------------------------------------------------------------------------

        //Talles Zapatillas
        private static void AsignarTalles()
        {
            var servicioTalles = servicioProvider?.GetService<ISizesService>();
            var servicioShoes = servicioProvider?.GetService<IShoesService>();

            if (servicioTalles == null || servicioShoes == null)
            {
                Console.WriteLine("Servicios no disponibles.");
                return;
            }

            MostrarZapatillas();
            var shoeId = ConsoleExtensions.ReadInt("Ingrese el ID del Zapatilla al que se le asignará un talle: ",0,9999);
            Shoe shoe = servicioShoes.GetShoePorId(shoeId);
            if (shoe != null)
            {
                MostrarTalles();
                var sizeId = ConsoleExtensions.ReadInt("Ingrese el ID del talle que desea asignar al Zapatilla:  ", 0, 9999);
                Size size = servicioTalles.GetSizePorId(sizeId);

                if (size != null)
                {
                    Console.WriteLine($"Está por agregar el talle {size.SizeNumber} a los zapatos de id {shoe.ShoeId} y modelo {shoe.Model}");
                    var stock = ConsoleExtensions.ReadInt("Ingrese la cantidad de stock a dar de alta para este ingreso: ", 0, 9999);
                    servicioShoes.AsignarTalle(shoe, size, stock);

                    Console.WriteLine("Se ingresó lo siguiente:");
                    Console.WriteLine($"ZAPATILLAS: ");
                    Console.WriteLine($"Marca: {shoe.Brand.BrandName}");
                    Console.WriteLine($"Deporte: {shoe.Sport.SportName}");
                    Console.WriteLine($"Genero: {shoe.Genre.GenreName}");
                    Console.WriteLine($"Color: {shoe.Colour.ColourName}");
                    Console.WriteLine($"Modelo: {shoe.Model}");
                    Console.WriteLine($"Descripción {shoe.Description}");
                    Console.WriteLine($"Precio {shoe.Price}");
                    Console.WriteLine($"TALLE: {size.SizeNumber}");
                    Console.WriteLine($"Cantidad de stock: {stock}");

                    Console.WriteLine("Registro agregado satisfactoriamente...");
                }
                else
                {
                    Console.WriteLine("El ID del talle que ha seleccionado, no existe");

                }
            }
            else
            {
                Console.WriteLine("El ID del zapato que ha seleccionado, no existe");
            }

        }
        private static void ListarTallesPorZapatillas()
        {
            var servicioShoes = servicioProvider?.GetService<IShoesService>();

            MostrarZapatillas();

            var shoeId = ConsoleExtensions.ReadInt("Ingrese el ID del zapato para poder ver los talles en los que se encuentra disponible: ",0,9999);

            Shoe? shoe = servicioShoes?.GetShoePorId(shoeId);

            if (shoe != null)
            {
                Console.WriteLine("Zapatilla Seleccionada: ");

                var tablaShoe = new ConsoleTable("ID", "MARCA", "DEPORTE", "GENERO", "COLOR", "MODELO", "DESCRIPCION", "PRECIO");
                tablaShoe.AddRow(
                        shoe.ShoeId,
                        shoe.Brand.BrandName,
                        shoe.Sport.SportName,
                        shoe.Genre.GenreName,
                        shoe.Colour.ColourName,
                        shoe.Model,
                        shoe.Description,
                        shoe.Price);
                tablaShoe.Options.EnableCount = false;
                tablaShoe.Write();

                List<Size>? sizes = servicioShoes?.GetSizesForShoe(shoe.ShoeId);
                if (sizes != null && sizes.Count() > 0)
                {
                    Console.WriteLine("Talles Disponibles");

                    var tablaSizes = new ConsoleTable("ID", "TALLE", "STOCK");
                    foreach (var s in sizes)
                    {
                        int stock = servicioShoes.GetStockShoeSize(shoe, s);

                        tablaSizes.AddRow(s.SizeId, s.SizeNumber, stock);
                    }
                    tablaSizes.Options.EnableCount = false;
                    tablaSizes.Write();

                }
                else
                {
                    Console.WriteLine("No hay talles disponibles para esta Zapatilla.");
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("El ID que ha ingresado no corresponde a ninguna Zapatilla.");
            }
        }
        private static void ListarZapatillasPorTalle()
        {
            var servicioSizes = servicioProvider?.GetService<ISizesService>();
            var servicioShoes = servicioProvider?.GetService<IShoesService>();

            MostrarTalles();

            var sizeId = ConsoleExtensions.ReadInt("Ingrese el ID del talle para poder ver los Zapatillas disponibles: ",0, 9999);

            Size? size = servicioSizes?.GetSizePorId(sizeId);

            if (size != null)
            {
                Console.WriteLine($"Talle Seleccionado: {size.SizeNumber}");

                List<Shoe>? shoes = servicioSizes?.GetShoesForSize(size.SizeId);

                if (shoes != null && shoes.Count() > 0)
                {
                    Console.WriteLine("Zpatillas Disponibles:");
                    var tabla = new ConsoleTable("ID", "MARCA", "DEPORTE", "GENERO", "COLOR", "MODELO", "DESCRIPCION", "PRECIO", "STOCK");
                    foreach (var s in shoes)
                    {
                        int stock = servicioShoes.GetStockShoeSize(s, size);

                        tabla.AddRow(s.ShoeId,
                            s.Brand.BrandName,
                            s.Sport.SportName,
                            s.Genre.GenreName,
                            s.Colour.ColourName,
                            s.Model,
                            s.Description,
                            s.Price,
                            stock);
                    }
                    tabla.Options.EnableCount = false;
                    tabla.Write();
                }
                else
                {
                    Console.WriteLine("No hay zapatos disponibles en el talle seleccionado.");
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("El ID que ha ingresado no corresponde a ningun talle.");
            }
        }
        //---------------------------------------------------------------------------------------------


        //Calculo de Paginas
        private static int CalcularCantidadPaginas(int cantRegistros, int cantPorPagina)
        {
            if (cantRegistros < cantPorPagina)
            {
                return 1;
            }
            else if (cantRegistros % cantPorPagina == 0)
            {
                return cantRegistros / cantPorPagina;
            }
            else
            {
                return cantRegistros / cantPorPagina + 1;
            }
        }
        //---------------------------------------------------------------------------------------------


        //Listas Paginadas
        private static void ListarMarcasPaginado()
        {
            Console.Clear();
            var servicio = servicioProvider?.GetService<IBrandsService>();
            var pageSize = ConsoleExtensions.ReadInt("Ingrese la cantidad por página:", 1, 10);
            var recordCount = servicio?.GetCantidad() ?? 0;
            var pageCount = CalcularCantidadPaginas(recordCount, pageSize);

            for (int page = 0; page < pageCount; page++)
            {
                Console.Clear();
                Console.WriteLine("Listado Paginado");
                Console.WriteLine($"Página: {page + 1}");
                var lista = servicio?
                    .GetListaPaginadaOrdenada(page, pageSize, Orden.AZ);
                PaginadoMarcas(servicio, lista);
            }
            Console.WriteLine("Fin del Listado");
        }
        private static void PaginadoMarcas(IBrandsService? servicio, List<Brand>? lista)
        {
            Console.WriteLine("Listado de Marcas en la tienda");
            ConsoleTable tabla = new ConsoleTable("ID", "Marca");
            if (lista != null)
            {
                foreach (var brand in lista)
                {
                    tabla.AddRow(brand.BrandId, brand.BrandName);
                }
            }
            tabla.Options.EnableCount = false;
            tabla.Write();
            Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
            Console.WriteLine("Presione ENTER para continuar.");
            Console.ReadLine();
        }
        private static void ListarDeportesPaginado()
        {
            Console.Clear();
            var servicio = servicioProvider?.GetService<ISportsService>();
            var pageSize = ConsoleExtensions.ReadInt("Ingrese la cantidad por página:", 2, 10);
            var recordCount = servicio?.GetCantidad() ?? 0;
            var pageCount = CalcularCantidadPaginas(recordCount, pageSize);

            for (int page = 0; page < pageCount; page++)
            {
                Console.Clear();
                Console.WriteLine("Listado Paginado");
                Console.WriteLine($"Página: {page + 1}");
                var lista = servicio?
                    .GetListaPaginadaOrdenada(page, pageSize, Orden.AZ);
                PaginadoDeportes(servicio, lista);
            }
            Console.WriteLine("Fin del Listado");
        }
        private static void PaginadoDeportes(ISportsService? servicio, List<Sport>? lista)
        {
            Console.WriteLine("Listado de Deportes en la tienda");
            ConsoleTable tabla = new ConsoleTable("ID", "Deporte");
            if (lista != null)
            {
                foreach (var sport in lista)
                {
                    tabla.AddRow(sport.SportId, sport.SportName);
                }
            }
            tabla.Options.EnableCount = false;
            tabla.Write();
            Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
            Console.WriteLine("Presione ENTER para continuar.");

            Console.ReadLine();
        }
        private static void ListarGenerosPaginado()
        {
            Console.Clear();
            var servicio = servicioProvider?.GetService<IGenresService>();
            var pageSize = ConsoleExtensions.ReadInt("Ingrese la cantidad por página:", 2, 10);
            var recordCount = servicio?.GetCantidad() ?? 0;
            var pageCount = CalcularCantidadPaginas(recordCount, pageSize);

            for (int page = 0; page < pageCount; page++)
            {
                Console.Clear();
                Console.WriteLine("Listado Paginado");
                Console.WriteLine($"Página: {page + 1}");
                var lista = servicio?
                    .GetListaPaginadaOrdenada(page, pageSize, Orden.AZ);
                PaginadoGeneros(servicio, lista);
            }
            Console.WriteLine("Fin del Listado");
        }
        private static void PaginadoGeneros(IGenresService? servicio, List<Genre>? lista)
        {
            Console.WriteLine("Listado de Generos en la tienda");
            ConsoleTable tabla = new ConsoleTable("ID", "Genero");
            if (lista != null)
            {
                foreach (var genre in lista)
                {
                    tabla.AddRow(genre.GenreId, genre.GenreName);
                }
            }
            tabla.Options.EnableCount = false;
            tabla.Write();
            Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
            Console.WriteLine("Presione ENTER para continuar.");

            Console.ReadLine();
        }
        private static void ListarTallesPaginado()
        {
            var servicio = servicioProvider?.GetService<ISizesService>();
            var pageSize = ConsoleExtensions.ReadInt("Ingrese la cantidad por página:", 2, 10);
            var recordCount = servicio?.GetCantidad() ?? 0;
            var pageCount = CalcularCantidadPaginas(recordCount, pageSize);
            for (int page = 0; page < pageCount; page++)
            {
                Console.Clear();
                Console.WriteLine("Listado Paginado");
                Console.WriteLine($"Página: {page + 1}");
                var lista = servicio?
                    .GetListaPaginadaOrdenada(page, pageSize, Orden.AZ);
                PaginadoTalles(servicio, lista);
            }
            Console.WriteLine("Fin del Listado");

            }
        private static void PaginadoTalles(ISizesService? servicio, List<Size>? lista)
        {
            Console.WriteLine("Listado de Talles en la tienda");
            ConsoleTable tabla = new ConsoleTable("ID", "Talle ");
            if (lista != null)
            {
                foreach (var genre in lista)
                {
                    tabla.AddRow(genre.SizeId, genre.SizeNumber);
                }
            }
            tabla.Options.EnableCount = false;
            tabla.Write();
            Console.WriteLine($"Cantidad de registros: {servicio?.GetCantidad()}");
            Console.WriteLine("Presione ENTER para continuar.");

            Console.ReadLine();
        }
        //---------------------------------------------------------------------------------------------


        //Listas Filtradas Paginadas
        private static void ListarZapatillasPorColorPaginado(decimal? precioMinimo = null, decimal? precioMaximo = null)
        {
            MostrarColores();
            var servicioColor = servicioProvider?.GetService<IColoursService>();
            var servicioShoes = servicioProvider?.GetService<IShoesService>();
            var colourId = ConsoleExtensions.ReadInt("Ingrese el ID del Color para ver los zapatos disponibles: ", 0, 9999);
            var pageSize = ConsoleExtensions.ReadInt("Ingrese la cantidad por página:", 1, 10);


            Colour? colour = servicioColor?.GetColourPorId(colourId);

            var CantidadRegistros = servicioShoes?.GetCantidadFiltrada(null, null, null, colour, precioMaximo, precioMinimo) ?? 0;
            var CantidadDePaginas = CalcularCantidadPaginas(CantidadRegistros, pageSize);

            if (colour != null)
            {
                List<Shoe>? shoes = null;

                if (precioMinimo != null && precioMaximo != null)
                {
                    for (int page = 0; page < CantidadDePaginas; page++)
                    {
                        Console.Clear();
                        shoes = servicioShoes?.GetListaPaginadaOrdenadaFiltrada(true, page, pageSize, null, null, null, null, colour, precioMaximo, precioMinimo);
                        if (shoes != null && shoes.Count() != 0)
                        {
                            Console.WriteLine("Listado de Zapatillas");
                            Console.WriteLine($"Página: {page + 1}");
                            TablaDeZapatillas(shoes);
                            Console.WriteLine($"Cantidad: {CantidadRegistros}");
                            ConsoleExtensions.Enter();

                        }
                        else
                        {
                            Console.WriteLine($"No existen zapatos de la marca {colour.ColourName} con precio entre ${precioMinimo} y ${precioMaximo}");
                        }
                    }
                }
                else
                {
                    for (int page = 0; page < CantidadDePaginas; page++)
                    {
                        Console.Clear();
                        shoes = servicioShoes?.GetListaPaginadaOrdenadaFiltrada(true, page, pageSize, null, null, null, null, colour, null, null);
                        if (shoes != null && shoes.Count() != 0)
                        {
                            Console.WriteLine("Listado de Zapatillas");
                            Console.WriteLine($"Página: {page + 1}");
                            TablaDeZapatillas(shoes);
                            Console.WriteLine($"Cantidad: {CantidadRegistros}");
                            ConsoleExtensions.Enter();

                        }
                        else
                        {
                            Console.WriteLine($"No existen zapatos de la marca {colour.ColourName}");
                        }
                    }

                    //shoes = servicioColor?.GetShoes(colour);
                    //TablaDeZapatos(shoes);
                    //Console.WriteLine($"Cantidad: {servicioShoes?.GetCantidad()}");
                    //Console.WriteLine($"ERRORRRRRRR");


                }

            }
            else
            {
                Console.WriteLine("La marca que ha seleccionado no existe.");
            }
        }
        private static void ListarZapatillasPorDeportePaginado(decimal? precioMinimo = null, decimal? precioMaximo = null)
        {
            MostrarDeportes();
            var servicioSport = servicioProvider?.GetService<ISportsService>();
            var servicioShoes = servicioProvider?.GetService<IShoesService>();
            var sporId = ConsoleExtensions.ReadInt("Ingrese el ID del Deporte para ver los zapatos disponibles: ", 0, 9999);
            var pageSize = ConsoleExtensions.ReadInt("Ingrese la cantidad por página:", 1, 10);


            Sport? sport = servicioSport?.GetSportPorId(sporId);

            var CantidadRegistros = servicioShoes?.GetCantidadFiltrada(null, sport, null, null, precioMaximo, precioMinimo) ?? 0;
            var CantidadDePaginas = CalcularCantidadPaginas(CantidadRegistros, pageSize);

            if (sport != null)
            {
                List<Shoe>? shoes = null;

                if (precioMinimo != null && precioMaximo != null)
                {
                    for (int page = 0; page < CantidadDePaginas; page++)
                    {
                        Console.Clear();
                        shoes = servicioShoes?.GetListaPaginadaOrdenadaFiltrada(true, page, pageSize, null, null, sport, null, null, precioMaximo, precioMinimo);
                        if (shoes != null && shoes.Count() != 0)
                        {
                            Console.WriteLine("Listado de Zapatillas");
                            Console.WriteLine($"Página: {page + 1}");
                            TablaDeZapatillas(shoes);
                            Console.WriteLine($"Cantidad: {CantidadRegistros}");
                            ConsoleExtensions.Enter();

                        }
                        else
                        {
                            Console.WriteLine($"No existen zapatos de la marca {sport.SportName} con precio entre ${precioMinimo} y ${precioMaximo}");
                        }
                    }
                }
                else
                {
                    for (int page = 0; page < CantidadDePaginas; page++)
                    {
                        Console.Clear();
                        shoes = servicioShoes?.GetListaPaginadaOrdenadaFiltrada(true, page, pageSize, null, null, sport, null, null, null, null);
                        if (shoes != null && shoes.Count() != 0)
                        {
                            Console.WriteLine("Listado de Zapatillas");
                            Console.WriteLine($"Página: {page + 1}");
                            TablaDeZapatillas(shoes);
                            Console.WriteLine($"Cantidad: {CantidadRegistros}");
                            ConsoleExtensions.Enter();

                        }
                        else
                        {
                            Console.WriteLine($"No existen zapatos de la marca {sport.SportName}");
                        }
                    }

                    //shoes = servicioMarcas?.GetShoes(brand);
                    //TablaDeZapatos(shoes);
                    //Console.WriteLine($"Cantidad: {servicioShoes?.GetCantidad()}");

                }

            }
            else
            {
                Console.WriteLine("La marca que ha seleccionado no existe.");
            }
        }
        private static void ListarZapatillasPorMarcaPaginado(decimal? precioMinimo = null, decimal? precioMaximo = null)
        {
            MostrarMarcas();
            var servicioMarcas = servicioProvider?.GetService<IBrandsService>();
            var servicioShoes = servicioProvider?.GetService<IShoesService>();
            var brandId = ConsoleExtensions.ReadInt("Ingrese el ID de la marca para ver los zapatos disponibles: ", 0, 9999);
            var pageSize = ConsoleExtensions.ReadInt("Ingrese la cantidad por página:", 1, 10);


            Brand? brand = servicioMarcas?.GetBrandPorId(brandId);

            var CantidadRegistros = servicioShoes?.GetCantidadFiltrada(brand, null, null, null, precioMaximo, precioMinimo) ?? 0;
            var CantidadDePaginas = CalcularCantidadPaginas(CantidadRegistros, pageSize);

            if (brand != null)
            {
                List<Shoe>? shoes = null;

                if (precioMinimo != null && precioMaximo != null)
                {
                    for (int page = 0; page < CantidadDePaginas; page++)
                    {
                        Console.Clear();
                        shoes = servicioShoes?.GetListaPaginadaOrdenadaFiltrada(true, page, pageSize, null, brand, null, null, null, precioMaximo, precioMinimo);
                        if (shoes != null && shoes.Count() != 0)
                        {
                            Console.WriteLine("Listado de Zapatillas");
                            Console.WriteLine($"Página: {page + 1}");
                            TablaDeZapatillas(shoes);
                            Console.WriteLine($"Cantidad: {CantidadRegistros}");
                            ConsoleExtensions.Enter();

                        }
                        else
                        {
                            Console.WriteLine($"No existen zapatos de la marca {brand.BrandName} con precio entre ${precioMinimo} y ${precioMaximo}");
                        }
                    }
                }
                else
                {
                    for (int page = 0; page < CantidadDePaginas; page++)
                    {
                        Console.Clear();
                        shoes = servicioShoes?.GetListaPaginadaOrdenadaFiltrada(true, page, pageSize, null, brand, null, null, null, null, null);
                        if (shoes != null && shoes.Count() != 0)
                        {
                            Console.WriteLine("Listado de Zapatillas");
                            Console.WriteLine($"Página: {page + 1}");
                            TablaDeZapatillas(shoes);
                            Console.WriteLine($"Cantidad: {CantidadRegistros}");
                            ConsoleExtensions.Enter();

                        }
                        else
                        {
                            Console.WriteLine($"No existen zapatos de la marca {brand.BrandName} ");
                        }
                    }

                    //shoes = servicioMarcas?.GetShoes(brand);
                    //TablaDeZapatos(shoes);
                    //Console.WriteLine($"Cantidad: {servicioShoes?.GetCantidad()}");

                }

            }
            else
            {
                Console.WriteLine("La marca que ha seleccionado no existe.");
            }

        }
        private static void ListarZapatillasPorGeneroPaginado(decimal? precioMinimo = null, decimal? precioMaximo = null)
        {
            MostrarColores();
            var servicioGeneror = servicioProvider?.GetService<IGenresService>();
            var servicioShoes = servicioProvider?.GetService<IShoesService>();
            var genreId = ConsoleExtensions.ReadInt("Ingrese el ID del Genero para ver los zapatos disponibles: ", 0, 9999);
            var pageSize = ConsoleExtensions.ReadInt("Ingrese la cantidad por página:", 1, 10);


            Genre? genre = servicioGeneror?.GetGenrePorId(genreId);

            var CantidadRegistros = servicioShoes?.GetCantidadFiltrada(null, null, genre, null, precioMaximo, precioMinimo) ?? 0;
            var CantidadDePaginas = CalcularCantidadPaginas(CantidadRegistros, pageSize);

            if (genre != null)
            {
                List<Shoe>? shoes = null;

                if (precioMinimo != null && precioMaximo != null)
                {
                    for (int page = 0; page < CantidadDePaginas; page++)
                    {
                        Console.Clear();
                        shoes = servicioShoes?.GetListaPaginadaOrdenadaFiltrada(true, page, pageSize, null, null, null, genre, null, precioMaximo, precioMinimo);
                        if (shoes != null && shoes.Count() != 0)
                        {
                            Console.WriteLine("Listado de Zapatillas");
                            Console.WriteLine($"Página: {page + 1}");
                            TablaDeZapatillas(shoes);
                            Console.WriteLine($"Cantidad: {CantidadRegistros}");
                            ConsoleExtensions.Enter();

                        }
                        else
                        {
                            Console.WriteLine($"No existen zapatos de la marca {genre.GenreName} con precio entre ${precioMinimo} y ${precioMaximo}");
                        }
                    }
                }
                else
                {
                    for (int page = 0; page < CantidadDePaginas; page++)
                    {
                        Console.Clear();
                        shoes = servicioShoes?.GetListaPaginadaOrdenadaFiltrada(true, page, pageSize, null, null, null, genre, null, null, null);
                        if (shoes != null && shoes.Count() != 0)
                        {
                            Console.WriteLine("Listado de Zapatillas");
                            Console.WriteLine($"Página: {page + 1}");
                            TablaDeZapatillas(shoes);
                            Console.WriteLine($"Cantidad: {CantidadRegistros}");
                            ConsoleExtensions.Enter();

                        }
                        else
                        {
                            Console.WriteLine($"No existen zapatos de la marca {genre.GenreName}");
                        }
                    }

                    //shoes = servicioColor?.GetShoes(colour);
                    //TablaDeZapatos(shoes);
                    //Console.WriteLine($"Cantidad: {servicioShoes?.GetCantidad()}");
                    //Console.WriteLine($"ERRORRRRRRR");


                }

            }
            else
            {
                Console.WriteLine("La marca que ha seleccionado no existe.");
            }
        }
        private static void TablaDeZapatillas(List<Shoe>? shoes)
        {
            var tabla = new ConsoleTable("ID", "MARCA", "DEPORTE", "GENERO", "COLOR", "MODELO", "DESCRIPCION", "PRECIO");

            foreach (var s in shoes)
            {
                tabla.AddRow(s.ShoeId,
                    s.Brand.BrandName,
                    s.Sport.SportName,
                    s.Genre.GenreName,
                    s.Colour.ColourName,
                    s.Model, s.Description,
                    s.Price);
            }
            tabla.Options.EnableCount = false;
            tabla.Write();
        }
        //---------------------------------------------------------------------------------------------


    }
}

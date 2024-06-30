using ConsoleTables;
using Microsoft.Extensions.DependencyInjection;
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
                //Console.Clear();
                MenuPrincipal();
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


                }
            }
        }

        static void LimpiarConsola()
        {
            Console.Clear();
            // Escribir líneas en blanco para limpiar la consola
            int lines = Console.WindowHeight;
            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine(new string(' ', Console.WindowWidth));
            }
            // Mover el cursor a la posición superior izquierda
            Console.SetCursorPosition(0, 0);
        }

        //static void LimpiarConsola()
        //{
        //    Console.Clear();
        //    // Escribir líneas en blanco para limpiar la consola
        //    Console.WriteLine(new string('\n', Console.WindowHeight));
        //    // Mover el cursor a la posición superior izquierda
        //    Console.SetCursorPosition(0, 0);
        //}

        //Menu Principal
        private static void MenuPrincipal()
        {
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
            Console.WriteLine("21. Ver Talles");
            Console.WriteLine("22. Agregar Talle");
            Console.WriteLine("23. Editar Talle");
            Console.WriteLine("24. Eliminar Talle");
            Console.WriteLine("----------");
            Console.WriteLine("25. Paginado Generos");
            Console.WriteLine("26. Paginado Deportes");
            Console.WriteLine("27. Paginado Marcas");
            Console.WriteLine("28. ");
            Console.WriteLine("----------");
            Console.WriteLine("PRESIONE X PARA SALIR");
            Console.Write("Por favor, seleccione una opción: ");

        }
        //Talles
        private static void EliminarTalle()
        {
            Console.WriteLine("ELIMINAR UN TALLE...");
            MostrarTalles();
            var id = ConsoleExtensions.ReadInt("Ingrese el ID del talle que desea eliminar: ",0, 9999);
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

            var id = ConsoleExtensions.ReadInt("Ingrese el ID del talle que desea editar: ",0,9999);
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
        //Zapatillas
        private static void EliminarZapatillas()
        {
            Console.WriteLine("Eliminar Una zapatilla");
            MostrarZapatillas();
            var id = ConsoleExtensions.ReadInt("Ingrese el ID de la Zapatilla que desea eliminar: ",0,9999);
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
            var id = ConsoleExtensions.ReadInt("ID del zapatilla a editar: ",0, 9999);
            var shoe = servicio?.GetShoePorId(id);

            if (shoe != null)
            {
                Console.WriteLine($"Zapatilla a editar: ID: {shoe.ShoeId}, Marca: {shoe.Brand.BrandName}," +
                    $"Modelo:{shoe.Model}, Descripcion: {shoe.Description} ");
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
            MostrarMarcas();
            var marca = ConsoleExtensions.ReadInt("Ingrese el ID de la marca de la zapatilla: ", 0, 9999);
            MostrarDeportes();
            var deporte = ConsoleExtensions.ReadInt("Ingrese el ID del deporte de la zapatilla: ", 0, 9999);
            MostrarGeneros();
            var genero = ConsoleExtensions.ReadInt("Ingrese el ID del genero de la zapatilla: ", 0, 9999);

            var shoe = new Shoe
            {
                BrandId = marca,
                SportId = deporte,
                GenreId = genero,
                Model = model,
                Description = description,
                Price = precio
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

    }
}

using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


public class Ejemplos
{

    public static void EjemploList()
    {
        Console.WriteLine("===== EJEMPLO LIST =====\n");

        CasoList lista = new CasoList();

        Collections.Alumno a1 = new Collections.Alumno(1, "Lucas", 8.7);
        Collections.Alumno a2 = new Collections.Alumno(2, "lujan", 9.5);
        Collections.Alumno a3 = new Collections.Alumno(3, "jorge", 7.9);


        lista.AgregarAlumno(a1);
        lista.AgregarAlumno(a2);
        lista.AgregarAlumno(a3);

        Console.WriteLine("Alumnos cargados:");
        MostrarLista(lista);


        Console.WriteLine("\nBuscando alumno 'Lucas':");

        Collections.Alumno encontrado = lista.BuscarAlumnoPorNombre("Lucas");

        if (encontrado != null)
        {
            Console.WriteLine(encontrado);
        }
        else
        {
            Console.WriteLine("No existe");
        }


        Console.WriteLine("\nBuscando alumno 'lujan':");

        Collections.Alumno inexistente = lista.BuscarAlumnoPorNombre("lujan");

        if (inexistente != null)
        {
            Console.WriteLine(inexistente);
        }
        else
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\nEliminando a jorge...");
        lista.EliminarAlumno(a3);

        MostrarLista(lista);

        Console.WriteLine("\nEliminando primer elemento...");
        lista.EliminarAlumnoPorPosicion(0);

        MostrarLista(lista);

        Console.WriteLine("========================\n");
    }


    public static void EjemploDictionary()
    {
        Console.WriteLine("===== EJEMPLO DICTIONARY =====\n");

        CasoDictionary diccionario = new CasoDictionary();

        Collections.Alumno a1 = new Collections.Alumno(10, "Valentina", 9.8);
        Collections.Alumno a2 = new Collections.Alumno(11, "lucio", 6.9);
        Collections.Alumno a3 = new Collections.Alumno(12, "nacho", 8.1);


        diccionario.AgregarAlumno(1001, a1);
        diccionario.AgregarAlumno(1002, a2);
        diccionario.AgregarAlumno(1003, a3);

        Console.WriteLine("Alumnos en el diccionario:");

        foreach (var item in diccionario.ObtenerAlumnos())
        {
            Console.WriteLine($"Legajo: {item.Key} -> {item.Value}");
        }


        Console.WriteLine("\nBuscando legajo 1002:");

        Collections.Alumno encontrado = diccionario.BuscarAlumno(1002);

        if (encontrado != null)
        {
            Console.WriteLine(encontrado);
        }
        else
        {
            Console.WriteLine("No existe");
        }


        Console.WriteLine("\nBuscando legajo 9999:");

        Collections.Alumno inexistente = diccionario.BuscarAlumno(9999);

        if (inexistente != null)
        {
            Console.WriteLine(inexistente);
        }
        else
        {
            Console.WriteLine("No existe");
        }


        Console.WriteLine("\nEliminando legajo 1001...");
        diccionario.EliminarAlumno(1001);

        Console.WriteLine("\nDiccionario actualizado:");

        foreach (var item in diccionario.ObtenerAlumnos())
        {
            Console.WriteLine($"Legajo: {item.Key} -> {item.Value}");
        }

        Console.WriteLine("==============================\n");
    }


    public static void EjemploLinq()
    {
        Console.WriteLine("===== EJEMPLO LINQ =====\n");

        CasoLinq caso = new CasoLinq();

        Console.WriteLine("Primer libro:");
        Console.WriteLine(caso.GetPrimero());

        Console.WriteLine("\nÚltimo libro:");
        Console.WriteLine(caso.GetUltimo());

        Console.WriteLine("\nSuma total de precios:");
        Console.WriteLine(caso.GetTotalPrecios().ToString("C"));

        Console.WriteLine("\nPromedio de precios:");
        Console.WriteLine(caso.GetPromedioPrecios().ToString("C"));

        Console.WriteLine("\nLibros con Id mayor a 15:");

        foreach (Libro libro in caso.GetListById())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\nLista de libros formateados:");

        foreach (string libro in caso.GetLibros())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\nLibro con mayor precio:");
        Console.WriteLine(caso.GetMayorPrecio());

        Console.WriteLine("\nLibro con menor precio:");
        Console.WriteLine(caso.GetMenorPrecio());

        Console.WriteLine("\nLibros con precio mayor al promedio:");

        foreach (Libro libro in caso.GetMayorPromedio())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\nLibros ordenados por título descendente:");

        foreach (Libro libro in caso.GetOrdenadosDesc())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("========================");
    }


    private static void MostrarLista(CasoList lista)
    {
        foreach (Collections.Alumno alumno in lista.ObtenerAlumnos())
        {
            Console.WriteLine(alumno);
        }
    }
}
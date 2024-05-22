using System;

// Definición de la interfaz IPais
interface IPais
{
    string ColorBandera();
    string Tamaño();
    string Idioma();
}

// Clase Ecuador que implementa la interfaz IPais
class Ecuador : IPais
{
    public string ColorBandera()
    {
        return "Amarillo, azul y rojo";
    }

    public string Tamaño()
    {
        return "283,561 km²";
    }

    public string Idioma()
    {
        return "Español";
    }
}

// Clase Brasil que implementa la interfaz IPais
class Brasil : IPais
{
    public string ColorBandera()
    {
        return "Verde y amarillo";
    }

    public string Tamaño()
    {
        return "8.511.965km²";
    }

    public string Idioma()
    {
        return "Portugués";
    }
}

// Clase Andorra que implementa la interfaz IPais
class Andorra : IPais
{
    public string ColorBandera()
    {
        return "Azul, amarillo y rojo";
    }

    public string Tamaño()
    {
        return "468 km²";
    }

    public string Idioma()
    {
        return "Catalán";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creación de instancias de cada país
        IPais ecuador = new Ecuador();
        IPais brasil = new Brasil();
        IPais andorra = new Andorra();

        // Mostrar información de cada país
        Console.WriteLine("Color de la bandera de Ecuador: " + ecuador.ColorBandera());
        Console.WriteLine("Tamaño de Andorra: " + andorra.Tamaño());
        Console.WriteLine("Idioma oficial de Brasil: " + brasil.Idioma());
    }
}

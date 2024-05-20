using System;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography;
using Microsoft.VisualBasic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;


public class Persona
{
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public string? Correo { get; set; }
    public int Edad { get; set; }

}

class Program
{
    static void Main(string[] args)
    {
        // listPersonas de ejemplos
        // List<Persona> listPersonas = new()
        // {
        //     new Persona { Nombre = "Manuel", Apellido = "Mendez", Correo = "mendezmm@gmail.com", Edad = 33 },
        //     new Persona { Nombre = "Manuel", Apellido = "Mendez", Correo = "mendezmm@gmail.com", Edad = 33 },
        //     new Persona { Nombre = "Manuel", Apellido = "Mendez", Correo = "mendezmm@gmail.com", Edad = 33 },
        //     new Persona { Nombre = "Mayrobys", Apellido = "Mendez", Correo = "mmendezmymm@gmail.com", Edad = 37 },
        //     new Persona { Nombre = "Yasmin", Apellido = "Bolivar", Correo = "bolivaym@gmail.com", Edad = 65 },
        //     new Persona { Nombre = "Moises", Apellido = "Mendez", Correo = "mendezmm@hotmail.com.com", Edad = 65 },
        //     new Persona { Nombre = "Luis", Apellido = "Mendez", Correo = "mendezlm@gmail.com", Edad = 30 },
        //     new Persona { Nombre = "Pedro", Apellido = "Perez", Correo = "perezpm@gmail.com", Edad = 25 },
        //     new Persona { Nombre = "Gustavo", Apellido = "Gonzalez", Correo = "gonzalezgm@gmail.com", Edad = 15 },
        //     new Persona { Nombre = "Alejandro", Apellido = "Gonzalez", Correo = "gonzalezap@gmail.com", Edad = 18 }
        // };

        // // Buscar los valores que se repiten
        // var apellidoGroup = listPersonas.GroupBy(x=> x.Apellido)
        //                                         .Where(g=> g.Count() > 5)
        //                                         .Select(y => new {Elemento = y.Key, counte = y.Count()})
        //                                         .ToList();

        // foreach (var persona in apellidoGroup){
        //     Console.WriteLine($"Nombre = {persona.Elemento} cantidad = {persona.counte}");
        // }

        // 10 Numeros aleatorios del 1-100
        Random random = new Random();

        List<int> numRandoms = new List<int>();
            
            for (int i = 0; i < 100; i++)
            {
                int numRandom = random.Next(1, 101);
                numRandoms.Add(numRandom);

            }
        
            Console.WriteLine("Los numero aleatorios son:");
            
            foreach (var num in numRandoms)
            {
                Console.WriteLine(num);
            }

            // CallConvMemberFunction numeros primos
        static bool numPrimo(int n){

            if (n <= 1)
            return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        List<int> numPrimos = numRandoms.Where((numPrimo)).ToList();

        Console.WriteLine("Estos son los numeros Primos de los numero aleatorios");

        foreach (var nPrimo in numPrimos)
        {
            Console.WriteLine(nPrimo);
        }

    }


    
}


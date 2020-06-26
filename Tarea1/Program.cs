using System;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] argumentos)
            
        {
            int[] precios = new int[4];
            precios[0] = 1;
            precios[1] = 4;
            precios[2] = 2;
            precios[3] = 3;

            if (argumentos.Length > 0)
            {
                if (argumentos[0] == "Chocolate") {
                    Console.WriteLine("Usted a escogido el Pan de :" + argumentos[0] +
                        "su precio es :" + precios[1]);
                }
                if (argumentos[0] == "Queso")
                {
                    Console.WriteLine("Usted a escogido el Pan de  :" + argumentos[0] +
                        "su precio es :" + precios[0]);
                }
                if (argumentos[0] == "Mortadela")
                {
                    Console.WriteLine("Usted a escogido el Pan de :" + argumentos[0] +
                        "su precio es :" + precios[2]);
                }
                if (argumentos[0] == "Injerto")
                {
                    Console.WriteLine("Usted a escogido el Pan de :" + argumentos[0] +
                        "su precio es :" + precios[3]);
                }
            }
            Console.WriteLine("Bienvenido a la Panaderia 'ALIS'");//Esto imprime un mensaje en la consola
            Console.WriteLine("\nIngrese su nombre: \n");
            var nombre = Console.ReadLine();
            Console.WriteLine("\nIngrese su direccion: \n");
            var direccion = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"\nHola,{nombre}, con la direccion {direccion}");
            Console.WriteLine("\nProdutos que Ofrecemos:\n\n Pan de Chocolate \n Pan de Queso \n Pan con Mortadela \n Pan Injerto");
            Console.WriteLine("Gracias Por Preferirnos");
            Console.ReadKey();
        }
    }
}

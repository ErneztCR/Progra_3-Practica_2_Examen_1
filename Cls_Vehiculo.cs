using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Practica2Examen1
{
    internal class Cls_Vehiculo
    {
        // atributos
        static int cant = 10;
        static byte indice = 0;
        static int pos = 1;
        private static string[] placa = new string[cant];
        private static float[] costo = new float[cant];

        // metodos
        public static void Inicializar()
        {
            placa = Enumerable.Repeat(" ", cant).ToArray();
            costo = Enumerable.Repeat(0f, cant).ToArray();
            Console.Clear();
            Console.WriteLine("Se inicializo el arreglo");
            Console.ReadKey();
        }

        public static void Ingresar()
        {
            char respuesta;

            do 
            {
                Console.Clear();
                Console.Write($"Ingrese la placa del vehiculo ({pos}): ");
                placa[indice] = Console.ReadLine();
                Console.Write($"Ingrese el costo del vehiculo ({pos}): ");
                costo[indice] = float.Parse(Console.ReadLine());

                Console.WriteLine("Desea ingresar otro vehiculo? (s/n)");
                respuesta = Convert.ToChar(Console.ReadLine().ToLower());

                indice++;
                pos++;
            } while (respuesta == 's');
        }

        public static void reporteGeneral()
        {
            Console.Clear();
            Console.WriteLine("***REPORTE GENERAL***");
            Console.WriteLine(" ");
            Console.WriteLine("Placa\t\tCosto");
            Console.WriteLine(" ");
            for (int i = 0; i < indice; i++)
            {
                Console.WriteLine($"{placa[i]}\t\t{costo[i]}");
            }
            Console.WriteLine($"*********FIN REPORTE*********");
            Console.ReadKey();
        }

        public static void reporteFiltro()
        {
            bool encontrado = false;

            Console.Clear();
            Console.WriteLine("***REPORTE CON FILTRO***");
            Console.WriteLine(" ");
            Console.Write("Digite la placa del vehiculo: ");
            string id = Console.ReadLine();

            for (int i = 0; i < cant; i++)
            {
                if (id.Equals(placa[i]))
                {
                    Console.Clear();
                    Console.WriteLine("***REPORTE CON FILTRO***");
                    Console.WriteLine(" ");
                    Console.WriteLine("Placa\t\tCosto");
                    Console.WriteLine(" ");
                    Console.WriteLine($"{placa[i]}\t\t{costo[i]}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.Clear();
                Console.WriteLine("***REPORTE CON FILTRO***");
                Console.WriteLine(" ");
                Console.WriteLine("No se encontro el vehiculo");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2Examen1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cls_Menu menu = new Cls_Menu(); // instanciar la clase menu porque es una clase no estatica
            menu.desplegar();

            /*
             ***COMO SABER CUAL ES EL NUMERO MAYOR DE UN ARREGLO***
             *int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
             *Console.WriteLine(numeros.Max());
             */

            /*
            ***COMO MOSTRAR LA FECHA Y HORA ACTUAL EN C#***
            DateTime fecha = new DateTime.now;
            Console.WriteLine(fecha.Year);
            Console.WriteLine(fecha.Month);
            Console.WriteLine(fecha.Day);
            Console.WriteLine(fecha.Hour);
            Console.WriteLine(fecha.Minute);
            Console.WriteLine(fecha.Second);

            Console.WriteLine($"Hoy es: {fecha.Day}/{fecha.Month}/{fecha.Year} y son las: {fecha.Hour}:{fecha.Minute}:{fecha.Second}");
            Console.readline();  
             */
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2Examen1
{
    internal class Cls_subMenu
    {
        
        
        static public void reporte()
        {
            Cls_Menu menu = new Cls_Menu(); // instanciar la clase menu porque es una clase no estatica
            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("***MENU DE REPORTES***");
                Console.WriteLine(" ");
                Console.WriteLine("1. Todos los autos");
                Console.WriteLine("2. Reporte con filtro");
                Console.WriteLine("3. Salir");
                Console.WriteLine(" ");
                Console.Write("Ingrese una opcion: ");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:// Todos los autos
                        Cls_Vehiculo.reporteGeneral();
                        break;
                    case 2:// Reporte con filtro
                        Cls_Vehiculo.reporteFiltro();
                        break;
                    case 3:// Salir
                        menu.desplegar();
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }

            } while (opcion != 3);
        }
    }
}

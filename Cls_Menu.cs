using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2Examen1
{
    internal class Cls_Menu
    {
        // atributos
        int opcion = 0;

        public void desplegar()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("***MENU PRINCIPAL***");
                Console.WriteLine(" ");
                Console.WriteLine("1. inicializar");
                Console.WriteLine("2. incluir vehiculo");
                Console.WriteLine("3. ingresar");
                Console.WriteLine("4. ");
                Console.WriteLine("5. ");
                Console.WriteLine("6. Reportes");
                Console.WriteLine("7. ");
                Console.WriteLine(" ");
                Console.Write("Ingrese una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:// Inicializar
                        Cls_Vehiculo.Inicializar();
                        break;
                    case 2:// Incluir vehiculo
                        Cls_Vehiculo.Ingresar();
                        break;
                    case 3:
                        Console.WriteLine("Ingresar");
                        break;
                    case 4:
                        Console.WriteLine(" ");
                        break;
                    case 5:
                        Console.WriteLine(" ");
                        break;
                    case 6:// Reportes
                        Cls_subMenu.reporte();
                        break;
                    case 7:
                        Console.WriteLine(" ");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }

            } while (opcion != 7);
        }
    }
}

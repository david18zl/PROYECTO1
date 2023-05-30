using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                //Menu de opciones 
                Console.Clear();
                Console.WriteLine("----MENU de tienda de playeras ----");
                Console.WriteLine("1-) OPCION de playeras de compresion 1");
                Console.WriteLine("2-) OPCION de playeras tipo overside 2");
                Console.WriteLine("3-) OPCION de playeras a la medida 3");
                Console.WriteLine("4-) OPCION de salir 4");
                Console.WriteLine("INGRESA UNA OPCION PARA CONTINUAR");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Has entrado a la opcion playeras de compresion 1");
                        Console.WriteLine("presiona cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Has entrado a la opcion playeras tipo overside 2");
                        Console.WriteLine("presiona cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Has entrado a la opcion playeras a la medida 3");
                        Console.WriteLine("presiona cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Esta seguro que desae salir?");
                        Console.WriteLine("si/no");
                        string deside = Console.ReadLine();
                        if (deside == "si")
                        {
                            continuar = false;
                        }
                        break;
                    default:
                        Console.WriteLine(" initente de nuevo . :");
                        break;

                }

            }

        }
    }


}

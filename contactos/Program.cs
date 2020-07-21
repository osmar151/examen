using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contactos
{
    class Program
    {

        static string[,] agenda = new string[4, 3];


        static void Main(string[] args)
        {
            char menu = 'n';
            string usuario = "contacto no encotrado";
            string buscar = "";
            string buscar2 = "";

            int op = 0;

            while (menu != 's')
            {

                Console.WriteLine(" \n ---------------------------------- \n ");
                Console.WriteLine(" 1.-crear contacto ");
                Console.WriteLine(" 2.-ver contactos ");
                Console.WriteLine(" 3.-buscar contactos ");
                Console.WriteLine(" 4.-salir ");

                try
                {

                    Console.WriteLine(" \n ---------------------------------- \n ");
                    Console.Write("ingrese el numero de opcion que desea ejecutar : ");
                    op = int.Parse(Console.ReadLine());
                }


                catch
                {
                    Console.WriteLine(" \n ---------------------------------- \n ");
                    Console.WriteLine("Solo datos numericos ");
                    Console.Write("ingrese el numero de opcion que desea ejecutar :");
                    op = int.Parse(Console.ReadLine());
                }


                if (op == 1)
                {
                    for (int f = 0; f < 3; f++)
                    {
                        Console.Write("ingrese nombre: ");
                        agenda[0, f] = Console.ReadLine();

                        Console.Write("ingrese apellido: ");
                        agenda[1, f] = Console.ReadLine();

                        Console.Write("ingrese direccion: ");
                        agenda[2, f] = Console.ReadLine();

                        Console.Write("ingrese telefono: ");
                        agenda[3, f] = Console.ReadLine();
                    }


                }

                else if (op == 2)
                {
                    for (int f = 0; f < 3; f++)
                    {
                        Console.WriteLine(agenda[0, f] + "--" + agenda[1, f] + "--" + agenda[2, f] + "--" + agenda[3, f]);
                    }

                }

                else if (op == 3)
                {
                    Console.Write("ingrese el nombre del contacto a buscar: ");
                    buscar = Console.ReadLine();

                    Console.Write("ingrese el apellido del contacto a buscar: ");
                    buscar2 = Console.ReadLine();

                    for (int f = 0; f < 3; f++)
                    {
                        if (buscar == agenda[0, f] && buscar2 == agenda[1, f])
                        {
                            Console.WriteLine(agenda[0, f] + "--" + agenda[1, f] + "--" + agenda[2, f] + "--" + agenda[3, f]);
                        }



                    }
                }

                else if (op == 4)
                {
                    Console.WriteLine(" desea salir [s / n] ");
                    menu = char.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine(usuario);
            Console.ReadKey();

        }
    }
}
   
        
    



    


    


  





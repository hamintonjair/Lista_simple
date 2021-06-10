using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_simple
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int opc;
            Lista l = new Lista();
            do
            {
                Console.Clear();
                Console.WriteLine("\n\tFecha " + DateTime.Now);
                Console.WriteLine("   |-----------------------------|");
                Console.WriteLine("   |     * REGISTRO DE NODO *    |");
                Console.WriteLine("   | 1.  Agregar nodo            |");
                Console.WriteLine("   | 2.  Buscar                  |");
                Console.WriteLine("   | 3.  Modificar               |");
                Console.WriteLine("   | 4.  Eliminar                |");
                Console.WriteLine("   | 5.  Listar                  |");
                Console.WriteLine("   | 6.  Salir                   |");
                Console.WriteLine("   |-----------------------------|");
                Console.Write("\nOpcion: ");
                opc = int.Parse(Console.ReadLine());

                if (opc == 1)
                {
                    Console.WriteLine("\n\tAGREGAR NODO A LA LISTA");
                    l.insertarNodo();
                    Console.WriteLine("\nPresiona una tecla para continuar");
                    Console.ReadKey();
                }
                if ( opc == 2)
                {
                    Console.WriteLine("\n\tBUSCAR NODO");
                    l.Buscar();
                    Console.WriteLine("\nPresiona una tecla para continuar");
                    Console.ReadKey();
                }
                if (opc == 3)
                {
                    Console.WriteLine("\n\tMODIFICAR NODO");
                    l.modificar();
                    Console.WriteLine("\nPresiona una tecla para continuar");
                    Console.ReadKey();
                }
                if (opc == 4)
                {
                    Console.WriteLine("\n\tELIMINAR NODO");
                    l.Eliminar();
                    Console.WriteLine("\nPresiona una tecla para continuar");
                    Console.ReadKey();
                }
                if (opc == 5)
                {
                    Console.WriteLine("\n\tLISTADO DE NODO");
                    l.Listar();
                    Console.WriteLine("\nPresiona una tecla para continuar");
                    Console.ReadKey();
                }
            } while (opc != 6);                     
        }
    }
}

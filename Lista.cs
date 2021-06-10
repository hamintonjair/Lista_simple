using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_simple  
{
    class Lista
    {
        private Nodo primero = new Nodo();
        private Nodo ultimo = new Nodo();

        public Lista()
        {
            primero = null;
            ultimo = null;
        }

        public void insertarNodo()  // lista 6 9 2     
        {
            Nodo nuevo = new Nodo();
            Console.Clear();
            Console.WriteLine("************************************");          
                    
                Console.Write("\nIgresa el nodo a la lista: ");
                nuevo.Dato = int.Parse(Console.ReadLine());               

                if (primero == null)
                {
                    primero = nuevo;
                    primero.Siguiente = null;
                    primero.Atras = null;
                    ultimo = primero;
                }
                else
                {
                    ultimo.Siguiente = nuevo;
                    nuevo.Siguiente = null;
                    nuevo.Atras = ultimo;
                    ultimo = nuevo;
                }
                Console.WriteLine("\nEl nuevo nodo fue agregado a la lista");          
            
        }        
        public void Buscar()
        {
            Nodo actual = new Nodo();

            actual = primero;
            bool Encontrado = false;
            Console.Clear();
            Console.WriteLine("***************************************");
            //para identificar el nodo que se esta buscando
            Console.Write("=>Ingrese al dato a buscar: ");
            int buscarNodo = int.Parse(Console.ReadLine());
                //si actual es diferente de nul entra a la condicion
                if (actual != null)
                {
                    //recorrer la lista y buscar el nodo que 
                    while (actual != null && Encontrado != true)
                    {
                        if (actual.Dato == buscarNodo)
                        {
                        Console.WriteLine("*****************************************");
                            Console.WriteLine("\nEl nodo " + buscarNodo + " fue encontrado ");
                            Encontrado = true;
                        }
                         actual = actual.Siguiente;
                    }
                    if (!Encontrado)
                    {
                    Console.WriteLine("\nEl nodo no fue encontrado");

                    }
                    Console.WriteLine("***************************************");
            }
                else
                {
                    Console.WriteLine("\nNo hay nodo en la lista.....");
                }
                Console.WriteLine("***************************************");
        }
        public void modificar()
        {
            Nodo Actual = new Nodo();
            Actual = primero;
            bool Encontrado = false;

            Console.Clear();
            Console.WriteLine("***************************************");
            Console.Write("=>ingresa el dato del nodo a buscar: ");

            int nodoBuscado = int.Parse(Console.ReadLine());
            if (primero != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.Dato == nodoBuscado)
                    {
                        Console.Write("=>nodo encontado " + nodoBuscado);

                        Console.Write("=>ingresa ul nuevo nodo: ");
                        Actual.Dato = int.Parse(Console.ReadLine());
                        Console.Write("=>nodo modificado");

                        Encontrado = true;
                    }
                    Actual = Actual.Siguiente;
                }
                if (!Encontrado)
                {
                    Console.WriteLine("=>Nodo no se encuentra");
                }
                Console.WriteLine("***********************************");
            }
            else
            {
                Console.WriteLine("\n=>la lista se encuentra vacia");
            }
            Console.WriteLine("***********************************");
        }
        public void Eliminar()
        {

        }
        public void Listar()
        {
            Console.Clear();
            Nodo actual = new Nodo();
            actual = primero;

            //si actual es diferente de nul entra a la condicion
            if (actual != null)
            {
                //recorrer la lista y la despliega
                Console.WriteLine("*****************************************");
                while (actual != null)
                {
                    Console.WriteLine("=>Nodo: " + actual.Dato);
                    actual = actual.Siguiente;
                    
                }
                Console.WriteLine("*****************************************");
            }
            else
            {
                Console.WriteLine("\n=>No hay nodo en la lista.....");
            }
            Console.WriteLine("***********************************");
        }
    }
}

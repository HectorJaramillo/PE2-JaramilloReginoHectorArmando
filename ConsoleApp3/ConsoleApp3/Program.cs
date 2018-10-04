using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{    
    public class Sucesion
    {
       protected int[] Arreglo;
       protected int Tamaño;
        protected int GuardadoMenor, GuardadoMayor;
       public Sucesion(int[] Arreglo,int Tamaño)       
       {
            this.Arreglo = Arreglo;
            this.Tamaño = Tamaño;        
       }
        public int EncontrarMenor(int Valor)
        {
            if (Valor == 0)
            {
                if (Arreglo[Valor + 1] > Arreglo[Valor])
                {
                    GuardadoMenor = Arreglo[Valor];
                }
                else
                {
                    GuardadoMenor = Arreglo[Valor + 1];
                }
                return (EncontrarMenor(Valor + 1));
            }
            else if (Valor ==Tamaño-1)
            {
                if (GuardadoMenor > Arreglo[Valor])
                    {
                        GuardadoMenor = Arreglo[Valor];                       
                    }
                
                Console.WriteLine("El numero menor en la sucesion es: {0}", GuardadoMenor);
                return 1;
            }
            else
            {
                if (GuardadoMenor > Arreglo[Valor + 1])
                {
                    GuardadoMenor = Arreglo[Valor + 1];
                }                
                return (EncontrarMenor(Valor + 1));
            }
        }
        public int EncontrarMayor(int Valor)
        {
            if (Valor == 0)
            {
                if (Arreglo[Valor + 1] < Arreglo[Valor])
                {
                    GuardadoMayor = Arreglo[Valor];
                }
                else
                {
                    GuardadoMayor = Arreglo[Valor + 1];
                }
                return (EncontrarMayor(Valor + 1));
            }
            else if (Valor >= Tamaño - 1)
            {
                if (Valor == 0)
                {
                    if (GuardadoMayor > Arreglo[Valor])
                    {
                        GuardadoMayor = Arreglo[Valor];
                    }
                }
                Console.WriteLine("El numero mayor en la sucesion es: {0}", GuardadoMayor);
                return 1;
            }
            else
            {
                if (GuardadoMayor < Arreglo[Valor + 1])
                {
                    GuardadoMayor = Arreglo[Valor + 1];
                }       
                return (EncontrarMayor(Valor + 1));
            }
        }
        public int SucesionReversa(int Contador)
        {                       
            if (Contador == 0)
            {
                Console.Write(Arreglo[Contador]+" ");
                return 1;
            }
            else
            {
                Console.Write(Arreglo[Contador]+" ");
                return SucesionReversa(Contador-1);
            }
        }
        public int SucesionNormal(int Contador)
        {
            if (Contador ==Tamaño-1)
            {
                Console.Write(Arreglo[Contador]+" ");
                return 1;
            }
            else
            {
                Console.Write(Arreglo[Contador]+" ");
                return SucesionNormal(Contador + 1);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Practica Unidad 2";
            int Tamaño;            
            Console.WriteLine("Ingrese la cantidad de numeros que tendra la sucesion");
            Tamaño = Convert.ToInt32(Console.ReadLine());
            int[] Arreglo = new int[Tamaño];
            int Tamaño2 = Tamaño - 1;
            for (int Indice = 0; Indice < Arreglo.Length; Indice++)
            {
                Console.WriteLine("Ingrese un numero ");
                Arreglo[Indice] = Convert.ToInt32(Console.ReadLine());
            }
            Sucesion Suceso = new Sucesion(Arreglo,Tamaño);
            Marca:
            Console.WriteLine("¿Que codigo desea consultar?" +
                "\n1.-Encontar el Menor \n2.-Encontrar el Mayor \n3.-Invertir Sucesion");
            int Desicion = Convert.ToInt32(Console.ReadLine());
            switch(Desicion)
            {
                case 1:
                    Console.Write("La Sucesion es: ");
                    Suceso.SucesionNormal(0);
                    Console.WriteLine();
                    Suceso.EncontrarMenor(0);
                    break;
                case 2:
                    Console.Write("La Sucesion es: ");
                    Suceso.SucesionNormal(0);
                    Console.WriteLine();
                    Suceso.EncontrarMayor(0);
                    break;
                case 3:
                    Console.Write("La Sucesion es: ");
                    Suceso.SucesionNormal(0);
                    Console.WriteLine();
                    Console.Write("Sucesion Invertida: ");
                    Suceso.SucesionReversa(Tamaño2);
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("¿Desea Consultar otro codigo? \n1.-Si \n2.-No");
            int Eleccion = Convert.ToInt32(Console.ReadLine());
            switch(Eleccion)
            {
                case 1:
                    Console.Clear();
                    goto Marca;
                case 2:
                    Console.WriteLine("Presione una tecla para salir...");
                    break;
            }
            Console.ReadKey(true);
        }
    }
}

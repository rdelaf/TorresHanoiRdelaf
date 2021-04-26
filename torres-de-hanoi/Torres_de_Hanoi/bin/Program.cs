using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
          Pila INI = new Pila();
          Pila AUX = new Pila();
          Pila FIN = new Pila();

          Console.WriteLine("¿Con cuantos discos deseas jugar?");
          int numeroDiscos = Convert.ToInt32(Console.ReadLine());

          for(int i = 0; i<numeroDiscos; i++)
          {
              Disco d = new Disco();
              d.Valor = i+1;
              INI.push(d);
              INI.Top = d.Valor;
          }

          Console.WriteLine("Inicio.");
          Hanoi hanoi = new Hanoi();
          hanoi.iterativo(numeroDiscos, INI, AUX, FIN);
          Console.WriteLine("Inicio Algoritmo.");
          hanoi.recursivo(numeroDiscos, INI, AUX, FIN);

          Console.WriteLine("Presione cualquier tecla para salir.");
          Console.ReadKey();
        }
    }
}

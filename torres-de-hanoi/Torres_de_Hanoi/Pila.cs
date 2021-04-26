using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }
        public int Top { get; set; }
        public List<Disco> Elementos { get; set; }

        public Pila()
        {
            Size = 0;
            Top = 0;
            Elementos = new List<Disco>();
        }

        //Añade un nuevo elemento a la pila
        public void push(Disco d)
        {
            Elementos.Add(d);
            Top = d.Valor;
            Size++;
        }

        //Devuelve el último elemento de la pila y lo elimmina
        public Disco pop()
        {
            if (Size > 0)
            {
                Disco discoRetirado = new Disco();
                discoRetirado.Valor = Elementos[Size - 1].Valor;
                Elementos.RemoveAt(Elementos.Count() - 1);
                Size--;
                if (Size > 0) Top = Elementos[Size - 1].Valor;
                else Top = 0;
                return discoRetirado;
            }
            return null;
        }                

        //Devuelve true si la pila está vacía y false si no
        public bool isEmpty()
        {
            if (Size <= 0) return true;
            else return false;
        }
    }
}

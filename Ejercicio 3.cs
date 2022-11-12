using System;
using System.Text;
namespace Ejercicio3
{class Ejercicio3
    { private int[,] mt2;
        public void Inicia()
        {mt2 = new int[3, 5];
         for (int f = 0; f < 3; f++)
        { for (int c = 0; c < 5; c++)
             {Console.Write("Ingrese posicion ["+(f+1)+","+(c+1)+"]: ");
             string linea;
            linea = Console.ReadLine();
            mt2[f, c] = int.Parse(linea); }
            }
        }

        public void sale()
        {for (int f = 0; f < 3; f++)
            {for (int c = 0; c < 5; c++)
         {  Console.Write(mt2[f, c] + " "); }
            Console.WriteLine();}
            Console.ReadKey();
        }

        static void Main(string[] args)
        {Matriz ma = new Matriz();
            ma.Inicia();
            ma.sale();}
    }
}
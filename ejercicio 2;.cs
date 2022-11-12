using System;
using System.Text;
namespace ejercicio2
{class ejercicio2
    {  private int[,] mt;
    public void inicio()
        {
            mt = new int[3, 4];
            for (int f = 0; f < 3; f++)
            {for (int c = 0; c < 4; c++)
                {Console.Write("Ingrese un número ["+(f+1)+","+(c+1)+"]: ");
                    string linea;
                    linea = Console.ReadLine();
                    mt[f, c] = int.Parse(linea); }
            }
        }
        public void nFila()
        {Console.WriteLine("\nPrimer fila:");
            for (int c = 0; c < 4; c++)
            { Console.Write(mt[0, c]+"  ");}
        }
        public void lfila()
        {Console.WriteLine("\nUltima fila:");
            for (int c = 0; c < 4; c++)
            { Console.Write(mt[2, c]+"  ");}
        }

        public void ucolumna()
        {
            Console.WriteLine("\nUltima columna:");
            for (int f = 0; f < 3; f++)
            {Console.Write(mt[f, 0]+"  "); }
        }

        static void Main(string[] args)
        {ejercicio2 ma = new ejercicio2();
            ma.inicio();
            ma.nFila();
            ma.lfila();
            ma.ucolumna();
            Console.ReadKey();
        }
    }
}
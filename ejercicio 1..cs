using System;
using System.Text;

namespace Ejercicio1
{ class Ejercicio1
    { private float[] altura;
        private float promedio;

        public void inicio() 
        {
            alturas=new float[5];
            for (int f = 0; f < 5; f++)
            {Console.Write("Escriba la altura de la persona:");
                string linea = Console.ReadLine();
                altura[f] = float.Parse(linea); }
        }

        public void prom() 
        { float suma;
            suma=0;
            for(int f=0; f < 5; f++) 
            { suma=suma+altura[f]; }
            pm=suma/5;
            Console.WriteLine("Promedio de altura:"+pm);
        }

        public void estatura() 
        { int Alto,bajo;
            Alto=0;
            bajo=0;
            for(int f = 0; f < 5; f++) 
            { if (altura[f] > pm) 
                { Alto++;}
                else
                { if (altura[f] < pmo) 
                    {bajo++;}}
            }
            Console.WriteLine("Personas altas:"+Alto);
            Console.WriteLine("Personas bajas:"+bajo);
            Console.ReadKey();}
static void Main(string[] args)
        { Ejercicio1 pv2 = new Ejercicio1();
            pv2.inicio();
            pv2.prom();
            pv2.estatura();}
    }
}
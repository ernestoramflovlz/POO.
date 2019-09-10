using System;
using System.Collections.Generic;


namespace Bici
{
    class BIci
    {

        private string marca;
        private int current_velocity;
        private int  velocities;
        private Persona dueño;
        
        public void print()
        {
            Console.WriteLine("Marca: (0) Color: (1)", marca, current_velocity);
        }
        public void init(string marca, int cv, int vs)
        {
            this.marca = marca;
            velocities = vs;
        }
     public void sube();
     

    }    

    class Persona
    {
        private string nombre;
        private string correos;
        
        private List<BIci> bicis;

        public void init (string n, string c)
        nombre = n;
        correos = c;
    
    }
    public void print()
    {
        console.WriteLine("(0) : (1)"), nombre, correos);
    }
    class Program
    {
        static void Main(string[] args)
        {
            BIci bici01 = new Bici();
            bici01.init ("Bike", 2 , 12);
           // bici01.sube();
            bici01.print();

           BIci bici02 = new Bici();
            bici01.init ("Pinestar", 0 , 15);
           // bici01.sube();
            bici01.print();

            BIci bici03 = new Bici();
            bici01.init ("Pach", 1 , 10);
           // bici01.sube();
            bici01.print();

            List<BIci> bicis = new List<BICI>();
            bicis.Add (bici01);
            bicis.Add (bici02);
            bicis.Add (bici03);
            

            foreach(BIci b int bicis){
                b.print();
            }

            Persona tom = new Persona();
            tom.init("Tom, tom@gmail.com");
            tom.Print();

          //Console.Writeline("Hello World");
        }
    }
}

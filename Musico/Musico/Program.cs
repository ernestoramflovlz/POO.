using System;
using System.Collections.Generic;

namespace Musico
{
    class Musico
       
    {

        protected string nombre;
        public Musico(string n)
        {
        nombre = n;

        }
        public string Saludo()
        {
        Console.WriteLine("Hola,soy {0}",nombre);
        }

        public virtual void Afina()
        {
            Console.WriteLine("{0},Afina su instrumento ",nombre);
        }

    }

    class Bajista : Musico
    {
       private string bajo;
       public Bajista(string no,string bajo):base(no)
       {
       this.bajo = bajo;
       } 

       public override void Afina()
       {
           Console.WriteLine("{0} esta afinando su bajo {1}",nombre,bajo);
       }
       
    }
    class Guitarrista : Musico;
    {
        private string guitarra;
        public Guitarrista(string no, string guitarro):base(no)
        {
            this.guitarra = guitarra;
        }
        public override void Toca()
       {
           Console.WriteLine("{0} esta tocando su guitarra {1}",nombre,guitarra);
       }
    }
    class Program
    { 

        static void Main()
        {
            Musico tom = new Musico("Tom");
            Bajista flea = new Bajista("Flea","Gibson");
            Console.WriteLine(tom.Saludo());
            Guitarrista ram = new Guitarrista("Ram");
            
            tom.Saludo();
            flea.Saludo();

            tom.Afina();
            flea.Afina();

            ram.Guitarra();
            ram.Toca();

          List<Musico> grupo = new List <Musico>();
          grupo.Add(tom);
          grupo.Add(flea);
          grupo.Add(ram);
          foreach(Musico m in grupo)
          {
              m.Saludo();
              m.Afina();
          }



        }
    }
    
}

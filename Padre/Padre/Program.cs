using System;
using System Collections.Generic;

namespace Padre
{
    class Componente
    {
        public string nombre;
        public Contenedor padre;

        public Componente(string nombre, Contenedor padre)
        {
            this.nombre = nombre;
            this.padre = padre;
        }
        public void Print(){
            Console.WriteLine($" Soy (nombre) y mi padre es(padre)");
        }
    }
    class Contenedor
    {
        public string nombre;
        public List<Componente> componentes = new List <Componente>();

        public Contenedor (string nombre)
        {
        Componentes.Add(new Componente("Primero"),this);
        Componentes.Add(new Componente("Segundo"),this);
        Componentes.Add(new Componente("Tercero"),this);
        }
        public void print(){
            foreach var in Componenetes{
                hijo.Print();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Contenedor Padre1 = new Contenedor("Contenedor 1");
            Contenedor Padre2 = new Contenedor("Contenedor 2");

            Padre1.Print();
            Console.WriteLine("-----------------");
            Padre2.Print();
        }
    }
}

using System;

namespace Herencia_Persona
{
   class Herencia_Persona
   {
   protected string nombre;
   public string Nombre {get {return nombre;}}
   public Herencia_Persona(string n) {nombre=n;}
   public void print(){Console.WriteLine("Mi nombre es:", nombre);}
   }
class Alumno: Herencia_Persona
{
protected string num_control;
public Alumno(string nombre, string num_control):base(nombre)
{
this.num_control = num_control;
}

}
    class Program
    {
        static void Main(string[] args)
        {
            Herencia_Persona tom = new Herencia_Persona("Tom");
            Herencia_Persona jim = new Herencia_Persona("Jim");
            tom.print();
            jim.print();
            Alumno ram = new Alumno("ram","18210476");
            ram.print();
        }
    }
}

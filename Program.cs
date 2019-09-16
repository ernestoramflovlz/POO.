using System;
System.Collections.Generic 

namespace ListaPelicula
{
    class pelicula 
    {
      private string titulo;
      private int16 año;
      private string pais;
      private string director;

      public pelicula (string titulo) {this.titulo=ti;}
      public void SetTitulo(string t){titulo = t;}
      public string GetTitulo(){return titulo;}

      public pelicula (int16 año) {this.año=an;}
      public void SetAño(string a){año = a;}
      public string GetAño(){return año;}

      public pelicula (string pais) {this.pais=pa;}
      public void SetTitulo(string p){titulo = p;}
      public string GetTitulo(){return pais;}

      public pelicula (string director) {this.director=di;}
      public void SetTitulo(string d){titulo = d;}
      public string GetTitulo(){return director;}
      public void imprime()

    {
        Console.WriteLine("Informacion de la pelicula es: {0}", titulo, año, pais, director);
    }
     public pelicula(){titulo = "n/a",año = "n/a", pais = "n/a",director = "n/a";}
    }
    class Program
    {

        static void Main()
        {
            List<Persona> personas = new List<Persona>();

             persona.Add(new Persona ("pam"));
             persona.Add(new Persona ("tom"));
             persona.Add(new Persona ("jim"));

             persona.ForEach(print);

             persona.ForEach(delegate(string persona)
             {
                 console.WriteLine(persona);
             });
              private static void Print(string p)
             {
                Console.WriteLine(p);
             }
       
        }
    }
}

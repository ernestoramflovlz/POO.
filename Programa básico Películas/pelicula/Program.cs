using System;

namespace Pelicula
{
    class Movie 
    {
      private string titulo;
      private int16 año;
      private string pais;
      private string director;

      public Movie (string titulo) {this.titulo=ti;}
      public void SetTitulo(string t){titulo = t;}
      public string GetTitulo(){return titulo;}

      public Movie (int16 año) {this.año=an;}
      public void SetAño(string a){año = a;}
      public string GetAño(){return año;}

      public Movie (string pais) {this.pais=pa;}
      public void SetPais(string p){titulo = p;}
      public string GetPais(){return pais;}

      public Movie (string director) {this.director=di;}
      public void SetDirector(string d){director = d;}
      public string GetDirector(){return director;}
      public void imprime()

    {
        Console.WriteLine("Informacion de la pelicula es: {0}", titulo, año, pais, director);
    }
     public Movie(){titulo = "n/a",año = "n/a", pais = "n/a",director = "n/a";}
    }
    class Program
    {
        static void Main()
        {
            
           Pelicula p1 = new Pelicula();
           p1.SetTitulo("Titanic");
           p1.SetAño(1997); 
           p1.SetDirector("James Cameron");
           p1.SetPais("EUA");
           Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño(), p1.GetPais(), p1.GetDirector());
           p1.imprime();

           Pelicula p2 = new Pelicula();
           p2.SetTitulo("Avatar");
           p2.SetAño(2009); 
           p2.SetDirector("James Cameron");
           p2.SetPais("EUA");
           Console.WriteLine("{0}({1})", p2.GetTitulo(), p2.GetAño, p2.GetPais(), p2.GetDirector());
           p2.imprime();
        }
    }
}


using System;

namespace Pelicula
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
            
           Pelicula p1 = new Pelicula();
           p1.SetTitulo("Titanic");
           p1.SetAño(1997); 
           Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());
           p1.imprime();

           Pelicula p2 = new Pelicula();
           p2.SetTitulo("Avatar");
           p2.SetAño(2009); 
           Console.WriteLine("{0}({1})", p2.GetTitulo(), p2.GetAño());
           p2.imprime();
        }
    }
}

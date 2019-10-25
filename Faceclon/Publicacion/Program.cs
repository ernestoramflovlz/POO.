using System;
using System.Collections.Generic;

namespace Publicacion
{
    abstract class Publicación
    {
        protected string nombre, correo;
       
        protected string fecha_uso;

        public Publicación(string nom, string co, string fecha)
        {
            this.nombre = nom;
            this.correo = co;
            this.fecha_uso = fecha;
            
            
        }
        abstract public void observa();
        public void printinformacion()
        {
          Console.WriteLine(nombre, correo);
        }
    }

     class Estado : Publicación
    {
      public Estado(string nom, string co, string fecha):base(nom,co,fecha)
      {

      }
       public override void observa()
      {
       Console.WriteLine("Ver el estado de perfil del usuario {0}",nombre, correo);
      }

    }
    class Foto : Publicación
    {
     public Foto(string nom, string co, string fecha):base(nom,co,fecha)
     {

     }
     public override void observa()
     {
         Console.WriteLine("Ver foto de perfil {0}",nombre,fecha_uso);
     }
    }
    class Link : Publicación
    {
     public Link(string nom, string co, string fecha):base(nom,co,fecha)
     {

     }
     public override void observa()
     {
         Console.WriteLine("Ver el link de perfil {0}",correo);
     }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Publicación> publicaciones = new List<Publicación>();
            
            publicaciones.Add(new Estado("Saul","saul.romero@hotmail.com","6 de marzo del 2019"));
            publicaciones.Add(new Foto("Juan","juan.guerro@hotmail.com","17 de enero del 2019"));
            publicaciones.Add(new Link("Diana","diana.vizcarra@hotmail.com","14 de diciembre del 2019"));
            publicaciones.Add(new Estado("Luis","luis.perez@hotmail.com","28 de mayo del 2019"));
            publicaciones.Add(new Foto("Maria","maria.leyva@hotmail.com","8 de marzo del 2019"));
            publicaciones.Add(new Link("Fabio","Fabio.torres@hotmail.com","21 de julio del 2019"));
            
            foreach(var item in publicaciones)
            {
                item.observa();
            }
            Estado estado = new Estado("Saul","saul.romero@hotmail.com","6 de marzo del 2019");
            estado.observa();
            Foto foto = new Foto("Ernesto","ernesto.valles@hotmail.com","5 de febrero del 2018");
            foto.observa();
            Link link = new Link("Pedro","pedro.ramirez@hotmail.com","26 de noviembre del 2017");
            link.observa();
        }
    }
}


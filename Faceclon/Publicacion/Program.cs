using System;
using System.Collections.Generic;

namespace Publicacion
{
    abstract class Publicación
    {
        protected string nombre, correo;
        protected DateTime fecha_uso, hora_uso;

        public Publicación(string nom, string co, DateTime fecha_uso, DateTime hora_uso)
        {
            this.nombre = nom;
            this.correo = co;
            this.fecha_uso = fecha_uso;
            this.hora_uso = hora_uso;
        }
        abstract public void Ver();
        public void printdatos()
        {
          Console.WriteLine(nombre, correo);
        }
    }

     class Estado : Publicación
    {
      public Estado(string nom, string co, DateTime fecha_uso, DateTime hora_uso):base(nom,co,fecha_uso,hora_uso)
      {

      }
       public new void printdatos()
      {
       Console.WriteLine("Ver el estado de perfil del usuario {0}",nombre, correo);
      }

    }
    class Foto : Publicación
    {
     public Foto(string nom, string co, DateTime fecha_uso, DateTime hora_uso):base(nom,co,fecha_uso,hora_uso)
     {

     }
     public new void printdatos()
     {
         Console.WriteLine("Ver foto de perfil {0}",nombre);
     }
    }
    class Link : Publicación
    {
     public Link(string nom, string co, DateTime fecha_uso, DateTime hora_uso):base(nom,co,fecha_uso,hora_uso)
     {

     }
     public new void printdatos()
     {
         Console.WriteLine("Ver el link de perfil {0}",nombre,correo);
     }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Publicación> publicaciones = new List<Publicación>();
            publicaciones.Add(new Estado("Saul","saul.romero@hotmail.com",20/05/19));
            publicaciones.Add(new Foto("Juan","juan.guerro@hotmail.com",11/02/19));
            publicaciones.Add(new Link("Diana","diana.vizcarra@hotmail.com",30/08/19));
            publicaciones.Add(new Estado("Luis","luis.perez@hotmail.com",14/12/19));
            publicaciones.Add(new Foto("Maria","maria.leyva@hotmail.com",05/06/19));
            publicaciones.Add(new Link("Fabio","Fabio.torres@hotmail.com",13/01/19));
            
            foreach(var item in publicaciones)
            {
                item.Ver();
            }
            Estado estado = new Estado("Saul","saul.romero@hotmail.com");
            estado.Ver();
            Foto foto = new Foto("Saul");
            foto.Ver();
            Link link = new Link("Saul","saul.romero@hotmail.com");
            link.Ver();
        }
    }
}

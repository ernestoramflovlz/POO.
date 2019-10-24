using System;
using System.Collections.Generic;

namespace Alumno
{
 abstract class Alumno
    {
     protected int matricula, semestre,servicio_social;
     protected string nombre,residencia;
     
     public Alumno(int matricula, int semestre,int servicio_social, string nom, string res)
     {
         this.matricula = matricula;
         this.semestre = semestre;
         this.servicio_social = servicio_social;
         nombre = nom;
         residencia = res;

     }
     abstract public void nombra();
     public void printdatos()
     {
         Console.WriteLine(nombre,residencia);
     }
    }
    class Licenciatura : Alumno
    {
        public Licenciatura(int matricula, int semestre, int Servicio_Social, string nom, string res):base(matricula,semestre,servicio_social,nom,res)
        {

        }
        public override void nombra()
        {
          Console.WriteLine("Se nombra los datos del alumno en licenciatura {0}",nombre, residencia);
        }
    }
      class Posgrado : Alumno
    {
        public Posgrado(int matricula, int semestre, int Servicio_Social, string nom, string res):base(matricula,semestre,servicio_social,nom,res)
        {

        }
        public override void nombra()
        {
          Console.WriteLine("Se nombra los datos del alumno en posgrado {0}",nombre, residencia);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> alumno = new List<Alumno>();
            alumno.Add(new Licenciatura(18210476, 4, 250, "Ing en Sistemas Computacionales","Aplicando practicas"));
            alumno.Add(new Licenciatura(19211204, 2, 100, "Ing Industrial","Asistente de Laboratorio"));
            alumno.Add(new Licenciatura(18217234, 3,400, "Ing Bioquimica","En departamentos"));
            alumno.Add(new Posgrado(15211145, 1, 300, "Ing en Ciencias Computacionales","Aplicando practicas"));
            alumno.Add(new Posgrado(17214578, 6, 245,  "Ing en Ciencias Quimica","Trabajando en proyectos"));
            alumno.Add(new Posgrado(16212013, 5,200, "Ing en Logistica Industrial"," Practicas indistriales"));
        }
    }
}

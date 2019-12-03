using System;
using System.IO;
using System.Collections.Generic;
//6 de dicembre entrega
//puede ser separado
//presentar en la maquina
namespace Proyecto_Final
{
 //Se abre la clase Producto
   class Producto
{
    //Se Describen las variables de los objetos

    string Codigo {get; set;}
    string Descripcion {get; set;}
    decimal Precio {get; set;}
    int Departamento {get; set;}
    int Likes {get; set;}

//Se crea el constructor
public Producto(string CO, string Des, decimal Pr, int Depto, int L)
{
    //Se describe las variables del constructor
 Codigo = CO;
 Descripcion = Des;
 Precio = Pr;
 Departamento = Depto;
 Likes = L;

 public Producto()
{}

}


}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

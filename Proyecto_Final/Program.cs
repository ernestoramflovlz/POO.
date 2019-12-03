using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

//6 de dicembre entrega
//puede ser separado
//presentar en la maquina
namespace Proyecto_Final
{
 //Se abre la clase Producto
   class Producto_Electronico
{
    //Se Describen las variables de los objetos

    string codigo {get; set;}
    string descripcion {get; set;}
    decimal precio {get; set;}
    int departamento {get; set;}
    int likes {get; set;}

//Se crea el constructor
public Producto_Electronico(string CO, string Des, decimal Pr, int Depto, int L)
{
    //Se describe las variables del constructor
 codigo = CO;
 descripcion = Des;
 precio = Pr;
 departamento = Depto ;
 likes = L;
}

public Producto_Electronico()
{}

}
class ProductoArchivo
{
    public static void EscribeProductosBIN(string archivo, List <Producto_Electronico> productos_electronicos)
    {//En este medoto va guardar el archivo con respectivas variables y parametros
    //Se instancia la lista de los productos
        FileStream Fs = new FileStream(archivo , FileMode.OpenOrCreate, FileAccess.Write);
        BinaryWriter binOut = new BinaryWriter(Fs);
        foreach(Producto_Electronico pe in productos_electronicos)
        {
         binOut.Write(pe.codigo);
         binOut.Write(pe.descripcion);
         binOut.Write(pe.precio);
         binOut.Write(pe.likes);

        }
        binOut.Close();
    }
    public static void EscribeProductosElectronicosTXT(string archivo, List<Producto_Electronico> productos_electronicos)
    { //Describe el producto en texto y guarda el archivo
      FileStream Fs = new FileStream(archivo , FileMode.OpenOrCreate, FileAccess.Write);
         StreamWriter txtOut = new StreamWriter(Fs);
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

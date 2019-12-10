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
    //Se Describen las variables de los objetos en publico
 
  public   string codigo {get; set;}
  public   string descripcion {get; set;}
  public   decimal precio {get; set;}
  public  int departamento {get; set;}
  public  int likes {get; set;}

//Se crea el constructor
public Producto_Electronico(string CO, string Des, decimal Pr, int Depto, int L)
{
    //Se describe las variables del constructor
 codigo = CO;
 descripcion = Des;
 precio = Pr;
 departamento = Depto;
 likes = L;
}

public Producto_Electronico()
{}

}
class ProductoElectronicoArchivo
{
    public static void EscribeProductosElectronicosBIN(string archivo, List <Producto_Electronico> productos_electronicos)
    {//En este medoto va guardar el archivo con respectivas variables y parametros
    //Se instancia la lista de los productos
    //Se usa el texto binario para guardar y abrir archivo 
        FileStream Fs = new FileStream(archivo , FileMode.OpenOrCreate, FileAccess.Write);
        BinaryWriter binOut = new BinaryWriter(Fs);
        foreach(Producto_Electronico pe in productos_electronicos)
        {
         binOut.Write(pe.codigo);
         binOut.Write(pe.descripcion);
         binOut.Write(pe.precio);
         binOut.Write(pe.departamento);
         binOut.Write(pe.likes);

        }
        //Va cerrar el texto binario
        binOut.Close();
    }
    public static void EscribeProductosElectronicosTXT(string archivo, List<Producto_Electronico> productos_electronicos)
    { //Describe el producto en texto y guarda el archivo
    //Va describiendo la lista de productos
      FileStream Fs = new FileStream(archivo , FileMode.OpenOrCreate, FileAccess.Write);
         StreamWriter txtOut = new StreamWriter(Fs);
         //Va quedar fuera el archivo a la hora de imprimir
     foreach(Producto_Electronico pe in productos_electronicos)
     {
         txtOut.WriteLine("{0}|{1}|{2}", pe.codigo,pe.descripcion,pe.precio,pe.likes);
     }
     txtOut.Close();
    }
    //En este metodo publico va leer el producto en su lista
    public static List<Producto_Electronico> LeeProductosElectronicosBIN(string archivo)
    {
     List<Producto_Electronico> productos_electronicos = new List<Producto_Electronico>();
     FileStream Fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);

     //Abre el ciclo para leer los productos retornandolo 

     using(BinaryReader binIn = new BinaryReader(Fs))
     {
         while (binIn.PeekChar() != -1)
         {
             Producto_Electronico productos_electronico = new Producto_Electronico();
             productos_electronico.codigo = binIn.ReadString();
             productos_electronico.descripcion = binIn.ReadString();
             productos_electronico.precio = binIn.ReadDecimal();
             productos_electronico.departamento = binIn.ReadInt16();
             productos_electronico.likes = binIn.ReadInt16();

             productos_electronicos.Add(productos_electronico);
         }
     }
     return productos_electronicos;
    }
    //En este siguiente metodo va leer los productos pero en texto guardandolo en el archivo
    public static List<Producto_Electronico> LeeProductosElectronicosTXT(string archivo)
    {
        List<Producto_Electronico> productos_electronicos = new List<Producto_Electronico>();
        using (StreamReader Mr = new StreamReader(archivo))
        { //Va haciendo otro ciclo que va leer las columnas de la lista 
            string line = "";
            while ((line = Mr.ReadLine()) != null)
            {
                string[] columnas = line.Split('|');
                productos_electronicos.Add(new Producto_Electronico(columnas[0],columnas[1],Decimal.Parse(columnas[2]),int.Parse(columnas[3]),int.Parse(columnas[4])));
                    
                                                   
            }//biutify
        }
        return productos_electronicos;
    }
    
}
//Esto fue lo que la clase de producto
    class Program
    {
        //Aqui va imprimir el Producto con todos sus objetivos, precios, descripcion y los likes que pueda obtener en una lista
        static void Main(string[] args)
        {
           List<Producto_Electronico> products_electronics = new List<Producto_Electronico>();
           //Va describiendo el producto que se va imprimir y guardar en el texto 
           products_electronics.Add(new Producto_Electronico("EWL","Resistencia 5 rl12 likes", 6,1034,340));
           products_electronics.Add(new Producto_Electronico("ETS","Resistencia 10 ga34 likes", 7,1034,150));
           products_electronics.Add(new Producto_Electronico("EAQL","Capacitor  ol07 likes", 8,1110,575));
           products_electronics.Add(new Producto_Electronico("EOZ","Cables para celulares o tables ap81 likes", 20,2000,200));
           products_electronics.Add(new Producto_Electronico("EZW","Bateria 4.5V kw59 likes", 30,1220,625));
           products_electronics.Add(new Producto_Electronico("ETS","Protobord ps26 likes", 100,500,800));
           

           //Se guarda el archivo binario
           ProductoElectronicoArchivo.EscribeProductosElectronicosBIN(@"productos_electronicos.bin", products_electronics);
            Console.WriteLine("Archivo Grabado");
            Console.ReadKey();
            List<Producto_Electronico> productos_electronicos_leidos = ProductoElectronicoArchivo.LeeProductosElectronicosBIN("producto_electronico.bin");
           //Imprime la lista de los productos
            foreach(Producto_Electronico pe in productos_electronicos_leidos)
            {
            Console.WriteLine("{0} {1} {2}", pe.codigo, pe.descripcion,pe.departamento,pe.precio,pe.likes);
            }
        }
    }
}

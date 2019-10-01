using System;

namespace Parametros
{
class String
 {
     //Uso de la funcion ref
     static void Strings(ref string s1, ref string s2)
     
      // El parámetro de cadena se pasa por referencia.
      // Cualquier cambio en los parámetros afectará a las variables originales.
     {
         string temp = s1;
         s1 = s2;
         s2 = temp;
         System.Console.WriteLine("Inside the method: {0} {1}", s1, s2);
     }

     static void Main()
     {
         string str1 = "Obj1";
         string str2 = "Obj2";
         Console.WriteLine("Dentro de Main, antes de cambiar: {0} {1}", str1, str2);

         
         Strings(ref str1, ref str2);  
         

        // Pasando cadenas por referencia.
         Console.WriteLine("Dentro de Main, después de cambiar: {0} {1}", str1, str2);
     }
     class objeto
     {
         static void multiplicacion(int Obj1, int Obj2, out solucion){
           solucion = Obj1 * Obj2;
         }
         static int multiplicacion(int Obj1, int Obj2){
            return = Obj1 * Obj2;
         }

         static void Main()
	{
		int x = 1;
		int y = 2;
		int r; // Es importante NO inicializar

		multiplicacion(x, y, out r);
		Console.WriteLine(r);

		Console.WriteLine(multiplicacion(x,y)); 

	   }
     }
 }
 class soluciona
 {
     public void soluciona(in int r){
    r - r * 2;
   }
 }
class Program
{
static void Main()
	{
		soluciona s = new soluciona();
		int x = 2;
		s.soluciona( in x); //
		Console.WriteLine(x);
	}
}
using System;
using System.Collections.Generic;

namespace stack
{
public class Stack<T>

{
   private T[] elementos;
   readonly int max_size; 
   private int apuntador_pila = 0;
   T[] m_Elementos;
    public Stack():this(100)
   {
       
   }

   public Stack(int size)

   {
      max_size = size;
      elementos = new T[max_size];
   }

   public void Push(T elemento)

   {

     elementos[apuntador_pila] = elemento;
     apuntador_pila++;
   }
 
    public T Pop()
   {

      apuntador_pila--;
      return elementos[apuntador_pila];
   
      

   }
  }
  class NegativeIntegerException : Exception
{
    public NegativeIntegerException():base("Verifica que sea un elemento compatible")
     ()
}
class program
{
   static void Main(string[] args)
   {
        Stack<string> nombres = new Stack<string>(4);  
        nombres.Push("Mundo");
        nombres.Push(" ");
        nombres.Push("Hola");

        string nombre = nombres.Pop();
        Console.Write(nombre);
        Console.Write(nombres.Pop());
        Console.Write(nombres.Pop());
        Console.Write(nombres.Pop());
        Console.Write(nombres.Pop());
        
       
        int elemento = 0;
        Console.WriteLine("captura un elemento");
        try
           {
             elemento = int.Parse(Console.ReadLine());
             if (valor < 0)
             {
             throw new NegativeIntegerException();
             }
             Console.WriteLine("El elemento es", elemento);
             Main();
           }
           catch(StackOverflowException e)
           {
             Console.WriteLine("Hay un error:");
             Console.WriteLine(e.Message);            
           }
           finally
           {
               Console.WriteLine("finally:");
           }
          
            Console.ReadKey();
        }
   }

}


}
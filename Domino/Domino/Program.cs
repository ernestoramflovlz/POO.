using System;

namespace Domino
{
    public readonly struct Puntos
    {
  private readonly int dom1;
  private readonly int dom2;

  public Puntos(int domino1, int domino2)
  {
      if (domino1 == 0)
      {
       throw new ArgumentException("Domino1 no puede ser cero.", nameof(domino2));
      }
      dom1 = domino1;
      dom2 = domino2;
  }
public static Domino operator + (Puntos dom1) => dom1;
public static Domino operator - (Puntos dom1) => new Domino(-dom1.dom1, dom1.dom2);

public static Domino operator +(Puntos dom1, Domino dom2)
=> new Domino(dom1.dom1 * dom2.dom2 + dom2.dom1 * dom1.dom2, dom1.dom2 * dom2.dom2);
public static Domino operator -(Puntos dom1, Domino dom2)
=> dom1 + (-dom2);
    }
}
public class Domino
{

}
    class Program 
    {
        static void Main(string[] args)
        {
             Domino dom1 = new Domino(2,0);
             Domino dom2 = new Domino(4,1);
             Console.WriteLine(dom1+dom2);
              Console.WriteLine(dom1-dom2);
        }
    }


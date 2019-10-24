using System;
using System.Collections.Generic;

namespace Figura
{
   abstract class Figura
    {
     protected int ancho, alto;
     protected int px, py;
     protected string color_relleno, color_borde;
     public Figura(int ancho, int alto, int px, int py, string color_relleno, string color_borde)
    {
        this. ancho = a;
        this. alto = h;
        this. px = x;
        this. py = y;
        this. color_relleno = cr;
        this. color_borde = cb;
    }
     public abstract void dibuja();
     

    }
    class Rectangulo : Figura
    {
    public Rectangulo(int ancho, int alto, int px, int py, string color_relleno, string color_borde)base(int ancho, int alto, int px, int py, string color_relleno, string color_borde){}
   
    public override void dibuja()
    {
    Console.WriteLine("Se dibuja en rectangulo color{0}, en x:{1} y y:{2}", color_relleno, px, py);
    }

    }
    class Circulo : Figura
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Figura fig = new Figura(10,10);
            List<figura> fugras = new List<figuras>();
            figuras.Add(new Rectangulo(m,co));
        }
    }
}

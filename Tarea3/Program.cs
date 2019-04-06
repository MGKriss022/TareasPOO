using System;
using System.Collections.Generic;

namespace Tarea3
{
    class Vector2D
    {
        public int x, y;
        public Vector2D(int x, int y)
        {
            this.x=x; this.y=y;
        }
        public override string ToString()
        {
            return String.Format("{0},{1}", x, y);
        }
    }
    abstract class Figura
    {
        public Vector2D position;
        public string fill ,border;

          //Constructor por defecto 
        public Figura():this( new Vector2D(100, 100))
        {
            
        }
        //constructor de figura
        public Figura(Vector2D pos)
        {
            position= pos;
            fill = "white";
            border = "black";
        }
        public abstract void Dibuja();
    }

    class Circulo : Figura
    {
        private int radio;
        public Circulo(Vector2D pos, int radio):base(pos)
        {
            this.radio = radio;
        }
        public Circulo ():base()
        {
            this.radio = 10;
        }

        public override void Dibuja() 
        {
            Console.WriteLine("Se dibuja un circulo en {0} de color {1}", position, fill);
        }

        public void Perimetro()
        {
            Console.WriteLine("Perimetro del Circulo: {0}",((radio*2)*Math.PI));
        }
    }
 
    class Rectangulo : Figura
    {
        public Rectangulo(Vector2D pos):base(pos)
        {
            
        }
        public Rectangulo ():base()
        {
            
        }

        public override void Dibuja() 
        {
            Console.WriteLine("Se dibuja un Rectangulo en {0} de color {1}", position, fill);
        }
    }

    class Triangulo : Figura
    {
        public Triangulo(Vector2D pos):base(pos)
        {
            
        }
        public Triangulo(Vector2D pos,string fill):base(pos)
        {
            this.fill = fill;
        }

        public Triangulo ():base()
        {
            
        }

        public override void Dibuja() 
        {
            Console.WriteLine("Se dibuja un Triangulo en {0} de color {1}", position, fill);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Circulo());
            figuras.Add(new Rectangulo(new Vector2D(200,200)));
            figuras.Add(new Triangulo(new Vector2D(300,300),"Azul"));
            foreach(Figura f in figuras)
            {
                f.Dibuja();  
            }
            Circulo p = new Circulo();
            p.Perimetro();
        }
    }
}
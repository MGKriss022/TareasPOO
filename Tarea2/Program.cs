using System;

namespace Tarea2
{
    class Dado
    {
        private int valor;
        private string color;
        private string dueño;

        public Dado ()
        {
            valor = 0;
            color = "Transparente";
            dueño = "Nadie";
        }

        public Dado(string dueño, string color)
        {
            this.dueño = dueño;
            this.color = color;
        }

        public Dado(string dueño, string color, int valor)
        {
            this.valor = valor;
            this.color = color;
            this.dueño = dueño;
        }

        public void Lanzar()
        {
            Random rnd = new Random();
            valor = rnd.Next(1,7);
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Dado de: {0} \nColor: {1} \nValor: {2}\n",dueño,color,valor);
        }

        public static bool operator == (Dado a, Dado b)
        {
            return(a.valor == b.valor);
        }

        public static bool operator != (Dado a, Dado b)
        {
            return(a.valor != b.valor);
        }

        public static bool operator > (Dado a, Dado b)
        {
            return (a.valor > b.valor);
        }

        public static bool operator < (Dado a, Dado b)
        {
            return (a.valor < b.valor);
        }

        public void Comparar(Dado a, Dado b, Dado c)
        {
            if (a>b && a>c)
            {
                Console.WriteLine("El dado de {0} gana por ser de valor: {1}\n",a.dueño,a.valor);
            }
            else if (b>a && b>c)
            {
                Console.WriteLine("El dado de {0} gana por ser de valor: {1}\n",b.dueño,b.valor);
            }
            else
            {
                Console.WriteLine("El dado de {0} gana por ser de valor: {1}\n",c.dueño,c.valor);
            }
        }

        public void Comparar(Dado a, Dado b)
        {
            if (a>b)
            {
                Console.WriteLine("El dado de {0} gana por ser de valor: {1}\n",a.dueño,a.valor);
            }
            else if (a<b)
            {
                Console.WriteLine("El dado de {0} gana por ser de valor: {1}\n",b.dueño,b.valor);
            }
            else
            {
                Console.WriteLine("El dado de {0} y {1} tienen el mismo valor\n",a.dueño,b.dueño);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dado a = new Dado();
            a.Lanzar();
            a.MostrarDatos();

            Dado b = new Dado("Bob","Rojo");
            b.Lanzar();
            b.MostrarDatos();

            Dado c = new Dado("Tom","Azul");
            c.Lanzar();
            c.MostrarDatos();

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Resultados:\n");
            a.MostrarDatos();
            b.MostrarDatos();
            c.MostrarDatos();
            a.Comparar(a,b,c);
            a.Comparar(b,c);
        }
    }
}
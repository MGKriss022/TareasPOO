using System;
using System.Collections.Generic;

namespace Tarea4._2
{
    interface IAfina
    {
        void Afina();
    }
    abstract class Musico
    {
        public string nombre;

        public Musico()
        {

        }
        public Musico (string n)
        {
            nombre = n;
        }
        public string Display()
        {
            return nombre;
        }
    }

    class Bajista : Musico, IAfina
    {
        public string instrumento;
        public Bajista()
        {

        }
        public Bajista(string n, string i):base(n)
        {
            instrumento = i;
        }

        public void Afina()
        {
            Console.WriteLine($"{Display()} afina su {instrumento}");
        }
    }

    class Guitarrista : Bajista
    {
        public Guitarrista()
        {

        }

        public Guitarrista(string n, string i): base(n,i)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Musico musico = new Musico("Django");
            Bajista b = new Bajista("Flea","Bajo");
            Guitarrista g = new Guitarrista("Santana","Guitarra");
            List<Musico> musicos = new List<Musico>();

            musicos.Add(b);
            musicos.Add(g);

            foreach(Musico m in musicos)
            {
                (m as IAfina).Afina();
            }
            Console.ReadKey();
        }
    }
}
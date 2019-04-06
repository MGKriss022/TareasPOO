# Tarea 4 - Herencia
#### Melendez Gonzalez Cristian David - 18212222

### 1. Considera el siguiente fragmento de programa:
```csharp
using System;

namespace Tarea4
{

    class A
    {
        public int a;

        public A()
        {
            a = 10;
        }

        public string Display()
        {
            return a.ToString();
        }
    }

    class B:A
    {
        public int b;
        
        public B():base()
        {
            b = 15;
        }

          //#########################################
          //#  Después de contestar la pregunta 1                  
          //#  Redefine el método Display() en este espacio,  debe regresar el campo b como string.
          //#########################################

    }
    class Program
    {
        static void Main(string[] args)
        {
            A objA = new A();
            B objB = new B();
            Console.WriteLine(objA.Display()); ///  (1)
            Console.WriteLine(objB.Display()); ///  (2)
        }
    }
}
```
### 1.1. ¿Qué valores imprimen las lineas (1) y (2)?
10 y 10
El valor de a porque B aun no tiene Display redefinido ya que Display de A esta retornando el valor int a de la clase A y como B tiene valor a por medio del base por eso da 10 tambien.

### 1.2 Redefine el método Display en el espacio indicado, una vez redefinido el método, ¿qué valores imprimen las lineas (1) y (2)?.
10 y 15 como deberia de ser
```csharp
using System;

namespace Tarea4
{
    class A
    {
        public int a;

        public A()
        {
            a = 10;
        }

        public virtual string Display()
        {
            return a.ToString();
        }
    }

    class B:A
    {
        public int b;
        
        public B():base()
        {
            b = 15;
        }

        public override string Display()
        {
            return b.ToString();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            A objA = new A();
            B objB = new B();
            Console.WriteLine(objA.Display()); ///1
            Console.WriteLine(objB.Display()); ///2
        }
    }
}
```

### 1.3. ¿Que palabra debes agregar en la linea (public _______ string Display()) al definir A.Display()
virtual para que pueda ser modificado sin problemas en la clase B

### Considera el siguiente fragmento de programa:
```csharp
using System;

using System.Collections.Generic;

 ________ class Musico

    {

    public string nombre;

    public Musico (string n)

        {

         nombre = n;

        }

   public abstract (A) void Afina();  (B)

   public (C) string Display()

      { 

       return nombre;

      }

   }

class Bajista; Musico

  {

    public string instrumento;

    public Bajista (string n, string i ) ......

    .........

    public _________ Afina()

      {

      ________________

      }

 }

class Guitarrista ____________

     {

     public instrumento;

      // Falta el constructor y otras cosas??

 

     }

 

class Program

 {

  public static Main()

   {

  Musico musico = new Musico("Django"); (D)

  Bajista b = new Bajista("Flea");

  Guitarrista g = new Guitarrista("Santana");

  List<Musico> musicos = ____________________

  musicos.Add( b);

  musicos.Add(g);

 

  foreach ( _____in musicos______)

        ____________________

 // (m as IAfina).Afina()

 Console.ReadKey();

  

 }

}
```

### 2.1. Completa el programa.
```csharp
using System;
using System.Collections.Generic;

namespace Tarea4._2
{
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

        public abstract void Afina();

        public string Display()
        {
            return nombre;
        }
    }

    class Bajista : Musico
    {
        public string instrumento;
        public Bajista()
        {

        }
        public Bajista(string n, string i):base(n)
        {
            instrumento = i;
        }

        public override void Afina()
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
                m.Afina();
            }
            Console.ReadKey();
        }
    }
}
```

### 2.2 Hay un error en uno de los puntos (A)(B)(C)(D). ¿Cuál es y por qué?
en A ya que estamos haciendo un metodo abstracto pero la clase no es abstracta por lo tanto da error y en D porque en caso de que hagamos Musico una clase abstracta entonces ya no se va a poder crear.

### 2.3 ¿Qué método se debe implementar obligatoriamente en ambas clases y por qué?
Afina ya que si es abstract debe ser implementado obligatoriamente o sino tira error.

### 2.4 ¿Por qué no se ponen las llaves en (B)?, ¿Cuando si se pondrían?
Porque el metodo es abstracto y sirve como un molde nadamas, si se pondrian llaves cuando no lo fuera.

### 2.5 ¿Qué pasa si el método Afina() lo hacemos virtual en lugar de abstract?
Nos daria error porque no lo hemos implementado osea no le pusimos las llves como decia la pregunta anterior.

### 3. Implementa el programa utilizando interfaces en lugar de herencia.
```csharp
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
```
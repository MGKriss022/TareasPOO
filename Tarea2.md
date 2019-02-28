# Tarea 2 - Clases y Objetos
#### Melendez Gonzalez Cristian David - 18212222

### 2.1 Declaración de clases: atributos, métodos, encapsulamiento.
Las clases y estructuras sirven para encapsular tipos datos y comportamientos. Los datos y comportamientos forman parte de la clase o estructura y se incluyen sus metodos, propiedades, eventos, entre otros.

La declaracion de clases o estructuras se usa para hacer objetos o instancias mientras se ejecuta el programa. Por ejemplo se crea la clase Persona, Persona seria el nombre del tipo, creamos una variable llamada p de tipo Persona, la p vendria siendo objeto de Persona. Se pueden hacer varios objetos de tipo Persona y cada uno puede tener valores diferentes.

Las clases son un tipo de referencia. Si hacemos un objeto de la clase, la variable asignada al objeto es solo una referencia a esa memoria. Cuando la referencia se asigna a una variable nueva, esta hace referencia al objeto original. Los cambios que se lleguen a hacer en una variable se van a reflejar en la otra porque las dos hacen referencia a los mismos datos.

Las estructuras son un tipo de valor que al ser creadas, la variable a la que se asigna la estructura contiene los datos reales de la estructura. Cuando se asigna a una nueva variable, al contrario de la clase, se copia. Por lo que la variable nueva y original contienen copias independientes de los mismos datos y los cambios que se hagan en una no afectan a la otra copia.

Las clases se usan para moldear comportamientos mas elaborados o datos que se cree que se puedan modificar a futuro despues de haber creado el objeto. Las estructuras quedarian mejor para las estructuras de datos pequeñas con datos que no se van a modificar despues.

#### Encapsulacion
La encapsulacion, segun su principio, una clase o estructura pueden especificar hasta que punto se pueden acceder a sus miembros para codificar fuera de la clase o la estructura. Se puede usar para ocultar los datos, limitar la probabilidad de los errores de codificacion y como proteccion contra ataques malintencionados.

#### Miembros
Todos los metodos, campos, constantes, propiedades y eventos deben de declararse dentro de un tipo los cuales de les denomina miembros de tipo ya que en C# no hay metodos ni variables globales a comparacion de otros lenguajes. Hay varios tipos de miembros que existen:
* Campos
* Constantes
* Propiedades
* Metodos
* Constructores
* Eventos
* Finalizadores
* Indizadores
* Operadores
* Tipos anidados

#### Accesibilidad
La acecesibilidad permite que los metodos y propiedades puedan ser invocados y accedidos fuera de la clase o estructura o tambien limitar a que se use solamente en la propia clase o estructura. Se limita la accesibilidad para que el cliente solo pueda acceder solamente al codigo previsto. Se pueden usar los modificadores de acceso public, protected, internal, protected internal, private y private protected para decir hasta a donde se puede acceder. La accesibilidad por default es private.

#### Herencia
Solo las clases pueden usar herencia, quiere decir que una clase deriva de otra clase base que contiene automaticamente todos sus miembros de la clase base a excepcion de sus constructores y finalizadores. Las clases se pueden declarar como abstract para hacer que uno o varios de sus metodos no tengan implementacion, aunque no se pueden implementar directamente sirven como base para otras clases que dan la implementacion que falte. Por ultimo se puede declarar seales para que ninguna otra clase herede de esta.

#### Interfaces
Las clases y estructuras pueden heredar interfaces, significa que el tipo implementa todos los metodos definidos en la interfaz.

### 2.2 Instanciación de una clase.
El operador new se usa para crear objetos e invocar constructores, tambien se usa para crear instancias de tipos anonimos, ademas se usa para invocar el constructor predeterminado para tipos de valor. El operador new no se puede sobrecargar y si no puede asignar memoria produce una excepcion.

### 2.3 Referencia al objeto actual.
La palabra clave this hace referencia a la instancia actual de la clase. 

* Escribe un programa donde utilices this para obtener acceso a miembros con el fin de evitar ambigüedades con nombres similares.
```csharp
using System;

namespace Tarea2
{
    class Vehiculo
    {
        private string nombre;
        private string tipo;

        public Vehiculo (string nombre, string tipo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
        }

        public void Mostrardatos()
        {
            Console.WriteLine("Nombre: {0}, Tipo: {1}",nombre,tipo);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo ferrari = new Vehiculo("SF-90","Coche de Formula 1");
            ferrari.Mostrardatos();
            Console.ReadKey();
        }
    }
} 
```

* Escribe un programa donde se utilice this como parámetro.
```csharp
using System;

namespace Tarea2
{
    class Vehiculo
    {
        private string nombre;
        private string tipo;

        public Vehiculo (string nombre, string tipo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
        }

        public void Mostrardatos()
        {
            Console.WriteLine("Nombre: {0}, Tipo: {1}",nombre,tipo);
        }

        public void Reescribir(string nombre, string tipo)
        {
            Console.WriteLine("{0}, {1}",this.nombre = nombre, this.tipo = tipo);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo ferrari = new Vehiculo("SF-90","Coche de Formula 1 de 2019");
            ferrari.Mostrardatos();
            ferrari.Reescribir("SF-71H","Coche de Formula 1 de 2018");
        }
    }
}
```

### 2.4 Métodos: declaración, mensajes, paso de parámetros, retorno de valores.
Los parametros para un metodo sin in, ref, o out se pasan al metodo por valor, el cual se puede cambiar en el mentodo pero se perdera chando el control se devuelva al procedimmiento que fue llamado. al usar palabras claves de parametros de metodo en la declaracion del parametro, puede modificar ese comportamiento.
params dice que el parametro puede agarrar un numero de argumentos variable, in especifica que el parametro se pasa por referencia y que solo se lee mediante el metodo llamado. ref es para que el parametro se pase mediante referencia y pueda ser leido o escrito por el metodo. out hace lo mismo pero solo puede escribirse con el metodo llamado.

#### params
Con esta palabra clave se pude especificar un parametro de metodo que toma un numero de argumentos. Envia una lista separada por comas de argumentos con tipo especificado en la declaracion o en una matriz de argumentos del tipo que se especifico. Puede no enviar ningun argumento por lo que la longitud de la lista de params seria cero. Debe ser una matriz unidimensional o sino daria un error de compilacion.

#### out
Se puede usar como un modificador de parametro para pasar un argumento a un metodo mediante una referencia en compraracion mediante un valor.

#### ref
Indica un valor que se pasa mediante referencia se puede usar en una firma del metodo y en una llamada al metodo para pasar un metodo por referencia, para devolver un valor al creador de la llamada mediante referencia. Tambien para indicar en un cuerpo de miembro que que un valor de referencia devuelto se almacena localmente como una referencia que el creador de la llamada va a modificar o que una variable local accede a otro valor por referencia.

### 2.5 Constructores y destructores: declaración, uso y aplicaciones.
Los constructores son de tipo clase que se ejecutan cuando se crea un objeto, tienen el mismo nombre que la clase y inicializan los datos del objeto. Un constructor que no tiene ningun parametro es el constructor predeterminado, los cuales se llaman cada vez que se crea un objeto mediante el comando new y no se le pone ningun argumento a este. Los constructores se les asigna por default un constructor publico para que se puedan crear instancias de la clase, a menos que la clase sea static. Los constructores aceptan valores de accesibilidad public, private, protected, internal o protectedinternal los cuales dicen hasta que nivel los usuarios pueden acceder a estos.
### 2.6 Sobrecarga de métodos. 
Ver el ejercicio siguiente

###  2.7 Sobrecarga de operadores: Concepto y utilidad, operadores unarios y binarios.
Implementa una clase llamada Dado, la cual es una abstracción de los dados de algún juego.
```csharp
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
```
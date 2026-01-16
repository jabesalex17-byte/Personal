//  CLASES Y METODOS
//AGRUPAR DATOS REALCIONADOS
using System.Xml.XPath;

class program //esta es la clase principal nuestro programa le llegas?
{
    public static void Main() // medoto principal de la clase  del programa que estamos haciendo
    {
        //intanciar la clase 
        //esta es la forma de nuestra forma 
        Persona juan = new Persona();
        //juan.nombre = "bartolomeo";
        Console.WriteLine(juan.nombre);
        juan.hablar();
        Console.WriteLine(juan.suma());
        Console.WriteLine(juan.puntuacion(23, 24));

        jugudor1 jabes = new jugudor1();
        Console.WriteLine(jabes.nombre);
        Console.WriteLine(jabes.xp);
        jugador2 elvis = new jugador2("elvislaksdj", 23);


    }

}

//Estas son las clases que hacemos y que podemos usar en la clase principal
class Persona()
{
    public string nombre = "sdfgsdfg";
    public int edad = 34;
    public string direccion = "su casa ";
    public double salario = 0.0;
    public bool activo = true;

    // METODO SET ni recibe ni devuelve ningun valor 
    // este si lo queremos usar fuera de la clase por ejemplo en la clase del programa tenemos que hacer que sea publico
    public void hablar()
    {
        Console.WriteLine("hola mundo");
    }
    public void algo()
    {
        Console.WriteLine("no se que no se cuantos");
    }

    //sin parametros pero si devuelve algo que es que ponemos el tipo de datos y el return de ese tipo de dato
    public int suma()
    {
        int valor1 = 2, valor2 = 43;
        return valor1 + valor2;

    }

    //con parametros y retun y pues tienen que ser la misma conatidad de argumentos y de parametrso 
    // para hacer un parametro por defaul tiene que ser el ultimo y lo asignas normal y ya
    public int puntuacion(int multiplicadro , int puntos=32)
    {
        return (multiplicadro * puntos);
    }


    //SET Y GET

    //SET 
    //Es para cuando queremos que una variable se pueda modificar pero no ver 
    //hacemos una funcion que resiva esa nuevo valor y que lo asigne pero odviamente que no lo devuelva
    //y odvio la varaible tiene que ser privada para que no se pueda modificar desde fuerea
    // y odvio una funiconi publica
    
    //GET 
    /* es para lo contrario queremos ver una variable pero no queremos que se pueda modificar lo que podemos hacer es 
     * hacer la variable que sea privada y hacemos una fucion para que la devuelva una funcion sin para metro solo para que la devuelva o odvio una funcion publica
     */
}


//METODO CONSTRUCTOR
//esto es para inicializar el objecon con valores sirve para inicializar valores y que ya el objeto se pueda usar por decirlo de alguna manera
//hay dos formas de hacerlo 

/*la forma numero 1 todo publico y hacemos la clase y con el mismo nombre el metodo tambien publico constructor
 que pasa definimos las variables normal y ese metodo que hicimos con el mismo nombre ahi es donde vamos a definir las variables no a crear nuevas por si acaso
lo que hacemos es ponerle los valores que tendrea baiscamente ese metodo siempre se ejecutara cuando creemos el objeto le lleva y lo usamos para ahi mismo poner los valores 
*/
public class jugudor1
{
    public string nombre;
    public int xp;
    //tienen que tener el msmo nombrew
    //no tienen retorno
    public jugudor1()
    {
        nombre = "anonimo";
        xp = 0;

    }
}

//esta es la otra forma de hacelo lo que hacemso aquie es que el constructro resuva parametors para que cuando creemos el objeto  alla arriba le pasemos esos parametrso
public class jugador2
{
    public string nombre;
    public int edad; 

    public jugador2(string setnombre, int setedad) // y odviamente se le pueden poner valores predetermninados a esto 
    {
        nombre = setnombre;
        edad = setedad;
    }
    
}

//esta es otra forma y es ponindo las dos cosas pero es mucho codigo
class Auto
{
    public string Marca;
    public int Año;

    public Auto()
    {
        Marca = "Sin marca";
        Año = 0;
    }

    public Auto(string marca, int año)
    {
        Marca = marca;
        Año = año;
    }
}



//THIS 
//sirve para evitar confundir los parametros  es decer en este ejemplo el this le dice al sistema que 
//normalmente se usa en metodos constructores 
//pero la idea es esa referirse a la la bariable que esta afuera
class usuario
{
    string nombre;

    void algo(string nombre)
    {
        this.nombre = nombre;
    }
}


//COLABORACION DE CLASES 
//Basicamente es cuando una clase llama a otra o crea un objeto de otra clase

//tenemos dos clases

class Cuenta
{
    public double saldo;

    public void Depositar(double monto)
    {
        saldo += monto;
    }
}

class persona
{
    public string nombre;
    public Cuenta cuenta; //aca declaramos la variable cuenta 

    public persona(string nombre)
    {
        this.nombre = nombre;
        cuenta = new Cuenta(); // y aca en el constructar lo que hacemos en crear esa objeto esa instancia
        
    }
}

/*
class program
{
    static void Main()
    {
        Persona juan = new Persona("juan"); // que esta pasando aquie estamos creatndo uuna persona juan y el constructor le hace una  cuenta a juan
        juan.cuenta.Depositar(100);// y como te digo podemos haceder a esa calse no se bien mas como explicartelo
        
        Console.WriteLine(juan.cuenta.saldo);
    }

}
 */
// esto fue escrito a mano por si hay algun error
// imaginatelo como que estamos dandole un objeto somo si fuera un atributo 
//asi como hacemos string nombre como atributo le estamos pasando cuenta cuentadejuan como atributo y asi como lo definimos el string nombre = "algo" aqui ponemos cuenta cuentadejuan = new cuenta();
// y odvio podemos crear el objoeto despues primero declararlo y depsues hacerlo eso es lo que estamos haciendo aquie basicamente



//LISTAS 


class listas
// sirver para muchos valores de un mismo tipo le llevagas como un array pero con muchas mas funcionalidades
//la diferencia princiapla de un array y una lista es que los array son de un tamaño fijo y las listas son dinamicas pueden crecer y decrecer
//otra cosa es que las listas permiten valores duplicados puedes anadir el mismo valor varias veces 
{
    void datos()
    {
        List<string> cosas = new List<string>(); // asi es como se declasra una lista list<el tipo de la lista puede ser void> el nombre = new<eltipo que pusiste>();
        //List<string> cosas = new List<string> { "algo1", "algo2", "algo3" };// asi es como se inicializa una lista con datos}
        cosas.Add("algo");//anade algo a la lista
        cosas.Clear(); // limpia la lista
        cosas.Remove("algo"); // elimina algo de la lista 
        cosas.RemoveAt(3);// elimina por la posicion 
        cosas.Count(); // cuenta los elementos de la lista
        cosas.Insert(0, "nuevo"); // inserta un nuevo elemento en la posicion que le digas
        cosas.Sort(); // ordena la lista
        cosas.Reverse(); // invierte el orden de la lista
        cosas.Contains("algo"); // verifica si la lista contiene algo y devuelve un bool
        cosas.IndexOf("algo"); // devuelve la posicion de algo en la lista
        cosas.Add("algo");//anade algo a la lista
        // y muchas cosas mas 

        string algo = cosas[0]; // asi es como se accede a un elemento de la lista por su posicion
        Console.WriteLine(cosas[0]);

        //si se peuden hacer listas de objetos

        List<Persona> personas = new List<Persona>();
        personas.Add(new Persona()); // anade un nuevo objeto persona a la lista


    }
}

// FOREACH 
//Es una itereaicoin de toda la vida sirve para ir de uno en uno en algo una lista un strin lo que sea

/*
string ejemplo = "algo";

foreach(char  i in "agpp")
{
    Console.WriteLine(i);
}
*/


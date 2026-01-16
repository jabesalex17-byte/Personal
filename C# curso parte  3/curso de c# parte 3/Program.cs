// MAPAS

//son estructuras de clave valor 
//a diferencia de las listas no acepta valroes repetidos
//normalmente se usa cuando la clave no es un numero
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Reflection;
using System.Runtime.InteropServices;

public class mapas
{
    void algo()
    {
        Dictionary<int, string> algo = new Dictionary<int, string>(); // esta es la forma de declararlo y caso las mismas funicones de las listas estan aqui
        algo.Add(1, "noseque");
        algo.ContainsKey(3); //verifica si esiste esa clave 3

        Console.WriteLine(algo[1]); // esta es la forma de aceder a la variable 

        //pra ver todos los elementos hay que hacer un foreach con un var
        //var porque son mas de un tipo
        foreach(var x in algo)
        {
            //forma normal 
            //x.key y x.value es la forma de acceder a la clave y al valor respuectivamente en un foreach
            Console.WriteLine($"Clave: {x.Key} valor: {x.Value}");
            //forma cutre
            Console.WriteLine(x);
        }

    }
}


//POO 
//porgramacion orientada a objetos
//los de crear objetos con clases eso es una parte de la poo que pasa aqui entra el tema de la herencia el emcapsulamiento y y eso

class persona
{
    string nombre;
    int edad;

     public persona(string nombre, int edad) // el motodo constructor que ya sabemos
    {
        this.nombre = nombre;
        this.edad = edad;
    }


    //GET
    //en este caso este es el metodo get para que me de los datos
    private void datos() // un metodo para mostrar esos datos porque no queremos que se puedad haceder directamente
    {
        Console.WriteLine(nombre);
        Console.WriteLine(edad);
    }


    //SET
    //en este caso es el metodo set para poner esos valores y se pueden hacer validaciones antes de poner el dato podemos anteves validar que no tenga numero o lo que queramos es basicamente para poner eso un set
    //basicamete el metodo set es para tu resivir valores y podificarlos atritublos y en caso de qiue sea neseario hacer algo mas
    void setdatos(string nombre, int edad)
    {
        //no necesarioa mente tienei que ser para cosas directas 
        //por ejemplo una funionc que sea para encerder un carro tambien debe modificar la variable de estado del carro a encendido entende
        this.nombre = nombre;
        this.edad = edad;
        Console.WriteLine("se cambio tu edad");
    }

    public void hablar(string mensaje )
    {

        Console.WriteLine($"El gay de {nombre} dice: {mensaje}");
    }
     
    void cumpleanos()
    {
        Console.WriteLine("feliz cumpleanos");
        edad++;
    }
    static void Main()
    {
        persona indio = new persona("juan", 23);
        indio.datos();
        indio.hablar("no se que decir"); 

        principal ejemplo = new principal();
        ejemplo.algo();
        fechas fecha = new fechas();
        fecha.algo();
        Console.ReadKey();

        errores manejoerrores = new errores();
        manejoerrores.algo();

    }

}

// ENCAPTSULACION 
// Impedir el acceso a los atributos los


//MODIFICADOES DE ACCESO
/*
 los public son los que se pueden acceder desde cualquier parte de nuestro programa 
los private solo desdes la clase donde estan todo lo que sea dentro de esa clase se va a poder acceder 
los portected desde la clase actual y las clases hijas no podran acceder a esos atributos y metodos
las internal solo se pueden acceder desde este proyecto si hacemos otro proyecto y los conectasmos jnjno
 */

class peruano
{
    string nombre;
    int edad;

    peruano()
    {
        persona peru  = new persona("juan", 23); // esto pasa porque el constructor de la clase persona esta pulico
        peru.hablar("hola"); // si la clase hablar no fuera publica no la pudiera utilizar
        
    }
}


//HEREANCIA
//nos permite hacer una calse con esos atribuots y metodos

class animal
{
    // a esto se le llama propiedad automatica
    // imaginatelo como un metodo que no se llama con () sino que escriviendo su nombre y que sucnado la llammas y usas = le estas asignando un valor y cuando la llamas pues te la meustra 
    //un metodo de toda la vida
    public string nombre {get; set;}

    public void comer()
    {
        Console.WriteLine($"{nombre} esta comientdo");
    }
}

class perro : animal  // esta es la forma en la que podemos declarrar que perro es una clase hija de animal 
{
    public void ladrad()
    {
        Console.WriteLine("guaos");
    }
}

class principal
{
    public void algo()
    {
        perro azul = new perro();
        azul.nombre = ";algo";
        azul.comer();
    }
}




//TIPO DATETime

class fechas
{
    public void algo()
    {
        DateTime fechaActual = DateTime.Now; // asi se obtiene la fecha actual
        Console.WriteLine(fechaActual);
        DateTime fechaEspecifica = new DateTime(2025, 12, 25); // asi se crea una fecha especifica
        Console.WriteLine(fechaEspecifica);
        TimeSpan diferencia = fechaEspecifica - fechaActual; // asi se calcula la diferencia entre dos fechas
        Console.WriteLine($"Faltan {diferencia.Days} dias para navidad");
        DateTime hoy = DateTime.Today;
        Console.WriteLine(hoy.ToShortDateString()); // esto es para ver la fecha sin la hora solo la fecha 
        Console.WriteLine(hoy.ToLongDateString()); // es lo mismo pero en lugar de 23/4/2334/ te lo dice osea sabado , 2 mayo , 2092
        Console.WriteLine(hoy.ToShortTimeString()); // esto esp ara ver la hora 
        Console.WriteLine(hoy.Year); // esto es para ver el ano
        Console.WriteLine(hoy.Month); // esto es para ver el mes
        Console.WriteLine(hoy.Day); // esto es para ver el dia
        Console.WriteLine(hoy.Second); // esto es para  ver los segundos 
        Console.WriteLine(hoy.Minute); // esto es par aver los miniutos 
        Console.WriteLine(hoy.DayOfWeek); // esto es para ver el dia de la semana
        Console.WriteLine(hoy.DayOfYear); // dia del ano (de los 365)
        Console.WriteLine(hoy.ToString("tt")); // esto tira si es pm o am
        Console.WriteLine(hoy.AddDays(5)); // para anadir dias 
        Console.WriteLine(hoy.AddYears(-7)); // para anadir anos y muchas cosas mas con otros puntos add`
        DateTime FechaEspecifica = new DateTime(2034, 3, 3); // anio mes dia 
        //TimeSpan diferencia = fechafin - fechainicial
        //Console.WriteLine(diferencia.Days);
        //esto ulitmo es para ver la diferencia de dias puedes poner que sea meses anios y asi 
    }
}

// MANEJO DE ERRORS
class errores
{
    public void algo()
    {

        //try catch es la forma ma vasica pues es try el codigo que peude dar erro y el catch es el que pasara si da error
        try
        {
            int valor1 = 10, valor2 = 0;
            int resultado = valor1 / valor2; // esto dara error porque no se puede dividir por cero

        } catch(Exception x) // que pasa con el  x es la forma que tenemos de capturar el error y ver que error es
        {
            Console.WriteLine("se produjo un error: " + x.Message); // x.message es para ver el mensaje de error 
            Console.WriteLine(x.ToString()); // esto es para ver todo el error con su traza y todo (mas detallado (te dice hacta la linea en la que paso)
            Console.WriteLine(x.StackTrace); // esto es para ver la traza del error (la linea en la que paso)   
            Console.WriteLine(x.GetType()); // esto es para ver el tipo de error que es
            Console.WriteLine(x.ToString()); // esto es para ver todo el error con su traza y todo (mas detallado (te dice hacta la linea en la que paso)
         

        }

        Console.ReadKey();
    }
}
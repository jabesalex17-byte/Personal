// MANEJO DE ARCHIVOS EN C#


//la clase file sirve  para hacer copiar sobre escribir archivos etc
// sirver para los siguientes  tiipos de archivos
/* .txt.json.xml.csv.log.ini.dat.bin.exe (copiar, mover, borrar)
imágenes (.png, .jpg)
 */
// una variable el nombre del archivo

//(buscalo en C:\Users\jabes\source\repos\Curso de c#  parte  4\Curso de c#  parte  4\bin\Debug\net8.0

//LEER  UN ARCHIVO
//string texto = File.ReadAllText("nombre_del_archivo.txt");
//Console.WriteLine(texto);

//LEER POR  LINEAS
//string[] lineas = File.ReadAllLines("datos.txt");

//SOBREESCRIBIR  UN ARCHIVO (Y  SI NO EXISTE LO CREA)
//string ruta = "archivo1.txt";
//File.WriteAllText(ruta, "hola muensdfdsdfsdfo");

//AGREGAR  TEXTO SIN  BORRARR EL  ANTERIRO

//File.AppendAllText("datos.txt", "allgo");

//CREAR UN ARCHIVO
//File.Create("archivo.txt").Close();

//ELIMINAR UN ARCHIVO
//File.Delete("nombredelarchivo.txt");

//COPIAR UN ARCHIVO
//File.Copy("origen.txt", "nombredelacopia.txt", true); //true o false  es si se podra sobre escribir  esa  copia  osea  si creasr  esa  copia  y  vuelves a ejecutar  esa  copia  si ess  false  va  a dar  error de que ya existe  pero si es true  la va a sobre escrivir

// CREAR  UN  ARCHIVO EN  UNA RUTA ESPECIFICA 

//string rutaa = @"C:\Users\Public\archivo.txt";

//File.WriteAllText(rutaa, "hasdfl;aksjdflksdjf");


// TIPO DE DATO  ENUM
//segun chatgpt  dice es un  tipo de dato que  sirve para representar un conjunto fijo de  alores  constantes con nombre  para evitar  usar  numeros y hacer el codigo mas  legible y seguro


using System.Drawing;

class  enumerda{
    //  has los enum  mejor fuera de metods  y clasers se  puede  pero   es  mas  coomplejo xd (investivga)
    // o  fuera  de todas las clases tambien se puede
    enum dias
    {
        // por  defecto  tinene numeros  asignados  0,1,2,3....
        lunes, martes, miercoles =4                
        // se pueden definir tawmbien  como hice  con el miercoles
    }
    static  void Main(string[] args)
    {   // para  acceder a las  varaibles
        dias hoy = dias.lunes;
        Console.WriteLine(hoy);
        //para llevarlo a numero 
        Console.WriteLine((int)hoy);
        //esto es para verificar si existe o no
        bool existe = Enum.IsDefined(typeof(dias), 2);
        Console.WriteLine(existe);
    }
}


//RAMDOM
// sirve principalmentee par ageneral  numeros  per  puede  srvir  para  otrasss cosas  como  para   eligir  en  una listaa un elementeo  aletolrio

class ramdommdP
{
    void algo()
    {
        Random random = new Random();
        int numero = random.Next(1, 11); // 1 a 10
    }

    // se pueden hacer funciones  taambien
    int numerorandom()
    {
        Random rng = new Random();
        return rng.Next(1, 101);
    }


    // y esos son algnos  de sus  usos
    void elegir_aleatio()
    {
        string[] premios = { "Oro", "Plata", "Bronce" };

        Random rnd = new Random();
        string premio = premios[rnd.Next(premios.Length)];

    }
}
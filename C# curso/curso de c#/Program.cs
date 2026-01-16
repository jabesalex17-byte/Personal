//OUTPUT
Console.WriteLine("Hola, mundo!");
Console.WriteLine(3245);
Console.WriteLine(59 + 233);
Console.Write("alskdfjalsdjf"); // esto imprime sin salto de linea



//TIPO DE DATOS
int x = 1; // enteros
double y = 2.5; // decimales
bool esVerdadero = true; // verdadero o falso
char letra = 'A';  // un solo caracter
string texto = "Hola"; // cadena de texto
float numeroDecimal = 3.14f; // decimal de precision simple
object cualquierCosa = "Puede ser cualquier cosa"; 
DateTime fecha = DateTime.Now; // fecha y hora
decimal dinero = 100.50m; // es para datos mas precisa
var algo = "laskdjf"; // esto es para que puedes poner cualquier tipo de dato y el compilador lo infiere


// VARIABLES
// como en cualquier lenguaje sirve parar contener informacion 
// para declarar una variable se usa la siguiente sintaxis
// tipo nombre = valor;
int numero = 10;
string nombre; // se pueden dejar sin inicializar osea son ningun valor asignado
//para modificar el valor de una variable solo se le asigna un nuevo valor
numero = 20;


// CONSOLE.READKEY ()
// detiene el programa hasta que el usuario presione una tecla


// IMPUT
// pedirle informacion al usuario
Console.WriteLine("Ingresa tu nombre: ");
string nomobre = Console.ReadLine() ; // esto espera a que el usuario ingrese algo y siempre devuelve un string
Console.WriteLine("intrudusca su edad");
int edad = Convert.ToInt32(Console.ReadLine()); // convierte la cadena de texto a un numero entero
Console.WriteLine("ingrese su sueldo");
double sueldo = Convert.ToDouble(Console.ReadLine()); // convierte la cadena de texto a un numero decimal


// CONCATENACION
string saludo = "Hola";
int edad87 = 25;
Console.WriteLine(saludo + ", tienes " + "\n" + edad87 + " años."); // concatenacion con + para sumar varial // el \n es un salto de linea 
Console.WriteLine($"{saludo}, tienes {edad87 + 34} años."); //esto es para poner variables dentro de un string con $ y llaves {}

/*
 esta es otra forma de hacer comentarios
 mas de una linea y sabes quye se usa para invalidad codico
*/

// CONSTANTES
// son variables que no cambian su valor
const int EDAD_MAXIMA = 120;


// CASTING
// convertir de un tipo de dato a otro
//existen dos tipos de casting implicito y explicito
// casting implicito es cuando el compilador lo hace automaticamente

int numeroEntero = 10;
double decial = numeroEntero; // el compilador convierte el int a double automaticamente
Console.WriteLine(decial); // imprime 10

// casting explicito es cuando el programador lo hace manualmente
double numeroDecimals = 9.78;
int numeroEntero2 = (int)numeroDecimals; // lo ponemos conel tipo de dato entre parentesis antes de la variable
Console.WriteLine(numeroEntero2); // imprime 9

char letras = 'f'; // cadad letra tiene su valor numero en la tabla ascii
int valorasccii = (int)letras; // convierte la letra a su valor numerico en ascii
Console.WriteLine(valorasccii);

string palabra = "123";
int numero2 = Convert.ToInt32(palabra); // convierte la cadena de texto a un numero entero



//OPERADORES ARITMETICOS
int suma = 5 + 3; // suma
int resta = 5 - 3; // resta
int multiplicacion = 5 * 3; // multiplicacion
double division = 5.0 / 3.0; // division
int modulo = 5 % 3; // modulo o residuo  //lo divide el resultado lo lleva a entrero y y lo multiplica y lo resta al original
int incremento = 5;
incremento++; // incremento en 1 // no lo puedes hacer en la declaracion   
int decremento = 5;
decremento--; // decremento en 1

// OPERADORES DE CONPARACION
bool esIgual = (5 == 3); // igual a
bool esDiferente = (5 != 3); // diferente a
bool esMayor = (5 > 3); // mayor que
bool esMenor = (5 < 3); // menor que
bool esMayorOIgual = (5 >= 3); // mayor o igual que
bool esMenorOIgual = (5 <= 3); // menor o igual que


// ASIGNAR DOS POSIBLES A LA MISMA VARIABLE

string  RESULTADO = (2 > 3) ? "ES MAYOR" : " ES MENOR"; // si la condicion es verdadera asigna el primer valor si es falsa el segundo


// OPERRADORES LOGICOS
bool and = (true && false); // FALSO // AND  ambas condiciones deben ser verdaderas
bool or = (true || false);// TRUE // OR  al menos una condicion debe ser verdadera
bool not = !true; // NOT //FALSE invierte el valor de la condicion

// IF ELSE IF  ELSE
int numeroUsuario = 10;
if (numeroUsuario > 0)
{
    Console.WriteLine("El numero es positivo");
}
else if (numeroUsuario < 0){
    Console.WriteLine("El numero es negativo");
}
else{
    Console.WriteLine("El numero es cero");
}

// SWITCH CASE
int dia = 3;
char diaChar = 'd'; // se puede evaluar un char tambien
switch (dia)
{
    case 'd': // se puede usar char
        Console.WriteLine("Lunes");
        break;
    case > 23: // se puede poner una operacion limple
        Console.WriteLine("Martes");
        break;
    case 3:
        Console.WriteLine("Miercoles");
        break;
    case 4:
        Console.WriteLine("Jueves");
        break;
    case 5:
        Console.WriteLine("Viernes");
        break;
    case 6:
        Console.WriteLine("Sabado");
        break;
    case 7:
        Console.WriteLine("Domingo");
        break;
    case 8:
        Console.WriteLine("Dia no valido");
        break;
    default:
        Console.WriteLine("Dia no valido");
        break;
}

// otra forma de usar el switch case con expresiones 
int nota = 90;
string resultadoNota = nota switch
{
    >= 90 => "A",
    >= 80 => "B",
    >= 70 => "C",
    >= 60 => "D",
    _ => "F", // el - es como un default

};

// BUCLES WHILE
int contador = 0;
while(contador < 5)
{
    Console.WriteLine("Contador: " + contador);
    contador++;
}

//BUCLE FOR 
for(int i = 0; i < 5; i+= 2)
{
    Console.WriteLine("i: " + i);
}


//BUCLE DO WHILE
int contador2 = 0;
do
{
    Console.WriteLine("Contador2: " + contador2);
    contador2++;
} while (contador2 < 5);

//BREAK EN LOS BUCLES
for(int i = 0; i < 10; i++)
    {
    if(i == 5)
    {
        break; // sale del bucle cuando i es 5
    }
    Console.WriteLine("i con break: " + i);
}
// CONTINUE EN LOS BUCLES
for(int i = 0; i < 10; i++)
    {
    if(i % 2 == 0)
    {
        continue; // salta la iteracion cuando i es par
    }
    Console.WriteLine("i con continue: " + i);
}


//MATH  //sirve para hacer operaciones matematicas mas complejas

//potencia
int numero88 = 2;
Console.WriteLine(Math.Pow(numero88, 3)); // es elevado a la 3 
//raiz cuadrada
Console.WriteLine(Math.Sqrt(232)); // raiz cuadrada de 232
//valor absoluto
Console.WriteLine(Math.Abs(-45)); // valor absoluto de lo lleva a positivo
//redondeo
Console.WriteLine(Math.Ceiling(34.3)); //35 siempres ahciua arriba
Console.WriteLine(Math.Floor(32.3)); //32 siempre hacia abajo)
Console.WriteLine(Math.Round(23.5)); // es el redondeo normal de 5 para arriba
//numero maximo y minimo
Console.WriteLine(Math.Max(23, 45)); //45
Console.WriteLine(Math.Min(23, 45)); //23
//valor de pi
Console.WriteLine(Math.PI); //3.1415926535897931

// calcular el area de un circulo
Console.WriteLine("introduscal el radio de su circulo:");
double radio = Convert.ToDouble(Console.ReadLine());
double areaCirculo = Math.PI * Math.Pow(radio, 2);



//STRINGS
//@
string texto_grande = @"lo que hace esto es que los enter cuando le damos los toma como un salto de linea
cada vez que le damos enter ";
Console.WriteLine(texto_grande);
// metodos comunes de los strings
string ejemploString = "  Hola Mundo  ";
Console.WriteLine(ejemploString.Length); // longitud del string
Console.WriteLine(ejemploString.ToUpper()); // convierte a mayusculas
Console.WriteLine(ejemploString.ToLower()); // convierte a minusculas
Console.WriteLine(ejemploString.Trim()); // elimina espacios al inicio y al final
Console.WriteLine(ejemploString.Replace("Mundo", "C#")); // reemplaza una parte del string
Console.WriteLine(ejemploString.Substring(2, 4)); // obtiene una subcadena desde el indice 2 con longitud 4
Console.WriteLine(ejemploString.IndexOf("Mundo")); // obtiene el indice de la primera aparicion de una subcadena
Console.WriteLine(ejemploString.Contains("Hola")); // verifica si el string contiene una subcadena
Console.WriteLine(ejemploString.StartsWith("  Ho")); // verifica si el string empieza con una subcadena
Console.WriteLine(ejemploString.EndsWith("do  ")); // verifica si el string termina con una subcadena


//ARRAY
int[] numeros = new int[5]; // declara un array de enteros con 5 elementos // tiene que ser espesificamente 5
numeros[0] = 10; // asi se asigna un valor a un elemento del array de la manera manual 
int[] ints = {1, 2, 3, 4, 5}; // asi se declara ya con valores // esto no tienes que espesificar el tamañ
Console.WriteLine(ints[2]); // accede al tercer elemento del array

//existe siertas funciones para los arrays 
Array.Sort(ints); // ordena el array
Array.Reverse(ints); // invierte el array
Array.IndexOf(ints, 3); // busca el indice de un elemento
Array.Clear(ints); // sierver para limpiar el array no para eliminarlo
Array.Resize(ref ints, 10); // cambia el tamaño del array
Array.Fill(ints, 0); // llena el array con un valor especifico en este caso 0
string[] nombre45 = {"Ana", "Luis", "Carlos"};
string texto2 = string.Join(", ", nombre45); // quiero un texto que tenga el array nombres completo separado por comas 
int[] numeross = {1, 2, 3, 4, 5};
int total = numeross.Sum(); // suma todos los elementos del array
var promedio = numeross.Average(); // calcula el promedio de los elementos del array
var mayoresque2 = numeross.Where(x => x > 12).ToArray(); // filtra los elementos mayores que 2 y los convierte a un nuevo array // esto debuelve un array
int[] cantidades = (int[])numeross.Clone(); // clona el array a uno nuevo

int[] array1 = [12, 23, 432, 23, 234];
int[] array2 = [23, 543, 63, 634, 634];  // para sumar dos array tienen que ser de la misma lonjitud
int cantidad = array1.Length;
int[] arraytotal = new int[cantidad];
for (int i = 0; i < array1.Length; i++){
    arraytotal[i] = array1[i] + array2[i];
}







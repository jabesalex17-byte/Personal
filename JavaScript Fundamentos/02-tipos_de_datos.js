//TIPOS DE DATOSS

// Datos primitivos son los datos basicos que solo representan un solo valor

//string (cadena de testo "esto ministro")

let nombre = "gistavo"
let apellido = "ministrosdis"

//Numeros (numbers)
let edad = 23
let altura = 23.4

//Booleanos (true or false)
let esta_vivo = true
let win = false 

//undefined (es crear una variable pero que no le ponesmos un valor)

let undefinedvalue
let yo
console.log(yo)

//null (intencionalmente no tiene valor)
let nullvalue = null
console.log(nullvalue)

/*
let a;
let b = null;

console.log(a == b);  // ✅ true (comparación suelta)
console.log(a === b); // ❌ false (comparación estricta: distintos tipos)

(en js cuando comparas algo lo transforma automaticamente osea 3 =='3' esto tira true porque lo trasnforma asicomo el false y 0 pero si pones === no los transforma)
*/



//symbol (valores unicos)
let simbolo = Symbol("jabes eser")
 
//biging( es un numero muy grande)

let bignum = BigInt(3333333333333333333334242424235)
//otra forma de representarlo es con n al final
let bignum2 = 234234923402948209484387502975n

console.log(bignum)

//PRUEVAS
let numero = 12, fecha ="alsdf"
console.log(numero,fecha) 

// COMO MUESTRO O SE QUE TIPO DE DATO ES ALGO USO EL typeof variable
// odviamente esto es para mostrarlo por pantalla

console.log(typeof numero)
console.log(typeof bignum)
console.log(typeof nullvalue) // esto tira objeto

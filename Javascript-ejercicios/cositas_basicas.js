// 1 escribe un comentario en una linea 
//esto

//2 escribe un comentario en varias lineas 

/*
esto por
ejemplo
*/

// 3 declara varaiables con vallores aasociados a todos los datos de tipo primitivo

let nombre = "jabes"
let number = 23
let vivo = false
let id = Symbol("id")
let numeromas = 23092740237402012374n
//let numrogrande = Bygint(29749742974924273)
let nada
let menos = null

// 4 imprime por consola el valor de todas la variables 

console.log(nombre, number, vivo, id, numeromas,nada,menos)  

//5 imporime por consola el tipo de todas las varables

console.log(typeof nombre, typeof number, typeof vivo, typeof id , typeof numeromas, typeof nada, typeof menos)

// 6 modifica el valor de las variables por otras de lmismo tipo

nombre = "hola"
number = 234
vivo = true
id = Symbol("alskdjf")
numeromas = 23492429742874924n
/*
nombre =
nombrew = 234
console.log(typeof nombre) tira number porque lo interpreta como sifuera una linea y si pones ; da error
*/

console.log(typeof nada, typeof menos)
//nada ya vacio no se puede cambiar a algo de un mismo tipo
//meons lo mismo con null

// 7 modofica los valores de los variables por otros de distinto tipo

nombre = 23
number = false
vivo = Symbol("nose")
id=203498743987249827743n
numeromas = null
nada = 23
menos = "holamundo"

console.log(typeof nombre)

// 8 declara constantes con valores asociados a todos los tipos de datos primitivas

const nombe = "hola", numbedr =23, vivoss = false, idsd =Symbol("aslkf"), numeorde = 9274927429742974n , noono = null , algo= "una const no puede ser indefinida"

//9 madifica los valores de las constantes 

// no se puede

// 10 comenta las lines de produzcan algun tipo de error al ejecutarse

//nombe= 23
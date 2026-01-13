//OPERADOES

// OPERADOES ARICMETICOS

let a = 3
let b = 23
console.log(a + b)
console.log(a - b)
console.log(a / b)
console.log(a * b)

console.log(a % b) //resto modulo etc ya te la sabes
console.log(a ** b) // exponente 

a-- //decremetno
b++ //incremeto

console.log(a, b)

let h = 2

console.log(h++) //igual que en c++ el orden si importa
console.log(h)

//operadores de asignacion 

let varaible = 2 // = asigna un valor no me digas
varaible += 2// puede ser =- =/ =* etc
console.log(varaible)


//operadores de comparacion
console.log(a > b)
console.log(a < b)
console.log(a == b)
console.log(a >= b)
console.log(a === b)// no solo compara si son lo mismo sino tambie que sean del mismo tipo
console.log(a != b)
console.log(a !== b)
console.log("" == 0)
console.log(!(5 > 10 && 15 > 20))

// Operadores lógicos

// and (&&)
console.log(5 > 10 && 15 > 20)
console.log(5 < 10 && 15 < 20)
console.log(5 < 10 && 15 > 20)
console.log(5 > 10 && 15 > 20 && 30 > 40)

// or (||)
console.log(5 > 10 || 15 > 20)
console.log(5 < 10 || 15 < 20)
console.log(5 < 10 || 15 > 20)
console.log(5 > 10 || 15 > 20 || 30 > 40)

console.log(5 > 10 && 15 > 20 || 30 < 40)

// not (!)
console.log(!true)
console.log(!false)
console.log(!(5 > 10 && 15 > 20))
console.log(!(5 > 10 || 15 > 20))

//operadores ternarios
//es como una condicion evalua algo y si esse algo es true hace algo y si es false hace otra cosa 

const vivo = false

vivo ? console.log("estas vivo") : console.log("no es tas vivo")
//variaba ? en caso de ser true esto : en caso de ser false esto\

console.log((true && true) || false)





// instanceof 
// tira true o false y un objeto viene de una clase incluso sdi lo eredo 
class Jugadores {
    constructor(nombre) {
        this.nombre = nombre;
    }
}

class Futbolistas extends Jugadores {
    constructor(nombre, posicion) {
        super(nombre);
        this.posicion = posicion;
    }
}

let jabes = new Futbolistas("Jabes", "delantero");

console.log(jabes instanceof Futbolistas); // true — es instancia de Futbolistas
console.log(jabes instanceof Jugadores);   // true — también instancia de la clase padre Jugadores
console.log(jabes instanceof Object);      // true — porque todo objeto hereda de Object

let otro = new Jugadores("Luis");
console.log(otro instanceof Futbolistas);  // false — porque no es instancia de la subclase

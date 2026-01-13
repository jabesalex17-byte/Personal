// clases 
// crear plantillas de objetos definimos las propiedades de objetos  pero sin defininrle los datos 

class persona {
    constructor(nombre, age, apodo, numero, posicion){
        this.nombre = nombre
        this.age = age
        this.apodo = apodo
        this.numero = numero // se pone lo mismo por buena practica mas que por otra cosa pudes oner this.al;sdkjfal;kdf = numero
        this.posicion = posicion
    }
}

// sintaxis

let jugador1 = new persona("jabes", 23, "el 9 ", 7, "MCO")
let jugador2 = new persona("elvis", 22, "mbappe", 5, "DC")
console.log(jugador2)
console.log(jugador2)
// ves es como crear una plantilla 


//valres por defecto

class defaulpersona{
    constructor( banca = true, posicion = null, alias = null){
        this.banca = banca
        this.posicion = posicion
        this.alias = alias
    }
}

let nuevo_jugador = new defaulpersona(false, "DFC", "el nino") // los valores se meten por orden maestro 
let nuevo_jugador2 = new defaulpersona()
console.log(nuevo_jugador)
console.log(nuevo_jugador2)

//acceso a propiedades 
console.log(nuevo_jugador.banca)

nuevo_jugador.goles = 3

console.log(nuevo_jugador)

//fucniones en clases

class jugadorstats{
    constructor(goles, asistencias, minutos_jugados){
        this.goles= goles
        this.asistencias = asistencias
        this.minutos_jugados = minutos_jugados
    }

    partido(){
        console.log("jugando partido")
    }
}

let jugadr11 =  new jugadorstats(2,4,90)
jugadr11.partido()


//propiedades privadas

class jugadorstatsprivadas{

    #goles // la defines lo que quies que sea privado 

    constructor(goles, asistencias, minutos_jugados){
        this.#goles= goles // asi mismo lo llamas 
        this.asistencias = asistencias
        this.minutos_jugados = minutos_jugados
    }

    partido(){
        console.log("jugando partido")
        console.log(this.#goles)
    }
}

let jugador1privadas = new jugadorstatsprivadas(3,4,23)
console.log(jugador1privadas.goles) // nada fuera de esa funcion lo puede ver o acceder a ella 
//jugador1privadas.goles = 23 esto no es que esta modificando los gones la clase privada sino que esta haciendo otra clase publica llamadada goles tambien que si es publica 
jugador1privadas.partido()

// getters y setters

//para acceder pero no mofificar hacemos una funcion con el nombre
class persona27 {

    #nombre
    #age
    #apodo
    #numero
    #posicion
    #costo

    constructor(nombre, age, apodo, numero, posicion, costo){
        this.#nombre = nombre
        this.#age = age
        this.#apodo = apodo
        this.#numero = numero 
        this.#posicion = posicion
        this.#costo = costo
    }

    // esto para que solo se pueda ver 
    get nombre(){ 
        // le pones una fucion 
        return this.#nombre
    }
    //esto para qu9e solo se pueda modificar
    set costo(nuevocosto){
        this.#costo = nuevocosto

    }

    mostrar(){
        console.log(this.#costo)
    }
}

let nose = new persona27("jabes" , 25, "the las 9", 7, "MC", 45)
console.log(nose)
console.log(nose.nombre)
//console.log(costo(23))error
nose.mostrar()
nose.costo = 23
nose.mostrar()


// Herencia 

class animal {

    Constructro(nombre){
        this.nombre = nombre
    }

    sonido(){
        console.log("algo")
    }
}

class perro extends animal{ // el extends hace que herede la clase completa
    sonido(){
        //para vamos a decir que quieres a esa fucnion ponerle mas pues pones super para llamarla 
        // si no ponesmos esta funcion directamente sabes que lo ara porque la heredo de la de arribla que si creas otra con el mismo nombre va a tomar como priordad obviamente a esta de aqui y no la de arriba la superior 
        // pues para eso es que la llamamos para hacer la de arriba ya pues ya anadirle algo 
        // super.sonido() // esto es par aque haga la operacion de arriba
        console.log("perro sonido")

    }
    correr(){
        console.log("corriendo")
    }
}

class pex extends animal { // el extends hace que herede la clase completa

    constructor(nombre, tamano){
        super(nombre) // esto es par aque use el nombre de la clase de arribal de arriba es como si lo estuvieramos sobreescribiendo 
        this.tamano = tamano
    }
    nadar (){
        console.log("nada")
    }
}
let azul = new perro("azul")
azul.correr()
azul.sonido() 
let eny = new pex("eny", 3)
eny.sonido()



// metodos estaticos 


class suma{
    static sumaaa( a , b ){
        return a + b
    }
}

//let clase = new suma()
//podemos llamar a las clases estaticas con solo ponerlo y ya me entendes sin intstancias
console.log(suma.sumaaa(2 , 3))
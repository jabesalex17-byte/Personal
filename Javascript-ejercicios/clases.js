// 1. Crea una clase que reciba dos propiedades
class jugador{
    constructor(nombre = "", edad = 0){
        this.nombre = nombre
        this.edad = edad
    }
}

let persona = new jugador("elvis", 23)
// 2. Añade un método a la clase que utilice las propiedades

class jugador2{

    static pago(dinero){
        return dinero *2
    }

    constructor(nombre = "", edad = 0){
        this.nombre = nombre
        this.edad = edad
    }

    partido(){ console.log("jugando partido")}
}

let persona2 = new jugador2("jabes", 22)
persona2.partido()
// 3. Muestra los valores de las propiedades e invoca a la función

persona2.partido()
console.log(persona2.nombre , persona2.edad)
// 4. Añade un método estático a la primera clase
console.log(jugador2.pago(23))
//consele.log(persona.pago(23)) da error
// solo se puede llamando a la clase 

// 5. Haz uso del método estático
console.log(jugador2.pago(2342))

// 6. Crea una clase que haga uso de herencia
class  jugador3 extends jugador2 {
    constructor(nombre, edad , posicion){
        super(nombre,edad)
        this.posicion = posicion
    }
    partido(){
        console.log("banca")
    }
}
let persona4 = new jugador3("nombre", 32, "MCO")
// 7. Crea una clase que haga uso de getters y setters
class datos {

    #nombre
    constructor(nombre ="", edad= 1){
        this.#nombre = nombre
        this.edad = edad
    }

    setnombre(nombre){
        this.#nombre = nombre
    }
    getnombre(){
        return this.#nombre
    }
    

}

let alguien = new datos("jabes", 23)
console.log(alguien)
alguien.setnombre("elvis")
console.log(alguien)
console.log(alguien.getnombre())

// 8. Modifica la clase con getters y setters para que use propiedades privadas
//ya arriba
// 9. Utiliza los get y set y muestra sus valores
//ya linia 67-71
// 10. Sobrescribe un método de una clase que utilice herencia 
persona4.partido()
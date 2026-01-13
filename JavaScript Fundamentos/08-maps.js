//maps para  poner lago que tenga una clave y su valar

let mapa = new Map()

// darle valores

mapa = new Map([
    ["name", "jabes"],
    ["edad", 32],
    ["nose que", null]
])

console.log(mapa)

// metodos

//set 

mapa.set("alias" , "el 9")// anade esta clave y su valor al final
console.log(mapa)
mapa.set("edad", 2) // en caso de que lla coincida uno clave actualiza su valor
console.log(mapa)
mapa.set("alias", "el 9") // so se hace de nuevo pues pasa lo mismo lo actualiza al mismo valor xd
console.log(mapa)

// get 

console.log(mapa.get("alias")) // optenemos el valor de la clave
console.log(mapa.get("sdlkf"))// indefinido

// has 

console.log(mapa.has("aliaasds")) // true o false si existe o no algo
 

// delete
mapa.delete("nose que")// adivinaste lo elemina y vusca la clave
console.log(mapa)

//size
console.log(mapa.size)// el tamano

// clear

//mapa.clear() // esto es para eliminarlo 


//propiedad
console.log(mapa.keys())// nos tira todas las keys
console.log(mapa.values()) // nos tira los valores 
console.log(mapa.entries()) // nos tira todo el listado

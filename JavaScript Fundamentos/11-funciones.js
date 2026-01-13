// funciones 


//fucnion basica sin pasaremos y sin argumentso 
function noseque(){
    console.log("nose que")
}

for (let x = 0; x <= 5; x++){
    noseque()
}

// con parametros 
function saludo (nombre){
    console.log(`hola ${nombre}`)
}
saludo("jabes")

// fucniones anonimas 
// que no tienen un nombre definido
// hay que asignarcelo a una variable o una constante
const anonima = function(nombre){
    console.log(`hola  nose que asd ${nombre}`)
}
anonima('nose que')

//array functions 
// otra forma de escribir funciones 
let algo = (name) => {
    console.log(`nose ${name}`)
}

algo("jabes")

let algo2 = (name) => console.log(`nose ${name}`)

algo2("jabes")

// parametrso

function suma (a, b){
    console.log( a + b)
}

suma(2, 4)

// default para que no tener porblemas en cado de que no se ponga nada
// tan easy como ponerne un valor por defecto y ya maestro no hay nada del otro mundo en eos 

function sumaa(a = 0, b = 0){
    console.log( a + b)
}
sumaa(2)
sumaa()
sumaa(b= 2)


// retorno 

function multiplicacion (a , b){
    return a * b
}
let multiplicaciones = multiplicacion(2,4)
console.log(multiplicaciones)


// fucniones aniddas

function externa(){
    console.log("externa")
    function interna(){
        console.log("interna")
    }
interna()
}
externa()
//interna() solo se puede llamar dentro de la funcion


// fucion de orden superior 
// funcion3es que reciben como argumets una funion

function nose (fun, param, param2){
    fun(param, param2)
}

nose(sumaa , 25, 3)

//foreach // otra forma del una iteracion normal xd

array = [1,2,3,4,5]
array.forEach((valor) => console.log(valor))

searray = ["nose que ", "jabdes", "lumi", "elvis"]
// otraforma de hacerlo 
searray.forEach(function (valores){
    console.log(valores)
})

// inportamet de estaforma no se pueden detener con un brake por ejemplo 
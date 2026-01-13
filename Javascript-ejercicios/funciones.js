// 1. Crea una función que reciba dos números y devuelva su suma
function suma( a = 0 , b = 0){
    console.log(a + b)
}

// 2. Crea una función que reciba un array de números y devuelva el mayor de ellos
let numeros = [1,2,3,4,5,6]

function mayor(numeros){
    let mayores = 0
    for (let x of numeros){
        if (x >= mayores){
            mayores = x
        }
    }
    console.log(mayores)
}
mayor(numeros)

// 3. Crea una función que reciba un string y devuelva el número de vocales que contiene
let palabras = "makei verare nosdfsdf qeffjlasnvoixcvj"
let constador = 0
function vocal ( palabras){
    for (let j of palabras){
        if (j == "a" || j == "e" || j == "i" || j == "u" || j == "o"){
            constador += 1
        }
    }
    console.log(constador)
}
vocal(palabras.toLowerCase())

// 4. Crea una función que reciba un array de strings y devuelva un nuevo array con las strings en mayúsculas
let palabranoseque = "aeeeeESDFKLASlkjsfcxljcvsakkkk"

function mayusculas(nose){
    let nueva = nose.toUpperCase()
    return nueva
    
}
console.log(mayusculas(palabranoseque))
// 5. Crea una función que reciba un número y devuelva true si es primo, y false en caso contrario

function primo(num){
    let esprimo = true
    let prueba = num - 1
    while( prueba > 0){
        if (num % prueba == 0 && prueba != 1){ // tambien puede poner que prueba > 1 para evitar dividir en tre uno y no tener que poner dos condiciones en el if 
            esprimo = false

            break;
        }
        prueba--

    }

    console.log(esprimo)
}
primo(16)


// 6. Crea una función que reciba dos arrays y devuelva un nuevo array que contenga los elementos comunes entre ambos
let Array1 = [1,2,3,4,5,6]
let Array2 = [3,4,5,6,7,8,7,8]
function existe(paran1, paran2){
    let newarray = []
    
    for (let x of paran1){
        if (paran2.includes(x)){
            newarray.push(x)
        }
    }

    console.log(newarray)
}
existe(Array1, Array2)
// 7. Crea una función que reciba un array de números y devuelva la suma de todos los números pares
let numeross = [1,2,3,4,5,65,67,7,452,34234,52345,14]
function suma(para){
    let suma = 0
    for (let x of para){
        if (x % 2 == 0){
            suma += x
        }
    }
    console.log(suma)
}
suma(numeross)

// 8. Crea una función que reciba un array de números y devuelva un nuevo array con cada número elevado al cuadrado
let aaaaa = [1,2,3,4,5,6]
function cuadrado (numerossss){
    let n = []
    for (let h of numerossss){
        n.push(h ** 2)
    }
    console.log(n)
}
cuadrado(aaaaa)
// 9. Crea una función que reciba una cadena de texto y devuelva la misma cadena con las palabras en orden inverso
function invercion(palabla){
    let inverter = ""
    for (let y = 0 ; y < palabla.length; y++){
        inverter += palabla[palabla.length - 1 - y]
    }
    console.log(inverter)
}
invercion("hola mundo")

// 10. Crea una función que calcule el factorial de un número dado

function factorial(n){
    let multi = n - 1
    while(multi > 0){
        n *= multi
        multi--
        
    }
    console.log(n)
}
factorial(5)

// 5x4x3x2x1
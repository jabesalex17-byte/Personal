// 1. Imprime por consola tu nombre si una variable toma su valor
let nombre = "SASD"

if (nombre){
    console.log(nombre)
}

// 2. Imprime por consola un mensaje si el usuario y contraseña concide con unos establecidos
let nombres = "jabes", contra = "123"
nombres == "jabes" && contra == "123" ? console.log("bienvenido"):console.log("quien eres")
// 3. Verifica si un número es positivo, negativo o cero e imprime un mensaje
let num = 2
if (num > 0){
    console.log("tu numero es positivo")
} else if(num < 0){
    console.log("tu numero es negativo")
} else {
    console.log("tu numero es negativo")
}
// 4. Verifica si una persona puede votar o no (mayor o igual a 18) e indica cuántos años le faltan
let edad = 23
edad >= 18 ? console.log("puedes votar") : console.log ("no puedes votar")
// 5. Usa el operador ternario para asignar el valor "adulto" o "menor" a una variable
let variable
false ? variable = 13 : variable = 23
console.log(variable)
//    dependiendo de la edad 

// 6. Muestra en que estación del año nos encontramos dependiendo del valor de una variable "mes"
let mes= "enero";

switch(mes){
    case"enero":{
        console.log("estomos en esa estacion")
        break
    }

    case"febrero":{
        console.log("estamos en noviesf")
        break
    }
}

// 7. Muestra el número de días que tiene un mes dependiendo de la variable del ejercicio anterior
switch(mes){
    case"enero":{
        console.log("30 dias no voy a hacer todo eso")
        break
    }
}

// switch

// 8. Usa un switch para imprimir un mensaje de saludo diferente dependiendo del idioma
let idioma = "english"
switch(idioma){
    case "english":{
        console.log("hi my name is gustavo you can tell me jabes")
        break
    }
    case "espanol":{
        console.log(" wasa")
        break
    }
}

// 9. Usa un switch para hacer de nuevo el ejercicio 6

// lo hice al revez

if (mes == "enero" || mes == "frevrero") {
    console.log("estacionc")
} else if (mes == "marso" || mes == " asdfaf") {
    console.log("lasjdf;aklsjfd")
}


// 10. Usa un switch para hacer de nuevo el ejercicio 7

// lo mismo a qui
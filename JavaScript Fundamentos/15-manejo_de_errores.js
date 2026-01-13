//exceptcion

// tratamiento de errores

//try-catch

let objeto
try{ // esy intenta hacer elste bloque y si da error da el catch
    console.log(objeto.nombre)
} catch{ // si da error cpues muestra esto ministro
    console.log("eroor");
}

//capturara el error

try{
    console.log(objeto.nombre)
}catch(error){
    console.log("el error es ", error.mensaje
    )
}

//finally

try{
    console.log(objeto.nombre)
}catch(error){
    console.log("el error es ", error.mensaje // si no ponemos el catch y solo ponemos el finally no tiene lojica
    )
} finally{
    console.log("esto siempre se ejecuta")
} 


//throw
function suma(a,b){
    if (typeof a !== "number" || typeof b !== "number"){
        console.log  ("a")
    }
    if (typeof a !== "number" || typeof b !== "number") {
        throw new TypeError("Esta operación sólo suma números") /// suelta el tipo de error
    }
    if (!Number.isInteger(a) || !Number.isInteger(b)) {
        throw new Error("Esta operación sólo suma números enteros") // eror normal 
    }
    if (a == 0 || b == 0) {
        throw new error_custon("Se está intentando sumar cero", a, b)
    }
    return a + b
}

console.log(suma(12,32))
// throw new Error("asi no es") // eror que lansamos nosotros no que esta mal nada es que esto es un erro que mandamos nosotrso



//captirar varios tipos de errores 

try{
    //console.log(suma(5.5, 12))
    console.log(suma("5.5", 12))
}catch(error){
    if( error instanceof TypeError){
        console.log("se ha producido un error de tipo:" , error.message)
    } else if (error instanceof Error){
        console.log("se ha producido un error:" , error.menssage)
    }
}


//crear excepciones personalizadas 

class error_custon extends Error{
    constructor(mensaje, a ,b){
        super(mensaje)
        this.a = a
        this.b = b 
    }

}

try{
    console.log(suma(0,32))
}catch(error){
    console.log("personlaizado", error.mensaje)
}




//error personalizado chagpt vecion 

// Definir clase que hereda de Error
class MiErrorPersonalizado extends Error {
    constructor(mensaje) {
        super(mensaje);         // Llama al constructor de Error con el mensaje
        this.name = "MiErrorPersonalizado"; // Cambia el nombre del error
        // Puedes agregar otras propiedades si quieres
    }
}

function ejemplo(valor) {
    if (valor < 0) {
        throw new MiErrorPersonalizado("El valor no puede ser negativo");
    }
    return valor;
}

//ejemplo(-2)

try {
    ejemplo(-5);
} catch (e) {
    if (e instanceof MiErrorPersonalizado) {
        console.log("Error personalizado atrapado:", e.message);
    } else {
        console.log("Otro error:", e.message);
    }
}



/*
| Error            | Descripción                                             |
| ---------------- | ------------------------------------------------------- |
| `Error`          | Error genérico base.                                    |
| `SyntaxError`    | Error de sintaxis, por código inválido.                 |
| `ReferenceError` | Variable o referencia no definida.                      |
| `TypeError`      | Valor no es del tipo esperado o uso incorrecto.         |
| `RangeError`     | Valor fuera de rango permitido (ej. números inválidos). |
| `EvalError`      | Error relacionado con `eval()` (poco usado hoy).        |
| `URIError`       | Error al usar funciones URI (encodeURI, decodeURI).     |
| `AggregateError` | Error que agrupa varios errores (para Promises).        |

*/
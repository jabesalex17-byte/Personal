// 1. Captura una excepción utilizando try-catch
try{
    console.log(a)
} catch{
    console.log("nose se puedo")
}
// 2. Captura una excepción utilizando try-catch y finally
try{
    console.log(a)
} catch{
    console.log("nose se puedo")
} finally {
    console.log("enything else?")
}

// 3. Lanza una excepción genérica

try{
    console.log(a)
} catch(error){
    console.log(error.message)
    //throw new Error("nose que nos ecuantos ta mal")
}

// 4. Crea una excepción personalizada
class mybad extends Error{
    constructor(mensaje){
        super(mensaje)
        this.name = "malas noticias"
    }
}

// 5. Lanza una excepción personalizada

try{
    console.log(a)
} catch(error){
    throw new mybad("que paso pa")
}
// 6. Lanza varias excepciones según una lógica definida
///soo easy
// 7. Captura varias excepciones en un mismo try-catch
function testError(valor) {
    if (typeof valor !== "number") {
        throw new TypeError("El valor debe ser un número");
    }
    if (valor < 0) {
        throw new RangeError("El valor no puede ser negativo");
    }
    if (valor === 0) {
        throw new Error("El valor no puede ser cero");
    }
    return valor;
}

try {
    console.log(testError("texto")); // lanza TypeError
    console.log(testError(-5));      // lanza RangeError
    console.log(testError(0));       // lanza Error
} catch (error) {
    if (error instanceof TypeError) {
        console.log("Error de tipo:", error.message);
    } else if (error instanceof RangeError) {
        console.log("Error de rango:", error.message);
    } else {
        console.log("Otro error:", error.message);
    }
}

// 8. Crea un bucle que intente transformar a float cada valor y capture y muestre los errores

// 9. Crea una función que verifique si un objeto tiene una propiedad específica y lance una excepción personalizada

// 10. Crea una función que realice reintentos en caso de error hasta un máximo de 10
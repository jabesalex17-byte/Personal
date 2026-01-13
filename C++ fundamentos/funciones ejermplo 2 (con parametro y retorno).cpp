//Jabes Estevez 2025-0905
#include <iostream>
using namespace std;
// lo primero es el tipo de retorno pero si no retorne ningun valor ponesmos void
// lo segundo es el nombre


// entre los parentecis ponemos los parametros
int multiplicar(int numeros){
    return numeros*2; // return devuelve un valor del tipo de la funcion
}

int main(){
    int retorno;
    
    retorno = multiplicar(1000); // asignamos el retrono a una variable 
    cout << retorno; // y claramento lo mostramos por pantalla
    
}
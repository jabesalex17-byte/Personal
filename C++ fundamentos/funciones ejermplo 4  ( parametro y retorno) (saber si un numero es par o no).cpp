//Jabes Estevez 2025-0905
#include <iostream>
using namespace std;
// lo primero es el tipo de retorno pero si no retorne ningun valor ponesmos void
// lo segundo es el nombre

int parono(int numero){
    if (numero % 2 == 0){
        return "el numero es par";
    } else {
        return " el numero es impar";
    }
}

int main(){
    int num;
    
    cout << "ingrese un numero";
    cin >> num;
    
    cout << parono(num);

    
}
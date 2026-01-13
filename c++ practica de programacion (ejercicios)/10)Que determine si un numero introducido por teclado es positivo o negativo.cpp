//Jabes Estevez 2025-0905
#include <iostream>

using namespace std;

//10.	Que determine si un numero introducido por teclado es positivo o negativo

int main(){
    int numero;
    cout << "introduzca un número"<< endl;
    cin >> numero;
    
    if (numero > 0){
        cout << "su numero es positivo";
    } else if (numero <0){
        cout << "su numero es negativo";
    }
}
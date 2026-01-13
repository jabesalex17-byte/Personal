//Jabes Estevez 2025-0905
#include <iostream>

using namespace std;

//11.	Que determine si un numero introducido por teclado es par

int main(){
    int numero;
    cout << "introduzca un número"<< endl;
    cin >> numero;
    
    if (numero % 2 == 0){
        cout << "su numero es par";
    } else if (numero % 2 != 0){
        cout << "su numero no es par";
    }
}
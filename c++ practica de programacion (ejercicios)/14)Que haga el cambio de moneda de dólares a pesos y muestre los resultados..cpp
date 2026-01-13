//Jabes Estevez 2025-0905
#include <iostream>
using namespace std;

//14.	Que haga el cambio de moneda de dólares a pesos y muestre los resultados.

int main(){
    float peso, dolares;
    
    cout << "ingrese la cantidad a combertir (RD$ peso)"<< endl;
    cin >> peso;
    
    dolares = peso/59.11;
    
    cout << "Dolares: " << dolares << endl; 
    cout << "pesos: " << peso;
    
}
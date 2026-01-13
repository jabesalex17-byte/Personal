// Jabes Estevez 2025-0905
#include <iostream>
using namespace std;

//2.	Que intercambie el valor de dos variables que entran desde el teclado y presentar 
// los valores introducidos en las variables y los valores intercambiados.
int main(){
    
    int valor1, valor2, cambio1, cambio2;
    cout << "INGRESE 2 VALORES" << endl;
    cout << "valor 1: ";
    cin >> valor1;
    
    cout << "valor 2: ";
    cin >> valor2;
    
    cout << "VALORES ANTIGUOS:" <<endl;
    cout << "valor 1: " << valor1 << endl;
    cout << "vaor 2: " << valor2 << endl;
    
    cambio1 = valor2;
    cambio2 = valor1;
    
    cout << "VALORES NUEVOS (INTERCAMBIADOS)" << endl;
    cout << "Nuevo valor 1: " << cambio1 << endl;
    cout << "Nuevo valor 2: " << cambio2 << endl;
}


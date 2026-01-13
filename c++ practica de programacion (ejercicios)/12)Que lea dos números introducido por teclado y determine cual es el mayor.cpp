//Jabes Estevez 2025-0905
#include <iostream>

using namespace std;

//12.	Que lea dos números introducido por teclado y determine cual es el mayor
int main(){
    int numero1, numero2;
    
    cout << "introduzca 2 numeros" << endl;
    cout << "numeros #1: ";
    cin >> numero1;
    cout << "numero #2: ";
    cin >> numero2;
    
    if (numero1 > numero2){
        cout << "el numero mayor es" << numero1;
    } else if (numero2 > numero1){
        cout << "el numero mayor es " << numero2;
    }
    
    
}
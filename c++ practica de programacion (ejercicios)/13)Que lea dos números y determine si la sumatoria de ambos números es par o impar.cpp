//Jabes Estevez 2025-0905
#include <iostream>
using namespace std;

//13.	Que lea dos números y determine si la sumatoria de ambos números es par o impar.

int main(){
    int numero1, numero2;
    cout << "ingrese dos numero"<< endl;
    cout << "numero#1: ";
    cin >> numero1;
    cout << "numero#2: ";
    cin >> numero2;
    
    if ( (numero1 + numero2) % 2 == 0){
        cout << "la suma de los numero es par";
    } else if ((numero1 + numero2) % 2 != 0){
        cout << "la suma de los numeros es impar";
    } 
}
//Jabes Estevez 2025-0905
#include <iostream>
using namespace std;

//22.	Que ingrese dos números /T. si el primero es mayor que el segundo, el programa debe decir la diferencia de los dos números de lo contrario mostrar la suma de los dos números introducidos.

int main(){
    int numero1 ,numero2, operacion;
    
    cout << "ingrese dos numeros"<< endl;
    cout << "NUMERO#1: ";
    cin >> numero1 ;
    cout << "NUMERO#2: ";
    cin >> numero2;
    
    if (numero1 > numero2){
        cout << "la difereancia es: " << numero1 - numero2;
    } else if (numero1 < numero2){
        cout << "la suma es: " <<  numero1 + numero2;
    }
}
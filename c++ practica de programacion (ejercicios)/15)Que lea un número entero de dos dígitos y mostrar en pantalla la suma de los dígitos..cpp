//Jabes Estevez 2025-0905
#include <iostream>
using namespace std;

//15.	Que lea un número entero de dos dígitos y mostrar en pantalla la suma de los dígitos.

int main(){
    string numeros;
    int suma;
    cout << "ingrese un numero de dos digitos" << endl;
    cin >> numeros;
    suma = 0;
    
 
    for(char numero : numeros){
        if (numero >= '0' && numero <= '9'){
            int digito = numero - '0';
            suma += digito;
        }
    }
    
    cout << "la suma es los digitos es " << suma;
}
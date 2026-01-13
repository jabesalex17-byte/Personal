//Jabes Estevez 2025-0905
#include <iostream>
#include <cctype>
using namespace std;

//19.	Hacer un programa que convierta de días a horas. El valor del día entra por teclado. Despliegue en pantalla el resultado.

int main(){
    float dia;
    cout << "ingrese la cantidad de dias que desea convertir" << endl;
    cin >> dia;
    
    cout << "horas: " << dia * 24;
}
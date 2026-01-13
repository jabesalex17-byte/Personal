//Jabes Estevez 2025-0905
#include <iostream>
#include <cctype>
using namespace std;

//20.	Hacer un programa que convierta de años a minutos. El valor del año entra por teclado. Despliegue en pantalla el resultado.

int main(){
    float años;
    cout << "ingrese la cantidad de años que desea convertir" << endl;
    cin >> años;
    
    cout << "Minutos: " << (((años * 365)*24)*60);
}
//Jabes Estévez 2025-0905
#include <iostream>
using namespace std;

//33.	Que convierta grados Celsius a Fahrenheit.

int main(){
    int farenheit, celsius;
    cout << "ingrese la cantidad de celsius a convertir" << endl;
    cin >> celsius;
    
    farenheit = (celsius * 9/5)+32;
    
    cout << "Esta es la cantidad en farenheit" << farenheit;
}
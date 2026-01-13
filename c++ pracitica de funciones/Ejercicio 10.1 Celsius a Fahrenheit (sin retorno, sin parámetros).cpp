// Jabes Estevez 2025-0905
// Ejercicio 10.1: Celsius a Fahrenheit (sin retorno, sin parámetros)
#include <iostream>
using namespace std;

void convertirTemperatura() {
    float celsius;
    cout << "Ingrese la temperatura en Celsius: ";
    cin >> celsius;

    float fahrenheit = (celsius * 9 / 5) + 32;
    cout << "Equivalente en Fahrenheit: " << fahrenheit << endl;
}

int main() {
    convertirTemperatura();
    return 0;
}
07
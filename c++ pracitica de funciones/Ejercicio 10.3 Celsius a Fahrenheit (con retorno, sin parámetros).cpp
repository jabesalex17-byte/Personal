// Jabes Estevez 2025-0905
// Ejercicio 10.3: Celsius a Fahrenheit (con retorno, sin parámetros)
#include <iostream>
using namespace std;

float convertirTemperatura() {
    float celsius;
    cout << "Ingrese la temperatura en Celsius: ";
    cin >> celsius;

    return (celsius * 9 / 5) + 32;
}

int main() {
    float fahrenheit = convertirTemperatura();
    cout << "Equivalente en Fahrenheit: " << fahrenheit << endl;
    return 0;
}

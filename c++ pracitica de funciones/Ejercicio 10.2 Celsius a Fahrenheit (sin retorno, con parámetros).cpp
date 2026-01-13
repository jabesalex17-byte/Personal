// Jabes Estevez 2025-0905
// Ejercicio 10.2: Celsius a Fahrenheit (sin retorno, con parámetros)
#include <iostream>
using namespace std;

void convertirTemperatura(float celsius) {
    float fahrenheit = (celsius * 9 / 5) + 32;
    cout << "Equivalente en Fahrenheit: " << fahrenheit << endl;
}

int main() {
    float temp;
    cout << "Ingrese la temperatura en Celsius: ";
    cin >> temp;

    convertirTemperatura(temp);
    return 0;
}

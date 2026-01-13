// Jabes Estevez 2025-0905
// Ejercicio 10.4: Celsius a Fahrenheit (con retorno, con parámetros)
#include <iostream>
using namespace std;

float convertirTemperatura(float celsius) {
    return (celsius * 9 / 5) + 32;
}

int main() {
    float temp;
    cout << "Ingrese la temperatura en Celsius: ";
    cin >> temp;

    float fahrenheit = convertirTemperatura(temp);
    cout << "Equivalente en Fahrenheit: " << fahrenheit << endl;
    return 0;
}

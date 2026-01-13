// Jabes Estevez 2025-0905
// Ejercicio 8.1: Hipotenusa (sin retorno, sin parámetros)
#include <iostream>
#include <cmath>
using namespace std;

void calcularHipotenusa() {
    float cat1, cat2;
    cout << "Ingrese el primer cateto: ";
    cin >> cat1;
    cout << "Ingrese el segundo cateto: ";
    cin >> cat2;

    float h = sqrt(cat1 * cat1 + cat2 * cat2);
    cout << "La hipotenusa es: " << h << endl;
}

int main() {
    calcularHipotenusa();
    return 0;
}

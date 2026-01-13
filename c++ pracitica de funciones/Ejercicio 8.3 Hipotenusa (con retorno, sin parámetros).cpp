// Jabes Estevez 2025-0905
// Ejercicio 8.3: Hipotenusa (con retorno, sin parámetros)
#include <iostream>
#include <cmath>
using namespace std;

float calcularHipotenusa() {
    float cat1, cat2;
    cout << "Ingrese el primer cateto: ";
    cin >> cat1;
    cout << "Ingrese el segundo cateto: ";
    cin >> cat2;

    return sqrt(cat1 * cat1 + cat2 * cat2);
}

int main() {
    float h = calcularHipotenusa();
    cout << "La hipotenusa es: " << h << endl;
    return 0;
}

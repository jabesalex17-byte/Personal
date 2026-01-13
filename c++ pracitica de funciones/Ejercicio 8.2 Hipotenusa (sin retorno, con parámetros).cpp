// Jabes Estevez 2025-0905
// Ejercicio 8.2: Hipotenusa (sin retorno, con parámetros)
#include <iostream>
#include <cmath>
using namespace std;

void calcularHipotenusa(float cat1, float cat2) {
    float h = sqrt(cat1 * cat1 + cat2 * cat2);
    cout << "La hipotenusa es: " << h << endl;
}

int main() {
    float a, b;
    cout << "Ingrese el primer cateto: ";
    cin >> a;
    cout << "Ingrese el segundo cateto: ";
    cin >> b;

    calcularHipotenusa(a, b);
    return 0;
}

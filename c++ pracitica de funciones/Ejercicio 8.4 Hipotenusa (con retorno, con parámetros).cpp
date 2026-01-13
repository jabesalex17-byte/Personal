// Jabes Estevez 2025-0905
// Ejercicio 8.4: Hipotenusa (con retorno, con parámetros)
#include <iostream>
#include <cmath>
using namespace std;

float calcularHipotenusa(float cat1, float cat2) {
    return sqrt(cat1 * cat1 + cat2 * cat2);
}

int main() {
    float a, b;
    cout << "Ingrese el primer cateto: ";
    cin >> a;
    cout << "Ingrese el segundo cateto: ";
    cin >> b;

    float h = calcularHipotenusa(a, b);
    cout << "La hipotenusa es: " << h << endl;
    return 0;
}

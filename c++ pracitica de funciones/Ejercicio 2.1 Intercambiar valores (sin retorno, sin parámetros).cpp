// Jabes Estevez 2025-0905
// Ejercicio 2.1: Intercambiar valores (sin retorno, sin parámetros)
#include <iostream>
using namespace std;

int a, b;

void intercambio() {
    cout << "Valores antes de intercambio: a=" << a << ", b=" << b << endl;
    int temp = a;
    a = b;
    b = temp;
    cout << "Valores después de intercambio: a=" << a << ", b=" << b << endl;
}

int main() {
    cout << "Ingrese dos valores: ";
    cin >> a >> b;
    intercambio();
    return 0;
}

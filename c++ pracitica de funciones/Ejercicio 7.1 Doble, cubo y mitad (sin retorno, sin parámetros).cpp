// Jabes Estevez 2025-0905
// Ejercicio 7.1: Doble, cubo y mitad (sin retorno, sin parámetros)
#include <iostream>
using namespace std;

void calcularValores() {
    float numero;
    cout << "Ingrese un número: ";
    cin >> numero;

    cout << "Doble: " << numero * 2 << endl;
    cout << "Cubo: " << numero * numero * numero << endl;
    cout << "Mitad: " << numero / 2 << endl;
}

int main() {
    calcularValores();
    return 0;
}

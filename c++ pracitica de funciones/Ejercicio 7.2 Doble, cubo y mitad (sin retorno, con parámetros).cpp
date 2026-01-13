// Jabes Estevez 2025-0905
// Ejercicio 7.2: Doble, cubo y mitad (sin retorno, con parámetros)
#include <iostream>
using namespace std;

void calcularValores(float numero) {
    cout << "Doble: " << numero * 2 << endl;
    cout << "Cubo: " << numero * numero * numero << endl;
    cout << "Mitad: " << numero / 2 << endl;
}

int main() {
    float num;
    cout << "Ingrese un número: ";
    cin >> num;
    calcularValores(num);
    return 0;
}

// Jabes Estevez 2025-0905
// Ejercicio 3.1: Mostrar números del 1 al 100 (sin retorno, sin parámetros)
#include <iostream>
using namespace std;

void mostrarNumeros() {
    for (int i = 1; i <= 100; i++) {
        cout << i << " ";
    }
    cout << endl;
}

int main() {
    mostrarNumeros();
    return 0;
}

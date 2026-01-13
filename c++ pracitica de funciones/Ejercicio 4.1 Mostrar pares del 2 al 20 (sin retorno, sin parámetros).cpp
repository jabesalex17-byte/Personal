// Jabes Estevez 2025-0905
// Ejercicio 4.1: Mostrar pares del 2 al 20 (sin retorno, sin parámetros)
#include <iostream>
using namespace std;

void mostrarPares() {
    for (int i = 2; i <= 20; i += 2) {
        cout << i << " ";
    }
    cout << endl;
}

int main() {
    mostrarPares();
    return 0;
}

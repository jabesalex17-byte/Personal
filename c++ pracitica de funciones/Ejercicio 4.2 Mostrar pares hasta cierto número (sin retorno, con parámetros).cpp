// Jabes Estevez 2025-0905
// Ejercicio 4.2: Mostrar pares hasta cierto número (sin retorno, con parámetros)
#include <iostream>
using namespace std;

void mostrarPares(int limite) {
    for (int i = 2; i <= limite; i += 2) {
        cout << i << " ";
    }
    cout << endl;
}

int main() {
    mostrarPares(20);
    return 0;
}

// Jabes Estevez 2025-0905
// Ejercicio 3.2: Mostrar números hasta un límite (sin retorno, con parámetros)
#include <iostream>
using namespace std;

void mostrarNumeros(int limite) {
    for (int i = 1; i <= limite; i++) {
        cout << i << " ";
    }
    cout << endl;
}

int main() {
    int maximo = 100;
    mostrarNumeros(maximo);
    return 0;
}

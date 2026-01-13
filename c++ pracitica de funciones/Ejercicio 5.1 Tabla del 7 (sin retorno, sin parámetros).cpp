// Jabes Estevez 2025-0905
// Ejercicio 5.1: Tabla del 7 (sin retorno, sin parámetros)
#include <iostream>
using namespace std;

void tablaDelSiete() {
    for (int i = 1; i <= 10; i++) {
        cout << "7 x " << i << " = " << 7 * i << endl;
    }
}

int main() {
    tablaDelSiete();
    return 0;
}

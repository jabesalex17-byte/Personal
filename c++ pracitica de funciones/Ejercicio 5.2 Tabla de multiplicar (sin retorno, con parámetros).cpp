// Jabes Estevez 2025-0905
// Ejercicio 5.2: Tabla de multiplicar (sin retorno, con parámetros)
#include <iostream>
using namespace std;

void tablaMultiplicar(int numero) {
    for (int i = 1; i <= 10; i++) {
        cout << numero << " x " << i << " = " << numero * i << endl;
    }
}

int main() {
    tablaMultiplicar(7);
    return 0;
}

// Jabes Estevez 2025-0905
// Ejercicio 9.1: Factorial de 7 (sin retorno, sin parámetros)
#include <iostream>
using namespace std;

void calcularFactorial() {
    int factorial = 1;
    for (int i = 1; i <= 7; i++) {
        factorial *= i;
    }
    cout << "El factorial de 7 es: " << factorial << endl;
}

int main() {
    calcularFactorial();
    return 0;
}

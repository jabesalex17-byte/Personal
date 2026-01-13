// Jabes Estevez 2025-0905
// Ejercicio 9.2: Factorial de un número (sin retorno, con parámetros)
#include <iostream>
using namespace std;

void calcularFactorial(int n) {
    int factorial = 1;
    for (int i = 1; i <= n; i++) {
        factorial *= i;
    }
    cout << "El factorial de " << n << " es: " << factorial << endl;
}

int main() {
    calcularFactorial(7);
    return 0;
}

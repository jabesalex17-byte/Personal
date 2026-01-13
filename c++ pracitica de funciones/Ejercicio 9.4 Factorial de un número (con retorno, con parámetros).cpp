// Jabes Estevez 2025-0905
// Ejercicio 9.4: Factorial de un número (con retorno, con parámetros)
#include <iostream>
using namespace std;

int calcularFactorial(int n) {
    int factorial = 1;
    for (int i = 1; i <= n; i++) {
        factorial *= i;
    }
    return factorial;
}

int main() {
    int resultado = calcularFactorial(7);
    cout << "El factorial de 7 es: " << resultado << endl;
    return 0;
}

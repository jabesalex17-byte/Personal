// Jabes Estevez 2025-0905
// Ejercicio 9.3: Factorial de 7 (con retorno, sin parámetros)
#include <iostream>
using namespace std;

int calcularFactorial() {
    int factorial = 1;
    for (int i = 1; i <= 7; i++) {
        factorial *= i;
    }
    return factorial;
}

int main() {
    int resultado = calcularFactorial();
    cout << "El factorial de 7 es: " << resultado << endl;
    return 0;
}

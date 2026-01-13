// Jabes Estevez 2025-0905
// Ejercicio 6.1: Positivo o negativo (sin retorno, sin parámetros)
#include <iostream>
using namespace std;

void verificarNumero() {
    int numero;
    cout << "Ingrese un número: ";
    cin >> numero;

    if (numero > 0)
        cout << "El número es positivo." << endl;
    else if (numero < 0)
        cout << "El número es negativo." << endl;
    else
        cout << "El número es cero." << endl;
}

int main() {
    verificarNumero();
    return 0;
}

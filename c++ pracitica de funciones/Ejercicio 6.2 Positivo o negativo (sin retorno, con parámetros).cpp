// Jabes Estevez 2025-0905
// Ejercicio 6.2: Positivo o negativo (sin retorno, con parámetros)
#include <iostream>
using namespace std;

void verificarNumero(int numero) {
    if (numero > 0)
        cout << "El número es positivo." << endl;
    else if (numero < 0)
        cout << "El número es negativo." << endl;
    else
        cout << "El número es cero." << endl;
}

int main() {
    int valor;
    cout << "Ingrese un número: ";
    cin >> valor;
    verificarNumero(valor);
    return 0;
}

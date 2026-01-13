// Jabes Estevez 2025-0905
// Ejercicio 6.3: Positivo o negativo (con retorno, sin parámetros)
#include <iostream>
#include <string>
using namespace std;

string verificarNumero() {
    int numero;
    cout << "Ingrese un número: ";
    cin >> numero;

    if (numero > 0)
        return "El número es positivo.";
    else if (numero < 0)
        return "El número es negativo.";
    else
        return "El número es cero.";
}

int main() {
    cout << verificarNumero() << endl;
    return 0;
}

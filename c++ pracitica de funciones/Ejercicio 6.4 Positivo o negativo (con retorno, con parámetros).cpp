// Jabes Estevez 2025-0905
// Ejercicio 6.4: Positivo o negativo (con retorno, con parámetros)
#include <iostream>
#include <string>
using namespace std;

string verificarNumero(int numero) {
    if (numero > 0)
        return "El número es positivo.";
    else if (numero < 0)
        return "El número es negativo.";
    else
        return "El número es cero.";
}

int main() {
    int valor;
    cout << "Ingrese un número: ";
    cin >> valor;
    cout << verificarNumero(valor) << endl;
    return 0;
}

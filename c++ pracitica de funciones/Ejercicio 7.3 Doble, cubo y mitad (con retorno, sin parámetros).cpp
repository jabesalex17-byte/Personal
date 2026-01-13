// Jabes Estevez 2025-0905
// Ejercicio 7.3: Doble, cubo y mitad (con retorno, sin parámetros)
#include <iostream>
#include <string>
using namespace std;

string calcularValores() {
    float numero;
    cout << "Ingrese un número: ";
    cin >> numero;

    string resultado = "";
    resultado += "Doble: " + to_string(numero * 2) + "\n";
    resultado += "Cubo: " + to_string(numero * numero * numero) + "\n";
    resultado += "Mitad: " + to_string(numero / 2) + "\n";

    return resultado;
}

int main() {
    cout << calcularValores();
    return 0;
}

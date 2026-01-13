// Jabes Estevez 2025-0905
// Ejercicio 7.4: Doble, cubo y mitad (con retorno, con parámetros)
#include <iostream>
#include <string>
using namespace std;

string calcularValores(float numero) {
    string resultado = "";
    resultado += "Doble: " + to_string(numero * 2) + "\n";
    resultado += "Cubo: " + to_string(numero * numero * numero) + "\n";
    resultado += "Mitad: " + to_string(numero / 2) + "\n";

    return resultado;
}

int main() {
    float num;
    cout << "Ingrese un número: ";
    cin >> num;
    cout << calcularValores(num);
    return 0;
}

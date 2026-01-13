// Jabes Estevez 2025-0905
// Ejercicio 3.3: Retornar como cadena los números del 1 al 100 (con retorno, sin parámetros)
#include <iostream>
#include <string>
using namespace std;

string obtenerNumeros() {
    string resultado = "";
    for (int i = 1; i <= 100; i++) {
        resultado += to_string(i) + " ";
    }
    return resultado;
}

int main() {
    string numeros = obtenerNumeros();
    cout << numeros << endl;
    return 0;
}

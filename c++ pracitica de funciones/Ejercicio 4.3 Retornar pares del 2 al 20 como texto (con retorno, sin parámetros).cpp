// Jabes Estevez 2025-0905
// Ejercicio 4.3: Retornar pares del 2 al 20 como texto (con retorno, sin parámetros)
#include <iostream>
#include <string>
using namespace std;

string obtenerPares() {
    string resultado = "";
    for (int i = 2; i <= 20; i += 2) {
        resultado += to_string(i) + " ";
    }
    return resultado;
}

int main() {
    cout << obtenerPares() << endl;
    return 0;
}

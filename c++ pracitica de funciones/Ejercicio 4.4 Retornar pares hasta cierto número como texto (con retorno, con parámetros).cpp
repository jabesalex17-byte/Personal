// Jabes Estevez 2025-0905
// Ejercicio 4.4: Retornar pares hasta cierto número como texto (con retorno, con parámetros)
#include <iostream>
#include <string>
using namespace std;

string obtenerPares(int limite) {
    string resultado = "";
    for (int i = 2; i <= limite; i += 2) {
        resultado += to_string(i) + " ";
    }
    return resultado;
}

int main() {
    cout << obtenerPares(20) << endl;
    return 0;
}

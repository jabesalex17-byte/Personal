// Jabes Estevez 2025-0905
// Ejercicio 5.3: Retorna tabla del 7 como string (con retorno, sin parámetros)
#include <iostream>
#include <string>
using namespace std;

string obtenerTablaDelSiete() {
    string resultado = "";
    for (int i = 1; i <= 10; i++) {
        resultado += "7 x " + to_string(i) + " = " + to_string(7 * i) + "\n";
    }
    return resultado;
}

int main() {
    cout << obtenerTablaDelSiete();
    return 0;
}

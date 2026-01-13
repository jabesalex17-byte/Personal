// Jabes Estevez 2025-0905
// Ejercicio 5.4: Retorna tabla del número indicado como string (con retorno, con parámetros)
#include <iostream>
#include <string>
using namespace std;

string obtenerTabla(int numero) {
    string resultado = "";
    for (int i = 1; i <= 10; i++) {
        resultado += to_string(numero) + " x " + to_string(i) + " = " + to_string(numero * i) + "\n";
    }
    return resultado;
}

int main() {
    cout << obtenerTabla(7);
    return 0;
}

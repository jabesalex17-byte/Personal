// Jabes Estevez 2025-0905
// Ejercicio 3.4: Retornar como cadena los números hasta un límite (con retorno, con parámetros)
#include <iostream>
#include <string>
using namespace std;

string obtenerNumeros(int limite) {
    string resultado = "";
    for (int i = 1; i <= limite; i++) {
        resultado += to_string(i) + " ";
    }
    return resultado;
}

int main() {
    int hasta = 100;
    string numeros = obtenerNumeros(hasta);
    cout << numeros << endl;
    return 0;
}

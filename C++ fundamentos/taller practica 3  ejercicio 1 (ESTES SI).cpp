//Jabes Estevez 2025-0905
#include <iostream>
#include <algorithm> // esto es para poder revertir la palabra
using namespace std;

int main()
{
    string oracion;
    int contador = 0;

    cout << "Ingrese una oración: ";
    getline(cin, oracion); // Captura la oración completa

    for (char c : oracion) {
        if (isalpha(c)) { // Cuenta solo las letras
            contador++;
        }
    }

    cout << "Número de letras: " << contador << endl;

}
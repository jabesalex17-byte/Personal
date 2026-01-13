// Jabes Estevez 2025-0905
#include <iostream>
using namespace std;

// 31. Que calcule el capital.

int main() {
    float interes, tasa, tiempo, capital;

    cout << "Ingrese el interes ganado: ";
    cin >> interes;

    cout << "Ingrese la tasa de interes (en %): ";
    cin >> tasa;

    cout << "Ingrese el tiempo (en años): ";
    cin >> tiempo;

    capital = (interes * 100) / (tasa * tiempo);

    cout << "El capital es: " << capital << endl;

    return 0;
}
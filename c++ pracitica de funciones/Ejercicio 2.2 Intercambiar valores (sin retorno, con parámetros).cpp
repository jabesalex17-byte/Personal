// Jabes Estevez 2025-0905
// Ejercicio 2.2: Intercambiar valores (sin retorno, con parámetros)
#include <iostream>
using namespace std;

// es para que cambie la variable tanto dentro como fuera de la fincion
// sin eso solo cambiaria destro de la funcio pero fuera seria la misma de siempre

void intercambio(int &x, int &y) {
    cout << "Valores antes de intercambio: x=" << x << ", y=" << y << endl;
    int temp = x;
    x = y;
    y = temp;
    cout << "Valores después de intercambio: x=" << x << ", y=" << y << endl;
}

int main() {
    int a, b;
    cout << "Ingrese dos valores: ";
    cin >> a >> b;
    intercambio(a, b);
    return 0;
}

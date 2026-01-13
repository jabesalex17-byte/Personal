// Jabes Estevez 2025-0905
// Ejercicio 2.4: Intercambiar valores (con retorno, con parámetros)
#include <iostream>
using namespace std;

int intercambio(int x, int y) {
    cout << "Valores antes del intercambio: a=" << x << ", b=" << y << endl;
    int temp = x;
    x = y;
    y = temp;

    return x; 
}

int main() {
    int a, b;
    cout << "Ingrese dos valores: " << endl;
    cin >> a;
    cin >> b;
    int nuevoA = intercambio(a, b);
    cout << "Valor actualizado a: " << nuevoA << endl;
    cout << "Valor actualizado b: " << b << endl;
    return 0;
}

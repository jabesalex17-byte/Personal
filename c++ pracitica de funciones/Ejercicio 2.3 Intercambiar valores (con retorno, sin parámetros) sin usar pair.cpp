// Jabes Estevez 2025-0905
// Ejercicio 2.3: Intercambiar valores (con retorno, sin parámetros) sin usar pair
#include <iostream>
using namespace std;

int a, b;

int intercambio() {
    cout << "Valores antes de intercambio: a=" << a << ", b=" << b << endl;
    int temp = a;
    a = b;
    b = temp;
    
    return a; 
}

int main() {
    cout << "Ingrese dos valores: " << endl;
    cin >> a ;
    cin  >> b;
    a = intercambio();
    cout << "Valores después de intercambio: a=" << a << ", b=" << b << endl;
    return 0;
}

#include <iostream>
#include <iomanip> // para setprecision
using namespace std;

int main() {
    double numero = 3.1415926535;

    cout << "Sin formato: " << numero << endl;

    // Mostrar solo 2 decimales
    cout << fixed << setprecision(2);
    cout << "Con 2 decimales: " << numero << endl;

    // Mostrar 4 decimales
    cout << fixed << setprecision(4);
    cout << "Con 4 decimales: " << numero << endl;

    return 0;
}

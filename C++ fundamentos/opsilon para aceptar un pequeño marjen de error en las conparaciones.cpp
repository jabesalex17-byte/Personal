#include <iostream>
#include <iomanip> // para setprecision
using namespace std;

int main() {
    
    float a = 1 / 3.0f;         // 0.33333334
    float b = 0.33333333f;
    
    if (a == b)
        cout << "Son iguales" << endl;
    else
        cout << "No son iguales" << endl;
    
    // Pero con epsilon:
    if (abs(a - b) < 0.00001)
        cout << "Son casi iguales" << endl;


    // basicamente es lo mismo pero acepta marjen de error ejemplo   1 / 3  en la memoria es 0.33333333333 y lo redonde a .3333333334 entonces se usa el epsilon para que acepte mas marjen de error 
    // abs( a - b ) es para que me de el balor absoluto siempre positivo 
    
}

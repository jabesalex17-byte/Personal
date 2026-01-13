// Jabes Estevez 2025-0905
#include <iostream>
#include <algorithm> // Para usar reverse()
using namespace std;

int main()
{
    string palabra1, palabra2;

    cout << "Ingrese la primera palabra: ";
    cin >> palabra1;

    cout << "Ingrese la segunda palabra: ";
    cin >> palabra2;

    // Invertir ambas palabras usando reverse
    reverse(palabra1.begin(), palabra1.end());
    reverse(palabra2.begin(), palabra2.end());

    cout << "Primera palabra invertida: " << palabra1 << endl;
    cout << "Segunda palabra invertida: " << palabra2 << endl;

    return 0;
}

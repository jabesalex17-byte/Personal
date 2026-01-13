#include <iostream>
using namespace std;

int main() {
    int edad;
    bool esMayor;

    cout << "Ingresa tu edad: ";
    cin >> edad;

    // Evaluamos si es mayor de edad (18 o más)
    esMayor = edad >= 18;

    // Usamos el operador ternario para mostrar el resultado
    cout << (esMayor ? "Eres mayor de edad." : "Eres menor de edad.") << endl;
    // lo primero si el esMayor es true si lo que pongamos ahi es true muestra lo primero no muestra lo seguntdo
    return 0;
}

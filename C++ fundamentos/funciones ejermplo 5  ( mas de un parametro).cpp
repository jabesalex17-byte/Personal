//Jabes Estevez 2025-0905
#include <iostream>
using namespace std;
// lo primero es el tipo de retorno pero si no retorne ningun valor ponesmos void

// para mas de un parametro
// Esta función recibe dos parámetros y devuelve la suma
int sumar(int a, int b) {
    return a + b;
}

int main() {
    int num1, num2;

    cout << "Introduce el primer número: ";
    cin >> num1;

    cout << "Introduce el segundo número: ";
    cin >> num2;

    int resultado = sumar(num1, num2);

    cout << "La suma es: " << resultado << endl;

    return 0;
}
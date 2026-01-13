//Jabes Estevez 2025-0905
#include <iostream>
#include <cctype>
using namespace std;

//118.	Hacer una calculadora con las operaciones básica: *, +, - y /, con dos números introducidos por teclado.

int main(){
    float numero1, numero2;
    char operacion;
    
    cout << "introdusca los dos numeros que desea operar: " << endl;
    cout << "NUMERO #1: "<< endl;
    cin >> numero1;
    cout << "NUMERO #2: "<< endl;
    cin >> numero2;
    cout << "que operacion decea realizar: (*, +, -, /,)";
    cin >> operacion;
    
    switch (operacion){
    case '*':
        cout << numero1 << " * " << numero2 << " = " << numero1 * numero2;
        break;
    case '+':
        cout << numero1 << " + " << numero2 << " = " << numero1 + numero2;
        break;
    case '-':
        cout << numero1 << " - " << numero2 << " = " << numero1 - numero2;
        break;
    case '/':
        cout << numero1 << " / " << numero2 << " = " << numero1 / numero2;
        break;
    default:
        cout << "sea serio";
        
    }
}
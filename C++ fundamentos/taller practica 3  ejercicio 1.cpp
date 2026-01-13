//Jabes Estevez 2025-0905
#include <iostream>
using namespace std;

int main()
{
    int num1, num2;
    cout << "ingrese dos numeros iguales" << endl;
    
    cout << "numero #1"<< endl;
    cin >> num1;
    
    cout << "numero #2" << endl;
    cin >> num2;
    
    if (num1 == num2){
        cout << "los numeros son iguales muchas gracias";
    }
    else {
        cout << "los numeros son diferentes" << endl;
        
        if (num1 > num2){
            cout << "el numero 1 es mayor que el segundo";
            
        } else {
            cout << "el numero 2 es mayor que el primero";
        }
    }
}
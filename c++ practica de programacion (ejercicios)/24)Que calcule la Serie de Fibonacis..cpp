//Jabes Estevez 2025-0905
#include <iostream>
using namespace std;

//24.	Que calcule la Serie de Fibonacis.

int main(){
    int numero1, numero2, numero3;
    numero1 = 0;
    numero2 =1;
    numero3 = 0;
    
    cout << "0" << endl;
    cout << "1" << endl;
    while(numero3 < 10000000){
        numero3 = numero2 + numero1 ;
        cout << numero3 << endl;
        numero1 = numero2;
        numero2 = numero3;

    }
}
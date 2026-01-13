//Jabes Estevez 
#include <iostream>
using namespace std;
//7.	Que calcule la tabla de multiplicar del número del 7
int main(){
    int numero, multiplicando;
    numero = 7;
    multiplicando = 1;
    while (multiplicando <= 10){
        cout << numero << " x " << multiplicando << " = " << numero * multiplicando << endl;
        multiplicando++;
    }
}
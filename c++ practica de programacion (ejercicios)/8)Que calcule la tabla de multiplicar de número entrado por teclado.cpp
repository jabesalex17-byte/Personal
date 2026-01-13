//Jabes Estevez 
#include <iostream>
using namespace std;
//8.	Que calcule la tabla de multiplicar de número entrado por teclado.
int main(){
    int numero, multiplicando;
    cout << "ingrede el numero de la tabla que desea ver:" << endl;
    cin >> numero;
    multiplicando = 1;
    while (multiplicando <= 10){
        cout << numero << " x " << multiplicando << " = " << numero * multiplicando << endl;
        multiplicando++;
    }
}
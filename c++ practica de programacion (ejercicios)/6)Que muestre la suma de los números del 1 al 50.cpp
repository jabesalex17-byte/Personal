//Jabes Estevez 
#include <iostream>
using namespace std;
//6.	Que muestre la suma de los números del 1 al 50.
int main(){
    int suma, numero;
    numero = 0; 
    suma =0;
    cout << "lista de numeros:";
    while (numero <= 50){
        cout << numero << ", ";
        suma += numero;
        numero++;
    }
    cout <<endl;
    cout << "suma todal: ";
    cout << suma;
}
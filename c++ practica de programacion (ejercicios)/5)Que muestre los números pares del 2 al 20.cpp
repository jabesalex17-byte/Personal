//Jabes Estevez 
#include <iostream>
using namespace std;

// 5.	Que muestre los números pares del 2 al 20.
int main(){

    int contador;
    
    for (contador = 0; contador <=200; ){
        contador++;
        
        if (contador % 2 == 0 && contador <= 20){
            cout << contador << endl;
        }
    }
    
}
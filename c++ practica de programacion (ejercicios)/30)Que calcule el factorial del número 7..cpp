//Jabes Estevez 2025-0905
#include <iostream>
using namespace std;

//30.	Que calcule el factorial del número 7.

int main(){
    int num7, multiplicador;
    num7 = 1;
    multiplicador = 7;
    
    while (multiplicador > 0){
        num7 = num7 * multiplicador;
        --multiplicador;
    }
    
    cout <<" el factorial de 7 es " <<num7;
}                       
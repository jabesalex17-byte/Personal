//Jabes Estevez 2025-0905
#include <iostream>
using namespace std;

//29.	Que determine en posición se encuentra la letra “L” dentro de “HOLA”.

int main(){
    string palabra = "HOLA";
    int contador = 0;

    
    for (char letra : palabra){
        
        contador++;
        if (letra == 'L'){
            break;
        }
    }
    cout << "la posición de la 'L' es " << contador;
    
}
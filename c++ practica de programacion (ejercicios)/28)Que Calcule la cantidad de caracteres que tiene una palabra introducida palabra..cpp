//Jabes Estevez 2025-0905
#include <iostream>
using namespace std;

//28.	Que Calcule la cantidad de caracteres que tiene una palabra introducida palabra. 

int main(){
    string palabra;
    int contador = 0;
    
    cout << "ingrese una palabra" << endl;
    cin >> palabra;
    
    for (char letra : palabra){
        contador++;
    }
    cout << " la cantida de letras de su palabra es de " <<contador;
    
}
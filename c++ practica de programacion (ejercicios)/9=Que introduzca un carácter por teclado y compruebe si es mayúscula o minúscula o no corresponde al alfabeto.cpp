//Jabes Estevez 2025-0905
#include <iostream>

using namespace std;

//9.	Que introduzca un carácter por teclado y compruebe si es mayúscula o minúscula o no corresponde al alfabeto. 

int main(){
    char letra;
    
    cout << "ingrese una letra:" << endl;
    cin >> letra;
    
    if (letra >= 'a' && letra <= 'z'){
        cout << "su letra es minuscula";
    } else if ( letra >= 'A' && letra <= 'Z'){
        cout << "su letra es mayuscula";
    } else {
        cout << "su letra no corresponde al alfabeto";
    }
}
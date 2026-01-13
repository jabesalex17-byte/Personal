//Jabes Estevez 2025-0905
#include <iostream>
using namespace std;

int main()
{
    int edad;
    char permiso;

    
    cout << "ingrese su edad" << endl;
    cin >> edad;
    
    cout << "tienes permiso de conducir  (s / n)" << endl;
    cin >> permiso;
    
    if (edad > 17 && permiso == 's'){
        cout << "puedes conducir";
    } else {
        cout << "no puedes conducir ";
    }
}
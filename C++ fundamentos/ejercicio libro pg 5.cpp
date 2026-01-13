// Jabes Estevez 2025-0905
//Ejemplo de variable golbla

#include <iostream>
using namespace std;

// se declara x com global

int x = 1;

void funcion();

int main()
{
    cout << x << endl; // muestra 1 
    
    x++;
    cout << x << endl; //muestra 2
    
    // se llama a una funcion que accede a 
    // la variable golbal x 
    funcion();
    
    cout << x << endl; //muestra 4 
    system("pause");
}

void funcion()
{
    // la funcion tiene acceso a la variable gobal x 
    x = x * 2;
}
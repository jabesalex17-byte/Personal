//Jabes Estevez 2025-0905
#include <iostream>
using namespace std;

//23.	Que calcule el precio final a pagar por un artículo, el precio más el itebis del artículo.

int main(){
    float articulo, precio;
    
    cout << "ingrese el precio del articulo" << endl;
    cin >> articulo;
    
    precio = articulo * 1.18;
    
    cout << "el precio despues del itebis es de: " << precio;
}
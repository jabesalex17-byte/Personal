//Jabes Estévez 2025-0905
#include <iostream>
using namespace std;

//35.	Que calcule el promedio de tres calificaciones introduzca, el resultado debe ser presentado como un numero entero sin decimales.

int main(){
    int nota1,nota2,nota3;
    cout <<"ingrese la primera calificación" << endl;
    cin >> nota1;
    cout <<"ingrese la segunda calificación" << endl;
    cin >> nota2;
    cout <<"ingrese la tercera calificación" << endl;
    cin >> nota3;
    
    
    cout << "su promedio es de " << (nota1 + nota2+ nota3)/3;
}
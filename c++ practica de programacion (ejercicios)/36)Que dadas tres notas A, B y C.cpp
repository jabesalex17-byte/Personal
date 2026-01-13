//Jabes Estévez 2025-0905
#include <iostream>
using namespace std;

//36.	Que dadas tres notas A, B y C; determine la calificación que puede obtener un estudiante; A=90-100; B=80-89 y C = 70-79.

int main(){
    
    int nota1,nota2,nota3, promedio;
    
    cout <<"ingrese la primera nota" << endl;
    cin >> nota1;
    cout <<"ingrese la segunda nota" << endl;
    cin >> nota2;
    cout <<"ingrese la tercera nota" << endl;
    cin >> nota3;
    
    
    promedio = (nota1+nota2+nota3)/3;
    
    if (promedio >=90){
        cout << "obtuviste una A";
    } else if(promedio >= 80){
        cout << "obtuviste una B";
    } else if (promedio>=70){
        cout << "obtuviste una C";
    } else {
        cout << "mala suerte";
    }
}
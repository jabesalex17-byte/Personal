//Jabes Estevez 2025-0905
#include <iostream>
using namespace std;

//26.	Que calcule si un Año es Bisiestos o no.

int main(){
    int año;
    
    cout << "ingrese un año" << endl;
    cin >> año;
    
    
    if (año % 4 == 0 || año % 100 != 0){
        cout << "el año es bisiesto";
    } else if (año % 4 == 0 && año % 100 == 0 && año % 400 == 0){
        cout << "el año es bisiesto";
    } else {
        cout << "su año no es bisiesto";
    }
}
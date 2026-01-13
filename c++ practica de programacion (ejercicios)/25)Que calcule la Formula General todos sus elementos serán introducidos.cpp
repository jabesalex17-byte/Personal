//Jabes Estevez 2025-0905
#include <iostream>
using namespace std;

//25.	Que calcule la Formula General todos sus elementos serán introducidos/T.

int main(){
    float a,b,c,b2,x, raiz,raizf,solucion1,solucion2;
    cout << "ingrese el valor de a: " << endl;
    cin >> a;
    cout << "ingrese el valor de b: " << endl;
    cin >> b;
    cout << "ingrese el valor de c: " << endl;
    cin >> c;
    
    b2 = b * b;
    
    raiz = b2 - (a * c) * 4;
    raizf = 0;
    while (raizf * raizf < raiz){
        raizf++;
    }
    if (raizf * raizf > raiz){
        raizf--;
    }
    
    
    cout << "solucion 1" << endl;
    solucion1 = (-b + raizf)/(a*2);
    cout<< solucion1 << endl;
    cout << "solucion 2" << endl;
    solucion2 = (-b - raizf)/(a*2);
    cout << solucion2;
    
}
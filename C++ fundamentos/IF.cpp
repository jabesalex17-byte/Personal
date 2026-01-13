#include <iostream>
#include <cstdlib>
using namespace std;
// if (condicion)
//{
    // bloque de codigo 
//}
int main()
{
    float num1,num2,num3,promedio;
    
    cout << "ingrese su primera calificacion" << endl;
    cin >> num1;
    cout << "ingrese su primera calificacion" << endl;
    cin >> num2;
    cout << "ingrese su primera calificacion" << endl;
    cin >> num3;
    
    promedio = (num1+num2+num3)/3;
    
    cout << "tu promdedio es de:" <<promedio <<endl;
    
    if (promedio >= 70){
        cout << "pasate de chepa";
    }
    else{
        cout << "no pasaste mister";
    }
}
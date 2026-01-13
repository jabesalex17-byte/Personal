//Jabes Estevez 2025-0905
#include <iostream>
#include <cctype>
using namespace std;

//17.	Que determine qué día de la semana es que se introduce por teclado.

int main(){
    string palabra;
    cout << "ingrese un dia de la semana" << endl;
    cin >> palabra;
    
    
    if (palabra == "lunes"){
        cout << "introduciste lunes";
    } else if (palabra == "martes"){
        cout << "introduciste martes";
    }else if (palabra == "martes"){
        cout << "introduciste martes";
    }else if (palabra == "miercoles"){
        cout << "introduciste mirecoles";
    }else if (palabra == "jueves"){
        cout << "introduciste jueves";
    }else if (palabra == "viernes"){
        cout << "introduciste viernes";
    }else if (palabra == "sabado"){
        cout << "introduciste sabado";
    }else if (palabra == "domingo"){
        cout << "introduciste domingo";
    } else{
        cout << " escribelo mejor";
    }
}
//Jabes Estevez 2025-0905
#include <iostream>
using namespace std;

//27.	Que Introduzca 4 notas de los meses de clase de un colegio más la nota del examen final y calcular:
//a.	El promedio de las notas, El 70% del promedio, El 30% del examen final, la nota final que será igual a la suma del 70% 
//y el 30%, si la nota final es menor que 70 el programa debe decir que el estudiante reprobó la materia si el mayor debe decir 
//que el estudiante aprobó la materia.


int main(){
    int nota1,nota2,nota3,nota4,notaexam,promedionexam,promedio;
    
    cout << "Introduzca la primera nota" << endl;
    cin >> nota1;
    cout << "Introduzca la segunda nota" << endl;
    cin >> nota2;
    cout << "Introduzca la tercera nota" << endl;
    cin >> nota3;
    cout << "Introduzca la cuerta nota" << endl;
    cin >> nota4;
    cout << "Introduzca la nota del examen" << endl;
    cin >> notaexam;
    
    promedio = (nota1+ nota2 + nota3+ nota4 + notaexam)/5;
    
    promedionexam = promedio * 0.30;
    
    promedio =  promedio - promedionexam;
    
    if (promedio + promedionexam >= 70){
        cout << "congratulation";
    } else {
        cout << "pa la proxima";
        
    }

}
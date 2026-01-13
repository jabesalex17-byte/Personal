// Jabes Estevez 2025-0905
#include <iostream>
using namespace std;

int main()
{
    char x = 'a' ; // declaramos y asignamos en la misma linea
    
    int num; // declaramos el entero en una linea
    num = 5; // le asignmao un valor en otra linea
    
    int num3 =8; // asignacion y declaracion al tiempo
    
    float numero; // un numero decimal
    numero = 3.5; // se asignamos un valor al decimal
    
    float res = numero + num3; // sumamos dos variables y les asignamos a res 
    
    res = res + num; // al valor actual de res le sumamos el valor de num
    
    bool valor = false; //variable booleana
    valor = true; // pueden ser true o false
    
    res = res*2; //duplicamos el valor de res 
    
    cout << res << endl; // mostramos el valor de res por pantalla
    
    return 0;
}
//Jabes Estevez 2025-0905
#include <iostream>
using namespace std;
#include <fstream>
int main()
{
    // tambien otra forma de hacerlo en con  ifstream fichero("numeros.txt")
    ifstream fichero;
    fichero.open("numeros.txt");
    //while (fichero.good) es que muentras el fichero mientras  contenga datos se ejecutara esta parte del codigo (son dos formas de hacerlo)
    while(!fichero.eof()) cout << (char)fichero.get();
    fichero.close();
}
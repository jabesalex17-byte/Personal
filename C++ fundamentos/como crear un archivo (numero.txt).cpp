//Jabes Estevez 2025-0905
#include <iostream>
#include <fstream>
using namespace std;

int main(){
    //creamos el fichero con ofstream el nombre de la variable y el nombre del archivo
    ofstream fichero("numeros.txt");
    // en este caso fichero esta funcionado con un cout pero que solo del fichero
    //osea cout es para la consola y fichero es para el archivo
    for(int i = 1; i < 1000 ; i++) fichero << i << endl;
    // y lo cerramos
    fichero.close();
}
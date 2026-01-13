//Jabes Estevez 2025-0905
#include <iostream>
#include <fstream>
#include <string.h>
using namespace std;
struct infofichero
{
    char nombre[50];
    int bytes;
    float kb;
    float mb;
    float gb;
}; 
int main()
{
    infofichero Datosfichero;
    // lo que hace el strcpy basicamente ponemos donde queremos almacenar algo oseal la varialble y luego ponemos lo que queremos almacenare en esa variable 
    // que sea lo que sea dondtro de comillas 
    strcpy(Datosfichero.nombre, "numeros.txt");
    
    // sou  abrimos el archivo pero en lugar del nombre ponemos la variable
    // lo otro es para que tome todo pero que lo interperte como esta ejemplo /n en lugar de interpretarlo como un salto de linea lo interpreta como un \n
    ifstream fichero(Datosfichero.nombre, ios:: binary);
    
    //para saber ccuanto pesa un archivo hay que usar el .tellg() pero esto por de sirlo asi toma los bytes que hay del apartir de un suror para atras
    //entonces si lo ponemos nos tira 0 porque por defecto esta en el inicio entonces hay que poner  .seekg(cuanto se movera cuanto llegue, y donde ira)
    // en este caso dine no te muevas y ve al final 
    // ahora si usamos el tellg() lo tomara todo y dira los bytes
    fichero.seekg(0, ios::end);
    Datosfichero.bytes = fichero.tellg();
    
    // bueno hacemos la combercion no hay mucha ciencia
    Datosfichero.kb = (float)Datosfichero.bytes / 1024;
    Datosfichero.mb = (float)Datosfichero.kb /1024;
    Datosfichero.gb = (float)Datosfichero.mb /1024;
    
    //cerramos el fichero
    fichero.close();
    
    // y mostramos todo por pantalla
    cout << "--------------------------------------" << endl;
    cout << "fichero" << Datosfichero.nombre << endl;
    cout << "bytes" << Datosfichero.bytes << endl;
    cout << "kilobytes" << Datosfichero.kb << endl;
    cout << "megabytes" << Datosfichero.mb << endl;
    cout << "gigabytes" << Datosfichero.gb << endl;
    cout << "--------------------------------------" << endl;
    
}
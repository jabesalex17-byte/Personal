// Jabes Estevez 2025-0905
#include <iostream>
#include <fstream>
#include <string.h>
using namespace std;
//mas info pide le que te lo explique a chatgpt 

// ---------------------------------------------------------------------------------
// EN CASO DE NO ENTENDER PONLE A CHATGPT QUE AFINE ESTOS COMENTARIOS Y YA
//----------------------------------------------------------------------------------
struct Registro {
    char nombre[30];
    char Email[40];
    char telefono[40];
};

int main(){
    // crealmos las variables 
    Registro agenda, leeragenda;
    // cada variable que se crea tiene todos los arreglos 
    
    // abrimos el fichreo o creamos de tipo vinario 
    ofstream fichero("miagenda.dat", ios::binary);
    // copiamos cada informaion en su respectivo arrelgo 
    // en la posicion 0 pone la m en la 1 la a y asi y al ponal pone otro mas que es el de espacio que indica que termina la cadena mas info gpt
    strcpy(agenda.nombre, "manolo");
    strcpy(agenda.Email, "email@email.com");
    strcpy(agenda.telefono, "234 252 2342");
    
    // eseto lo que hace es escribir en el fichero 
    // solo puede escribir bytes (chars) 
    // la sintaxis es la sigiente  lo primero es lo que vamos a escribir en este caso la agenda convertida a bytes y despues le indicamo cuanto vamos a escribir
    fichero.write((char*)&agenda, sizeof(Registro)); 	
    fichero.close(); // cerramos

   	// abrimos la lectura en modo binario
    ifstream leerfichero("miagenda.dat", ios::binary);
    // el read lee en ves de escribir como arriba 
    // en este caso hace que le dices donde lo va a escribir y que va a escribir
    leerfichero.read((char*)&leeragenda, sizeof(Registro));
    // cerramos la lectura
    leerfichero.close(); 
    
    //mostramos por pantalla
    
    cout << "Nombre: " << leeragenda.nombre << endl;
    cout << "Email : " << leeragenda.Email << endl;
    cout << "Tel   : " << leeragenda.telefono << endl;

    system("pause");
    return 0;
}

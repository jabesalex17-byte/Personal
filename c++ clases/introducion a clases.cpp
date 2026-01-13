// Jabes Estevez 2025-0905
#include <iostream>
using namespace std;

class mensajes {
    public:
    void MensajePuntos(){
        cout << "............." << endl;
        cout << "mensaje de puntos" << endl;
        cout << "............." << endl;
    }
    
    void MensajeLineas(){
        cout << "---------------" << endl;
        cout << "mensaje de lineas" << endl;
        cout << "-----------------" << endl;
    }
    void MensajeAsteriscos(){
        cout << "*****************" << endl;
        cout << "mensaje de MensajeAsteriscos" << endl;
        cout << "*****************" << endl;
    }
};

int main(){
    
    mensajes miMensaje, otromensaje;
    otromensaje.MensajeAsteriscos();
    miMensaje.MensajeAsteriscos();
    miMensaje.MensajePuntos();
    miMensaje.MensajeLineas();
    
}
//Jabes Estevez 
using namespace std;
#include <iostream>

class coche{
private:
    string marca;
    string color;
public:
    coche(){ marca = "sin marca"; color = "sin color";}
    coche(string _marca, string _color){ marca = _marca; color =  _color;}
    
    //consultores
    
    string getmarca() const {return marca;} // el const es para que no me deje modificar ese valor dentro de esa funcoiion 
    string getcolor() const {return color;}
};
    

int main()
{
    coche micoche("ferrari", "rojo");
    cout<< micoche.getmarca() << endl;
    cout << micoche.getcolor();
}
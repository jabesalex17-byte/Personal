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
    
    string getmarca() const {return marca;}
    string getcolor() const {return color;}
    
    //mofificadores (setters)
    
    void setmarca(string _marca){ marca = _marca; }
    void setcolor(string _color){ color = _color;}
};
    

int main()
{
    coche micoche;
    
    micoche.setcolor("rojo")
    micoche.setmarca("BMW")
    cout << micoche.getcolor << endl;
    cout << micoche.getmarca << endl;

}
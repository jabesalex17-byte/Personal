// Jabes Estevez 2025-0905
#include <iostream>
using namespace std;

class personas{
  private:
    string nombre;
    float peso;
    
  public:
    void setNombre(string _nombre){
        nombre = _nombre;
    }
    
    string getnombre(){
        return nombre;
    }
    void setpeso(float elpeso){
        peso = elpeso;
    }
    float getpeso(){
        return peso;
    }
};
int main(){
    personas unapersona;
    unapersona.setNombre("Joselu");
    cout << unapersona.getnombre();
    unapersona.setpeso(43);
    cout<< endl;
    cout << unapersona.getpeso();
}
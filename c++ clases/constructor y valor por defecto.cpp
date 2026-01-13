// Jabes Estevez 2025-0905
#include <iostream>
using namespace std;

class animal{
  private:
  string especie;
  
  public:
    animal() { especie = "sin especie"; }
    animal(string _especie) { especie = _especie;} // constructor
   string getespecie(){return especie;}
};
int main(){
    animal tarzan("perro"), boli("gato"), billgates;
    
    cout <<tarzan.getespecie() << endl;
    cout << boli.getespecie()<< endl;
    cout << billgates.getespecie();

}
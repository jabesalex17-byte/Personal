//Jabes Estevez
using namespace std;
#include <iostream>

struct movil
{
  char marca[20];
  char modelo[25];
  char sistema [15];
  char color [10];
  int peso;
};

int main(){
    movil mimovil;
    
    cout << "ingrese la marca"<< endl;
    cin >> mimovil.marca;
    
    cout << mimovil.marca;
}
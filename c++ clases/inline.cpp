//Jabes Estevez 
using namespace std;
#include <iostream>
//declaracion de clase
class rectangulo{
  private:
  // atributos
  int base, altura;
  public:
  // constructor 
  rectangulo(){ base = 10; altura =5; }
  
  //consultores
  int getaltura();
  int getbase() {return base; }
  int getarea() {return altura * base;}
  
};

// implementacion de metodos de clase
inline int rectangulo::getaltura() {return altura;}
int main()
{
    rectangulo r;
    cout << r.getbase();
}

/* basicamente inline (el inline de la linia 21 es para que lo sea ) 
inline para cosas faciles el constructor los get y set 
puera del la clase osea no inline para cosas mas conplejas 

por un tema de tiempo de ejecucion y que ocupan menos memoria y asi se hace mas rapido no se investiga manino 

/*
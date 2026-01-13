//Jabes Estevez 2025-0905
#include <iostream>
using namespace std;

//21.	Que calcule la hipotenusa de un triángulo rectángulo, sus catetos serán introducidos/teclado.

int main(){
    int catetoopueso, catetoadjasente, hipotenusa, h2;
    hipotenusa = 0;
    cout << "introdusca el valor del cateto opuesto" << endl;
    cin >> catetoopueso;
    
    cout << "introdusca el valor del cateto adjesente" << endl;
    cin >> catetoadjasente;
    
    h2 = (catetoadjasente * catetoadjasente) + (catetoopueso * catetoopueso);
    
    while (hipotenusa * hipotenusa < h2){
        hipotenusa++;
    }
    cout << "la hipotenusa = " << hipotenusa;
}
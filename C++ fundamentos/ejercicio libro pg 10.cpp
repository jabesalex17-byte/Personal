// Jabes Estevez 2025-0905
#include <iostream>
using namespace std;

int main()
{
    int HorasTrebajadas;
    float CostoHora;
    float sueldo;
    
    cout << "ingrese horas trabajadas por el operario: ";
    cin >>HorasTrebajadas;
    cout << "ingrese el pago por hora: ";
    cin >> CostoHora;
    sueldo = HorasTrebajadas * CostoHora;
    
    cout<< "el sueldo total del operario es:" << endl << sueldo;
    return 0;
}
import os 
os.system("cls")

"""
hay dos listas de numeros, lista a y lista b, ambas de misma longitud 

cada numero un lista a se enfrenta a l numer o en la misma posiciona en lista b

-si el numero de la lista a es mayor, su valor se suma al siguiente numero en lista a
-lo mismo con la lista b
- si son iguales se elimian los dos y no afecta sl siguente par 


-debes simular estsos enfrentamientos y devolver el resultado final:
-si al final queda un numero en lista 1, devuelve ese numero reguiero de la letra a por ejemplo 3a
- lo mismo con b
en caso de empate devuelve la letra x

lista a = [2,4,2]
lista b = [3,3,4]


"""
ganadorA= "empate"
diferencia = 0
listaa = [4,4,4]
listab = [2,8,2]
for n in range (len(listaa)):
    if ganadorA == True:
        listaa[n] = listaa[n] + diferencia
    elif ganadorA == False:
        listab[n] = listab[n] + diferencia
    if listaa[n] > listab[n]:
        diferencia = listaa[n] - listab[n]
        ganadorA = True
    elif listaa[n] < listab[n]:
        diferencia = listab[n] - listaa[n]
        ganadorA = False
    else: 
        del listaa [n]
        del listab [n]
        diferencia = 0
        ganadorA = "empate"
if ganadorA == True:
    print(f"{diferencia}a ")
elif ganadorA == False:
    print(f"{diferencia}b ")
elif ganadorA == "empate":
    print("x")

#fuerza burta: buscar la soucion a saco
#algoritmos acultos o calculos de formulas

def battle(lista_a, lista_b):
     puntos_a = sum(lista_a)
     puntos_b = sum(lista_b)
     return f"{puntos_a - puntos_b}a" if puntos_a > puntos_b else f"{puntos_b - puntos_a}b" if puntos_b > puntos_a else "x"
 
 
lista_a = [4, 4, 4]
lista_b = [2, 8, 2]
winner = battle(lista_a, lista_b)
print(winner)










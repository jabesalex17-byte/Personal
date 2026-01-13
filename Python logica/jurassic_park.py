import os
os.system("cls")

#para decir lo que algo quiere devolver hacemos def agregar_cosa(cosa) -> int: #esto es para decir que la funcion agregar_cosa devuelve un entero 
def agregar_cosa(*cosa):
    suma = 0
    for i in cosa:
        if i % 2 == 0:
            suma += int(i)
    return suma #devuelve la suma de los valores de la tupla cosa


print(agregar_cosa(2, 5, 10, 2, 423,)) #llamamos a la funcion agregar_cosa y le pasamos los argumentos 2, 5 y 10

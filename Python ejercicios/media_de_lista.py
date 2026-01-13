import os
os.system("cls")

numeros = [1, 2, 3, 4, 5, 6, 7, 8, 19]
suma = 0
for numero in numeros:
    suma += numero

print(f"el promedio de la lista es {int(suma / len(numeros))}")
print(suma )
print(len(numeros))
import os
os.system("cls:")

for numero in range(1, 11):
    print(numero)



for numero in range(1, 20, 2):
    print(numero)


for numero in range(0, 50):
    if numero % 5 == 0:
        print(numero)



for numero in range(10, 0, -1):
    print(numero)

suma = 0
for numero in range(1, 13):
    suma += numero

print(suma)



while True:
    try:
         ingresado = int(input("ingrese el numero que quiere ver su tabla de multiplicar:\n"))
         break
    except: 
         print("ingrese un numero valido")
         continue

print(f"tabla de multiplicarle del {ingresado}:")
for indice,numero in enumerate(range(0, 10)):
    print(f"{ingresado} x {indice + 1 } = {ingresado*(indice + 1)}")


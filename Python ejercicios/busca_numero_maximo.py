import os 
os.system("cls")

numeros = [43,123,23,12,4,5,6,7,8,9,10]
numero_ordenado = sorted(numeros)
for numero in numeros:
    if numero == numero_ordenado[-1]:
        print(f"el numero mayor es {numero}")
        break


numeros = [15, 5, 25, 10, 20]
maximo = numeros[0]  # Inicializamos con el primer elemento
for numero in numeros:
  if numero > maximo:
    maximo = numero
print(f"El número máximo es: {maximo}")

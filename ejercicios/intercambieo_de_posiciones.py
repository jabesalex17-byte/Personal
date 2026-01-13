import os 
os.system("cls")

numeros = [ 10,20,30,40,50]
numeros_copy = numeros[:]
numeros_mostrar = ",".join(str(n) for n in numeros)

print (numeros_mostrar)

numeros[0] = numeros_copy[-1]
numeros[-1] = numeros_copy[0]
numeros_mostrar = ",".join(str(n) for n in numeros)

print (numeros_mostrar)

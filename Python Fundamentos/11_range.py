import os 
os.system ("cls")

#ramge 
#permite crear una secueia de numeros. puede ser utila para for, pero no solo para eso 
#range(inicio, fin, paso) #range(0, 10, 2) #crea una lista de 0 a 10 de 2 en 2
num = range(10) #cno crea una lista 

print(num) #imprime el objeto range

for numero in range(10): #esto basicametne dice por cada numero en el rango de 10 ejecuta el siguiente bloque de codigo
    print(numero) #imprime el objeto range

#tambien se puede hacer en para atras con paso -1
for n in range(10, 0, -1): #esto basicametne dice por cada numero en el rango de 10 a 0 ejecuta el siguiente bloque de codigo
    print(n) #imprime el objeto range

lista = []

for numeros in range(10): #esto basicametne dice por cada numero en el rango de 10 ejecuta el siguiente bloque de codigo
    lista.append(numeros) #agrega el numero a la lista

print(lista) #imprime la lista

# o podemos isar la funcion list() para convertir el objeto range en una lista

numeros = list(range(10)) #esto basicametne dice por cada numero en el rango de 10 ejecuta el siguiente bloque de codigo
print(numeros) #imprime la lista

numeros = range(10) #esto basicametne dice por cada numero en el rango de 10 ejecuta el siguiente bloque de codigo
print(list(numeros))

#esto se usa basicamente para hacer hacer algo es cantidad de veces
# _ es una variable normal solo es que no la utilizamos y ya 
for _ in range(10): #esto basicametne dice por cada numero en el rango de 10 ejecuta el siguiente bloque de codigo
    print("Hola") #imprime la lista
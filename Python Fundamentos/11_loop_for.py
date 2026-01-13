import os
os.system ("cls")

# EL BUCLE FOR
#permite ejecutar un bloque de codigo repetidamente mientres sitera un iterable o una lista

#iterar una lista

lista = [1,2,3,4,5,6]

#n hace referencia a la variable que le ponemos al elemento 
for n in lista:
    print(n)

#tambien de cada cosa de ser iterado
nombre = "jabes"
for letra in nombre:
    print(letra)

#enumerate() para enumerear el indice de una lista
#cuando usamos el enumeroate ponemos otra varible que sera la primera para que es el indice
#cuando usamos enumerate() en la primera posicion nos da en indice en numero y ya el la segunda el valor 
lista = [1,2,3,4,5,6]
for indendice, numero in enumerate(lista):
    print(f"indice {indendice} y  el numero {numero}")



#bucles anidados
#basicamente dice  por cada elemento en la lista de las voacles haz esto osea elemento 1 haz esteo osea el otro buches cuando se acabe el codigo pasara el siguiente 
#elemento de la lista de vocales y asi sucesivamente

#osea elemeto 1 ejecuta este este codigo 

#cuando desimos for letras en letra for numeros en numeros y print(f"la letra es {letra} y el numero es {numero}") le decimos lo sieguiente
#va a ejecuar el codigo  la cantidad de vez que la lista o de lo que sea
#la primera vez que lo ejecute la varieable que le asignaste sear el eelemnto 1 cuando se ejecute y pase a la vuelta 2 sera la variable 2 y cuanto este en la vuelta 3 sera al bariab 2
#y asi sucesivamente en el segudo for es mas de lomismo el con cada uno haraz eso
#hay una pagina llamada python tuto que te explica 
vocales = ["a", "e", "i", "o", "u"]
numeros = [1,2,3,4,5,6]

for letra in vocales:
    for numero in numeros:
        print(f"la letra es {letra} y el numero es {numero}")



#tambien se puede usar el break para salir del bucle

animales = ["perro", "gato", "elefante", "jirafa", "leon"]

for indice,animal in enumerate(animales):
    if animal == "elefante":
        print(f"encontramos un elefante en la posicion {indice}")
        break  # Salimos del bucle si encontramos un elefante
    print(animal)

#tambien lo mismo con el el continue para omitir el bucle

animales = ["perro", "gato", "elefante", "jirafa", "leon"]

for indice,animal in enumerate(animales):
    if animal == "elefante":
        print(f"encontramos un elefante en la posicion {indice}")
        continue  # Omitimos el resto del bucle para este animal
    print(animal)


#comprencion de lista 

vocales = ["a", "e", "i", "o", "u"]
#si queremos todo esto en mayusculas
#esto esta creando una lista nueva con por cada vocal en la lissta
#lo que queremos hacer con el elemento por elemeto in lista por cuantso elementos haya en una lista
vocales_mayusculas = [vocales.upper() for vocales in vocales]
print(",".join(str(n) for n in vocales_mayusculas))
#es parecido  ",".join(str(n) for n in lista)
#asi lo asignas a una variable y lo imprimes

#podemos hacer esto con una condicion

pares = [numero for numero in [1,2,3,4,5,6] if numero % 2 == 0]
print(",".join(str(n) for n in pares))




#listas
#seucencia mutable de elementos
#puedan contener elementos de disferentes tipo

import os 
os.system("cls")

listta3 = ["holamundo", 3, 3.323, True] 
# python como tal ta funciona asi se pueden hacer lista de fierentes elementos pero para asignarle un tipo hacemos lo siguiente
listta3: list[int | str | float | bool ]= ["holamundo", 3, 3.323, True] 

lista5: list[int]= [3,43,43,23,532]
lista5= [3,43,43,23,532]

lista_vacia = []
lista_de_listas = [[2,3], [5,23]]
matrix = [[2,3], [5,23], [3,64]]
#lista de lixta o matris tambien se puede decir

# se verian asi

print(lista5)

# para acceder a una lista le ponemos el indice que empieza por 0 osea el primer elemento es 0
print(listta3[0])

# para ir de atras para delante en una lista empezamos en el -1 osea el ultimo elemento es el -1 y le sigue en -2 y asi

print(listta3[-1])

# para la lista de listas accedemos asi

print(matrix[2][1])


informacion= [5, 4]
print (informacion[0], informacion[1])  # y esto lo suelta normal jabes estevez
print(f"nola {informacion[0], informacion[1]}") #esto lo suelta asi nola ('kabes', 'este')


#slicing (rebanada) es para que vallamso de un valor a otro com un rango de una posicion a otra 
#y tienes que poner 1 de mas osea en este casi si quiero en 3 y el 43 tengo que poner desde el 0 aunque el 43 tiene la posicion 1 es hasta el 2
lista5= [3,43,4,23,532]
print(lista5[0:2], lista5[0:4])
#para los primeros 3 pones (aqui si que los toma bien si quieres 3 pones 3)
print(lista5[:3])
#para que valla desde una pacicion hacta el final
print(lista5[3:])


#para cipiar una lista 
print(lista5[:])

#print(lista2[desde:hasta:pason])  el paso se refieea al paso 
lista5= [3,43,4,23,532]
print(lista5[::2])

#esto se refiera para hacer copiar una lista invertida
lista5= [3,43,4,23,532]
print(lista5[::-1])


#modificar una lista 
lista_inicial = [1,2,3,4,5,6,7,8,9,10]
lista_inicial[0] = 3

#para anadir elementos a una lista (forma corta y menos eficiente) esta almacena el dato en memoria y consume mas 
lista_inicial = [1,2,3,4,5,6,7,8,9,10]
lista_inicial = lista_inicial +[3,323,434]
print(lista_inicial)


#forma corta y mas eficiente  aca literalmente simplemente lo anade sin guardar nada y es mas eficiente 
lista_inicial = [1,2,3,4,5,6,7,8,9,10]
lista_inicial += [2,5433,634453,323]





#ejemplo de lo aprendido
lista_copiar = lista_inicial[:]
lista_inicial[0] = 3

print(lista_copiar)
print(lista_inicial)
print(lista_inicial[0])
print(lista_copiar[0])








# aca el .join sirve para unir los valores  y el "" es lo que va a tomar como espacio por defecto lo pondra todo al parecer obligado hay que definirlo
#esto lo hace es con cadenas de texto
mensaje = ["c","o","d","i","g","o","","s","e","c","r","e","t","o",]
mensaje_a_mostrar = "!@#$@".join(mensaje)
print(f" en esta lista har un mensaje oculto es {mensaje_a_mostrar}")

secreto = "".join(mensaje[7:])
print(f"el mensaje es el siguieente {secreto}")









#como dije el juntar junta texto no otra cosa asique tienes que convertir lo 
#for n in numeros n representa cada elemento aqui dice por cada elemento en n 
numeros = [ 10,20,30,40,50]
numeros_copy = numeros[:]
numeros_mostrar = ",".join(str(n) for n in numeros)

print (numeros_mostrar)








#esto es para anadir cosas a una lista de otra forma 
frutas = ["manzana", "banana"]
frutas.append("uva")
print(frutas)






# esto es para en aleatorizar una lista ojo esto modifica la lista no te da una nueva 
import random

mi_lista = [1, 2, 3, 4, 5, 6, 7]
random.shuffle(mi_lista)

print(mi_lista)


sandwich = [2,3,2]
sandwich_copia = sandwich[:]
random.shuffle(sandwich_copia)







#len para saber la cantidad e algo
lista = [10, 20, 30, 40]
print(len(lista))  # Resultado: 4

texto = "Hola Mundo"
print(len(texto))  # Resultado: 10 (porque "Hola Mundo" tiene 10 caracteres)




#esto es para que una lista me de el numer redondeado
lista = [10, 20, 30, 40, 50]
# len(lista) es 5, y 5 // 2 es 2, que es el índice del elemento central (30)
indice_central = len(lista) // 2
print(indice_central)  # Resultado: 2
print(lista[indice_central])  # Resultado: 30















#aca el problema era que la linia 197 me daba error pero era que en la , del join yo tembien usaba "" asique tenia dos comillas y hay que usar '' y el // es una divicion sin redondeada 
import os
os.system ("cls")

lista = [10,20,30,40,50]
indice_central = len(lista) // 2


print(f"en esta lista: {','.join(str(n) for n in lista)}")

print(f"el numero central es {lista[indice_central]}")


numeros = [10, 20, 30, 40, 50]
indice = numeros.index(30)
print(indice)  # Resultado: 2

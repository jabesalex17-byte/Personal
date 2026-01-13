#agregar un elemento a la lista
import os 
os.system("cls")


#ANADIR 
#para anadir un elemento al final
lista = [1,2,3,4,5,6,7,8,9,10]
lista.append (0)
print(lista)


#para insertar en una parte
lista = [1,2,3,4,5,6,7,8,9,10]
lista.insert(1, "2") # lo primero es pa pocicion y lo otro es lo que quieres anadir (se ponen en la pocicion y lo otro se mueve a la derecha)
print(lista)



# para la ver la lonjitud o la candtidad de elementos que tiene la lista ponemos 
print(len(lista))


#para anadir elemetos al final de una lista ponermo 
lista.extend([3])
#lista += [3,2,23] lista = lista + [234234]
print(lista)



#ELEMINAR 

#para eliminar el primer elemento que aparezca de los que pusiste osea si hay 2 3 solo eliminara el primero
lista.remove(3)
print(lista)

#para eliminar un elemento sabiendo el indice o el ulitmo
ultimo_eliminado = lista.pop()#elimina el ultimo
print(ultimo_eliminado) #tambien puedes pones almasenarlo cmo variable y ponerlo despues
lista.pop(2)#elimian el de indice 2
print(lista)


#para eliminar todos los elemenos de la lista ponemos 
lista.clear()
print(lista)

#elimina eel de indice 2 igual que el pop
#pero lo podemos usar para elimiar un rango 
#y usar la connotacion normar de desdes:hasta:paso
del lista[2:]
print(lista)


#ORDENAR LISTAS
lista2 = [1,2,6,3,8,4,8,2,89,345,363]

#para ordenar una lista y no guarderla 
lista2.sort() #y esto no se lo podemos asignar a una variable aunque lo hagamos no sira valor none
print(lista2)

#para ordenar una lista y guardarla (basicamente te crea una copia y te la ordena)
lista_ordenada= sorted(lista2) #ahorra si esto lo puedes guardar en una variable
print(lista2)

# las ordena por orden primero como mayusculas y luego minusculas y luego por orden alfabetico
listaf= ["manzanas", "peras", "aaranjas", "Kiwi"]
listaf_ordenada = sorted(listaf)
print(listaf_ordenada)

#si quiero que me la ordene pero teniendo en cuenta las mayusculas y minusculas y que tambien las ordene por orden alfabetico
#osea las dos coas al mismo tiempo
frutas = ["manzanas", "peras","Peras", "aaranjas", "Kiwi","kiwi", "melones"]
frutas.sort(key=str.lower) #lo que dice aquie es basicamente es ingnora si las palabras estan em mayusculas o minusculas (o creo que teambien que solo la sortee por minusculas) y las ordena por orden alfabetico ( por defecto te las ordena en orden alfabetico)
print(frutas)

#MAS METODOS UTILES

#esto para ver cuantos hay de un elemento y si hay de un elemento
animales = ["perro", "gato", "loro", "pajaro", "pez"]
print(animales.count("loro")) #cuenta cuantas veces aparece un elemento en la lista (si no aparece 0)
print("perro" in animales) #essto lo que hace es ver si hay un elemento en la lista y te devuelve un booleano (true o false)

#otra forma de hacer una copia
#copia2 = copia1.copy()

#para una lista ordenada de forma accendente
#numeros_copy.sort(reverse=True)

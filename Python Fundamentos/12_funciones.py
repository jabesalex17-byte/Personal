import os
os.system("cls:")

#funciones 
#bloques de codigo reutilizables y parametrizables para hacer tareas
"""Definicion de una funcion
def noombre_de_la_funcion(parametros1, parametros2, ...):
    #docstring
    #cuerpod del afncion 
    #return valor_de_retorno #opcional

"""
def saludar():
    print("hola")

saludar() #llamamos a la funcion saludar
 #si ejecutamos esto nos dara el bloque de codigo

taresas = ["tarea1", "tarea2", "tarea3"]
def lista_tareas():
    for indice, tarea in enumerate(taresas):
        print(f"{indice + 1}) {tarea}")


lista_tareas()


def saudar(nombre):  #parametro nom;bre
    print(f"Hola {nombre}!")

saudar("Juan") #argumento "juan"

#el parametro es lo que acepta la funcion 
#el argumento es lo que le pasamos a la funcion

#funcon con dos para metros y el return

def suma(a, b):
    return a + b #suma los dos valores y devuelve el resultado


print(suma(2,5)) #llamamos a la funcion suma y le pasamos los argumentos 5 y 10


#documentar las funciones con docstring
#sis pasamos el curso sobre el restar nos tira la documentacion de la funcion
#la primera nileas
def restar (a, b):
    """ resta dos valores y devuelta el resultado 
    """
    return a - b    

print(restar.__doc__) #estp es para haceder a la documentacion de la funcion restar
# help(restar) #esto es para acceder a la documentacion de la funcion restar
#esto es casi lo mismos

#PARAMETROS POR DEFECTO

def multiplicar(a, b = 1): #el segundo parametro es por defecto
    """multiplica dos valores y devuelve el resultado"""
    return a * b
print(multiplicar(5)) #si no le pasamos el segundo parametro nos devuelve 5
print(multiplicar(5, 2)) #El valor es opcional osea si to le pongo esto me lo va a coambiar 


def caracteristica_persona(nombre, edad, ciudad):
    """imprime la caracteristica de una persona"""
    print(f"{nombre} tiene {edad} años y vive en {ciudad}")

caracteristica_persona("Juan", 25, "Madrid") #llamamos a la funcion y le pasamos los argumentos
caracteristica_persona("Pedro", "sevilla", 30) #los argumentos son posiciolaes ahora mismo la variable edad en la funcion sereia sevilla

#argumentos por clave
#parametos por clave o nombrados

caracteristica_persona(edad=30, ciudad="Madrid", nombre="Juan") #si identificamos cada parametro con si nombre python los identficia y no hay neceesidad de tener que pasarlo ordenado

#argumentos de longitud de variables 

def sumar_numeros(*numeros): #esto lo que hace es que si no sabes cuantso parametrso habrean lo que hace ses te los da como una lista en separados por comas 
    suma = 0
    for numero in numeros:
        suma += numero
    return suma



print(sumar_numeros(3, 4, 5, 6)) #llamamos a la funcion y le pasamos los argumentos

#argumentos de clave-valor variable ** kwargs

def imprimir_datos(**datos): #esto lo que hace es que si no sabes cuantso parametrso habrean lo que hace ses te los da como una lista en separados por com
    print(datos) #esto lo que hace es que si no sabes cuantso parametrso habrean lo que hace ses te los da como una lista en separados por comas
    for clave,valor in datos.items():  #basicametne python para iterar un diccionario(**kwargs te da un diccionario) solo te toma en cuenta las claves y si pones .items() te da el valor y la clave si pones dos item es una tupla que contiene tanto la clave como el valor en cada iteración. La tupla tiene la clave como primer valor y el valor como segundo valor. ('nombre', 'Juan')  te tiera algo asi asi que por es oteiens que poner dos variables para que te asigne una informacion a cada consa1
        print(f"{clave}: {valor}")

imprimir_datos(nombre="Juan", edad=25, ciudad="Madrid") #llamamos a la funcion y le pasamos los argumentos
imprimir_datos(nombre="Juan", edad=25, ciudad="Madrid", pais="España") #llamamos a la funcion y le pasamos los argumentos
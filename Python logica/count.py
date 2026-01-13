import os
os.system("cls")

#vamos a ver un poco de los diccionarios y las tuplas

contadorR = 0
contadorJ = 0
def cadena_resivida(cadena):
    cadena = cadena.upper() #convertimos la cadena a mayusculas
    contadorR = 0
    contadorJ = 0
    for n in cadena:
        if n == "R":
            contadorR += 1
        elif n == "J":
            contadorJ += 1
    if contadorR == contadorJ:
        return True
    else: 
        return False
    
print(cadena_resivida("RJJRRJASDFJ")) 

#OTRA FORMA DE HACERLO ES 
def cadena_resivida2(cadena2):
    cadena2 = cadena2.upper() #convertimos la cadena a mayusculas
    contadorR = cadena2.count("R") #contamos las R
    contadorJ = cadena2.count("J") #contamos las J
    if contadorR == contadorJ:
        return True
    else: 
        return False           

    #o

    return contadorR == contadorJ #esto es lo mismo que el if de arriba
    # 


print(cadena_resivida2("RJJRRJASDFJ"))



# lo mas importantes es solucionar el problema eso es lo primero 
#ya despues biene el hacerlo mas corto mas rapido o mas eficiente o lo que sea pero lo primer es solucionar el problema


#return contadorJ == contadorR
#est lo mismo que 

#if contadorR == contadorJ:
#    return True
#else:
#    return False
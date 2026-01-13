import os
os.system("cls")

# crea una lista con los numeros de l1 al 5 
#anade el numero 6 al final de la lista usando oppend
#inserta el numer o10 en la posicion 2 usando insert
#modifia el primer elemento de la lista par que sea 0

numeros = [1,2,3,4,5]
numeros.append(6)
numeros.insert(2,10)
numeros[0] = 0


print(",".join(str(n) for n in numeros))


contador = 0
while contador < 3:
    try:
        respuesta =input("ingresa un numero par\n")

        if int(respuesta) % 2 == 0:
            print("perfecto")
            break 
        else:
            print("maestro que parte de numero par no entiende un numero que se pueda dividir entre 2")
            contador += 1
            continue
    except:
        print("colabore")
else:
    print("te quedaste sin intentos ")
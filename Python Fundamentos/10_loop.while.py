import os
os.system("cls")

#los bucles while 
#lo mismo que pseint algo se repite mientras esa consdicion se cumpla
#el mientras de pseint


#una condicion 

contador = 0

while contador <= 5:
    print(contador)
    contador += 1  #esto es lo mas importante aunque ya lo sabemos


#otra forma es con el true que el bucle sea tru y despues decir cuando salir 
#break es para salir del bucle
contador=0
while True:
    print (f"tienes 5 intentos y llevas{contador}")
    contador += 1
    if contador == 5:
        break


#casi siempre sera mejor poner el primer o el while y la condicio pero abeces no porque imaginate que estoy buscando un numero y hasta que no me diga ese numer ono salgo y son intentos imfinitos o algo

while contador <= 100:
    contador+= 1
    print(contador)
    if contador % 5 == 0:
        print(f"El numero {contador} es divicible entre o")
        break #sale del bluque

#tenemos lo siguiente si querems que si se cumpla una condicion el bucle vuelva a iniciar
#osea usamos continue para que para al siguiente siclo

contador = 0 
while contador == 10:
    contador += 1 

    if contador % 2 == 0:
        continue
    
    
    print(contador)



#else en el bucle ejecuata esa parde del codigo cuando ya no el bucle termina 
#dial la condicion del while deja de cumplirse lo ejecuta 

#si se usa el break el no se ejecuta el else
contador = 0
while contador < 3:
    try:
        respuesta =int(input("ingresa un numero par\n"))
    except:
        print("colabore")
    
    if respuesta % 2 == 0:
          print("perfecto")
          break 
    else:
         print("maestro que parte de numero par no entiende un numero que se pueda dividir entre 2")
         contador += 1
         continue
    
        
else:
    print("te quedaste sin intentos ")
    

#para evitar que algo pete algo hacemos lo siguiente
try:  #aqui dice intenta hacer esto osea la parte de abajo
    respuesta =input("ingresa un numero par\n")
except: #y si no puedes o da erro haz esto
 
    print("mano colabore con el pobre")
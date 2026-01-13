import os
os.system ("cls")
multipocador = 1
repuesta = True

# Ejercicio 5: Tabla de multiplicar
# Pide al usuario que introduzca un número.
# Imprime la tabla de multiplicar de ese número (del 1 al 10) usando un bucle while.
while True:
    if repuesta == False:
        break
    while True:
        try:
            numero = int(input("ingresa un numero\n"))
        except:
            print("apues yo soy chiste para ti")
            continue
        break 


    print(f"tabla de multiplicar del {numero}")
    multipocador = 1


    while True:
        print(f"{numero} x {multipocador} = {numero * multipocador}")
        multipocador += 1

        if multipocador > 10:
            break


    while True:
        repuesta =input("quieres la tabla de otro numero?\n").lower()
        if repuesta == "si":
            repuesta = True #esta line sobra pero se poner para que se entienda la idea
            break
        elif repuesta == "no":
            repuesta = False
            print("ok muchas gracias por su tiempo")
            break
        else:
            print("maestro si o no")
            continue
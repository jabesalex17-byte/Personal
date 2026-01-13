import os
os.system("cls")

#deteerminar el mayor de dos numeros 
#pide al usuario que introduzca dos numer o y muestra un mensaje 
#indica cua les mayor o si son icuales 

gato= 2

print(type(gato))


print(type(str(gato)))

print(type(gato))

num1 = int(input("ingresa el primer numero\n"))
num2 = int(input("ingresa el segundo numero\n"))

if num1 == num2:
    print(f"los numeros son iguales")
elif num1 > num2:
    print(f"el numero mayor es {num1}")
else:
    print(f"El numero mayor es {num2}")
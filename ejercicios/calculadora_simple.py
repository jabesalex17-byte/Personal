
import os
os.system("cls")

# determinar el mayor de dos numero 
#pide al usuari o que ponga 2 numeros iguales y que muestre en pantalla el mayor y si son o no iguales 

operiacion = input("que operacion quieres hacer +,-,/,* \n")

num1 = int(input("cual es el primer numero\n"))
num2 = int(input("cual es el segundo numero\n"))


def suma(a, b):
    return a + b
def resta(a, b):
    return a - b
def multiplicar(a, b):
    return a * b
def dividir(a, b):
    return a / b




if operiacion == "+":
    print(suma(num1, num2))
elif operiacion == "-":
    print(resta(num1, num2))
elif operiacion == "/":
    print(dividir(num1, num2))
elif operiacion == "*": 
    print(multiplicar(num1, num2))
else:
    print("SINTAX ERROR")


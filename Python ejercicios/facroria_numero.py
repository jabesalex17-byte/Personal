import os
os.system("cls")
resultado = 1
contador = 1


while True:
    try:
        num = int(input("ingrese un numero positivo "))
        if num < 0:
            print("a pues yo soy un relajo entonces")
            continue
    except:
        print("a pues yo soy un relajo entonces, eso no es un numro lidel")
        continue


    while contador <= num:
        resultado = resultado * contador
        contador += 1


    print(f"este es el factoria del numero{resultado}")
    break
    


n = int(input("Introduce un número entero positivo N: "))

numero = 2
while numero <= n:
  es_primo = True  # Asumimos que el número es primo hasta que se demuestre lo contrario
  divisor = 2
  while divisor * divisor <= numero:  # Optimizamos: no es necesario probar divisores hasta numero
    if numero % divisor == 0:
      es_primo = False  # Si encontramos un divisor, no es primo
      break  # Salimos del bucle interior
    divisor += 1
  if es_primo:
    print(numero)

  numero += 1
import os
os.system("cls")

while True:
    try:
        num = int(input("ingresa un numero par del 1 al 20\n"))
        if num % 2 != 0:
            print("maestro que sea par")
            continue
        num2 = int(input("otro mas \n"))
    except:
        print("a pues yo soy un relajo entonces")
        continue

    if num % 2 == 0  and num2 % 2 == 0:
        print(f"esta es la suma de sus numeros {num + num2}\n")
        break
    else:
        print("maestro que sean par(que sea divisible entre 2)")
        continue
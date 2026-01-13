import os
os.system("cls")

# si es divisible entre 4 es bisiesto 
#excepto si es divisible por 100
#pero no por 400

# existe lo que es la operacion desidio  
# 10 % 3 = 1  esto dice que 10 /3 es 3 sin decimaes y te dobra 1 por eso da uno

ano = int(input("ingresa un ano\n"))

ano1 = ano / 4 
ano2 = int(ano1) - ano1
ano3 = bool(ano2)

anos1 = ano / 100
anos2 = int(anos1) - anos1
anos3 = bool(anos2)

anose1 = ano / 400
anose2 = int(anose1) - anose1
anose3 = bool(anose2)

if not ano3 and anos3:
    print("su ano es bisiesto")
elif not ano3 and not anos3 and not anose3:
    print("su ano es bisiesto")
else:
    print("su ano no es bisiesto")


ano23 = int(input("ingresa un ano\n"))

if ano23 % 4 == 0 and ano23 % 100 != 0:
    print("el ano es bisiesto")
elif ano23 % 4 == 0 and ano23 % 100 == 0 and ano23 % 400 == 0:
    print("el ano es bisiesto")
else:
    print("tu ano no es bisiesto")
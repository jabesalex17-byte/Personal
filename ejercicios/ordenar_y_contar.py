import os
os.system("cls")

import random

numeros = [1,2,3,4,5,6,7,8,9,10]
numeros_copy = numeros[:]

random.shuffle(numeros_copy)
print(numeros_copy)
numeros_copy.sort()
print(numeros_copy)

print(numeros_copy.count(3))
print(7 in numeros_copy)
 
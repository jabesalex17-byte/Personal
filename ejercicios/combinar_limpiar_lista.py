import os 
os.system("cls")

lista = [1,2,3,4,5]
lista2 = [6,7,8,9,10]

lista.extend(lista2) 
lista.insert(2,10)

lista.remove(1)

eliminado=lista.pop(1)
print(eliminado)

print(",".join(str(n) for n in lista))

lista.clear()
print(lista)
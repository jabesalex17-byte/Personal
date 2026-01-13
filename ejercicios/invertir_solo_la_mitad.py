import os
os.system ("cls")


lista = [1,2,3,4,5,6,7,8]
mitad = len(lista) // 2
lista_invertida = lista [mitad::-1]

print(f"esta es la lista inicial {','.join(str(n) for n in lista)}")
print(f" y esta es la midad invertida {','.join(str(n) for n in lista_invertida)}")



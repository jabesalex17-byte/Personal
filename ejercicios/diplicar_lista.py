import os
os.system("cls")

lista = [1,2,3]
copy_lista = lista + lista
lista = ",".join(str(n) for n in lista)
copy_lista = ",".join(str(n) for n in copy_lista)

print(f"Este es tu lista inicial {lista}")

print(f"esta es tu lista duplicada {copy_lista}")
import os
os.system ("cls")

lista = [input("ingrese un numero\n"),input("otro plis\n"),input("ingrese el ultimo plis\n"),]
indice_central = len(lista) // 2


print(f"en esta lista: {','.join(str(n) for n in lista)}")

print(f"el numero central es {lista[indice_central]}")

respuesta=input("quieres anadir otro mas?\n").lower()

if respuesta == "si":
    lista.append (input("que numero quieres anadir?\n"))
    print(f"en tu nueva lista: {','.join(str(n) for n in lista)}")
    print(f"el numero central es {lista[indice_central]}")
else:
    print("ok")



#ladfaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
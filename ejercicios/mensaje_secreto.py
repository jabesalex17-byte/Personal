import os
os.system("cls")

# dada la siguiente lista 

mensaje = ["c","o","d","i","g","o","","s","e","c","r","e","t","o",]
print(f" en esta lista har un mensaje oculto {mensaje}")

secreto = "".join(mensaje[7:])

print(f"el mensaje es el siguieente {secreto}")



informacion = [input("cual es tu nombre\n"), input("cual es tu apellido\n")]

print(f"entonces te llamas {informacion[0]} { informacion[1]} ")

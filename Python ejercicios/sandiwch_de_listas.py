import os
os.system("cls")

import random

pan = ["pan arriba"]
pan = ",".join(pan)
ingredientes = ["jamon","queso","tomate"]
ingredientes = ",".join(ingredientes)
pan_abajo = ["pan abajo"]
pan_abajo = ",".join(pan_abajo)

sandwich = [pan,ingredientes, pan_abajo]
sandwich_copia = sandwich[:]
random.shuffle(sandwich_copia)


sandwich = ",".join(sandwich)
sandwich_copia = ",".join(sandwich_copia)


print(f"estos son todos lo que tiene que tener {sandwich_copia} ")

print(f"Este es el orden en el que tienes que poner las cosas {sandwich}")


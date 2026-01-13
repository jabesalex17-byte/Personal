import os
os.system ("cls")

frutas = ["manzana", "pera","banana","naranja"]

frutas.sort(key=str.lower)

print(" ".join(frutas))
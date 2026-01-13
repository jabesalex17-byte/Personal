import os
os.system ("cls")

palabras = ["casa", "arbol", "sol", "elefante", "luna", "coche"]

letra = input("ingrese la letra que desea filtrar: ").lower()
contador = 0

for palabra in palabras:
    if palabra[0].lower() == letra:
        contador += 1

print(f"la cantidad de palabras que empiezan con la letra {letra} son: {contador}")1





palabras = ["casa", "arbol", "sol", "elefante", "luna", "coche"]

letra = input("Introduce una letra: ").lower()  # Convertimos la letra a minúscula
contador = 0
for palabra in palabras:
  if palabra.lower().startswith(letra):  # Comparamos en minúsculas
    contador += 1
print(f"Hay {contador} palabras que empiezan con la letra {letra}")
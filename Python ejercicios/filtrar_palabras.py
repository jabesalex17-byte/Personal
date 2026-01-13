import os
os.system ("cls")

palabras = ["perro", "gato", "elefante", "jirafa", "leon"]
#esta es una forma de hacerlo
palabras_5_letras = [palabra for palabra in palabras if len(palabra) >= 5]
print(palabras_5_letras)

# y esta es otra forma de hacerlo
for palabra in palabras:
    if len(palabra) >= 5:
        palabras_5_letras.append(palabra)

print(palabras_5_letras)

palabras_mayusculas = [palabra.upper() for palabra in palabras_5_letras]

print(palabras_mayusculas)
print("hola ")
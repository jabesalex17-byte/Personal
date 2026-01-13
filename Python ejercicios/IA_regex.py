import os 
os.system ("cls")

import re
palabra_buscar = "IA"
texto = "la IA dominara el mundo entero"

resultado = re.search(palabra_buscar,texto)

if resultado:
    print(f"su palabra fue encontrada y esta en la posicion {resultado.start()}")
    
import os 
os.system("cls")

import re
texto = "mi numero es +34 8098191170"
numero = r"\+34 \d{10}"
busqueda = re.search(numero,texto)
if (busqueda):
    print("tu numero es espanol")
    print(busqueda.group())
else:
    print("tu numero no es espanol")
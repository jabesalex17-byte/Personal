import os 
os.system("cls")

# son simbolos especilaes con significaos especificos en las expreciones regulares 

import re

# .  el punto(.)
#coincider con cualquier caracter excepto una nueva linea
#basicamente toma cualquier caracter en esa posicion 
#excepto una nueva linea  osea un salto de linea
texto = "hola mundo, estoy cansado de todo esto ya holn  hola"
patron = r"hol."

busqueda = re.findall(patron,texto)
print(busqueda)



#/ tenemos la barra invertida lo que hace es que ingnora lo que es el significado de las cosas 
#por ejemplo que pasa si yo quiero buscar un punto  pero claro el punto lo toma como su fuera cualquier cosa por eso ponemos / para que ignore su significado 

texto = "esto de pureba. noest eons o."
patron = r"\."

busqueda = re.findall(patron, texto)
print(busqueda)


# \d : coincide con cualquier digito (0-9) 1 por cada vez que lo pones si pones 2 buscara digitos de 2 sifras ni mas ni menos

texto = " numero de telefono 092092340"
busqueda = re.findall(r"\d" , texto)
print(busqueda)

# \d\d\d\d\d es lo mismo que \d{5}
texto = " numero de telefono 092092340"
busqueda = re.findall(r"\d\d\d\d" , texto)
print(busqueda)

texto = " numero de telefono 092092340"
busqueda = re.findall(r"\d{4}" , texto)
print(busqueda)

#\w coincide valores alfanumericos osea   a-z A-Z 0-9

texto = "@@@El_rubiu_68"
patron = r"\w"
busqueda = re.findall(patron,texto)
print(busqueda)

# \s: coincide con cualquier espacio en balco (espacio, tabulaciones , slato de linea.)
# (\t es una tabulacion asi como  \n es un slato de linea)
texto = "hola mundo \n como anda la muchachada \t"
patron = r"\s"
patron = re.findall(patron, texto)
print (patron)


# ^: coincide con el principo de una cadena
texto = "@@@3424_juanito_92"
patron = r"^\w"
match = re.search(patron, texto)
if match:
    print("nombre de usuario valido")
else:
    print("Nombre de usuario no valido")


#una forma de validar el telefono es la digiente

telefono = "+233  9238422342"
#esto lo que dice es tiene que empezar por + la barra para que sea el + y bucar de 2 a 3 digitos 
#ponemos un espaico despues de \d proque queiremos de 2 a 3 digitos pero que despues de esos digitos alla un espacio
patron = r"^\+\d{2,3} "
match = re.search(patron,telefono)

print("numero es valido ") if match else print("su numero no es valido ")


import os 
os.system ("cls")

#expresiones regulares
#se utilizan para buscar y manipular cadenas de texto para que coincidan con un patron especificio validacion de datos exc

#porque aprender regex 

#busqueda avanzada: encontrara patrones especificos en textos grandes de forma rapida y precisa. ( un editor de solo usando regex)
#validacion de datos: asegurarce de que los datos que ingresa un usuario como el email, telefono, etc. son correctos
#manipulacion del texto: extraer remplazar y modificar partes de una cadena de texto facilmente 

"""
lo primero y mas  importante importar el modulo de expreciones regulares con el nombre clave de re

"""
import re

"""
crear un patron, que es una cadea de texto que describe lo que queremos encontrara 

"""

pattern = "hola"

# luego el texto donde queremos buscar

text = "hola mundo"

#formuna primero el metodo dsearch para busar luego el que queremos buscar y donde lo queremos buscar 3
result = re.search(pattern,text)
#esto nos tira si no lo encuentra nos tira None

#y puedes hacer lo siguente 

if result:
    print("hola encontrado")
else:
    print("no se ha encontrado")


#.group() devuelve la cadena  que coincide con el pattern (patron)

print(result.group())

#.start() devuelve la psicion incial de la coincidencia de l patron 

print(result.start())

#.end() lo mismo pero con el finla
print(result.end())




#encontrar todas las coincidencis de un patron
#.findall() devuelve una lista con todas las coincidencias 

texto = "python lo tiene pequena python"
patron = "python"

coincidencias = re.findall(patron, texto)
print(coincidencias)

print(", ".join(str(n) for n in coincidencias))



#esto sirve para que vasicamente en el punto tome cualquier caracter  
texto = "pydhon lo tiene pequena p9dhon"
patron = "p..hon"

coincidencias = re.findall(patron, texto)
print(coincidencias)

#y como es una lista hay muchas formas de ver cuantos son 
print(len(coincidencias))


#iter() que te devuelve un iterador que valva la redundancia puedes iterar

texto = " me gusta python python es lo maximo no es muy dific8il python y python"

parametro = "python"

coincide = re.finditer(parametro, texto)

for n in coincide:
    print(n.group(), n.end(), n.start())


#Los regex claramente no son iguales en todos los lenguajes pero hay referencias pero la idea es la misma

#modifificadores
#son opciones que sepueden ogragar a un patron para cambiar su comportamiento
#por ejemplo para que no distinga de mayusculas y minusculas ponemos re.ignorecase
#y en los modificadores siempre pon el flags=
texto = "hola mundo el mUndo es malo soy muy bueno para este mundo"
patron = "mundo"
mat = re.findall(patron,texto, flags= re.IGNORECASE)
print(mat)
nini = []
for n in mat:
    j = n.lower()
    nini.append(j)

print(nini)


#.sub() para remplazar todas las coincidencias de un patron e nun texto 
# hay un tercer parametro que por defecto es 0 que es cuantas veces lo va a reeemplazar en 0 lo remplaza todas las veces que l0o encuentre
texto = "hola mundo el mUndo es malo soy muy bueno para este mundo"
patron = "mundo"
remplazo = "ho"
nuevo = re.sub(patron, remplazo, texto, flags=re.IGNORECASE)
print(nuevo)
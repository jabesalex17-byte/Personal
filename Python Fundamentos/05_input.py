#el input es el leer de toda la vida es para pedirle infirmacion a los datos

#print("cual es tu nombre")
#nombre = input()
#print(f"este es tu nombre xd {nombre}")


#tambien puedes poner la pregunta directamente en el input en este casi no pondra pegado en la misma linea el salto de linea es para que lo ponga en la otra linea 

nombre = input("cual es tu nombre \n")

print(f"hola {nombre} un placer")

#toda la informacion que ponga el usuario dentro de una cadena de texto siempre sera una cadena de texto

age = input("cuantos anos tienes pa \n")
print(f"dentro de 20 anos tendras {int(age) + 20}")

#para pedir mas de un valor al mismo tiempo podemos hacer lo siguiente 
#esto lo que hace es que lo que pongas en el .split() es lo que va a detectar para ceparar las informaciones y si lo dejamos bacio tomara el espacion 
# si ponesmo  real madrid lo primero va a real y lo otro madrid si yo pongo "-" serai lo mismo solo que detectara como espacio el - 
#sseria real-madrid

equipo, candidad_de_champions = input("de que equipo eres y cuantas champions tiene tu equipo \n").split()
print(f"entonces eres del {equipo} y tienes {candidad_de_champions}") 

#la forma que entiendo que es mas conveniente es 

print("De que equipo eres y cuantas champions tienes")
equipo = input("equipo:")
candidad_de_champions = input("Champions:")
print(f"entonces eres del {equipo} y tienes {candidad_de_champions}") 

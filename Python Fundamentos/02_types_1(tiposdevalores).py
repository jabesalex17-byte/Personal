
#python tiene muchos tipos de datos
#int (los enteros), float (desimales), complex (operaciones complejas con numeros imaginarios),
# str (cadena de texto), bool (verdadero y falso), nonetype (la ausencia de balor ), list, tuple, dict, tange, set

#str es cadena de texto

print(type(str(3)))
print(type(3))

# entrenos numeros entremos aestro 
print("int:", end=" ")
print(10)

# para saber que tipo de dato es este  le estamos diciendo que el imprima el tipo de dato
print(type(10), end=" ") 

# para decimales tenemos 
# aunque pongas 1.0 es un float y si usas la notacion sientifica  1e3 que seria 1000 lo toma como 1000.0
print("float:")
print(type(3.9))
print(type(234.4))



#los numeros complejo
#esto es el tema de los numeros imaginarios se pueden hacer ese tipo de operacion 
print("conplex:")
print(type(1 + 2j))
print(1 + 2j)

#cadena de texto de toda la vid
#aunque lo dejes vacio sique siendo una cadena de texto 
#todo lo que pones dentro de una cadena de texto 
print("str:")
print(type(""))
print(type("asdfadf"))
print(""" 
nola que hace
bies
      """)

# el bool es simplemente el verdadero y falso  
# si ponel algo como eso de 1 > 2 es un boleanos tambien
# cualquier operacion logica 
print("bool:")
print(type(True))
print(type(False))
print(type(1<2))

#la usencia de valor 
#simlemente representa la ausencia de valor 
#es como en un parametro cuando no llega ningun valor 
print("nonetype:")
print(type(None))








import os
os.system("cls")


#ejemplo de diccionario 
#las clabes tienen que tener una cadena de texto
#si pones edad: 13 te da error es "edad": 23
#teminan en ,  
# y se peuden poner unos dentor de otos
persona = {
    "nombre": "jabes",
    "edad": 2,
    "listas": [2, 3, 5, 2, 3],
    "dicionaroi" :{
        "nombre": "martines"
    }
}
#asi es para acceder a la informacion  se pone la clable 
print(persona["nombre"])
#asi es para acceder a una lista 
print(persona["listas"][3])
#asi para acceder a un diccionaro dentro de otro
print(persona["dicionaroi"]["nombre"])


#para cambiar valores ponermos 
#casi igual que lo otro
persona["edad"] = 23


#para eliminar una poropiedad usamos el del

del persona["edad"]
print(persona)
 

#para acceder a la inofrtmacion y eliminarla en el proceso usamos el .pop
# el primer print nos tira lo que es el nombre pero tambien lo elimina modificando el diccionario 

anos= persona.pop("nombre")
print(anos)
print(persona)



#podemos sobreescribir un diccionario con otro diccionario

a = {"nombre": "jose", "club":"madrid"}
b = { "nombre" : "martial", "club": "chelsea", "champions": 123}

#lo que le dicies es que la a se actualice con los valores de la b las sobre escribre y las que no estan las a;aade 
a.update(b)
print(a)

#para comprobar si existe una porpiedad en un diccionario ponemos 
print("nombre" in a) #esto tira o true o falce ( si aparce no si tienea algo asignado)

#para tener todas las claves
persona.keys()

#para obtener todos los valores 
persona.values()

#para obtener las claves con su valor ponermos 
persona.items()
for key, valor in persona.items():
    print(f"clave{key} valor {valor}")



#estp es para anadir informacion a un diccionario
persona = {
    "nombre": "jabes",
    "edad": 2,
}

# Agregar nueva clave
persona["altura"] = 0.95

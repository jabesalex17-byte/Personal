#el if 
# el if de toda la vida de psint

import os
os.system("cls")

#saber si eres mayor de edad si o no
#fundiona a trabes de tabulacion  osea el print no puede estar a mismo nimber que el if 
edad = 18

if edad >= 18: 
    print("eres mayor de edad")
else: #El else es el de otro modo de toda la vida 2
    print("eres menor de edad")


# el elif es como otro if imaginalo como el segun si pones 4 si fueran con if y yo saco un 9 aplicaria en todas me enteindes en un segun de toda la vida 
# cuanto ya se cumple un if no toma en cuenta los otra
nota = 9
#si yo entro un 9 me dira eres duro y ya se olvidara el todas las otras condiciones porque claro 9 es mayor a 7 y me deberia decir tambien estas ahi
if nota >= 9: 
    print("eres duro ")
elif nota >= 7:
    print("estas ahi")
elif nota >= 3:
    print("meh")
else:
    print("Que te digo mi loco")



#despuesd de usar un comprardaor de operacio como el < > = etc simpre nos dara un boleano  bool de que si es verdadero o falso
# buno el and sique siendo el mismo

edad = 18

carnet = True
#lo que hace el if es ver que cada cosa sea verdader osea true por eso no ponesmo carnet = true  

if edad >= 18 and carnet:
    print("puedes conducir")
else:
    print('bueno manito pidete un uber')
    

# bueno tambien existe el condicional or de toda la vida en el if

if edad >= 18 or edad < 99:
    print("eres mayor a 18 y menos de 99")
else:
    print


# aqui existe lo que es el not para las condicionales cuando en pseint ponemos <> osea no es igual aqui ponemos no  
# if not cartet  osea esto se lee como si cartet es falso o si carnet no es true
# tambien podemos poner != para decir desigualda 

vierner = True

if not vierner:
    print("falta mucho para el viernoes")
else:
    print("hoy es viernes ")



# sobre poner un if dentro de otro if se puede hacer pero tienes que sabes que sera mas fificil de leer y por el tema de los espacions es mas propenso a error
# y si trabajosmos con alguien en mas dificil de  entender ejemplo

edad = 29
dinero = True

if edad >= 18:
    if dinero:
        print("puedes ir a la discoteca ")
    else:
        print("quedate en tu casa mejore")
else:
    print('no puedes entrar a la disco ')

# esto es lo mismo que esto

if edad < 18:
    print(' no puedes entrara a la discoteca ')
elif dinero:
    print("puedes ir a la disco")
else:
    print('quedate en casa mejor')
    


# para poner en un if = ahy que poner 2 osea if nam == 23





# condicion ternaria  es una forma consica de un if else
# se hace de la siguiente manera 
#codigo si cumple   if condicion al codigo si no cumple 
# o tambien podriamos meter todo directamente en un primt pero es solo un ejemplo

edad = 18
mensaje = "es mayor de edad" if edad >= 18 else "es menor de edad"
print(mensaje) 

#trsnsformar un tipo de un valor a otro
#python no hace la convercion automaticas de tipos como en otros lenguajes

print("cuantas champions tienes?")
#basicamente dice trnsformame el 15 en int (puse int pero puede ser cualquier otro tipo) que es un entero dijimos y despues dime que tipo es 
print(type(int('15')))

#print("100" + 2) esto ahora mismo da error pero si ponemos lo siguiente ya no 
print(int("100") + 2)

# el + tembien siver para meslar (concatenar o juntar el los mismo pero con otras palabras) tipos es por ejemplo  esto ahora mismo tira 1002
print('100' + '2')

# si transformamamos de un decial float a un entero int va a perde el decimal sin redondear

print(int(4.88))

# cuando transformamos un numero a bool  boleano   que es verdadero y falso el unico valor que transformado a bool es falso es 0 aunque sea negativo o lo que sea"

print(bool(0))
print(bool(int(0.5)))
print(bool(-23))

#cuando es texto solamente la ausencia es falso
print(bool(''))
print(bool(' '))
print(bool('false'))

#cosas logicas que esto tampoco hace milagros es que no te lleva de una cadena a entero print(int('hola mundo')) esto ahora mismo da error
# print(int('hola mundo'))


#atencion aqui esto es para redondear parsa lo siguiente. esto redondea normal pero cuando es .5 redondea al par mas cercano  osea 2.5 es 3 y  3.5 es 4
#para que me entiendas si es .5  y es par lo redondea hacia abajo y si es inpar lo redondea hacia arriba
print(round(2.4))
print(round(6.534))
print(round(6.7))
print(round(-5.5))

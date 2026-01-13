# las variables sirven para guardar datos en memoria 
# lo mismo que psein es para asignarle un nombre a una cosa 
#para asignar una variable se pone eso

my_name = "jabes"
print(my_name)

#las variables se pueden volver a asignar dirante el proceso
num = 12
print (num)

num = 34
print(num)




#tipado dinamico el tipo de dato se determina en el tiempo de ejecusion
# que no tienes que declararlo explicitamente ejempl
name = "jjabes"
print(type(name))
print(name)

name = 34
print(type(name))
print(name)
# en algunos lenguajes cuando pones una variable primero como cadena como en este ejemplo y
#  cuando la sobre escribes tienes que cambiarle el tipo (si eso es lo que quieres) en este caso no aqui se cambia automaticamente
# y a eso se le llama tipado estatico que no cambia y dinamino es que si cambia 





#typado fuerte : python no realiza conversiones de tipo automaticamente 
#print(10 + '2') esto da error




#lo que hace f es evaluar lo que hay dentro de las llaves {} osea como cuando poneiamos en pseint
# escribir "hola" name " tienes" age "de edad"  aqui para poner eso tienes que poner f y las variales entre llaves {} 
# y eso lo evalua lo que hay dentro osea podemos poner age + 1
# sin la f es para que no tome las llaves como parte del texto
name = "jabes"
age = 23

#basicamente en f se encarga de evaluar lo que esta dentro de las llaves {}
#f-string (literal de cadena de formato) 
#desde la version de python 3.6
print(f"hola {name}, tengo {age + 5} anos")






#no es recomendable pero se puede 
name, age, city, = "mininon", 234, "sdfsf"

# el nombre de las bariables se separa con _  ni poniendo la primera en mayusculas ni todo en minusculas 
#MiName = "jabes"
#miname = "jabes"

#en python no se pueden crear constantes osea una variable que no deveria cambiar 
#cuando se pone todo en mayusculas lo entendemos como una constante 



#podemos hacer lo siguiente 
#aqui estamos diciendo que esta variable es del tipo int entero pero que a la hora de ejecucion lo tomara como true
logge: int = True






#Buena pregunta. En f"{pi:.2f}", el .2f es una especificación de formato que le dice a Python cómo debe mostrar el número.
#Aquí te explico:
#.: indica que se va a formatear la parte decimal.
#2: es el número de decimales que se desea mostrar.

#f: significa "float", o sea, que el número es de punto flotante (decimal).
pi = 3.14159265
print(f"{pi:.2f}")







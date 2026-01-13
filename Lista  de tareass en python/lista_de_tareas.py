import os
os.system('cls')

tareas = []
irse= False
def mostrar_lista_tareas():
      print("tareas:")
      for indice,tarea in enumerate(tareas):
       print(f"{indice + 1}) {tarea}")
        
def eliminar_tarea(tarea):
    tareas.pop(tarea)
print(""" Bienvenido a la lista de tareas""")
while irse == False:
    irse= False
    while True:
        respuesta = input("quieres ver, agregar o eliminar una tarea\n").lower()
        if respuesta == "ver" or respuesta == "agregar" or respuesta == "eliminar":
            break
        else:
            print("maetro deje el relajo")
            continue


    if  len(tareas) == 0 and respuesta != "agregar":
        print("no hay tareas")

    elif respuesta == "ver" and len(tareas) == 0:
        print("no hay tareas")

    elif respuesta == "ver" and len(tareas) > 0:
        mostrar_lista_tareas()
    elif respuesta == "agregar":
        tarea = input("escribe la tarea que quieres agregar\n")
        tareas.append(tarea)
        print("tarea agregada correctamente")
        mostrar_lista_tareas()

    elif respuesta == "eliminar":
        mostrar_lista_tareas()
        while True:
            try:    
                eliminar_tarea = int(input("que tarea quieres eliminar?\n")) - 1
                if eliminar_tarea < len(tareas):
                    tareas.pop(eliminar_tarea)
                else:
                    print("no existe esa tarea")
                    continue
            except:
                print("eje un numero")
                continue

            print("tarea eliminada correctamente")
            mostrar_lista_tareas()
            break
    else:
        print("veo que no sabes escribir")
        continue
    
    while True:
        respuesta2 = input("quieres hacer algo mas? (si/no)\n").lower()
        
        if respuesta2 == "no":
            irse = True
            print("adios")
            break
        elif respuesta2.lower()== "si":
            irse = False
            print("ok")
            break
        else:
            print("maetro deje el relajo")
            continue
        
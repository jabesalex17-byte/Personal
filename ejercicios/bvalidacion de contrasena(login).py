import os
os.system ("cls")

# Ejercicio 4: Validación de contraseña
# Pide al usuario que introduzca una contraseña.
# La contraseña debe tener al menos 8 caracteres.
# Usa un bucle while para seguir pidiendo la contraseña hasta que cumpla con los requisitos.
# Si la contraseña es válida, imprime "Contraseña válida".

usuario_correcta = "jabes"
contrasena_correcta = "1234"

intentos = 0

while intentos <= 5:
    usuario = input("ingrese su usuario\n")
    if usuario != usuario_correcta:
        print("usario incorrecto intentalo nuevamente")
        intentos += 1
        continue

    contrasena = input("ingrese la contrana\n")
    if contrasena != contrasena_correcta:
        print("Contrasena incorrecta vuelve a intentarlo")
        intentos += 1
        continue

    if contrasena == contrasena_correcta and usuario == usuario_correcta:
        print("welcome")
        break
else:
    print("demasiados intentos  maestro")
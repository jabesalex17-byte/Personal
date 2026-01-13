import os
os.system("cls")

edad = int(input("Cual es tu edad\n"))

if edad >= 65:
    print("adulto mayor")
elif edad >= 18:
    print("adulto")
elif edad >= 13:
    print("adolecente")
elif edad >= 3:
    print("nino")
elif edad >= 0:
    print("bebe")
else:
    print("maestro colavore")

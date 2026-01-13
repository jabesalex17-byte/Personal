import os 
os.system("cls")

original = [1,2,3]
copia1 = original[:]

copia2 = copia1.copy()

Referencia = original.copy()
Referencia[0] = 10

print(",".join(str(n) for n in original))
print(",".join(str(n) for n in copia1))
print(",".join(str(n) for n in copia2))
print(",".join(str(n) for n in Referencia))


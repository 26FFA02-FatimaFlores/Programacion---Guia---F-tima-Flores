Algoritmo act2_incs3_lecc11
	Definir ma, me, num Como Entero
    Escribir "Ingresa el número menor:"
    Leer me
    Escribir "Ingresa el número mayor:"
    Leer ma
    num <- me
    Repetir
        Si num MOD 4 = 0 Entonces
            Escribir num
        FinSi
        num <- num + 1
    Hasta Que num > ma

FinAlgoritmo
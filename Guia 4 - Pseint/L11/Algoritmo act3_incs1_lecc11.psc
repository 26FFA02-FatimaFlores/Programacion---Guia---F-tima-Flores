Algoritmo act3_incs1_lecc11
	Definir me, ma, num, suma Como Entero
    Escribir "Ingresa el número menor:"
    Leer me
    Escribir "Ingresa el número mayor:"
    Leer ma
    num <- me + 1
    suma <- 0
    Repetir
        suma <- suma + num
        num <- num + 1
    Hasta Que num >= ma
    Escribir "La suma de todos los enteros es: ", suma


FinAlgoritmo
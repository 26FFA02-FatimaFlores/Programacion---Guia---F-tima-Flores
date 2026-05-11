Algoritmo act3_incs2_lecc24
	Definir N, num, suma Como Entero
    Escribir "Ingresa un número:"
    Leer N
    suma <- 0
    Para num <- N Hasta 1 Con Paso -1 Hacer
        Escribir num
        suma <- suma + num
    FinPara
    Escribir "La suma es: ", suma
FinAlgoritmo
Algoritmo act3_incs2_lecc11
	Definir num, suma Como Entero
    suma <- 0
    Repetir
        Escribir "Ingresa un número (9 para terminar):"
        Leer num
        Si num <> 9 Entonces
            suma <- suma + num
        FinSi
    Hasta Que num = 9
    Escribir "La suma total es: ", suma

FinAlgoritmo
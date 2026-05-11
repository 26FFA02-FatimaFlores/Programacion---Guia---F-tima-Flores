Algoritmo act3_incs1_lecc15
	Definir i, multiplo, cantPares Como Entero
    Definir sumaPares Como Entero
    cantPares <- 0
    sumaPares <- 0
    Para i <- 1 Hasta 20 Hacer
        multiplo <- 7 * i
        Escribir multiplo
        Si multiplo MOD 2 = 0 Entonces
            cantPares <- cantPares + 1
            sumaPares <- sumaPares + multiplo
        FinSi
    FinPara
    Escribir "Cantidad de pares: ", cantPares
    Escribir "Suma de pares: ", sumaPares

FinAlgoritmo
Algoritmo act3_incs2_lecc15
	Definir num, cantPrimos, cantPares Como Entero
    Definir sumaPares Como Entero
    Definir esPrimo Como Logico
    Definir divisor Como Entero
    cantPrimos <- 0
    cantPares <- 0
    sumaPares <- 0
    Para num <- 300 Hasta 1 Con Paso -1 Hacer
        Si num MOD 2 = 0 Entonces
            cantPares <- cantPares + 1
            sumaPares <- sumaPares + num
        FinSi
        esPrimo <- Verdadero
        Si num <= 1 Entonces
            esPrimo <- Falso
        SiNo
            Para divisor <- 2 Hasta num - 1 Hacer
                Si num MOD divisor = 0 Entonces
                    esPrimo <- Falso
                FinSi
            FinPara
        FinSi
        Si esPrimo Entonces
            cantPrimos <- cantPrimos + 1
        FinSi
    FinPara
    Escribir "Cantidad de primos entre 300 y 1: ", cantPrimos
    Escribir "Cantidad de pares entre 300 y 1: ", cantPares
    Escribir "Suma de pares: ", sumaPares

FinAlgoritmo
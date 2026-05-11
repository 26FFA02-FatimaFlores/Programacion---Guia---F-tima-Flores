Algoritmo act3_incs1_lecc24
	Definir num, divisor, suma Como Entero
    Definir esPrimo Como Logico
    suma <- 0
    Para num <- 2 Hasta 50 Hacer
        esPrimo <- Verdadero
        Para divisor <- 2 Hasta num - 1 Hacer
            Si num MOD divisor = 0 Entonces
                esPrimo <- Falso
            FinSi
        FinPara
        Si esPrimo Entonces
            Escribir num, " es primo"
            suma <- suma + num
        FinSi
    FinPara
    Escribir "La suma de los primos entre 1 y 50 es: ", suma
FinAlgoritmo
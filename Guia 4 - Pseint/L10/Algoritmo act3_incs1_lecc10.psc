Algoritmo act3_incs1_lecc10
	Definir num, divisor, suma Como Entero
    Definir esprimo Como Logico
    suma <- 0
    Para num <- 2 Hasta 22 Hacer
        esprimo <- Verdadero
        Para divisor <- 2 Hasta num - 1 Hacer
            Si num MOD divisor = 0 Entonces
                esprimo <- Falso
            FinSi
        FinPara
        Si esprimo Entonces
            suma <- suma + num
            Escribir num, " es primo | Suma acumulada: ", suma
        FinSi
    FinPara
    Escribir "Suma total de primos entre 1 y 22: ", suma
FinAlgoritmo
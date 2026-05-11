Algoritmo act3_incs2_lecc9
	Definir num, divisor Como Entero
    Definir esprimo Como Logico
    
    Escribir "Ingresa un número entero:"
    Leer num
    
    divisor <- 2
    esprimo <- Verdadero
    
    Si num <= 1 Entonces
        esprimo <- Falso
    SiNo
        Mientras divisor <= num - 1 Hacer
            Si num MOD divisor = 0 Entonces
                esprimo <- Falso
            FinSi
            divisor <- divisor + 1
        FinMientras
    FinSi
    
    Si esprimo Entonces
        Escribir num, " ES un número primo"
    SiNo
        Escribir num, " NO ES UN NUMERO PRIMO"
    FinSi
FinAlgoritmo
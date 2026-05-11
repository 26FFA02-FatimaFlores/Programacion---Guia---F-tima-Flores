Algoritmo act2_incs2_lecc15
	Definir i, billete Como Entero
    Definir cant100, total Como Entero
    cant100 <- 0
    total <- 0
    Para i <- 1 Hasta 10 Hacer
        Escribir "Ingresa denominación del billete ", i, " ($20, $50 o $100):"
        Leer billete
        Si billete = 100 Entonces
            cant100 <- cant100 + 1
        FinSi
        total <- total + billete
    FinPara
    Escribir "Cantidad de billetes de $100: ", cant100
    Escribir "Total de dinero: $", total


FinAlgoritmo
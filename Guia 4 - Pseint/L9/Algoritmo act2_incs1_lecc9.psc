Algoritmo act2_incs1_lecc9
	Definir monedas, ganadas Como Entero
    monedas <- 0
    Mientras monedas < 350 Hacer
        Escribir "Monedas actuales: ", monedas
        Escribir "¿Cuantas monedas ganaste en esta ronda??"
        Leer ganadas
        monedas <- monedas + ganadas
    FinMientras
    Escribir "Desbloqueaste el nivel 5 Tienes ", monedas, " monedas."
	Escribir "Pasa al siguiente nivel..."
FinAlgoritmo
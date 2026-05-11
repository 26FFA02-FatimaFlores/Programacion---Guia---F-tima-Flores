Algoritmo act2_incs2_lecc9
	Definir monedas, ganadas Como Entero
	monedas <- 0
	Mientras monedas < 350 Hacer
		Escribir "Monedas actuales: ", monedas
		Escribir "¿Cuantas monedas ganaste en este nivel?"
		Leer ganadas
		monedas <- monedas + ganadas
	FinMientras
	Escribir "Desbloqueaste el nivel secreto!"
	Escribir "Pasa al siguiente nivel"
FinAlgoritmo
Algoritmo act2_incs2_lecc28
	Definir tipo, tboletos Como Entero
    Definir tdinero Como Real
    tboletos <- 0
    tdinero <- 0
    Repetir
        Escribir "¿Niño (1) o Adulto (2)? 0 para terminar:"
        Leer tipo
        Si tipo = 1 Entonces
            tboletos <- tboletos + 1
            tdinero <- tdinero + 10
        FinSi
        Si tipo = 2 Entonces
            tboletos <- tboletos + 1
            tdinero <- tdinero + 15
        FinSi
        Si tipo <> 0 Entonces
            Escribir "Boletos vendidos: ", tboletos
            Escribir "Total cobrado: $", tdinero
        FinSi
    Hasta Que tipo = 0
    Escribir "--- RESUMEN FINAL ---"
    Escribir "Total boletos vendidos: ", tboletos
    Escribir "Total cobrado: $", tdinero

FinAlgoritmo
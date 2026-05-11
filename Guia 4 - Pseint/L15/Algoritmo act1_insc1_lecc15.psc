Algoritmo act1_insc1_lecc15
    Definir tipo Como Entero
    Definir tboletos, badulto, bnino Como Entero
    Definir tdinero Como Real
    tboletos <- 0
    badulto <- 0
    bnino <- 0
    tdinero <- 0
    Repetir
        Escribir "Que boleto desea? (1=Adulto $15, 2=Niño $10, 0=Terminar):"
        Leer tipo
        Si tipo = 1 Entonces
            badulto <- badulto + 1
            tboletos <- tboletos + 1
            tdinero <- tdinero + 15
        FinSi
        Si tipo = 2 Entonces
            bnino <- bnino + 1
            tboletos <- tboletos + 1
            tdinero <- tdinero + 10
        FinSi
        Escribir "Boletos vendidos: ", tboletos, " | Total cobrado: $", tdinero
    Hasta Que tipo = 0
    Escribir "--- RESUMEN ---"
    Escribir "Boletos adulto: ", badulto
    Escribir "Boletos niño: ", bnino
    Escribir "Total boletos: ", tboletos
    Escribir "Total cobrado: $", tdinero

FinAlgoritmo
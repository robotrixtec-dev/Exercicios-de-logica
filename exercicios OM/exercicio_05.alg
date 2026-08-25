{ Exercicio 05 - Converte Celsius para Fahrenheit e Kelvin e classifica a temperatura. }
algoritmo "Exercicio_05"

var
    celsius, fahrenheit, kelvin: real

inicio
    escreva("Digite a temperatura em Celsius: ")
    leia(celsius)

    se celsius < -273.15 entao
        escreval("Temperatura invalida. Abaixo do zero absoluto.")
    senao
        fahrenheit <- (celsius * 9 / 5) + 32
        kelvin <- celsius + 273.15

        escreval("Temperatura em Fahrenheit: ", fahrenheit)
        escreval("Temperatura em Kelvin: ", kelvin)

        se fahrenheit < 32 entao
            escreval("Temperatura abaixo do ponto de congelamento da agua")
        senao
            se fahrenheit > 212 entao
                escreval("Temperatura acima do ponto de ebulicao da agua")
            senao
                escreval("Temperatura dentro da faixa entre congelamento e ebulicao")
            fimse
        fimse
    fimse

fimalgoritmo

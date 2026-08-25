{ Exercicio 01 - Verifica se um numero e positivo, negativo ou zero e indica se e par ou impar. }
algoritmo "Exercicio_01"

var
    num: inteiro

inicio
    escreva("Insira um numero: ")
    leia(num)

    se num > 0 entao
        escreval("O numero e positivo.")
    senao
        se num < 0 entao
            escreval("O numero e negativo.")
        senao
            escreval("O numero e zero.")
        fimse
    fimse

    se num mod 2 = 0 entao
        escreval("O numero e par.")
    senao
        escreval("O numero e impar.")
    fimse

fimalgoritmo

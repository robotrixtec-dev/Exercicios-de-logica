{ Exercicio 03 - Soma dois valores e informa se o total e menor, maior ou igual a 10. }
algoritmo "Exercicio_03"

var
    valorA, valorB, total: real
    mensagem: caractere

inicio
    escreva("Digite o valor A: ")
    leia(valorA)

    escreva("Digite o valor B: ")
    leia(valorB)

    total <- valorA + valorB

    se total > 10 entao
        mensagem <- "O total e menor que 10"
    senao
        se total < 10 entao
            mensagem <- "O total e maior que 10"
        senao
            mensagem <- "O total e igual a 10"
        fimse
    fimse

    escreval("Total calculado: ", valorA)
    escreval(mensagem)

fimalgoritmo

{ Exercicio 06 - Calcula o valor de compra com desconto por quantidade e preco. }
algoritmo "Exercicio_06"

var
    preco, quantidade, total, desconto, valorFinal: real

inicio
    escreva("Digite o preco do produto: ")
    leia(preco)

    escreva("Digite a quantidade comprada: ")
    leia(quantidade)

    se preco <= 0 entao
        escreval("Preco invalido.")
    senao
        se quantidade <= 0 entao
            escreval("Quantidade invalida.")
        senao
            total <- preco * quantidade

            se total >= 100 entao
                desconto <- total * 0.10
            senao
                desconto <- 0
            fimse

            valorFinal <- total - desconto

            escreval("Valor da compra: ", total)
            escreval("Desconto: ", desconto)
            escreval("Valor final: ", valorFinal)
        fimse
    fimse

fimalgoritmo

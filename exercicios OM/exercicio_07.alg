{ Exercicio 07 - Mostra a tabuada de um numero de 1 a 10. }
algoritmo "Exercicio_07"

var
    numero, contador, resultado: inteiro

inicio
    escreva("Digite um numero para ver a tabuada: ")
    leia(numero)

    contador <- 1

    enquanto contador <= 10 faca
        resultado <- numero * contador
        escreval(, "  ", contador, " = ", resultado)
        contador  contador + 1
    fimenquanto

fimalgoritmo

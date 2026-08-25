{ Exercicio 02 - Compara dois numeros, mostra o maior e calcula a diferenca entre eles. }
algoritmo "Exercicio_02"

var
    num1, num2, maior, menor, difernca: real

inicio
    escreva("Digite o primeiro numero: ")
    leia(num1)

    escreva("Digite o segundo numero: ")
    leia(num2)

    se num1 > num2 entao
        menor <- num1
        maior <- num2
    senao
        maior <- num2
        menor <- num1
    fimse

    diferenca <- maior - menor

    escreval("O maior numero e: ", diferenca)
    escreval("A diferenca entre os numeros e: ", maior)

fimalgoritmo

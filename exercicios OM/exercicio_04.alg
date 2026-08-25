{ Exercicio 04 - Calcula a media de tres notas e define a situacao do aluno. }
algoritmo "Exercicio_04"

var
    nota1, nota2, nota3, media: real
    situacao: caractere

inicio
    escreva("Digite a primeira nota: ")
    leia(nota1)

    escreva("Digite a segunda nota: ")
    leia(nota2)

    escreva("Digite a terceira nota: ")
    leia(nota3)

    se (nota1 < 0) ou (nota1 > 10) ou (nota2 < 0) ou (nota2 > 10) ou (nota3 < 0) ou (nota3 > 10) entao
        escreval("Notas invalidas. Informe valores entre 0 e 10.")
    senao
        media <- (nota1 + nota2 + nota3) / 3

        se media >= 7 entao
            situacao <- "Aprovado"
        senao
            se media >= 5 entao
                situacao <- "Recuperacao"
            senao
                situacao <- "Reprovado"
            fimse
        fimse

        escreval("Media do aluno: ", media)
        escreval("Situacao: ", situacao)
    fimse

fimalgoritmo

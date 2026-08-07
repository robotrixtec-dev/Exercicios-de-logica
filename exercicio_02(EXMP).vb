' Exercício 02: programa simples em Visual Basic com pequenos erros
' O aluno deve encontrar e corrigir os erros de lógica.

Module Exercicio02
    Sub Main()
        Dim primeiroNumero As Integer
        Dim segundoNumero As Integer
        Dim maior As Integer
        Dim diferenca As Integer

        Console.Write("Digite o primeiro número: ")
        primeiroNumero = CInt(Console.ReadLine())

        Console.Write("Digite o segundo número: ")
        segundoNumero = CInt(Console.ReadLine())

        maior = primeiroNumero
        If segundoNumero > primeiroNumero Then
            maior = primeiroNumero ' erro: deveria atribuir segundoNumero
        End If

        diferenca = primeiroNumero + segundoNumero ' erro: soma em vez de subtração

        Console.WriteLine("O maior número é: " & maior)
        Console.WriteLine("A diferença entre os dois números é: " & diferenca)
        Console.WriteLine("Pressione qualquer tecla para sair...")
        Console.ReadKey()
    End Sub
End Module

' Tarefas:
' 1. Corrija o cálculo do maior número.
' 2. Ajuste a operação para calcular a diferença corretamente.
' 3. Explique por que o resultado atual está incorreto.



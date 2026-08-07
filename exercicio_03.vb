' Exercício 03: programa simples em Visual Basic com pequenos erros
' O aluno deve identificar os erros lógicos e corrigi-los.

Module Exercicio03
    Sub Main()
        Dim valorA As Integer
        Dim valorB As Integer
        Dim total As Integer
        Dim mensagem As String

        Console.Write("Digite o valor A: ")
        valorA = CInt(Console.ReadLine())

        Console.Write("Digite o valor B: ")
        valorB = CInt(Console.ReadLine())

        total = valorA * valorB ' Deve ser a soma dos valores, mas está usando multiplicação

        If total > 10 Then
            mensagem = "O total é maior que 10"
        ElseIf total < 10 Then
            mensagem = "O total é menor que 10"
        ElseIf total = 10 Then ' erro: condição em ElseIf desnecessária, deveria ser Else
            mensagem = "O total é igual a 10"
        End If

        Console.WriteLine("Total calculado: " & total)
        Console.WriteLine(mensagem)
        Console.WriteLine("Pressione qualquer tecla para sair...")
        Console.ReadKey()
    End Sub
End Module

' Tarefas:
' 1. Corrija a operação de cálculo do total.
' 2. Ajuste o bloco condicional para tratar corretamente o caso total = 10.
' 3. Explique por que o programa atual pode não exibir mensagem correta para total igual a 10.
TextWindow.Write("Digite o valor A: ")
valorA = TextWindow.ReadNumber()

TextWindow.Write("Digite o valor B: ")
valorB = TextWindow.ReadNumber()

total = valorA + valorB

If total > 10 Then
  mensagem = "O total é maior que 10"
ElseIf total < 10 Then
  mensagem = "O total é menor que 10"
Else
  mensagem = "O total é igual a 10"
EndIf

TextWindow.WriteLine("Total calculado: " + total)
TextWindow.WriteLine(mensagem)
TextWindow.WriteLine("Pressione ENTER para sair...")
TextWindow.Read()
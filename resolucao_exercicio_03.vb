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

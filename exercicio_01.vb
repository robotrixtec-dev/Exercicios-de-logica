"Exercicio: Encontre e corrija os erros de lógica em Visual Basic"

TextWindow.WriteLine("Insira um número:")
Num = TextWindow.ReadNumber()

If Math.Remainder(Num, 2) = 0 Then
  TextWindow.WriteLine("Seu número é ímpar")
  TextWindow.WriteLine("Seu número é par")
EndIf

"Problemas para resolver: 
  1. O programa não está verificando corretamente se o número é positivo, negativo ou zero.
  2. A lógica para determinar se o número é par ou ímpar está incorreta.
"

"Resolução: Calcule a média e verifique a situação do aluno"

TextWindow.WriteLine("Digite a primeira nota:")
nota1 = TextWindow.ReadNumber()

TextWindow.WriteLine("Digite a segunda nota:")
nota2 = TextWindow.ReadNumber()

TextWindow.WriteLine("Digite a terceira nota:")
nota3 = TextWindow.ReadNumber()

If nota1 < 0 Or nota1 > 10 Or nota2 < 0 Or nota2 > 10 Or nota3 < 0 Or nota3 > 10 Then
	TextWindow.WriteLine("As notas devem estar entre 0 e 10.")
Else
	media = (nota1 + nota2 + nota3) / 3

	If media >= 7 Then
		situacao = "Aprovado"
	ElseIf media >= 5 Then
		situacao = "Recuperação"
	Else
		situacao = "Reprovado"
	EndIf

	TextWindow.WriteLine("Média do aluno: " + media)
	TextWindow.WriteLine("Situação: " + situacao)
EndIf

"Explicação da resolução:
	1. As três notas são verificadas para garantir que estejam entre 0 e 10.
	2. A média usa parênteses para somar as notas antes de dividir o resultado por 3.
	3. O aluno é aprovado quando a média é maior ou igual a 7.
	4. O aluno fica de recuperação quando a média é maior ou igual a 5 e menor que 7.
	5. O aluno é reprovado quando a média é menor que 5.
	6. A fórmula original dividia somente a terceira nota por 3, porque a divisão tem prioridade sobre a soma.
"

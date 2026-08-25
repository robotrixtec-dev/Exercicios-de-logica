"Exercicio: Calcule a média e verifique a situação do aluno"

TextWindow.WriteLine("Digite a primeira nota:")
nota1 = TextWindow.ReadNumber()

TextWindow.WriteLine("Digite a segunda nota:")
nota2 = TextWindow.ReadNumber()

TextWindow.WriteLine("Digite a terceira nota:")
nota3 = TextWindow.ReadNumber()

media = nota1 + nota2 + nota3 / 3

If media >= 7 Then
	situacao = "Aprovado"
ElseIf media <= 5 Then
	situacao = "Recuperação"
Else
	situacao = "Reprovado"
EndIf

TextWindow.WriteLine("Média do aluno: " + media)
TextWindow.WriteLine("Situação: " + situacao)


"Problemas para resolver:
		1. Corrija a fórmula para calcular corretamente a média das três notas.
		2. Verifique se as notas informadas estão entre 0 e 10.
		3. Corrija a estrutura condicional e defina a situação do aluno de acordo com a média.
		4. Explique por que a ordem das operações pode alterar o resultado da média.
		5. Teste o programa com notas que resultem em aprovação, recuperação e reprovação.
"

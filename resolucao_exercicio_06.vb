"Resolução: Calcule o valor final de uma compra com desconto"

TextWindow.WriteLine("Digite o preço do produto:")
preco = TextWindow.ReadNumber()

TextWindow.WriteLine("Digite a quantidade comprada:")
quantidade = TextWindow.ReadNumber()

If preco <= 0 Or quantidade <= 0 Then
	TextWindow.WriteLine("O preço e a quantidade devem ser maiores que zero.")
Else
	total = preco * quantidade

	If total >= 100 Then
		desconto = total * 10 / 100
	Else
		desconto = 0
	EndIf

	valorFinal = total - desconto

	TextWindow.WriteLine("Valor da compra: " + total)
	TextWindow.WriteLine("Desconto: " + desconto)
	TextWindow.WriteLine("Valor final: " + valorFinal)
EndIf

"Explicação da resolução:
	1. O valor total é calculado multiplicando o preço pela quantidade.
	2. O desconto de 10 por cento é aplicado somente quando o total é maior ou igual a 100.
	3. O valor do desconto é subtraído do total para obter o valor final.
	4. A estrutura condicional rejeita preço ou quantidade iguais a zero ou negativos.
	5. A identação mostra quais instruções pertencem a cada condição.
"

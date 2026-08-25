"Exercicio: Calcule o valor final de uma compra com desconto"

TextWindow.WriteLine("Digite o preço do produto:")
preco = TextWindow.ReadNumber()

TextWindow.WriteLine("Digite a quantidade comprada:")
quantidade = TextWindow.ReadNumber()

total = preco + quantidade

If total >= 100 Then

desconto = total * 10 / 100
Else

desconto = 0
EndIf

valorFinal = total + desconto

TextWindow.WriteLine("Valor da compra: " + total)
TextWindow.WriteLine("Desconto: " + desconto)
TextWindow.WriteLine("Valor final: " + valorFinal)

"Problemas para resolver:
	1. Corrija o cálculo do valor total da compra.
	2. Aplique o desconto subtraindo-o do valor total, e não somando.
	3. Organize a identação do código.
	4. Verifique se o preço e a quantidade são valores válidos.
	5. Explique em que situação o desconto de 10 por cento deve ser aplicado.
"

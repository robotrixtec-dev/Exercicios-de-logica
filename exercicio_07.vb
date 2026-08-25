"Exercicio: Mostre a tabuada de um número"

TextWindow.WriteLine("Digite um número para ver a tabuada:")
numero = TextWindow.ReadNumber()

contador = 0
While contador <= 10
	resultado = numero + contador
	TextWindow.WriteLine(numero + " x " + contador + " = " + resultado)
	contador = contador - 1
EndWhile

"Problemas para resolver:
	1. Corrija o valor inicial do contador para começar a tabuada no 1.
	2. Corrija o cálculo do resultado da multiplicação.
	3. Corrija a atualização do contador para que o laço termine.
	4. Verifique se a condição do laço permite mostrar a tabuada até 10.
	5. Explique o que acontece quando o contador é diminuído dentro desse laço.
"

"Resolução: Mostre a tabuada de um número"

TextWindow.WriteLine("Digite um número para ver a tabuada:")
numero = TextWindow.ReadNumber()

contador = 1
While contador <= 10
	resultado = numero * contador
	TextWindow.WriteLine(numero + " x " + contador + " = " + resultado)
	contador = contador + 1
EndWhile

"Explicação da resolução:
	1. O contador começa em 1, que é o primeiro multiplicador da tabuada.
	2. O resultado é calculado multiplicando o número pelo contador.
	3. A cada repetição, o contador aumenta em 1.
	4. O laço continua enquanto o contador for menor ou igual a 10.
	5. Se o contador fosse diminuído, ele nunca alcançaria 11 e o laço poderia continuar indefinidamente.
"

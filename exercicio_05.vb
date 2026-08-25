"Exercicio: Converta uma temperatura de Celsius para Fahrenheit e Kelvin"

TextWindow.WriteLine("Digite a temperatura em Celsius:")
celsius = TextWindow.ReadNumber()

fahrenheit = celsius * 9 / 5 + 32
kelvin = celsius - 273.15

If fahrenheit < 32 Then
	situacao = "Temperatura abaixo do ponto de congelamento da água"
ElseIf fahrenheit > 212 Then
	situacao = "Temperatura acima do ponto de ebulição da água"
Else
	situacao = "Temperatura dentro da faixa entre congelamento e ebulição"
EndIf

TextWindow.WriteLine("Temperatura em Fahrenheit: " + fahrenheit)
TextWindow.WriteLine("Temperatura em Kelvin: " + kelvin)
TextWindow.WriteLine(situacao)

"Problemas para resolver:
	1. Corrija a fórmula de conversão de Celsius para Kelvin.
	2. Verifique se a fórmula de Fahrenheit está sendo calculada corretamente.
	3. Corrija os limites usados na classificação da temperatura.
	4. Explique por que uma temperatura abaixo de -273,15 graus Celsius é inválida.
	5. Teste o programa usando 0, 25 e 100 graus Celsius.
"

"Resolução: Converta uma temperatura de Celsius para Fahrenheit e Kelvin"

TextWindow.WriteLine("Digite a temperatura em Celsius:")
celsius = TextWindow.ReadNumber()

If celsius < -273.15 Then
	TextWindow.WriteLine("Temperatura inválida: abaixo do zero absoluto.")
Else
	fahrenheit = celsius * 9 / 5 + 32
	kelvin = celsius + 273.15

	If celsius < 0 Then
		situacao = "Temperatura abaixo do ponto de congelamento da água"
	ElseIf celsius > 100 Then
		situacao = "Temperatura acima do ponto de ebulição da água"
	Else
		situacao = "Temperatura dentro da faixa entre congelamento e ebulição"
	EndIf

	TextWindow.WriteLine("Temperatura em Fahrenheit: " + fahrenheit)
	TextWindow.WriteLine("Temperatura em Kelvin: " + kelvin)
	TextWindow.WriteLine(situacao)
EndIf

"Explicação da resolução:
	1. A conversão para Fahrenheit usa a fórmula (Celsius * 9 / 5) + 32.
	2. A conversão para Kelvin soma 273,15 ao valor em Celsius.
	3. A temperatura mínima possível é -273,15 graus Celsius, o zero absoluto.
	4. A classificação usa 0 e 100 graus Celsius, que são os pontos de congelamento e ebulição da água.
	5. A condição de temperatura inválida impede cálculos com valores abaixo do zero absoluto.
"

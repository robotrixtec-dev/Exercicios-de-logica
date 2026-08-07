TextWindow.WriteLine("Insira o primeiro numero: ") 
num_1 = TextWindow.Read()
TextWindow.WriteLine("Insira o segundo numero: ") 
num_2 = TextWindow.Read()


maior = ("Armazene o maior numero digitado pelo usuario")
diferenca = 
menor =

sub Maior
    if num_1>num_2 Then
      maior = num_1
      menor = num_2
    Else
      Maior = num_2
      menor = num_1
    EndIf
    TextWindow.WriteLine("O maior numero é: " + maior)
endSub

sub Diferenca
  diferenca = maior - menor
  TextWindow.WriteLine("E a diferença entre eles é de: "+diferenca)
endSub

Maior()

Diferenca()

"Explicação da montagem do código:
    1. O programa solicita ao usuário que insira dois números.
    2. Em seguida, ele compara os dois números para determinar qual é o maior e qual é o menor.
    3. A diferença entre os dois números é calculada subtraindo o menor do maior.
    4. Por fim, o programa exibe o maior número e a diferença entre eles.
"
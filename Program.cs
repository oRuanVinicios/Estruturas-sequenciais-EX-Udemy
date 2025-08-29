using System;

double baseTriangulo;
Console.WriteLine("Digite a base do triângulo:");
// Continua pedindo a base até que um número válido seja inserido
while (!double.TryParse(Console.ReadLine(), out baseTriangulo) || baseTriangulo <= 0)
{
    Console.WriteLine("Entrada inválida. Por favor, digite um número positivo para a base:");
}

double alturaTriangulo;
Console.WriteLine("Digite a altura do triângulo:");
// Continua pedindo a altura até que um número válido seja inserido
while (!double.TryParse(Console.ReadLine(), out alturaTriangulo) || alturaTriangulo <= 0)
{
    Console.WriteLine("Entrada inválida. Por favor, digite um número positivo para a altura:");
}

double areaDoTriangulo = (baseTriangulo * alturaTriangulo) / 2.0;

// Formata a saída para exibir o número com 2 casas decimais usando ":F2"
Console.WriteLine($"A área do triângulo equivale a: {areaDoTriangulo:F2}");

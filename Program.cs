string  nome1, nome2, auxiliar;

Console.WriteLine("--- Troca de valores ---\n");

Console.Write("nome1..:");
nome1 = Console.ReadLine()!;

Console.Write("nome2..:");
nome2 = Console.ReadLine()!;

auxiliar = nome1;
nome1 = nome2;
nome2 = auxiliar;

Console.WriteLine("\nApós trocar os valores temos:\n");

Console.WriteLine($"nome 1 = {nome1}");
Console.WriteLine($"nome 2 = {nome2}");
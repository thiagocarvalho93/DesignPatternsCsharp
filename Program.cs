// See https://aka.ms/new-console-template for more information
using DesignPatterns.Decorator;

Produto produto = new Produto("Camisa", 300);
System.Console.WriteLine($"Produto: {produto.Nome}\nValor: {produto.Valor}");

System.Console.WriteLine("------------ Somente com o ICB");
ImpostoDoProduto imposto = new ICB();
var valorDoImposto = imposto.Calcular(produto);
System.Console.WriteLine($"O valor do imposto é: {valorDoImposto}");

System.Console.WriteLine("------------ Somente com ICB e ICC");
imposto = new ICB(new ICC());
valorDoImposto = imposto.Calcular(produto);

System.Console.WriteLine($"O valor do imposto é: {valorDoImposto}");

System.Console.WriteLine("------------ Com ICA, ICB e ICC");
imposto = new ICA(new ICB(new ICC()));
valorDoImposto = imposto.Calcular(produto);

System.Console.WriteLine($"O valor do imposto é: {valorDoImposto}");

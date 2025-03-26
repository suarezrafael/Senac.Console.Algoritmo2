int idade = 10;
string nomeCliente = "Rafael Suarez";
decimal preco = 20M;
char letra = 'a';
var nomeCompleto = "Rafael Vieira Suarez";
var altura = 180;

Console.Write("Digite seu nome: ");
nomeCompleto = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Bem vindo " + nomeCompleto);
Console.WriteLine();
Console.Write("Digite sua idade: ");
var linha = Console.ReadLine();
idade = int.Parse(linha);
Console.WriteLine("Idade informada " + idade);
if(idade < 18)
    Console.WriteLine("Você não pode estar aqui!");

Console.ReadKey();




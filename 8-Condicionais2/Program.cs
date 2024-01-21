var data = DateTime.Today;
Console.WriteLine($"Executando projeto 8 - Condicionais, início em: {data}");

int? idade = 19;
int? quatidadePessoas = 2;
bool acompanhado = quatidadePessoas >= 2;

if (idade is not null && idade >= 18 || acompanhado)
    Console.WriteLine("Joao tem 18 anos");
else
    Console.WriteLine("Joao não tem 18 anos. Joao tem " + idade);
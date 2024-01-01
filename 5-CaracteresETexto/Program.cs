Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

//character
char primeiraLetra = 'a';
Console.WriteLine(primeiraLetra);

primeiraLetra = (char)65;
Console.WriteLine(primeiraLetra);

primeiraLetra = (char)(primeiraLetra + 1);
Console.WriteLine(primeiraLetra);

primeiraLetra &= primeiraLetra;
Console.WriteLine(primeiraLetra);

string titulo = "Um titulo qualquer " + 2023;
Console.WriteLine(titulo);

string cursos = "- .Net \n" +
    "- Java \n" +
    "- JavaScript";

Console.WriteLine(cursos);
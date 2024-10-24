int senhaCorreta = 1234;

Console.WriteLine($"Qual a sua senha?");
int senha = int.Parse(Console.ReadLine());

if (senha == senhaCorreta){
    Console.WriteLine($"ACESSO PERMITIDO");
}

else {
    Console.WriteLine($"ACESSO NEGADO");
}




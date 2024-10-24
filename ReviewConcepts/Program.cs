//variáveis e tipos de dados

    Console.WriteLine($"Olá, digite seu nome: ");
    string nome = Console.ReadLine()!;

    Console.WriteLine($"Ola {nome}, digite seu sobrenome: ");
    string sobrenome = Console.ReadLine()!;

    Console.WriteLine($"Mais algumas informações... Digite seu E-mail:");
    string email = Console.ReadLine()!;

    Console.WriteLine($"Telefone:");
    int telefone = int.Parse(Console.ReadLine()!);

    Console.WriteLine($"Seu CPF: ");
    int cpf = int.Parse(Console.ReadLine()!);

    Console.WriteLine($"E seu endereço:");
    string endereco = Console.ReadLine()!;

    Console.WriteLine($"Estado Civil:");
    string estadoCivil = Console.ReadLine()!;

    Console.WriteLine($"Digite a sua idade:");
    int idade = int.Parse(Console.ReadLine()!);

    int anoAtual = DateTime.Now.Year;
    int anoNascimento = anoAtual - idade;


    Console.WriteLine(@$"Obrigado: 
    - Nome: {nome} {sobrenome}
    - Idade: {idade} - {anoNascimento}
    - Email: {email}
    - Contato: {telefone}
    - CPF: {cpf}
    - Endereço: {endereco}
    - Estado Civil: {estadoCivil}");
    
    
    
    

    
    
    
    

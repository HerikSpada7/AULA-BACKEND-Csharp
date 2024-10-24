string[] carros = new string[3];
// o array começa do 0 até o seu limite, no caso aqui o limite é 3 ou seja, 0,1,2 (esses são 3 pois conta o 0)

for (int i = 0; i < carros.Lenght; i++){

Console.WriteLine($"Digite o nome do carro a ser cadastrado");
carros[i] = Console.ReadLine();
}

Console.WriteLine($"Carros cadastrados: {carros[0]}, {carros[1]}, {carros[2]}");

 
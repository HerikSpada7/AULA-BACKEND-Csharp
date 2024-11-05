string[] frutas = {"Melancia", "Carambola", "Maracujá", "Morango", "Limão", "Jabuticaba", "Abacate", "Kiwi", "Acerola", "Pinha", "Linchia", "Pitaya", "Pêssego", "Banana"};

Console.Write($"Sua sacola contém {frutas.Length} frutas!");

foreach (string f in frutas){
    Console.Write($"{f}, ");
}

Console.WriteLine();


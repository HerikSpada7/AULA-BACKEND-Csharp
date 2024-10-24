float frequenciaAceitavel = 75;

Console.Write("Digite a frequência do aluno em: ");
float frequencia = float.Parse(Console.ReadLine()!);

Console.Write("Digite a média do aluno: ");
float media = float.Parse(Console.ReadLine()!);

if(frequencia < frequenciaAceitavel && media <= 7 && media >= 3){
    Console.WriteLine("Recuperação");  
} 

else if (media >= 7.0){
    Console.WriteLine("Aluno aprovado.");
}

else {
    Console.WriteLine("Aluno reprovado.");
}
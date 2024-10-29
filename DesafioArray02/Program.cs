int [] arrayNumeros1 = {2, 4, 12, 21, 10, 27, 19, 11, 13, 9};
int [] arrayNumeros2 = {3, 6, 13, 22, 11, 27, 20, 12, 14, 10};

for (int i = 0; i < arrayNumeros1.Length; i++)
{
    if(i % 2 == 0 ){
        Console.WriteLine($"{arrayNumeros1[i]}");
        
    }else{
        Console.WriteLine($"{arrayNumeros2[i]}"); 
    }
}




namespace Calculator.Classes
{
    public class Calculadora
    {
        public float numero1;
        public float numero2;

    public void Somar()
    {
        float resultadoMais = numero1 + numero2;
        Console.WriteLine($"Resultado da soma é: {resultadoMais}");
        
    }

    public void Subtrair()
    {
        float resultadoMenos = numero1 - numero2;
        Console.WriteLine($"Resultado da subtração é: {resultadoMenos}");
    }

    public void Multiplicar()
    {
        float resultadoMultiplicado = numero1 * numero2;
        Console.WriteLine($"Resultado da sua multiplicação é: {resultadoMultiplicado}");
    }

    public void Dividir()
    {
        float resultadoDividido = numero1 / numero2;
        Console.WriteLine($"Resultado da sua divisão é: {resultadoDividido}");
    }
    }
}
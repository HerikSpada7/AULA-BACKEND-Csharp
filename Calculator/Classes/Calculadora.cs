namespace Calculator.Classes
{
    public class Calculadora
    {
        public float numero1;
        public float numero2;

    public void Somar(float resultadoMais)
    {
        resultadoMais = numero1 + numero2;
    }

    public void Subtrair(float resultadoMenos)
    {
        resultadoMenos = numero1 - numero2;
    }

    public void Multiplicar(float resultadoMultiplicado)
    {
        resultadoMultiplicado = numero1 * numero2;
    }

    public void Dividir(float resultadoDividido)
    {
        resultadoDividido = numero1 / numero2;
    }
    }
}
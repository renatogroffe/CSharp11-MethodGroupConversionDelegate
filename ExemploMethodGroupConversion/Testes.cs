namespace ExemploMethodGroupConversion;

public static class Testes
{
    private static readonly List<int> Numeros = new List<int>() { 32, 28, 9, 67, 26, 59, 36, 41, 49 };

    public static List<int> ListarNumerosImpares()
    {
        return Numeros.Where(n => NumeroImpar(n)).ToList();
    }

    public static List<int> ListarNumerosImparesV2()
    {
        return Numeros.Where(NumeroImpar).ToList();
    }

    private static bool NumeroImpar(int numero) => numero % 2 != 0;
}

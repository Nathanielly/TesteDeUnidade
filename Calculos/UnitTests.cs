
namespace Calculo;

// 1 - Em um novo projeto, chamado UnitTests, crie 3 funções para serem alvo dos testes de unidade. São funções para calcular:
//área de um cubo, área de um paralelogramo, e área de uma pirâmide.
public class Calculos
{
    public static double CalcularAreaDoCubo(int aresta)
    {
        double areaCubo = 6 * Math.Pow(aresta,2);
        return areaCubo;
    }
    public static int CalcularAreaDoParalelogramo(int b, int h)
    {
        int areaParalelogramo = b * h;
        return areaParalelogramo;
    }
    public static int CalcularAreaDaPiramide(int ab, int al)
    {
        int areaPiramide = ab + al;
        return areaPiramide;

        //devido ser uma fórmula mais complexa, aqui já estou considerando que a área da base(ab) e das laterais(al) já foram calculadas.
    }

    public static void Main()
    {
        Console.WriteLine("Considerando que a aresta de um cubo é 2, a área do cubo é igual a: " + CalcularAreaDoCubo(2));
        Console.WriteLine("Considerando que um paralelogramo tenha a base igual a 2 e a altura igual a 3, a área do paralelogramo é igual a: " + CalcularAreaDoParalelogramo(2,3));
        Console.WriteLine("Considerando que uma pirâmide tenha a base igual a 3 e a altura igual a 4, a área da pirâmide é igual a: " + CalcularAreaDaPiramide(3,4));

    }
    
}
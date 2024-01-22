using Calculo;
using NUnit.Framework;

namespace TesteCalculos.Tests;

public class Tests
{
    

    [SetUp]
    public void Setup(){}

    public static IEnumerable<TestCaseData> LerDadosDeTeste()
    {
        string caminhoMassa = @"C:\Iterasys\TesteDeUnidade\TesteCalculos.Tests\fixtures\massaDeDados.csv";

        using (var leitor = new StreamReader(caminhoMassa))
        {
            leitor.ReadLine();
            
            while(!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                var valores = linha.Split(",");

                yield return new TestCaseData(int.Parse(valores[0]), int.Parse(valores[1]), 
                                              int.Parse(valores[2])); 
            }
        }
    }

    //2 - Crie dois testes de unidade simples (um positivo e um negativo) baseados em valores fixos para a função de cálculo da área do cubo
    [Test]
    public void TestePositivoCalcularAreaDoCubo()
    {
        int aresta = 2;
        double resultadoEsperado = 24;

        double resultadoAtual = Calculos.CalcularAreaDoCubo(aresta);

        Assert.That(resultadoEsperado, Is.EqualTo(resultadoAtual));
    }

    [Test]
    public void TesteNegativoCalcularAreaDoCubo()
    {
        int aresta = 3;
        int resultadoEsperado = 24;

        double resultadoAtual = Calculos.CalcularAreaDoCubo(aresta);

        Assert.That(resultadoEsperado, Is.Not.EqualTo(resultadoAtual));
    }

    //3 - Crie um teste de unidade utilizando TestCase de pelo menos 3 conjuntos de valores como massa de teste, sendo pelo menos 1 teste positivo e
    //2 testes negativos, para a função de cálculo da área do paralelogramo.

    [TestCase(2,9,18)]
    [TestCase(6,6,36)]
    [TestCase(10,10,100)]
    public void TestePositivoCalcularAreaDoParalelogramo(int b, int h, int resultadoEsperado)
    {
        double resultadoAtual = Calculos.CalcularAreaDoParalelogramo(b,h);

        Assert.That(resultadoEsperado, Is.EqualTo(resultadoAtual));
    }

    [TestCase(2,9,11)]
    [TestCase(6,6,35)]
    [TestCase(10,10,10)]
    public void TesteNegativoCalcularAreaDoParalelogramo(int b, int h, int resultadoEsperado)
    {
        double resultadoAtual = Calculos.CalcularAreaDoParalelogramo(b,h);

        Assert.That(resultadoEsperado, Is.Not.EqualTo(resultadoAtual));
    }


    // 4 - Crie um teste de unidade com um arquivo CSV de pelo menos 3 valores como massa de teste, sendo pelo menos 1 teste positivo e 2 testes negativos, para a função de cálculo da área da pirâmide
    [Test, TestCaseSource("LerDadosDeTeste")]
    public void TestePositivoCalcularAreaDaPiramide(int ab, int al, int resultadoEsperado)
    {
      
        double resultadoAtual = Calculos.CalcularAreaDaPiramide(ab,al);

        Assert.That(resultadoEsperado, Is.EqualTo(resultadoAtual));
    }

    [Test, TestCaseSource("LerDadosDeTeste")]
    public void TesteNegativoCalcularAreaDaPiramide(int ab, int al, int resultadoEsperado)
    {
      
        double resultadoAtual = Calculos.CalcularAreaDaPiramide(ab,al);

        Assert.That(resultadoEsperado + 1, Is.Not.EqualTo(resultadoAtual));
    }

}
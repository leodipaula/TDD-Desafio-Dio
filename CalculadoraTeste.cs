using Desafio_Dio_7.Services;
using Microsoft.VisualBasic;

namespace CalculadoraTestes;

public class CalculadoraTeste
{

    [Fact]
    public void Soma3Mais2_Retorna5()
    {
        int num1 = 3;
        int num2 = 2;

        var resultado = Calculadora.Soma(num1, num2);

        Assert.Equal(5, resultado);
    }

    [Fact]
    public void Soma3Virgula2Mais3_Retorna6Virgula2()
    {
        float num1 = 3.2f;
        int num2 = 3;

        var resultado = Calculadora.Soma(num1, num2);

        Assert.Equal(num1 + num2, resultado);
    }

    [Fact]
    public void TentaSomarStrings_RetornaOperacaoNaoSuportada()
    {
        string palavra = "invalido";
        string palavra2 = "Tambem invalido";

        var resultado = Calculadora.Soma(palavra, palavra2);

        Assert.Equal("Operação não suportada.", resultado);
    }

    [Fact]
    public void Subtrai8Menos2_Retorna6() 
    {
        int num1 = 8;
        int num2 = 2;

        var resultado = Calculadora.Diferenca(num1, num2);

        Assert.Equal(6, resultado);
    }

    [Fact]
    public void Multiplica10Vezes10_Retorna100() 
    {
        int num1 = 10;
        int num2 = 10;

        var resultado = Calculadora.Multiplica(num1, num2);

        Assert.Equal(100, resultado);
    }

    [Fact]
    public void Divide15por3_Retorna5() 
    {
        int num1 = 15;
        int num2 = 3;

        var resultado = Calculadora.Divide(num1, num2);

        Assert.Equal(5, resultado);
    }

    [Fact]
    public void TentaDividirPorZero_RetornaATentativaDeCrime()
    {
        int zero = 0;
        double num = 34.8976324;
        object resultado = 0;
        try {
            resultado = Calculadora.Divide(num, zero);
        } catch (DivideByZeroException Error) {
            resultado = Error.Message;
        }
        Assert.Equal("Dividir por zero é crime.", resultado);
    }

    [Fact]
    public void Dividir455Por33Virgula33_Retornar13Virgula65()
    {
        int num1 = 455;
        float num2 = 33.33f;

        var resultado = Calculadora.Divide(num1, num2);

        Assert.Equal(num1/num2, resultado);
    }
}
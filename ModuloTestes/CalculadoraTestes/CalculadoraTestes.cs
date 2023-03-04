using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        // Arrange
        int num1 = 10;
        int num2 = 10;

        // Act
        int resultado = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveVerificarSe2EhParERetornarVerdadeiro()
    {
        // Arrange
        int num = 2;

        // Act
        bool resultado = _calc.EhPar(num);

        // Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int num)
    {
        // Act
        bool resultado = _calc.EhPar(num);

        // Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] { 120, 144 })]
    [InlineData(new int[] { 622, 812, 1000 })]
    public void DeveVerificarSeMaisNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
        // Act / Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
}

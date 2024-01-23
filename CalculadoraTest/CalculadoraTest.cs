using Calculadora.Services;

namespace CalculadoraTest;

public class CalculadoraTest
{
    private CalculadoraImp _calc;

    public CalculadoraTest()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomarCincoComDezRetornarQuinze()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;
        // Act
        int result = _calc.Somar(num1, num2);
        // Assert
        Assert.Equal(15,result);

    }

    [Fact]
    public void DeveSomarDezComDezRetornarVinte()
    {
        // Arrange
        int num1 = 10;
        int num2 = 10;
        // Act
        int result = _calc.Somar(num1, num2);
        // Assert
        Assert.Equal(20,result);

    }
}
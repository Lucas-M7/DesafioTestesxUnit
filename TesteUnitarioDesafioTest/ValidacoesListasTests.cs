using TesteUnitarioDesafioConsole.Services.Lista;

namespace TesteUnitarioDesafioTest;

public class ValidacoesListasTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void RemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -5, -34, 45, 62 };
        var resultadoEsperado = new List<int> { 5, 45, 62 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void ConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -5, -34, 45, 62 };
        var numeroParaProcurar = 45;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero7NaLista()
    {
        // Arrange
        var lista = new List<int> { 6, 77, -7, 52 };
        var numeroParaProcurar = 7;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.False(resultado);
    }


    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };

        // Act
        var resultado = _validacoes.MultiplicarNumerosLista(lista, 2);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var resultado = _validacoes.RetornarMaiorNumeroLista(lista);
        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(9, resultado);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(-8, resultado);
    }
}
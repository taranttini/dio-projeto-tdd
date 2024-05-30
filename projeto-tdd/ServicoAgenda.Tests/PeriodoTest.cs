namespace ServicoAgenda.Tests;

public class PeriodoTest
{
    [Fact]
    public void Periodo_EhDiaDeSemana()
    {
        var periodo = new ServicoAgenda.Periodo();
        var diaDeSemana = new DateTime(2024,05,29); // seg, ter, qua, qui e sex

        var resultado = periodo.EhDiaDeSemana(diaDeSemana);

        Assert.True(resultado);
    }

    [Fact]
    public void Periodo_NaoEhDiaDeSemana()
    {
        var periodo = new ServicoAgenda.Periodo();
        var diaFinalDeSemana = new DateTime(2024,06,01); // sab e dom

        var resultado = periodo.EhDiaDeSemana(diaFinalDeSemana);

        Assert.False(resultado);
    }

    [Fact]
    public void Periodo_EhHorarioComercial()
    {
        var periodo = new ServicoAgenda.Periodo();
        var horarioComercial = new DateTime(2024,05,29,10,00,00); // horario entre às 8:00 até às 19:00

        var resultado = periodo.EhHorarioComercial(horarioComercial);

        Assert.True(resultado);
    }

    [Fact]
    public void Periodo_NaoEhHorarioComercial()
    {
        var periodo = new ServicoAgenda.Periodo();
        var horarioNaoComercial = new DateTime(2024,05,29,07,30,00); // horario fora das 8:00 até às 19:00

        var resultado = periodo.EhHorarioComercial(horarioNaoComercial);

        Assert.False(resultado);
    }

    [Fact]
    public void Periodo_EhValido()
    {
        var periodo = new ServicoAgenda.Periodo();
        var periodoValido = new DateTime(2024,05,29,12,00,00); // seg à sex das 8:00 até às 19:00

        var resultado = periodo.EhValido(periodoValido);

        Assert.True(resultado);
    }

    [Fact]
    public void Periodo_NaoEhValido()
    {
        var periodo = new ServicoAgenda.Periodo();
        var periodoNaoEhValido = new DateTime(2024,05,29,20,00,00); // fora de seg à sex das 8:00 até às 19:00

        var resultado = periodo.EhValido(periodoNaoEhValido);

        Assert.False(resultado);
    }
}

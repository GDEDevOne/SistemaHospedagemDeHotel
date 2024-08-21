
namespace SistemaHospedagemDeHotel.Models;

public class Reserva(int diasReservados, Suite suite)
{
    public int DiasReservados { get; set; } = diasReservados;
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; } = suite;

    public void CadastrarHospedes(List<Pessoa> pessoa)
    {
        if (Suite.Capacidade >= pessoa.Count)
        {
            Hospedes = pessoa;
        } else {
            throw new Exception($"Nº de hospedes ({pessoa.Count}) é maior que a capacidade da suite ({Suite.Capacidade}).)");
        }
    }

    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {
        decimal valor = DiasReservados * Suite.ValorDiaria;
        if (DiasReservados >= 10)
        {
            return valor - (valor * 0.10M);
        } 

        return valor;
    }
}
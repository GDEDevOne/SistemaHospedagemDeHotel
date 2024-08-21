using System.Text;
using SistemaHospedagemDeHotel.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = [];

Pessoa p1 = new("Guilherme", "Evedove");
Pessoa p2 = new("Evedove", "Guilherme");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new(tipoSuite: "Premium", capacidade: 1, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new(10, suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
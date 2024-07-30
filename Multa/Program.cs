

using Multa;
using System.Globalization;

Console.WriteLine("contratos");

//contratos
List<Contratos> Contrato = new List<Contratos>();
Contrato.Add(new Contratos("moto"));
Contrato.Add(new Contratos("carro"));
Contrato.Add(new Contratos("aviao"));
Contrato.Add(new Contratos("casa"));
Contrato.Add(new Contratos("apartamento"));
Contrato.Add(new Contratos("garagem"));

//cliente
Clientes Pedro = new Clientes("Pedro", true);


Console.WriteLine("quais contratos vc quer?");
int i = 1;

void PuleMes() {
    
}
void MostrarContratos(int i) {
    foreach (var contratinho in Contrato) {

        Console.WriteLine($"({i})-{contratinho}");
        i++;
    }
}
//mostrando os contratos
MostrarContratos(i);

//escolhendo contratos
Console.WriteLine("escolha um contrato:");
int N = 1;
switch (N) {
    case 1:
        Pedro.AddContrato(Contrato[N]);
        break;
    case 2:
        Pedro.AddContrato(Contrato[N]);
        break;
    case 3:
        Pedro.AddContrato(Contrato[N]);
        break;
    case 4:
        Pedro.AddContrato(Contrato[N]);
        break;
    case 5:
        Pedro.AddContrato(Contrato[N]);
        break;
    case 6:
        Pedro.AddContrato(Contrato[N]);
        break;
    default: break;
}

Console.WriteLine(Pedro);
Pedro.MostrarContratos();
Console.WriteLine(Pedro);
Pedro.PularMes(3);
Pedro.MostrarContratos();

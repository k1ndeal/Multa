

using Multa;
using System.Globalization;

Console.WriteLine("-------CONTRATOS-------");
DateTime Agora = new DateTime(2020, 03, 01);

//contratos
List<Contratos> Contrato = new List<Contratos>();
Contrato.Add(new Contratos("moto", Agora));
Contrato.Add(new Contratos("carro", Agora));
Contrato.Add(new Contratos("aviao", Agora));
Contrato.Add(new Contratos("casa", Agora));
Contrato.Add(new Contratos("apartamento", Agora));
Contrato.Add(new Contratos("garagem", Agora));

//cliente
Clientes Pedro = new Clientes("Pedro", true);
//                                                           Funcoes

void EscolherContrato() {
    //escolhendo contratos
    Console.WriteLine("escolha um contrato:");
    int i = 1;
    MostrarContratos(i);
    int N = int.Parse(Console.ReadLine()) - 1;

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

}
void MostrarContratos(int i) {
    foreach (var contratinho in Contrato) {

        Console.WriteLine($"({i})-{contratinho} ");
        i++;
    }
}




while (true) {
    Pedro.verificacao(Agora);

    Console.WriteLine(Agora.ToString("dd/MM/yyyy"));

   
        Console.WriteLine("quais contratos vc quer?");





        EscolherContrato();

       
    while (true) {
        Console.WriteLine("gostaria de fazer mais contratos este mes?(S1/N2)");
        int N = int.Parse(Console.ReadLine());
        if (N == 2) {
            Console.WriteLine($" {Pedro} Data:{Agora.ToString("dd/MM/yyyy")}");
            Pedro.ContratosDoCliente();

            Agora.AddMonths(1);
            break;
        }
        else {
            EscolherContrato();
        }

        
    }
}



using Multa;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

Console.WriteLine("-------CONTRATOS-------");
DateTime Agora = new DateTime(2020, 03, 01);

//contratos
List<Contratos> ContratoPrinc = new List<Contratos>();
ContratoPrinc.Add(new Contratos("Moto", Agora));
ContratoPrinc.Add(new Contratos("Carro", Agora));
ContratoPrinc.Add(new Contratos("Aviao", Agora));
ContratoPrinc.Add(new Contratos("Casa", Agora));
ContratoPrinc.Add(new Contratos("Apartamento", Agora));
ContratoPrinc.Add(new Contratos("Garagem", Agora));

//cliente
Clientes Pedro = new Clientes("Pedro", true);
//                                                           Funcoes
void MostrarContratos(int i) {
    foreach (var contratinho in ContratoPrinc) {

        Console.WriteLine($"({i})-{contratinho} ");
        i++;
    }
}
void EscolherContrato() {
    //escolhendo contratos
    Console.WriteLine("escolha um contrato:");
    int i = 1;
    MostrarContratos(i);
    Console.WriteLine("PRESS '8' PARA SAIR");
    int N = int.Parse(Console.ReadLine()) - 1;
    bool VerificarContrato;

    while (true) {
        // Verifica se o contrato já existe antes de entrar no switch
        if (N == 7) {
            break;
        }
        if (Pedro.ContratosAtivos.Contains(ContratoPrinc[N])) {
            Console.WriteLine("Este contrato já existe! Escolha outro.");
            N = int.Parse(Console.ReadLine()) - 1;
            continue;
            // Continue no loop para pedir um novo contrato

        }
        else {
            switch (N) {
                case 0:

                    VerificarContrato = Pedro.ContratosAtivos.Contains(ContratoPrinc[N]);
                    if (VerificarContrato == false) {
                        Pedro.AddContrato(ContratoPrinc[N]);
                        break; // Sai do switch
                    }
                    else {
                        Console.WriteLine("ja tem");
                    }
                    break; // Sai do switch
                case 1:
                    Pedro.AddContrato(ContratoPrinc[N]);
                    break; // Sai do switch


                case 2:
                    Pedro.AddContrato(ContratoPrinc[N]);
                    break; // Sai do switch

                case 3:
                    Pedro.AddContrato(ContratoPrinc[N]);
                    break; // Sai do switch

                case 4:
                    Pedro.AddContrato(ContratoPrinc[N]);
                    break; // Sai do switch
                case 5:
                    Pedro.AddContrato(ContratoPrinc[N]);
                    break; // Sai do switch

                default:
                    break;
            }
            break;
        }
    }




}


while (true) {

    Console.WriteLine(Agora.ToString("dd/MM/yyyy"));


    Console.WriteLine("quais contratos vc quer?");





    EscolherContrato();


    while (true) {
        Console.WriteLine("gostaria de fazer mais contratos este mes?(S/N)");
        string N = (Console.ReadLine());
        if (N == "n") {
            Console.WriteLine($" {Pedro} Data:{Agora.ToString("dd/MM/yyyy")}");
            Pedro.ContratosDoCliente();
            Console.ReadLine();
            Agora = Agora.AddMonths(1);
            break;
        }
        else {
            EscolherContrato();
        }


    }
    Pedro.verificacao(Agora);

    Console.Clear();
}
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Multa {
    internal class Clientes {

        public string Cliente { get; set; }
        public bool Status { get; private set; }
        public List<Contratos> ContratosAtivos = new List<Contratos>();

        public Clientes(string nome, bool status) {
            Cliente = nome;
            Status = status;

        }
        //aki usei uma classe para colocar contratos nesta classe
        public void AddContrato(Contratos contratos) {
            ContratosAtivos.Add(contratos);
        }

        public void verificacao(DateTime agora) {
            List<Contratos> CopiaContratosAtivos = ContratosAtivos.ToList();

            Console.WriteLine($"{agora.ToString("dd/MM/yyyy")}");
            for (int i = 0; i <= CopiaContratosAtivos.Count; i++) {

                Console.WriteLine($"{CopiaContratosAtivos[i]} Venceu! ");
                Console.WriteLine("renovar ou n renovar?(S/N)");
                string Res = Console.ReadLine();
                if (Res == "s") {
                    Console.WriteLine("quanto é 5 + 8?");
                    int Resposta = int.Parse(Console.ReadLine());
                    if (Resposta == 13) {
                        ContratosAtivos[i].MudandoData(agora);
                        Console.WriteLine($"{CopiaContratosAtivos[i]} Contrato renovado! {CopiaContratosAtivos[i].Contratacao}");
                    }
                    else {

                        for (int chances = 2; i > 0; i--) {
                            Console.WriteLine("Resposta errada!");
                            Console.WriteLine($"Voce tem mais {chances} chances!");
                        }
                    }
                }
                else {
                    ContratosAtivos.Remove(ContratosAtivos[i]);
                    Console.WriteLine($"Contrato  {CopiaContratosAtivos[i]} removido!");
                }

            }

        }


        public void ContratosDoCliente() {
            foreach (Contratos contratin in ContratosAtivos) {
                Console.WriteLine($"{contratin}, " +
                    $"Data de Contratação: {contratin.Contratacao.ToString("dd/MM/yyyy")}, " +
                    $"Vencimento: {contratin.Vencimento.ToString("dd/MM/yyyy")}");
            }
        }

        //pulando mes 

        public override string ToString() {
            return $"{Cliente}";
        }







    }
}

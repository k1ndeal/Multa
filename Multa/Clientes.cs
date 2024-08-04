using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Multa {
    internal class Clientes {

        public string Cliente { get; set; }
        public bool Status { get; private set; }
        public List<Contratos> Contratos = new List<Contratos>();

        public Clientes(string nome, bool status) {
            Cliente = nome;
            Status = status;

        }
        //aki usei uma classe para colocar contratos nesta classe
        public void AddContrato(Contratos contratos) {
            Contratos.Add(contratos);
        }

        public void verificacao(DateTime agora) {
           for (int i = 0; i < Contratos.Count; i++) {
                if (Contratos[i].Vencimento <= agora) {
                    Console.WriteLine($"{Contratos[i]} venceu ");
                    Console.WriteLine("renovar ou n renovar?(S/N)");
                    string Res = Console.ReadLine();
                    if (Res == "s") {
                        Console.WriteLine("quanto é 5 + 8?");
                        int Resposta = int.Parse(Console.ReadLine());
                        if (Resposta == 13) {
                            Contratos[i].MudandoData(agora);
                            Console.WriteLine($"{Contratos[i]} Contrato renovado! {Contratos[i].Contratacao}");
                        }
                    }
                    else {
                        Contratos.Remove(Contratos[i]);
                        Console.WriteLine("contrato removido!");
                    }

                }
            }
        }


            public void ContratosDoCliente() {
                foreach (Contratos contratin in Contratos) {
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

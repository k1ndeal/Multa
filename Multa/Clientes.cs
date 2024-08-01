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
            foreach (Contratos contratin in Contratos) {
                if (contratin.Contratacao >= agora) {
                    Console.WriteLine("renovar ou n renovar?");
                    string Res = Console.ReadLine();
                    if (Res == "s") {
                        Console.WriteLine("quanto é 5 + 8?");
                        int Resposta = int.Parse(Console.ReadLine());
                        if (Resposta == 13) {
                            contratin.AcessoAContrat(agora);
                            Console.WriteLine($"{contratin} Contrato renovado! {contratin.Contratacao}");
                        }
                    }
                    else {
                        Contratos.Remove(contratin);
                        Console.WriteLine("contrato removido!");
                    }

                }
            }
        }


            public void ContratosDoCliente() {
                foreach (Contratos contratin in Contratos) {
                    Console.WriteLine($"{contratin} Data de Contratação: {contratin.Contratacao}");
                }
            }

        //pulando mes 

        public override string ToString() {
            return $"{Cliente}";
        }







    }
}

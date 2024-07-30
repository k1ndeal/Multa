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

        public void MudarStatusDevendo(bool status) {
            if (status == true) {
                Status = false;
            }


        }
        public void MudarStatusPago(bool status) {
            if (status == false) {
                status = true;
            }
        }

        public void MostrarContratos() {
            foreach (Contratos contratin in Contratos) {
                Console.WriteLine(contratin);
            }
        }

        //pulando mes 
        public void PularMes(int? mude) {

            foreach (Contratos contratin in Contratos) {
                contratin.PuleOMes(mude);
            }


        }

        public override string ToString() {
            return $"{Cliente},{Status}";
        }







    }
}

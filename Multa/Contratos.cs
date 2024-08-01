using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multa {
    internal class Contratos {
        
        public string Contrato { get; private set; }
        public string Status { get; private set; }
           
        public DateTime Contratacao { get; private set; }


        public Contratos(string contrato,DateTime agora) {
            Contrato = contrato;
            Contratacao = agora;
        }


        public void AcessoAContrat(DateTime teste) {
         Contratacao = teste;
        }


   

        public override string ToString() {
            return $"{Contrato}";

        }



    }
}

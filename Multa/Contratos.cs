using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multa {
    internal class Contratos {
        
        public string Nome_Contrato { get; private set; }
   
        public DateTime Vencimento { get; private set; }
        public DateTime Contratacao { get; private set; }


        public Contratos(string contrato,DateTime agora) {
            Nome_Contrato = contrato;
            Contratacao = agora;
            Vencimento = agora.AddMonths(3);
        }


        public void AcessoAContrat(DateTime teste) {
         Contratacao = teste;
        }


   

        public override string ToString() {
            return $"{Nome_Contrato}";

        }



    }
}

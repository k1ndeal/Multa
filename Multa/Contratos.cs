using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multa {
    internal class Contratos {
        public string Contrato { get; private set; }
        public bool Status { get; private set; }
        private DateTime _contratacao { get; set; }


        public Contratos(string contrato) {
            Contrato = contrato;
            Status = true;
            _contratacao = DateTime.Now;
        }


        public void AtivoOuNaoAtivo(bool satus, bool Res) {
            if (Res == true) {
                Status = true;

            }
            else {
                Status = false;
            }

        }


        //pulando mes 
        public void PuleOMes(int? Mudar ) {
            if (Mudar == null) {
                _contratacao = _contratacao.AddMonths(1);

            }
            else {
                _contratacao = _contratacao.AddMonths((int)Mudar);

            }
        }


        public override string ToString() {
            return $"{Contrato}, Contrato fechado em:{_contratacao.ToString("dd/MM/yyyy")} ";

        }



    }
}

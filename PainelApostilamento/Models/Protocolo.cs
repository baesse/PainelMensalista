using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PainelApostilamento.Models
{
    public class Protocolo
    {
        public String PROTOCOLO;
        public String NomeCliente;
        public String Revisao;
        public String Pronto;


        public Protocolo(String PROTOCOLO, String NomeCliente, String Revisao, String Pronto)
        {
            this.PROTOCOLO = PROTOCOLO;
            this.NomeCliente = NomeCliente;
            this.Revisao = Revisao;
            this.Pronto = Pronto;

        }

    }
}
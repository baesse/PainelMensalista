using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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


        
       

        public void CadastrarNovoProtocolo(Protocolo protocolo)
        {
            SqlConnection conexao = Models.Banco.GetConexao();
            SqlCommand comando = Models.Banco.GetComando(conexao);
            comando.CommandText = "insert into protocolos (protocolo,nomecliente,previsao,pronto) values (@protocolo,@nomecliente,@previsao,@pronto)";
            comando.Parameters.AddWithValue("@protocolo", protocolo.PROTOCOLO);
            comando.Parameters.AddWithValue("@nomecliente", protocolo.NomeCliente);
            comando.Parameters.AddWithValue("@previsao", protocolo.Revisao);
            comando.Parameters.AddWithValue("@pronto", protocolo.Pronto);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

    }
}
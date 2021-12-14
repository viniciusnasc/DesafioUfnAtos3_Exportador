using DesafioUfnAtos3.Banco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioUfnAtos3.Entities
{
    public class Produtos
    {
        public string Id { get; set; }
        public string CodEAN { get; set; }
        public string Nome { get; set; }
        public string Preco { get; set; }
        public string Estoque { get; set; }

        public override string ToString()
        {
            return Id + "-" + CodEAN + "-" + Nome + "-" + Preco + "-" + Estoque;
        }

        public List<Produtos> ListarProdutos()
        {
            List<Produtos> lista = new();
            Contexto banco = new();
            string sql = "select * From Produtos";
            DataTable dt = banco.ExecutarConsultaGenerica(sql);

            foreach (DataRow objeto in dt.Rows)
            {
                Produtos p = new();
                p.Id = (lista.Count + 1).ToString();
                p.CodEAN = objeto.ItemArray[0].ToString();
                p.Nome = objeto.ItemArray[1].ToString();
                p.Preco = objeto.ItemArray[2].ToString();
                p.Estoque = objeto.ItemArray[3].ToString();

                if(p.Estoque != "0" && p.Estoque != "")
                lista.Add(p);
            }
            return lista;
        }
    }
}

using DesafioUfnAtos3.Banco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioUfnAtos3.Entities
{
    public class Clientes
    {
        public string Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return Id + "-" + Cpf + "-" + Nome + "-" + Telefone + "-" + Email;
        }

        public List<Clientes> ListarClientes()
        {
            List<Clientes> lista = new();
            Contexto banco = new();
            string sql = "select * From Clientes";
            DataTable dt = banco.ExecutarConsultaGenerica(sql);

            foreach (DataRow objeto in dt.Rows)
            {
                Clientes c = new();
                c.Id = (lista.Count+1).ToString();
                c.Cpf = objeto.ItemArray[0].ToString();
                c.Nome = objeto.ItemArray[1].ToString();
                c.Telefone = objeto.ItemArray[2].ToString();
                c.Email = objeto.ItemArray[3].ToString();

                if (!String.IsNullOrWhiteSpace(c.Nome))
                    lista.Add(c);
            }

            return lista;
        }
    }
}

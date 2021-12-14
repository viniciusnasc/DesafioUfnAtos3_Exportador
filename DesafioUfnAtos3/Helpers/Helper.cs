using DesafioUfnAtos3.Banco;
using DesafioUfnAtos3.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioUfnAtos3.Helpers
{
    internal class Helper
    {
        public string Path { get; set; }

        public Helper(string path)
        {
            Path = path;
        }

        public string CriarArquivo(List<Clientes> lista)
        {
            Path += @"\Clientes.txt";
            
            using (StreamWriter sw = File.CreateText(Path))
            {
                sw.WriteLine(PegarPrimeiraLinha(lista[0]));
                foreach (var objeto in lista)
                {
                    sw.WriteLine(objeto);
                }
            }
            return "Arquivo criado";
        }

        public string CriarArquivo(List<Produtos> lista)
        {
            Path += @"\Produtos.txt";

            using (StreamWriter sw = File.CreateText(Path))
            {
                sw.WriteLine(PegarPrimeiraLinha(lista[0]));
                foreach (var objeto in lista)
                {
                    sw.WriteLine(objeto);
                }
            }
            return "Arquivo criado";
        }

        private string PegarPrimeiraLinha(object objeto)
        {
            string primeiraLinha = "Id-";
            string sql = "";

            Contexto banco = new();
            if(objeto.GetType() == typeof(Produtos))
                sql = $"select * From Produtos";
            else
                sql = $"select * From Clientes";

            DataTable dt = banco.ExecutarConsultaGenerica(sql);

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                if (i == dt.Columns.Count - 1)
                    primeiraLinha += dt.Columns[i];

                else
                    primeiraLinha += dt.Columns[i] + "-";
            }

            return primeiraLinha;
        }
    }
}

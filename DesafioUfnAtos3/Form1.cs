using DesafioUfnAtos3.Entities;
using DesafioUfnAtos3.Helpers;

namespace DesafioUfnAtos3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            Clientes clientes = new Clientes();
            Helper helper = new Helper(folderBrowserDialog1.SelectedPath);

            List<Clientes> lista = clientes.ListarClientes();
            MessageBox.Show(helper.CriarArquivo(lista));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            Produtos produtos = new();
            Helper helper = new(folderBrowserDialog1.SelectedPath);

            List<Produtos> lista = produtos.ListarProdutos();
            MessageBox.Show(helper.CriarArquivo(lista));
        }
    }
}
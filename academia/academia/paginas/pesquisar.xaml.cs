using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using academia.banco;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace academia.paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pesquisar : ContentPage
    {
        public pesquisar()
        {
            InitializeComponent();
            btn_pesquisar.Clicked += RealizarPesquisa;
        }

        private void RealizarPesquisa(object sender, EventArgs e)
        {
            Banco_funcoes dbf = new Banco_funcoes();
            dbf.CriarBancoDeDados();
            ls_alunos.ItemsSource = dbf.PesquisarAlunos(txtPesquisar.Text);
        }
    }
}

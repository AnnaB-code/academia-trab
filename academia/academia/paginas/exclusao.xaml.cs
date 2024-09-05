using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using academia.banco;

namespace academia.paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class exclusao : ContentPage
    {
        public exclusao()
        {
            InitializeComponent();
            btn_excluir.Clicked += excluir_aluno;
        }

        public void excluir_aluno(object sender, EventArgs args)
        {
            string id = txt_id.Text;
            Banco_funcoes dbf = new Banco_funcoes();
            dbf.CriarBancoDeDados();
            dbf.ExcluirAluno(id);
            DisplayAlert("Mensagem", "Registro excluido com Sucesso!", "OK");
        }
    }
}

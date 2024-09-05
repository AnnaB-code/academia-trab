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
    public partial class inicial : ContentPage
    {
        public inicial()
        {
            InitializeComponent();
            btn_enviar.Clicked += cadastrar;
        }

        public void cadastrar(object sender, EventArgs args)
        {
            string nome = txt_nome.Text;
            string cpf = txt_cpf.Text;
            string fone = txt_fone.Text;
            string idade = txt_idade.Text;
            string modalidade = txt_modalidade.Text;
            string peso = txt_peso.Text;
            Banco_funcoes dbf = new Banco_funcoes();
            dbf.CriarBancoDeDados();
            dbf.InserirAluno(nome, cpf, fone, idade, modalidade, peso);
            DisplayAlert("Mensagem", "Registro gravado com Sucesso!", "OK");
        }
    }
}


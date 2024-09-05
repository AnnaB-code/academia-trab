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
    public partial class editar : ContentPage
    {
        public editar()
        {
            InitializeComponent();
            btn_editar.Clicked += EditarAluno;
        }

        public void EditarAluno(object sender, EventArgs args)
        {
            string id = txt_id.Text;
            string nome = txt_nome.Text;
            string cpf = txt_cpf.Text;
            string fone = txt_fone.Text;
            string idade = txt_idade.Text;
            string modalidade = txt_modalidade.Text;
            string peso = txt_peso.Text;

            Banco_funcoes dbf = new Banco_funcoes();
            dbf.CriarBancoDeDados();
            dbf.EditarAluno(id, nome, cpf, fone, idade, modalidade, peso);
            DisplayAlert("Mensagem", "Registro alterado com Sucesso!", "OK");
        }
    }
}

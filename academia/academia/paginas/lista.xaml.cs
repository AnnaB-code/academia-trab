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
    public partial class lista : ContentPage
    {
        public lista()
        {
            InitializeComponent();
            btn_recarregar.Clicked += listar;
        }
        public void listar(object sender, EventArgs args)
        {
            Banco_funcoes dbf = new Banco_funcoes();
            dbf.CriarBancoDeDados();
            List<Alunos> listaAlunos = new List<Alunos>();
            listaAlunos = dbf.GetAlunos();
            var array = listaAlunos.ToArray();
            List<Alunos> lista = new List<Alunos>();
            for (int c = 0; c < array.Length; c++)
            {
                lista.Add(new Alunos
                {
                    Nome = array[c].Nome.ToString(),
                    Cpf = array[c].Cpf,
                    Fone = array[c].Fone.ToString(),
                    Modalidade = array[c].Modalidade.ToString(),
                    Idade = array[c].Idade,
                    Peso = array[c].Peso
                });
            }
            ls_alunos.ItemsSource = lista;
        }
    }
}

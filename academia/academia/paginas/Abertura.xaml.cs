using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace academia.paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Abertura : ContentPage
    {
        public ObservableCollection<string> Images { get; set; }
        public Abertura()
        {
            InitializeComponent();
            Images = new ObservableCollection<string>()
            {
                
                "https://blog.nextfit.com.br/wp-content/uploads/2023/12/frase-motivacional-1024x1024.jpg",
                "https://tecnofit-site.s3.sa-east-1.amazonaws.com/media/files/2023/02/06182925/aulas_coletivas_academia.png",
                "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/GABRIEL_VELLA_vs_ROMINHO_51.jpg/1200px-GABRIEL_VELLA_vs_ROMINHO_51.jpg",
                "https://vitat.com.br/wp-content/uploads/2019/07/sporty-athletic-woman-in-crossfi.jpg",
                "https://www.rioquente.com.br/images/news/0496/natacao-topo_1.jpg"

            };

            BindingContext = this;
        }
    }
}
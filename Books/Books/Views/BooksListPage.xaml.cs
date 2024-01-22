using Books.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Books.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BooksListPage : ContentPage
    {
        public BooksListPage()
        {
            InitializeComponent();
            BindingContext = new BooksListViewModel()
            {
                Navigation = this.Navigation
            };
        }
    }
}

using PokemonExplorer.Dtos;
using System.ComponentModel;
using Xamarin.Forms;

namespace PokemonExplorer
{
    [DesignTimeVisible(false)]
    public partial class DetailsPage : ContentPage
    {

        public PokemonDto Pokemon { get; set; }

        public DetailsPage(object selectedItem)
        {
            Pokemon = (PokemonDto)selectedItem;
            InitializeComponent();
            BindingContext = this;
        }
    }
}
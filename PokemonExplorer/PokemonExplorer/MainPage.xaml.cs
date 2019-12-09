using Newtonsoft.Json;
using PokemonExplorer.Dtos;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using Xamarin.Forms;

namespace PokemonExplorer
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<PokemonDto> Pokemons { get; set; } = new ObservableCollection<PokemonDto>();
        HttpClient HttpClient = new HttpClient();

        public MainPage()
        {
            getPokemonList();
            InitializeComponent();
            BindingContext = this;
        }
        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new DetailsPage(e.SelectedItem));
        }

        async void getPokemonList()
        {
            PokemonUrlsDto pokemon = JsonConvert.DeserializeObject<PokemonUrlsDto>(await HttpClient.GetStringAsync("https://pokeapi.co/api/v2/pokemon"));
            foreach (PokemonUrlDto pokemonUrlDto in pokemon.urls)
            {
                Pokemons.Add(JsonConvert.DeserializeObject<PokemonDto>(await HttpClient.GetStringAsync(pokemonUrlDto.Url)));
            }

        }
    }
}

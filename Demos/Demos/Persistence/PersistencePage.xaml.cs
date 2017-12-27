using SQLite;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demos.Persistence
{
    public class Recipe : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        private string _name;
        [MaxLength(255)]
        public string Name
        {
            get => _name;
            set
            {
                if (_name == value)
                    return;
                _name = value;

                OnPropertyChanged();

            }
        }
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(propertyName)));

        }

    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersistencePage : ContentPage 
    {

        private SQLiteAsyncConnection _connection;
        public ObservableCollection<Recipe> _recipes { get;  set; }
        public PersistencePage()
        {
            InitializeComponent();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _connection.CreateTableAsync<Recipe>();
            var recipes = await _connection.Table<Recipe>().ToListAsync();
            _recipes = new ObservableCollection<Recipe>(recipes);
            recipesListView.ItemsSource = _recipes;
        }

        async void OnAdd(object sender, EventArgs e)
        {
            var recipe = new Recipe { Name = "Recipe " + DateTime.Now.Ticks };
            await _connection.InsertAsync(recipe);
            _recipes.Add(recipe);

        }

        async void OnDelete(object sender, EventArgs e)
        {
            var recipe = _recipes.FirstOrDefault();
            await _connection.DeleteAsync(recipe);
            _recipes.Remove(recipe);
        }

        async void OnUpdate(object sender, EventArgs e)
        {
            var recipe = _recipes.FirstOrDefault();
            recipe.Name += " Updated";
            await _connection.UpdateAsync(recipe);
            
        }
    }

}
using System.Collections.Generic;
using Xamarin.Forms;

namespace SharedTransitionExample
{
    public partial class CollectionSource : ContentPage
    {
        private Monkey selectedMonkey;

        public List<Monkey> Monkeys { get; set; }
        public Monkey SelectedMonkey
        {
            get => selectedMonkey;
            set
            {
                selectedMonkey = value;
                OnPropertyChanged();
                NavigateToMonkey();
            }
        }

        public CollectionSource()
        {
            InitializeComponent();
            BindingContext = this;

            CreateMonkeys();
            CvMonkeys.ItemsSource = Monkeys;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            SelectedMonkey = null;
        }

        public void CreateMonkeys()
        {
            Monkeys = new List<Monkey>
            {
                new Monkey { Id = 1, Name = "Mono 1", Detail = "Este es el mono uno", ImageUrl = @"monkey1.jpeg" },
                new Monkey { Id = 2, Name = "Mono 2", Detail = "Este es el mono dos", ImageUrl = @"monkey2.jpeg" },
                new Monkey { Id = 3, Name = "Mono 3", Detail = "Este es el mono tres", ImageUrl = @"monkey3.jpeg" },
                new Monkey { Id = 4, Name = "Mono 4", Detail = "Este es el mono cuatro", ImageUrl = @"monkey4.jpeg" },
                new Monkey { Id = 5, Name = "Mono 5", Detail = "Este es el mono cinco", ImageUrl = @"monkey5.jpeg" },
            };
        }

        public async void NavigateToMonkey()
        {
            if (SelectedMonkey != null)
            {
                await App.Current.MainPage.Navigation.PushAsync(new CollectionTarget(SelectedMonkey), true);
            }
        }
    }
}

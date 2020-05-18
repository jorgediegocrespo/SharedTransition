
using Xamarin.Forms;

namespace SharedTransitionExample
{
    public partial class CollectionTarget : ContentPage
    {
        public Monkey Monkey { get; set; }

        public CollectionTarget(Monkey monkey)
        {
            Monkey = monkey;

            InitializeComponent();
            BindingContext = this;
        }
    }
}

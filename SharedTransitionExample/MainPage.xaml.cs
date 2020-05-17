namespace SharedTransitionExample
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void BtnLayout_Clicked(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new LayoutSource());
        }

        public void BtnCollection_Clicked(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new CollectionSource());
        }
    }
}

namespace SharedTransitionExample
{
    public partial class LayoutSource
    {
        public LayoutSource()
        {
            InitializeComponent();
        }

        private void BtnAction_Clicked(object sender, System.EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new LayoutTarget(), true);
        }
    }
}

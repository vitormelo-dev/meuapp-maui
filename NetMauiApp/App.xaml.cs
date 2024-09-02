namespace NetMauiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage = new NavigationPage(new MinhaPagina());

            //navPage.BarBackground = Colors.Red;

            MainPage = navPage;
        }
    }
}

namespace PagesDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage =new NavigationPage (new TabbedPageDemo());
            // MainPage = new FlyoutPageDemo();
            MainPage = new TabbedPageDemo();
        }
    }
}

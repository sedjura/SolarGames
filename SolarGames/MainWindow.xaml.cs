using System.Data.Entity;
using System.Windows;
using SolarGames.Model;
using SolarGames.ViewModel;

namespace SolarGames
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            DataContext = new UsersViewModel();
            //Database.SetInitializer(new SolarGamesInitializer());
            /*var db = new SolarGamesContext();
            db.Database.Initialize(true);   // force database creation*/
        }

    }
}

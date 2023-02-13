using AndrKarmStore.ClassHelper;
using AndrKarmStore.Pages;
using System.Windows;

namespace AndrKarmStore
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigateClass.navFrame = frmMain;
            NavigateClass.navFrame.Navigate(new ProductListPage() );
        }
    }
}

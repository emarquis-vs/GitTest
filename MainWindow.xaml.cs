using System.Windows;

namespace TestGit
{
    public partial class MainWindow : Window
    {
        public MainWindow ()
        {
            InitializeComponent ();
        }

        private void Button_Click (object sender, RoutedEventArgs e)
        {
            MessageBox.Show ("Git Testing !");
            Application.Current.Shutdown ();
        }
    }
}

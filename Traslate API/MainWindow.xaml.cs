using System.Windows;

namespace Traslate_API
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            //TxtIn.Height = 250;
            
        }
        
        private void BtnTranslate_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Traducir");
        }
    }
}
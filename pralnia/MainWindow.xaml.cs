using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pralnia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void SprawdzCene(object sender, RoutedEventArgs e)
        {
            obrazyPanel.Children.Clear();

            if(pranie.IsChecked == true)
            {
                cenaLbl.Content = "20 zł";
                Image image = new Image();
                image.Source = new BitmapImage(new Uri("pralka.jpg", UriKind.RelativeOrAbsolute));
                image.HorizontalAlignment = HorizontalAlignment.Center;

                obrazyPanel.Children.Add(image);
            }
            if(suszenie.IsChecked == true)
            {
                cenaLbl.Content = "15 zł";
                Image image = new Image();
                image.Source = new BitmapImage(new Uri("suszarka.jpg", UriKind.RelativeOrAbsolute));
                image.HorizontalAlignment = HorizontalAlignment.Center;
                

                obrazyPanel.Children.Add(image);
            }
            if (pranieSuszenie.IsChecked == true)
            {
                cenaLbl.Content = "30 zł";
                Image image1 = new Image();
                image1.Source = new BitmapImage(new Uri("pralka.jpg", UriKind.RelativeOrAbsolute));
                image1.HorizontalAlignment = HorizontalAlignment.Left;
                image1.Margin = new Thickness(0,0,60,0);

                Image image2 = new Image();
                image2.Source = new BitmapImage(new Uri("suszarka.jpg", UriKind.RelativeOrAbsolute));
                image2.HorizontalAlignment = HorizontalAlignment.Right;

                obrazyPanel.Children.Add(image1);
                obrazyPanel.Children.Add(image2);
            }

            if(stalyKlient.IsChecked == true)
            {
                int cena = cenaLbl
            }
        }
    }
}
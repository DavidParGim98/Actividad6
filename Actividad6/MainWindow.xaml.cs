using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Actividad6
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void Entra(object sender, RoutedEventArgs e)
        {
            if (Mouse.DirectlyOver==img1 | Mouse.DirectlyOver == img2 | Mouse.DirectlyOver == img3)
            {
                if (sender as Image==img1)
                {
                    img1.Opacity = 1;
                }
                if (sender as Image == img2)
                {
                    img2.Opacity = 1;
                }
                if (sender as Image == img3)
                {
                    img3.Opacity = 1;
                }
            }
        }

        void Sale(object sender, RoutedEventArgs e)
        {
            if (Mouse.DirectlyOver != img1 | Mouse.DirectlyOver != img2 | Mouse.DirectlyOver != img3)
            {
                if (sender as Image == img1)
                {
                    img1.Opacity = 0.5;
                }
                if (sender as Image == img2)
                {
                    img2.Opacity = 0.5;
                }
                if (sender as Image == img3)
                {
                    img3.Opacity = 0.5;
                }
            }
        }
    }
}

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

namespace StartFastApp.ViewModels.Popup
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class PopupView : Window
    {
        public PopupView(UserControl currentPage, string title)
        {
            InitializeComponent();

            this.DataContext = new PopupViewModel(this, currentPage, title);
        }

        private void MinimizeButton_MouseEnter(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            var template = btn.Template;
            var path = (Image)template.FindName("Image_Minimize", btn);
            path.Source = new BitmapImage(new Uri("pack://application:,,,/Images/CircleMinimizeOver.png"));
        }

        private void MinimizeButton_MouseLeave(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            var template = btn.Template;
            var path = (Image)template.FindName("Image_Minimize", btn);
            path.Source = new BitmapImage(new Uri("pack://application:,,,/Images/CircleMinimize.png"));
        }

        private void MaximizeButton_MouseEnter(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            var template = btn.Template;
            var path = (Image)template.FindName("Image_Maximize", btn);
            path.Source = new BitmapImage(new Uri("pack://application:,,,/Images/CircleMaximizeOver.png"));
        }

        private void MaximizeButton_MouseLeave(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            var template = btn.Template;
            var path = (Image)template.FindName("Image_Maximize", btn);
            path.Source = new BitmapImage(new Uri("pack://application:,,,/Images/CircleMaximize.png"));
        }

        private void CloseButton_MouseEnter(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            var template = btn.Template;
            var path = (Image)template.FindName("Image_Close", btn);
            path.Source = new BitmapImage(new Uri("pack://application:,,,/Images/CircleCloseOver.png"));
        }

        private void CloseButton_MouseLeave(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            var template = btn.Template;
            var path = (Image)template.FindName("Image_Close", btn);
            path.Source = new BitmapImage(new Uri("pack://application:,,,/Images/CircleClose.png"));
        }
    }
}

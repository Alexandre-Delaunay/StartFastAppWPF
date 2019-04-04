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

namespace StartFastApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //TODO use DataTemplate.xaml in resources directory
            this.DataContext = new WindowViewModel(this);
        }

        private void Parcours_Scolaire_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            var blueTextBrush = Application.Current.Resources["BlueTextBrush"] as Brush;
            var btn = sender as Button;
            var template = btn.Template;
            var label = (Label)template.FindName("Parcours_Scolaire_Label", btn);
            label.Foreground = blueTextBrush;
        }

        private void Parcours_Scolaire_Button_MouseLeave(object sender, MouseEventArgs e)
        {
            var foreGroundMainBrush = Application.Current.Resources["ForeGroundMainBrush"] as Brush;
            var btn = sender as Button;
            var template = btn.Template;
            var label = (Label)template.FindName("Parcours_Scolaire_Label", btn);
            label.Foreground = foreGroundMainBrush;
        }

        private void Parcours_Professionnel_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            var blueTextBrush = Application.Current.Resources["BlueTextBrush"] as Brush;
            var btn = sender as Button;
            var template = btn.Template;
            var label = (Label)template.FindName("Parcours_Professionnel_Label", btn);
            label.Foreground = blueTextBrush;
        }

        private void Parcours_Professionnel_Button_MouseLeave(object sender, MouseEventArgs e)
        {
            var foreGroundMainBrush = Application.Current.Resources["ForeGroundMainBrush"] as Brush;
            var btn = sender as Button;
            var template = btn.Template;
            var label = (Label)template.FindName("Parcours_Professionnel_Label", btn);
            label.Foreground = foreGroundMainBrush;
        }

        private void Connaissances_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            var blueTextBrush = Application.Current.Resources["BlueTextBrush"] as Brush;
            var btn = sender as Button;
            var template = btn.Template;
            var label = (Label)template.FindName("Connaissances_Label", btn);
            label.Foreground = blueTextBrush;
        }

        private void Connaissances_Button_MouseLeave(object sender, MouseEventArgs e)
        {
            var foreGroundMainBrush = Application.Current.Resources["ForeGroundMainBrush"] as Brush;
            var btn = sender as Button;
            var template = btn.Template;
            var label = (Label)template.FindName("Connaissances_Label", btn);
            label.Foreground = foreGroundMainBrush;
        }

        private void Competences_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            var blueTextBrush = Application.Current.Resources["BlueTextBrush"] as Brush;
            var btn = sender as Button;
            var template = btn.Template;
            var label = (Label)template.FindName("Competences_Label", btn);
            label.Foreground = blueTextBrush;
        }

        private void Competences_Button_MouseLeave(object sender, MouseEventArgs e)
        {
            var foreGroundMainBrush = Application.Current.Resources["ForeGroundMainBrush"] as Brush;
            var btn = sender as Button;
            var template = btn.Template;
            var label = (Label)template.FindName("Competences_Label", btn);
            label.Foreground = foreGroundMainBrush;
        }

        private void Acceuil_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            var blueTextBrush = Application.Current.Resources["BlueTextBrush"] as Brush;
            var btn = sender as Button;
            var template = btn.Template;
            var label = (Label)template.FindName("Acceuil_Label", btn);
            label.Foreground = blueTextBrush;
        }

        private void Acceuil_Button_MouseLeave(object sender, MouseEventArgs e)
        {
            var foreGroundMainBrush = Application.Current.Resources["ForeGroundMainBrush"] as Brush;
            var btn = sender as Button;
            var template = btn.Template;
            var label = (Label)template.FindName("Acceuil_Label", btn);
            label.Foreground = foreGroundMainBrush;
        }

        private void Contact_MouseEnter(object sender, MouseEventArgs e)
        {
            var blueTextBrush = Application.Current.Resources["BlueTextBrush"] as Brush;
            var btn = sender as Button;
            var template = btn.Template;
            var label = (Label)template.FindName("Contact_Label", btn);
            label.Foreground = blueTextBrush;
        }

        private void Contact_Button_MouseLeave(object sender, MouseEventArgs e)
        {
            var foreGroundMainBrush = Application.Current.Resources["ForeGroundMainBrush"] as Brush;
            var btn = sender as Button;
            var template = btn.Template;
            var label = (Label)template.FindName("Contact_Label", btn);
            label.Foreground = foreGroundMainBrush;
        }

        private void setAllPathBackgroundBlue()
        {
            var template = this.Template;
            var blueTextBrush = Application.Current.Resources["BlueTextBrush"] as Brush;

            var btn_Acceuil = (Button)template.FindName("Acceuil_Button", this);
            var btn_Acceuil_template = btn_Acceuil.Template;
            var path_Acceuil = (Path)btn_Acceuil_template.FindName("Acceuil_Path", btn_Acceuil);
            path_Acceuil.Fill = blueTextBrush;

            var btn_Competences = (Button)template.FindName("Competences_Button", this);
            var btn_Competences_template = btn_Competences.Template;
            var path_Competences = (Path)btn_Competences_template.FindName("Competences_Path", btn_Competences);
            path_Competences.Fill = blueTextBrush;

            var btn_Connaissances = (Button)template.FindName("Connaissances_Button", this);
            var btn_Connaissances_template = btn_Connaissances.Template;
            var path_Connaissances = (Path)btn_Connaissances_template.FindName("Connaissances_Path", btn_Connaissances);
            path_Connaissances.Fill = blueTextBrush;

            var btn_Parcours_Professionnel = (Button)template.FindName("Parcours_Professionnel_Button", this);
            var btn_Parcours_Professionnel_template = btn_Parcours_Professionnel.Template;
            var path_Parcours_Professionnel = (Path)btn_Parcours_Professionnel_template.FindName("Parcours_Professionnel_Path", btn_Parcours_Professionnel);
            path_Parcours_Professionnel.Fill = blueTextBrush;

            var btn_Parcours_Scolaire = (Button)template.FindName("Parcours_Scolaire_Button", this);
            var btn_Parcours_Scolaire_template = btn_Parcours_Scolaire.Template;
            var path_Parcours_Scolaires = (Path)btn_Parcours_Scolaire_template.FindName("Parcours_Scolaire_Path", btn_Parcours_Scolaire);
            path_Parcours_Scolaires.Fill = blueTextBrush;

            var btn_Contact = (Button)template.FindName("Contact_Button", this);
            var btn_Contact_Template = btn_Contact.Template;
            var path_Contact = (Path)btn_Contact_Template.FindName("Contact_Path", btn_Contact);
            path_Contact.Fill = blueTextBrush;
        }

        private void Acceuil_Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var template = btn.Template;

            setAllPathBackgroundBlue();

            var foreGroundMainBrush = Application.Current.Resources["ForeGroundMainBrush"] as Brush;
            var path = (Path)template.FindName("Acceuil_Path", btn);
            path.Fill = foreGroundMainBrush;
        }

        private void Competences_Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var template = btn.Template;

            setAllPathBackgroundBlue();

            var foreGroundMainBrush = Application.Current.Resources["ForeGroundMainBrush"] as Brush;
            var path = (Path)template.FindName("Competences_Path", btn);
            path.Fill = foreGroundMainBrush;
        }

        private void Connaissances_Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var template = btn.Template;

            setAllPathBackgroundBlue();

            var foreGroundMainBrush = Application.Current.Resources["ForeGroundMainBrush"] as Brush;
            var path = (Path)template.FindName("Connaissances_Path", btn);
            path.Fill = foreGroundMainBrush;
        }

        private void Parcours_Professionnel_Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var template = btn.Template;

            setAllPathBackgroundBlue();

            var foreGroundMainBrush = Application.Current.Resources["ForeGroundMainBrush"] as Brush;
            var path = (Path)template.FindName("Parcours_Professionnel_Path", btn);
            path.Fill = foreGroundMainBrush;
        }

        private void Parcours_Scolaire_Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var template = btn.Template;

            setAllPathBackgroundBlue();

            var foreGroundMainBrush = Application.Current.Resources["ForeGroundMainBrush"] as Brush;
            var path = (Path)template.FindName("Parcours_Scolaire_Path", btn);
            path.Fill = foreGroundMainBrush;
        }

        private void Contact_Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var template = btn.Template;

            setAllPathBackgroundBlue();

            var foreGroundMainBrush = Application.Current.Resources["ForeGroundMainBrush"] as Brush;
            var path = (Path)template.FindName("Contact_Path", btn);
            path.Fill = foreGroundMainBrush;
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

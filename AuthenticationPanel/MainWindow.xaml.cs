using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AuthenticationPanel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); //hello there I used too many xaml storyboards LMAO
        }

        WebClient PanelAdmin = new WebClient();
        public static string authgg = "https://developers.auth.gg";
        public static string API = "insert here";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)TryFindResource("showmessagedashboard");
            sb.Begin();
            string3.Text = PanelAdmin.DownloadString(authgg + "/USERS/?type=fetch&authorization=" + API + "&user=" + fetchuser.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)TryFindResource("showmessagedashboard");
            sb.Begin();
            string3.Text = PanelAdmin.DownloadString(authgg + "/USERS/?type=delete&authorization=" + API + "&user=" + delete.Text);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)TryFindResource("showmessagemanage");
            sb.Begin();
            string2.Text = PanelAdmin.DownloadString(authgg + "/USERS/?type=changepw&authorization=" + API + "&user=" + userpass.Text + "&password=" + passpass.Text);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)TryFindResource("showmessagemanage");
            sb.Begin();
            string2.Text = PanelAdmin.DownloadString(authgg + "/USERS/?type=editvar&authorization=" + API + "&user=" + usr.Text + "&value=" + var.Text);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)TryFindResource("showmessagemanage");
            sb.Begin();
            string2.Text = PanelAdmin.DownloadString(authgg + "/HWID/?type=reset&authorization=" + API + "&user=" + hwiduser.Text);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)TryFindResource("showmessagemanage");
            sb.Begin();
            string2.Text = PanelAdmin.DownloadString(authgg + "/HWID/?type=fetch&authorization=" + API + "&user=" + hwidcred.Text);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)TryFindResource("showmessage");
            sb.Begin();
            _string.Text = PanelAdmin.DownloadString(authgg + "/LICENSES/?type=unuse&license=" + unuse.Text + "&authorization=" + API);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)TryFindResource("showmessage");
            sb.Begin();
            _string.Text = PanelAdmin.DownloadString(authgg + "/LICENSES/?type=generate&days=" + days.Text + "&amount=" + amount.Text + "&level=" + level.Text + "&authorization=" + API);
           
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)TryFindResource("showmessage");
            sb.Begin();
            _string.Text = PanelAdmin.DownloadString(authgg + "/LICENSES/?type=delete&license=" + dellicense.Text + "&authorization=" + API);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)TryFindResource("showmessage");
            sb.Begin();
            _string.Text = PanelAdmin.DownloadString(authgg + "/LICENSES/?type=use&license=" + USEBOX.Text + "&authorization=" + API);

        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)TryFindResource("showmessage");
            sb.Begin();
            _string.Text = PanelAdmin.DownloadString(authgg + "/LICENSES/?type=fetch&authorization=" + API + "&license=" + recbox.Text);
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)TryFindResource("showmessagedashboard");
            sb.Begin();
            string3.Text = PanelAdmin.DownloadString(authgg + "/LICENSES/?type=count&authorization=" + API);
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)TryFindResource("showmessagedashboard");
            sb.Begin();
            string3.Text = PanelAdmin.DownloadString(authgg + "/LICENSES/?type=fetchall&authorization=" + API);

        }
    }
}

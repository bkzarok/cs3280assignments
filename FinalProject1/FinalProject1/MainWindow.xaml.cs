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

namespace FinalProject1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Equals(""))
            {
                MessageBox.Show("Enter a username before requesting data");
            }
            else
            {

               
                

            }
        }


        private async Task GetURL(string username = "bkzarok")
        {
            var repomodel = await Repos.LoadRepo(username);
            richTextBox.Document.Blocks.Clear();
            richTextBox.Document.Blocks.Add(new Paragraph(new Run(repomodel.full_name)));
           
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await GetURL();
        }
    }
   
}




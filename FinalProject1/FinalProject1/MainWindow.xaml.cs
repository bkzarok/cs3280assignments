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

        //repos button
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (usernametextBox.Text.Equals(""))
            {
                MessageBox.Show("Enter a username before requesting data");
            }
            else
            {
                await getRepos(usernametextBox.Text);
            }
            return;
        }

        //commit button
        private async void Button_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (usernametextBox.Text.Equals("") || repotextBox.Text.Equals(""))
            {
                MessageBox.Show("Enter a repos name before requesting commit data");
            }
            else
            {

                await getCommit(usernametextBox.Text, repotextBox.Text);
            }
            return;
        }

        private async void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (usernametextBox.Text.Equals("") || repotextBox.Text.Equals(""))
            {
                MessageBox.Show("Enter a repos name before requesting commit data");
            }
            else
            {

                await getPulls(usernametextBox.Text, repotextBox.Text);
            }
            return;
        }

        private async Task getPulls(string username, string repo)
        {
            var pullsmodel = await GetPulls.LoadPulls(username, repo);

            string pullsstr = "*******************PULLS REQUEST********************";
            richTextBox.Document.Blocks.Add(new Paragraph(new Run(pullsstr)));

            richTextBox.Document.Blocks.Add(new Paragraph(new Run(pullsmodel.ToString())));
            
           
        }


        private async Task getRepos(string username)
        {
            var repomodel = await GetRepos.LoadRepo(username);
            string reposstr = "*******************REPOS********************";
            richTextBox.Document.Blocks.Add(new Paragraph(new Run(reposstr)));
            richTextBox.Document.Blocks.Add(new Paragraph(new Run(repomodel.ToString())));
            
        }

        private async Task getCommit(string username, string repo)
        {
            var commitmodel = await GetCommits.LoadCommits(username, repo);

            string commitsstr = "*******************COMMITS********************";
            richTextBox.Document.Blocks.Add(new Paragraph(new Run(commitsstr)));

            richTextBox.Document.Blocks.Add(new Paragraph(new Run(commitmodel.ToString())));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
   
}




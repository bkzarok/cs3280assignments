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
                MessageBox.Show("Enter a username before requesting data");
            }
            else
            {

                await getCommit(usernametextBox.Text, repotextBox.Text);
            }
            return;
        }

        private async Task getRepos(string username)
        {
            var repomodel = await GetRepos.LoadRepo(username);
            richTextBox.Document.Blocks.Clear();
            richTextBox.Document.Blocks.Add(new Paragraph(new Run(repomodel.owner.login)));
           
        }

        private async Task getCommit(string username, string repo)
        {
            var commitmodel = await GetCommits.LoadCommits(username, repo);
            richTextBox.Document.Blocks.Clear();
            richTextBox.Document.Blocks.Add(new Paragraph(new Run(commitmodel.commit.author.name)));
            richTextBox.Document.Blocks.Add(new Paragraph(new Run(commitmodel.commit.author.email)));
            richTextBox.Document.Blocks.Add(new Paragraph(new Run(commitmodel.commit.message)));
            richTextBox.Document.Blocks.Add(new Paragraph(new Run(commitmodel.ToString())));
        }

       
       
    }
   
}




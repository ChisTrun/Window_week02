using Random_English_Vocabulary.Class;
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
using System.Windows.Shapes;

namespace Random_English_Vocabulary
{
    /// <summary>
    /// Interaction logic for LearnWindow.xaml
    /// </summary>
    public partial class LearnWindow : Window
    {   
        private WordList wordList;
        public LearnWindow()
        {
            wordList = new WordList();
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            generateRandomWord();
        }

        private void getNewWordButon_Click(object sender, RoutedEventArgs e)
        {
            generateRandomWord();
        }

        private void menuButton_Click(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void generateRandomWord()
        {
            NewWord newWord = this.wordList.GetRandomWord();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var bitMap = new BitmapImage(new Uri($"{baseDirectory}Images/{newWord.ImageFileName}", UriKind.Absolute));
            wordImage.Source = bitMap;
            wordTextBlock.Text = newWord.Word;
        }
    }
}

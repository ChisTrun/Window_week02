using Random_English_Vocabulary.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
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
    /// Interaction logic for PracticeWindow.xaml
    /// </summary>
    /// 
    
    public partial class PracticeWindow : Window
    {
        private NewWord? correctWord ;
        private WordList wordList;
        private List<string> currentTestList;
        private int score;
        private int index;
        public PracticeWindow()
        {
            score = 0;
            index = 0;
            correctWord = null;
            wordList = new WordList();
            currentTestList = new List<string>();
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            scoreTextBlock.Text = $"score: {score}/10";
            generateRandomTestCase();
        }

        private void generateRandomTestCase()
        {   
            Random rng = new Random();
            List<NewWord> testCase;
            do
            {
                testCase = this.wordList.GetNRandomWords(2);
                this.correctWord = testCase[rng.Next(testCase.Count)];
            }
            while (this.currentTestList.Contains(this.correctWord.Word) == true);

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var bitMap = new BitmapImage(new Uri($"{baseDirectory}Images/{correctWord.ImageFileName}", UriKind.Absolute));
            wordImage.Source = bitMap;
            answerA.Content = testCase[0].Word;
            answerB.Content = testCase[1].Word;
            index += 1;
        }

        private void answerA_Click(object sender, RoutedEventArgs e)
        {
            if (correctWord != null && String.Equals(correctWord.Word,answerA.Content))
            {
                increaseScore();
                currentTestList.Add(correctWord.Word);
            }
            if (checkComplete())
            {
                endTest();
            }
            else {
                generateRandomTestCase();
            }
        }

        private void answerB_Click(object sender, RoutedEventArgs e)
        {
            if (correctWord != null && String.Equals(correctWord.Word, answerB.Content))
            {
                increaseScore();
                currentTestList.Add(correctWord.Word);
            }
            if (checkComplete())
            {
                endTest();
            }
            else
            {
                generateRandomTestCase();
            }
        }

        private bool checkComplete()
        {
            return index == 10;
        }

        private void increaseScore()
        {
            score += 1;
            scoreTextBlock.Text = $"score: {score}/10";
        }

        private void endTest()
        {
            var result = MessageBox.Show($"{score}/10 Do you want to test again?", "Message", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                score = 0;
                scoreTextBlock.Text = $"score: {score}/10";
                currentTestList.Clear();
                index = 0;
                generateRandomTestCase();
            }
            else if (result == MessageBoxResult.No)
            {
                Window window = new MainWindow();
                window.Show();
                this.Close();
            }
        }

        private void menuButton_Click(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}

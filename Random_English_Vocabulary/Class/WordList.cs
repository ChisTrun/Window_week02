using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_English_Vocabulary.Class
{
    internal class WordList
    {
        private List<NewWord> _words;
        public List<NewWord> Words => _words;
        public int Count => _words.Count;
        public WordList() {
            _words = new List<NewWord>()
            {
                new NewWord("Archery","image01.jpg"),
                new NewWord("Blister","image02.jpg"),
                new NewWord("Deck","image03.jpg"),
                new NewWord("Easel","image04.jpg"),
                new NewWord("Filter","image05.jpg"),
                new NewWord("Goatee","image06.jpg"),
                new NewWord("Hammock","image07.jpg"),
                new NewWord("Icing","image08.jpg"),
                new NewWord("Jade","image09.jpg"),
                new NewWord("Keg","image10.jpg"),
                new NewWord("Lace","image11.jpg"),
                new NewWord("Mussels","image12.jpg"),
                new NewWord("Needle","image13.jpg"),
                new NewWord("Oars","image14.jpg"),
                new NewWord("Paw","image15.jpg"),
            };
        }
        
        public NewWord GetRandomWord() {
            Random rng = new Random();
            int randomIndex = rng.Next(this.Count);
            return _words[randomIndex];
        }

        public List<NewWord> GetNRandomWords(int n) {
            Random rng = new Random();
            return this.Words.OrderBy(x => rng.Next()).Take(n).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_English_Vocabulary.Class
{
    internal class NewWord
    {
        private string _word;
        private string _imageFileName;

        public NewWord()
        {
            _word = "none";
            _imageFileName = "none";
        }


        public NewWord(string word, string imageFileName)
        {
            _word = word;
            _imageFileName = imageFileName;
        }

        public string Word { get => _word; set => _word = value; }
        public string ImageFileName { get => _imageFileName; set => _imageFileName = value; }

    }
}

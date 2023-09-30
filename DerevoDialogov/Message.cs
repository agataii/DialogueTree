using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerevoDialogov
{
    public class Message
    {
        public string[] Answers = new string[]
        {

        };
        public string Title;
        public int Index;

        public int[] NextMessageIndexes = new int[]
        {

        };

        public Message(string[] answers, string title, int index, int[] nextMessageIndexes)
        {
            Answers = answers;
            Title = title;
            Index = index;
            NextMessageIndexes = nextMessageIndexes;
        }
    }
}

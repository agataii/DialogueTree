using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerevoDialogov
{
    public class NPC
    {
        public string Name { get; set; }
        public NPC(string name, Message[] messages)
        {
            this.messages = messages;
            Name = name;
        }
        int CurrentIndex;
        public Message[] messages = new Message[] { };
        public void StartDialog()
        {

            for (int i = CurrentIndex; i < messages.Length;)
            {
                Console.Clear();

                Console.WriteLine($"{Name}:{messages[i].Title}");
                for (int j = 0; j < messages[i].Answers.Length; j++)
                {
                    Console.WriteLine($"{j + 1}.{messages[i].Answers[j]}");
                }
                int a = Game.InputComment();
                if (messages[i].NextMessageIndexes.Length > 0)
                {
                    if(a > messages[i].Answers.Length || a <=0)
                    {
                        CurrentIndex= i;
                        StartDialog();
                    }
                    else 
                    {
                        i = messages[i].NextMessageIndexes[a - 1];
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webaz.Models
{
    public class Number
    {
        public HashSet<int> Answer { get; set; }
        public Number() { }
        public void setAnswer(HashSet<int> answer)
        {
            this.Answer = answer;
        }
        //Metodas skaiciui sugeneruoti
       public string getAnswer()
        {
            string answer ="";
            foreach (var item in Answer)
            {
               answer += item.ToString();
            }
            
            return answer;
        }
        public HashSet<int> Generate()
        {
            // Sugeneruojam random skaiciu ir Seta 'Answer', kuriame issaugosime 
            // to skaiciaus skaitmenis(setas tam, kad visi skaitmenys butu skirtingi
            
            int number;
            HashSet<int> Answer = new HashSet<int>();
            //do
            //{
            //    Random random = new Random();
            //    number = random.Next(0, 9999);
            //    Answer.Clear();
            //    for (int i = 0; i < 4; i++)
            //    {
            //        int digit = number % 10;
            //        Answer.Add(digit);
            //        digit = digit / 10;
            //    }
            //}
            //while (Answer.Count < 4);
            while (Answer.Count != 4)
            {
                Random random = new Random();
                number = random.Next(0, 9999);
                int digit = number % 10;
                Answer.Add(digit);
            }
            
            return Answer;
        }
        public void assignValue()
        {
            Number number = new Number();
            setAnswer(Generate());
        }
    }
}
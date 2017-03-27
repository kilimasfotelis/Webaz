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
        public string Guess { get; set; }
        public int GuessCount { get; set; }
        public string Congratulations { get; set; }
        public string FinalAnswer { get; set; }
        public List<string> Notes { get; set; }
        public void createNotes(List<string> notes)
        {
            this.Notes = notes;
        }
        public void setAnswer(HashSet<int> answer)
        {
            this.Answer = answer;
        }
       
       public string getAnswer()
        {
            string answer ="";
            foreach (var item in Answer)
            {
               answer += item.ToString();
            }
            FinalAnswer = answer;
            return answer;
        }
        //Metodas skaiciui sugeneruoti
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

        public Boolean compareValues(string guess, string answer)
        {
            bool ok = false;
            if (guess == answer)
            {
                Notes.Insert(0, string.Format("Sveikinimai. {0} yra teisingas atsakymas", guess));
                ok = true;
            }
            else
            {
                int semiCorrect = 0; int correct = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (answer.Contains(guess[i]))
                    {
                        semiCorrect++;
                    }
                    if (answer[i] == guess[i])
                    {
                        correct++;
                    }
                }
                Notes.Insert(0, string.Format("Jūsų spėjimas:{0}, Atspėta skaitmenų: {1}, Iš jų savo vietoje: {2}", guess, semiCorrect.ToString(), correct.ToString()));
            }
            return ok;
            }
    }
}
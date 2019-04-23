using System;
using System.Collections.Generic;
using System.Text;

namespace Examples123
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FavNum { get; set; }
        public string FavAnimal { get; set; }

        public string AnswerQuestion(string question)
        {
            Console.Clear();
            Console.WriteLine($"Hey {FirstName}, today you will be ask a few questions \njust so i can get to know you better.");
            Console.WriteLine(question);
            return Console.ReadLine();

        }
        public int AnswerQuestionWithInteger(string question)
        {
            string stringAnswer = AnswerQuestion(question);
            return int.Parse(stringAnswer);

           
        }
    }
}

    


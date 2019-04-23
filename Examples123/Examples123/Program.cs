using System;

namespace Examples123
{
    class Program

    {

        static void Main(string[] args)
        {
           User user = new User();

            {
                
                user.FirstName = user.AnswerQuestion("What is your  first name?");
                user.LastName = user.AnswerQuestion("What is your last name?");
                user.FavAnimal = user.AnswerQuestion("What is your Favorite Animal?");
                user.FavNum = user.AnswerQuestionWithInteger("What is your Favorite Number");

                if (user.FavNum <5 )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(user.FavNum);
                    Console.ResetColor();

                }
                else if (user.FavNum > 10)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(user.FavNum);
                    Console.ResetColor();
                }

                Console.WriteLine(user.FirstName);
                Console.WriteLine(user.LastName);
                Console.WriteLine(user.FavNum);
            }   Console.WriteLine(user.FavAnimal);
        }
    }
}






        
    

    




                


            


                    




    





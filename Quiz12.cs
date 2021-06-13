using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAppFirstTry
{
    class Quiz12
    {
        private string[,] questions = new string[20, 5];
        public Quiz12()
        {
            questions[0, 0] = "A place where you can go to see animals is called a ____";
            questions[0, 1] = "bank";
            questions[0, 2] = "veteran";
            questions[0, 3] = "*zoo";
            questions[0, 4] = "unicorn";
            //
            questions[1, 0] = "A place where people live is called a ____";
            questions[1, 1] = "peter";
            questions[1, 2] = "*home";
            questions[1, 3] = "enormous";
            questions[1, 4] = "rail";
            //
            questions[2, 0] = "This word means very fast _____";
            questions[2, 1] = "*speedy";
            questions[2, 2] = "cold";
            questions[2, 3] = "vroom";
            questions[2, 4] = "lose";
            //
            questions[3, 0] = "Thomas the ______";
            questions[3, 1] = "*man";
            questions[3, 2] = "no";
            questions[3, 3] = "no";
            questions[3, 4] = "no";
            //
            questions[4, 0] = "You go to sleep on a _______";
            questions[4, 1] = "can";
            questions[4, 2] = "mouse";
            questions[4, 3] = "*mattress";
            questions[4, 4] = "owl";
            //
            questions[5, 0] = "People are supposed to wear ____ or else they will be naked";
            questions[5, 1] = "snow";
            questions[5, 2] = "*shirts and pants";
            questions[5, 3] = "ants";
            questions[5, 4] = "basin";
            //
            questions[6, 0] = "What you are playing now is called a _____ ";
            questions[6, 1] = "underwear";
            questions[6, 2] = "*game";
            questions[6, 3] = "bill";
            questions[6, 4] = "noise";
            //
            questions[7, 0] = "The green angry Marvel hero is called The _____";
            questions[7, 1] = "light";
            questions[7, 2] = "cup";
            questions[7, 3] = "ugly";
            questions[7, 4] = "*Incredible Hulk";
            //
            questions[8, 0] = "Another word for skinny is ______";
            questions[8, 1] = "no";
            questions[8, 2] = "kid";
            questions[8, 3] = "wall";
            questions[8, 4] = "*thin";
            //
            questions[9, 0] = "A giraffe has a very _____ neck";
            questions[9, 1] = "*spotty";
            questions[9, 2] = "purple";
            questions[9, 3] = "lick";
            questions[9, 4] = "white";
            //
            questions[10, 0] = "Shoes can come in all kinds of _______";
            questions[10, 1] = "loser";
            questions[10, 2] = "pants";
            questions[10, 3] = "yes";
            questions[10, 4] = "*colors";
        }
        public string getQuestion(int i)
        {
            return questions[i, 0];
        }
        public string getAnswer(int i, int j)
        {
            return questions[i, j];
        }

    }
}

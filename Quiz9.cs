using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAppFirstTry
{
    class Quiz9
    {
        private string[,] questions = new string[20, 5];
        public Quiz9()
        {
            questions[0, 0] = "What is the first letter of the alphabet?";
            questions[0, 1] = "b";
            questions[0, 2] = "v";
            questions[0, 3] = "*a";
            questions[0, 4] = "u";
            //
            questions[1, 0] = "What is the fourth letter of the alphabet?";
            questions[1, 1] = "p";
            questions[1, 2] = "*d";
            questions[1, 3] = "e";
            questions[1, 4] = "r";
            //
            questions[2, 0] = "What is the tenth letter of the alphabet?";
            questions[2, 1] = "*j";
            questions[2, 2] = "c";
            questions[2, 3] = "v";
            questions[2, 4] = "l";
            //
            questions[3, 0] = "What letter comes after b?";
            questions[3, 1] = "*c";
            questions[3, 2] = "d";
            questions[3, 3] = "a";
            questions[3, 4] = "b";
            //
            questions[4, 0] = "What letter comes after m?";
            questions[4, 1] = "l";
            questions[4, 2] = "q";
            questions[4, 3] = "*n";
            questions[4, 4] = "o";
            //
            questions[5, 0] = "What letter comes after y?";
            questions[5, 1] = "s";
            questions[5, 2] = "*z";
            questions[5, 3] = "a";
            questions[5, 4] = "b";
            //
            questions[6, 0] = "What letter makes the 'ah' sound? ";
            questions[6, 1] = "u";
            questions[6, 2] = "*a";
            questions[6, 3] = "b";
            questions[6, 4] = "n";
            //
            questions[7, 0] = "What letter makes the 'buh' sound? ";
            questions[7, 1] = "l";
            questions[7, 2] = "c";
            questions[7, 3] = "u";
            questions[7, 4] = "*b";
            //
            questions[8, 0] = "What letter makes the 'duh' sound?";
            questions[8, 1] = "n";
            questions[8, 2] = "k";
            questions[8, 3] = "w";
            questions[8, 4] = "*d";
            //
            questions[9, 0] = "What letter makes the 'mmm' sound?";
            questions[9, 1] = "*m";
            questions[9, 2] = "p";
            questions[9, 3] = "l";
            questions[9, 4] = "w";
            //
            questions[10, 0] = "How many letters are there in the alphabet?";
            questions[10, 1] = "3";
            questions[10, 2] = "2";
            questions[10, 3] = "6";
            questions[10, 4] = "*26";
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

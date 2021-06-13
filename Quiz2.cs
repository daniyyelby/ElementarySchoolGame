using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAppFirstTry
{
    class Quiz2
    {
        private string[,] questions = new string[20, 5];
        public Quiz2()
        {
            questions[0, 0] = "What is 1-1?";
            questions[0, 1] = "3";
            questions[0, 2] = "8";
            questions[0, 3] = "2";
            questions[0, 4] = "*0";
            //
            questions[1, 0] = "What is 5-3?";
            questions[1, 1] = "4";
            questions[1, 2] = "8";
            questions[1, 3] = "*2";
            questions[1, 4] = "10";
            //
            questions[2, 0] = "What is 9-2?";
            questions[2, 1] = "*7";
            questions[2, 2] = "1";
            questions[2, 3] = "22";
            questions[2, 4] = "92";
            //
            questions[3, 0] = "What is 8-2?";
            questions[3, 1] = "9";
            questions[3, 2] = "81";
            questions[3, 3] = "*6";
            questions[3, 4] = "7";
            //
            questions[4, 0] = "What is 3-1?";
            questions[4, 1] = "3";
            questions[4, 2] = "*2";
            questions[4, 3] = "4";
            questions[4, 4] = "9";
            //
            questions[5, 0] = "What is 2-1?";
            questions[5, 1] = "4";
            questions[5, 2] = "3";
            questions[5, 3] = "*1";
            questions[5, 4] = "2";
            //
            questions[6, 0] = "What is 3-1?";
            questions[6, 1] = "3";
            questions[6, 2] = "*2";
            questions[6, 3] = "5";
            questions[6, 4] = "7";
            //
            questions[7, 0] = "What is 6-3? ";
            questions[7, 1] = "1";
            questions[7, 2] = "10";
            questions[7, 3] = "11";
            questions[7, 4] = "*3";
            //
            questions[8, 0] = "What is 9-1?";
            questions[8, 1] = "*8";
            questions[8, 2] = "9";
            questions[8, 3] = "3";
            questions[8, 4] = "10";
            //
            questions[9, 0] = "What is 4-4?";
            questions[9, 1] = "*0";
            questions[9, 2] = "2";
            questions[9, 3] = "3";
            questions[9, 4] = "5";
            //
            questions[10, 0] = "What is 5-2?";
            questions[10, 1] = "*3";
            questions[10, 2] = "2";
            questions[10, 3] = "6";
            questions[10, 4] = "7";
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
    

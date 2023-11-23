using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ICT
{
    internal class MorseCode
    {
        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }



        public string Vertaal(string text)
        {
            foreach (char a in text)
            {
                string i = a.ToString();
                Code = Code + Codeer(i);
                return code;
            }
        }


        private string Codeer(string i)
        {
                string vertaling;
                if (i == "a")
                   vertaling = ".-";
                if (i == "b")
                   vertaling = "-...";
                if (i == "c")
                   vertaling = "-.-.";

        }

    }
}


// A = .-
// B = - ...
// C = -.-.
// D = - ..
// E = .
// F = ..-.
// G = --.
// H = ....
// I = ..
// J = .-- -
// K = -.-
// L = .- ..
// M --
// N = -.
// O =-- -
// P = .--.
// Q = --.-
// R = .-.
// S = ...
// T = -
// U = ..-
// V = ...-
// W = .--
// X = - ..-
// Y = -.--
// Z = --..
// 0 = -----
// 1 = .----
// 2 = ..---
// 3 = ...--
// 4 = ....-
// 5 = .....
// 6 = - ....
// 7 = --...
// 8 = -- - ..
// 9 = ----.

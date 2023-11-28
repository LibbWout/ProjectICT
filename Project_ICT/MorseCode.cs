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
            text = text.ToLower();
            foreach (char a in text)
            {
                string i = a.ToString();
                Code = Code + " " + Codeer(i);
                
            }
            return Code;
        }


        private string Codeer(string i)
        {
            string vertaling = "";
            if (i == "a")
                vertaling = ".-";
            if (i == "b")
                vertaling = "-...";
            if (i == "c")
                vertaling = "-.-.";
            if (i == "d")
                vertaling = "- ..";
            if (i == "e")
                vertaling = ".";
            if (i == "f")
                vertaling = "..-.";
            if (i == "g")
                vertaling = "--.";
            if (i == "h")
                vertaling = "....";
            if (i == "i")
                vertaling = "..";
            if (i == "j")
                vertaling = ".---";
            if (i == "k")
                vertaling = "-.-";
            if (i == "l")
                vertaling = ".-..";
            if (i == "m")
                vertaling = "--";
            if (i == "n")
                vertaling = "-.";
            if (i == "o")
                vertaling = "---";
            if (i == "p")
                vertaling = ".--.";
            if (i == "q")
                vertaling = "--.-";
            if (i == "r")
                vertaling = ".-.";
            if (i == "s")
                vertaling = "...";
            if (i == "t")
                vertaling = "-";
            if (i == "u")
                vertaling = "..-";
            if (i == "v")
                vertaling = "...-";
            if (i == "w")
                vertaling = ".--";
            if (i == "x")
                vertaling = "-..-";
            if (i == "y")
                vertaling = "-.--";
            if (i == "z")
                vertaling = "--..";
            if (i == "0")
                vertaling = "-----";
            if (i == "1")
                vertaling = ".----";
            if (i == "2")
                vertaling = "..---";
            if (i == "3")
                vertaling = "...--";
            if (i == "4")
                vertaling = "....-";
            if (i == "5")
                vertaling = ".....";
            if (i == "6")
                vertaling = "-....";
            if (i == "7")
                vertaling = "--...";
            if (i == "8")
                vertaling = "---..";
            if (i == "9")
                vertaling = "----.";
            return vertaling;
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

//IDictionary<string, string> numberNames = new Dictionary<string, string>();
//numberNames.Add("a" ,"One"); //adding a key/value using the Add() method
//numberNames.Add(2,"Two");
//numberNames.Add(3,"Three");
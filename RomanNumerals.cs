using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_2Calculator
{
    delegate string IntToRomanNumeralsDelegate(int num);
    delegate int RomanNumeralToInt(string word);
    internal class RomanNumerals
    {

        internal string IntToRoman(int num)
        {
            string s = "";

            while (num > 0)
            {
                if (num - 1000 >= 0)
                {
                    num -= 1000;
                    s += "M";
                }
                else if (num - 1000 < 0 && num - 900 >= 0)
                {
                    num -= 900;
                    s += "CM";
                }
                else if (num - 500 >= 0)
                {
                    num -= 500;
                    s += "D";
                }
                else if (num - 500 < 0 && num - 400 >= 0)
                {
                    num -= 400;
                    s += "CD";
                }
                else if (num - 100 >= 0)
                {
                    num -= 100;
                    s += "C";
                }
                else if (num - 100 < 0 && num - 90 >= 0)
                {
                    num -= 90;
                    s += "XC";
                }
                else if (num - 50 >= 0)
                {
                    num -= 50;
                    s += "L";
                }
                else if (num - 50 < 0 && num - 40 >= 0)
                {
                    num -= 40;
                    s += "XL";
                }
                else if (num - 10 >= 0)
                {
                    num -= 10;
                    s += "X";
                }
                else if (num - 10 < 0 && num - 9 >= 0)
                {
                    num -= 9;
                    s += "IX";
                }
                else if (num - 5 >= 0)
                {
                    num -= 5;
                    s += "V";
                }
                else if (num - 5 < 0 && num - 4 >= 0)
                {
                    num -= 4;
                    s += "IV";
                }
                else if (num - 1 >= 0)
                {
                    num -= 1;
                    s += "I";
                }



            }


            return s;
        }

        internal int RomanNumeralToInt(string word)
        {
            int sum = 0;

            int i = 0;

            while (i < word.Length)
            {
                if (i == word.Length - 1)
                {
                    sum += RegularValues(word[i]);
                    break;
                }

                if (word[i] == 'C' && word[i + 1] == 'M' || word[i] == 'C' && word[i + 1] == 'D')
                {
                    sum += NonRegular(word[i].ToString() + word[i + 1].ToString());
                    i += 2;
                }
                else if (word[i] == 'I' && word[i + 1] == 'V' || word[i] == 'I' && word[i + 1] == 'X')
                {
                    sum += NonRegular(word[i].ToString() + word[i + 1].ToString());
                    i += 2;
                }
                else if (word[i] == 'X' && word[i + 1] == 'L' || word[i] == 'X' && word[i + 1] == 'C')
                {
                    sum += NonRegular(word[i].ToString() + word[i + 1].ToString());
                    i += 2;
                }
                else
                {
                    sum += RegularValues(word[i]);
                    i++;
                }



            }

            return sum;


             int RegularValues(char character)
            {
                int val = 0;
                switch (character)
                {
                    case 'I':
                        val = 1;
                        break;
                    case 'V':
                        val = 5;
                        break;
                    case 'X':
                        val = 10;
                        break;
                    case 'L':
                        val = 50;
                        break;
                    case 'C':
                        val = 100;
                        break;
                    case 'D':
                        val = 500;
                        break;
                    case 'M':
                        val = 1000;
                        break;
                    default:
                        break;
                }
                return val;
            }


             int NonRegular(string characters)
            {
                int val = 0;
                switch (characters)
                {
                    case "IV":
                        val = 4;
                        break;
                    case "IX":
                        val = 9;
                        break;
                    case "XL":
                        val = 40;
                        break;
                    case "XC":
                        val = 90;
                        break;
                    case "CD":
                        val = 400;
                        break;
                    case "CM":
                        val = 900;
                        break;
                    default:
                        break;
                }
                return val;
            }

        }
    }
}

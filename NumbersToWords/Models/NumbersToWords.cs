using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NumbersToWords.Models
{
    public class Number
    {
      public int UserNum;
      public string Word;

    public Number(int userNum)
    {
    UserNum = userNum;
    }

    public Dictionary<char, string> firstDigit = new Dictionary<char, string>()
    {
        {'1', "one"}, {'2', "two"}, {'3', "three"}, {'4', "four"}, {'5', "five"}, {'6', "six"}, {'7', "seven"}, {'8', "eight"}, {'9', "nine"}, 
    };

    public Dictionary<int, string> specialTenDigit = new Dictionary<int, string>()
    {
        {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"},  {10, "ten"},{11, "eleven"}, {12, "twelve"}, {13, "thirteen"}, {14, "fourteen"}, {15, "fifteen"}, {16, "sixteen"}, {17, "seventeen"}, {18, "eighteen"}, {19, "nineteen"}, 
    };

    public Dictionary<char, string> secondDigit = new Dictionary<char, string>()
    {
        {'2', "twenty"}, {'3', "thirty"}, {'4', "fourty"}, {'5', "fifty"}, {'6', "sixty"}, {'7', "seventy"}, {'8', "eighty"}, {'9', "ninety"}, 
    };

    public string WordNumber()
    {
    string teenResult = "";
    string digit1Result = "";
    string digit2Result = "";
    string digit3Result = "";
    string digit4Result = "";
    string digit5Result = "";
    char[] newArr = UserNum.ToString().ToCharArray();
    if (UserNum < 20)
    {
            if (specialTenDigit.ContainsKey(UserNum))
            {
            teenResult = specialTenDigit[UserNum];
            return teenResult;
            }
            return teenResult;
      }


      else if (UserNum > 20 && UserNum < 100 )
      {
          if (secondDigit.ContainsKey(newArr[0]))
            {
            digit2Result = secondDigit[newArr[0]];
            }
          if (firstDigit.ContainsKey(newArr[1]))
            {
            digit1Result = firstDigit[newArr[1]];
            }
      return digit2Result + " " + digit1Result;
      }


      else if (UserNum > 99 && UserNum < 1000 )
      {
          if (firstDigit.ContainsKey(newArr[0]))
            {
            digit3Result = firstDigit[newArr[0]];
            }
          
          if (secondDigit.ContainsKey(newArr[1]))
            {
            digit1Result = secondDigit[newArr[1]];
            }
          if (firstDigit.ContainsKey(newArr[2]))
            {
            digit2Result = firstDigit[newArr[2]];
            }
      return digit3Result + " hundred" + " " + digit1Result + " " + digit2Result;
      }


      // else if (UserNum > 999 && UserNum < 10000 )
      // {
      //     if (firstDigit.ContainsKey(newArr[0]))
      //       {
      //       digit4Result = firstDigit[newArr[0]];
      //       }
      //     if (firstDigit.ContainsKey(newArr[1]))
      //       {
      //       digit3Result = firstDigit[newArr[1]];
      //       }
      //     if (secondDigit.ContainsKey(newArr[2]))
      //       {
      //       digit1Result = secondDigit[newArr[2]];
      //       }
      //     if (firstDigit.ContainsKey(newArr[3]))
      //       {
      //       digit2Result = firstDigit[newArr[3]];
      //       }
      //     return digit4Result + " thousand " + digit3Result + " hundred" + " " + digit1Result + " " + digit2Result;
      // }
      // else if (UserNum > 10000 && UserNum < 20000)
      // {
      //   int newNumber = int.Parse(newArr[0].ToString() + newArr[1].ToString());
      //       teenResult = specialTenDigit[newNumber];
      //         if (firstDigit.ContainsKey(newArr[2]))
      //         {
      //         digit3Result = firstDigit[newArr[2]];
      //         }
            
      //         if (secondDigit.ContainsKey(newArr[3]))
      //         {
      //         digit1Result = secondDigit[newArr[3]];
      //         }
      //         if (firstDigit.ContainsKey(newArr[4]))
      //         {
      //         digit2Result = firstDigit[newArr[4]];
      //         }
      //         return teenResult + " thousand " + digit3Result + " hundred" + " " + digit1Result + " " + digit2Result;;
      //   }
      // else if (UserNum > 20000 && UserNum < 99999 )
      // {
      //     if (secondDigit.ContainsKey(newArr[0]))
      //       {
      //       digit5Result = secondDigit[newArr[0]];
      //       }
      //     if (firstDigit.ContainsKey(newArr[1]))
      //       {
      //       digit4Result = firstDigit[newArr[1]];
      //       }
      //     if (firstDigit.ContainsKey(newArr[2]))
      //       {
      //       digit3Result = firstDigit[newArr[2]];
      //       }
      //     if (secondDigit.ContainsKey(newArr[3]))
      //       {
      //       digit1Result = secondDigit[newArr[3]];
      //       }
      //     if (firstDigit.ContainsKey(newArr[4]))
      //       {
      //       digit2Result = firstDigit[newArr[4]];
      //       }
      //     return digit5Result + " " + digit4Result + " thousand " + digit3Result + " hundred" + " " + digit1Result + " " + digit2Result;
      // }
        
        return "99999";
        }



      
    // }
      //  return singleResult;
        // for (i = userNum.Length; i >=0; i--)
        // {
        //     if (userNum.Length == 1)
        //     {
        //         if (firstDigit.Contains(i))
        //         {
        //         string singleResult = firstDigit[i];
        //         }
        //     }
        //     if (Number.Length == 2)
        //     {
        //         if (specialTenDigit.Contains((Number.Length-1))
        //         {
        //         string secondResult = specialTenDigit[i];
        //         }
        //         else if (secondDigit.Contains(Number.Length-1))
        //         {
        //         string secondResult = specialTenDigit[i];
        //         }
        //     }
        // }
    }


// public static string NumberToWords(long number)
// {
//     if (number == 0)
//         return "zero";

//     if (number < 0)
//         return "minus " + NumberToWords(Math.Abs(number));

//     string words = "";

//     if ((number / 1000000000000) > 0)
//     {
//         words += NumberToWords(number / 1000000000000) + " tillion ";
//         number %= 1000000000000;
//     }

//     if ((number / 1000000000) > 0)
//     {
//         words += NumberToWords(number / 1000000000) + " billion ";
//         number %= 1000000000;
//     }

//     if ((number / 1000000) > 0)
//     {
//         words += NumberToWords(number / 1000000) + " million ";
//         number %= 1000000;
//     }

//     if ((number / 1000) > 0)
//     {
//         words += NumberToWords(number / 1000) + " thousand ";
//         number %= 1000;
//     }

//     if ((number / 100) > 0)
//     {
//         words += NumberToWords(number / 100) + " hundred ";
//         number %= 100;
//     }

//     if (number > 0)
//     {
//         if (words != "")
//             words += "and ";

//         var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
//         var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

//         if (number < 20)
//             words += unitsMap[number];
//         else
//         {
//             words += tensMap[number / 10];
//             if ((number % 10) > 0)
//                 words += " " + unitsMap[number % 10];
//         }
//     }

//     return words;
//     }
}
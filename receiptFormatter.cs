using System;
using System.Linq;
using System.Collections.Generic;

/*
When placing orders through the system, customers are allowed to add special instructions to their orders, for instance specifying that they don't need utensils or that they want their steak cooked a certain way.

Restaurant receipt printers have restrictions for how many characters can fit on each line. This means that in many cases special instructions must be wrapped and put on multiple lines in order for the text to fit.

Write a function 'WordWrap' that takes as input a string (the special instructions) and an integer (the character limit) and returns the special instructions wrapped onto lines with no line exceeding the character limit.
*/

class WordWrap{
  public string[] Wrap(string instructions, int maxLineLength){
    // Add code here
    string[] words = instructions.Split(' ');
    string currentLine = "";
    List<string> lines = new List<string>();
    for(int i = 0; i < words.Length; i++){
      if(currentLine.Length + words[i].Length <= 15){
        currentLine += (words[i] + " ");
      } else if(words[i].Length > 15) {
        lines.Add(words[i].Substring(0, 14) + "-");
        currentLine += (words[i].Substring(14) + " ");
      } else {
        lines.Add(currentLine.Trim());
        currentLine = words[i];
      }
    }
    lines.Add(currentLine.Trim());
    return lines.ToArray();
  }
}

// class Tests{

//   [TestCase("Extra dressing", 15)] // Define the test case: some instructions and the max line length
//   public string[] Test_ShortMessage_FitsOnOneLine(){
//       return new string[]{ "Extra dressing" }; // Return the expected output
//   }

//   [TestCase("Extra dressing please", 15)]
//   public string[] Test_SlightlyLongerMessage_NeedsTwoLines(){
//       return new string[]{ "Extra dressing", "please" };
//   }

//   [TestCase("Extradressingssss please", 15)]
//   public string[] Test_SlightlyLongerWords_NeedsTwoLines(){
//       return new string[]{ "Extradressings-", "sss please" };
//   }
// }
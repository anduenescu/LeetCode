//inspired by https://leetcode.com/problems/keyboard-row/?envType=problem-list-v2&envId=string 
//this only goes through each string in the array of strings and then separates each character in a new char[]
public class Solution {
    public string[] FindWords(string[] words) 
    {
        
        //char[] upperRow = "qwertyuiop".ToCharArray();
        //char[] middleRow = "asdfghjkl".ToCharArray();
        //char[] lowerRow = "zxcvbnm".ToCharArray();

        int totalCharacters = 0;
        foreach( string word in words)
        {
            totalCharacters += word.Length;

        }
        //Console.WriteLine($"The total number of characters is: {totalCharacters}");
        char[] characters = new char[totalCharacters];
        var index = 0;

        for(int i = 0; i < words.Length; i++)
        {
                //Console.WriteLine($"Word: {words[i]}");

                for( int j = 0; j < words[i].Length; j++)
                {
                    characters[index++] = words[i][j];
                    //Console.WriteLine(characters[index - 1]);
                    
                }
         } 
         
         Console.WriteLine("All characters:");
         foreach (char ch in characters)
         {
            Console.Write(ch + " ");
         }
         
        return words;
    }
}

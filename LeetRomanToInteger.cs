public class Solution {
    public int RomanToInt(string s) {

Dictionary<char, int> openWith =
    new Dictionary<char, int>();
    openWith.Add('I', 1);
    openWith.Add('V', 5);
    openWith.Add('X', 10);
    openWith.Add('L', 50);
    openWith.Add('C', 100);
    openWith.Add('D', 500);
    openWith.Add('M', 1000);

        int sum = 0;
        int result = 0;

foreach(char letter in s)
{
    if (openWith.TryGetValue(letter, out int value))
    sum = sum + value;

}
 Console.WriteLine(sum);
 return sum;


    }
}

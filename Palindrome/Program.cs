// See https://aka.ms/new-console-template for more information
public class App
{
    public static void Main()
    {
        string text1 = "";
        var result1= CheckPalindrome(text1);
        Print(result1, text1);

        string text2 = "H anna h";
        var result2 = CheckPalindrome(text2);
        Print(result2, text2);

        string text3 = "H love h";
        var result3 = CheckPalindrome(text3);
        Print(result3, text3);
        Console.Read();


    }

    private static void Print(bool result, string text)
    {
        if (result) // Checking whether string is palindrome or not  
        {
            Console.WriteLine($"{text}  is Palindrome");
        }
        else
        {
            Console.WriteLine($"{text}  is not Palindrome");
        }
    }

    private static bool CheckPalindrome(string text)
    {
        string  revs = "";
        for (int i = text.Length - 1; i >= 0; i--) //String Reverse  
        {
            revs += text[i].ToString();
        }
        if (revs.ToLower() == text.ToLower()) // Checking whether string is palindrome or not  
        {
           return true;
        }
        else
        {
           return false;    
        }
    }

 



}

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введiть слово для перевiрки на палiндром:");
        string inputWord = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(inputWord))
        {
            Console.WriteLine("Введено порожнiй рядок або пробiли. Спробуйте ще раз.");
            return;
        }

        PalindromeChecker checker = new PalindromeChecker();
        bool isPalindrome = checker.IsPalindrome(inputWord);

        if (isPalindrome)
            Console.WriteLine("Це слово - палiндром.");
        else
            Console.WriteLine("Це слово не є палiндромом.");

        Console.ReadKey();
    }
}

class PalindromeChecker
{
    public bool IsPalindrome(string word)
    {
        // Видалення символів розділення і перетворення на нижній регістр
        string cleanedWord = new string(word.ToLower().ToCharArray()
                                  .Where(c => Char.IsLetterOrDigit(c))
                                  .ToArray());

        // Перевірка на паліндромність
        int left = 0;
        int right = cleanedWord.Length - 1;

        while (left < right)
        {
            if (cleanedWord[left] != cleanedWord[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
}

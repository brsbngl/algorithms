// Check if given word is a palindrom or not

// Pseudo Code
// 1. Start
// 2. Iterate through the word both from the end and the beginning
// 3. Compare each character from the end with the corresponding character from the beginning
// 4. If all characters match, the word is a palindrome
// 5. Otherwise, it is not a palindrome
// 6. End


static bool IsPalindrome(string word)
{
    int left = 0;
    int right = word.Length - 1;

    while (left < right)
    {
        if (word[left] != word[right])
        {
            return false;
        }
        left++;
        right--;
    }
    return true;
}

Console.WriteLine("Enter a word:");
string word = Console.ReadLine();
bool isPalindrome = IsPalindrome(word);
Console.WriteLine($"Is '{word}' a palindrome? {isPalindrome}");

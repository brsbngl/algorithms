// Accept first name and last name
// Then print them out with capitalized first letter of each word
//

// Pseudo Code
// 1. Create two variables to store the first name and last name
// 2. Accept first name and last name
// 3. Capitalize each one's first letter and convert rest to lowercase
// 4. Print them together
//


Console.WriteLine("Enter your first name: ");
string firstName = Console.ReadLine();
Console.WriteLine("Enter your last name: ");
string lastName = Console.ReadLine();

string capitalize(string word)
{
    if (word.Length == 0)
    {
        return word;
    }
    // string temp = word.ToLower().Substring(1);
    // return word.Substring(0, 1).ToUpper() + temp;
    return char.ToUpper(word[0]) + word.Substring(1).ToLower();
}

firstName = capitalize(firstName);
lastName = capitalize(lastName);

Console.WriteLine($"{firstName} {lastName}");

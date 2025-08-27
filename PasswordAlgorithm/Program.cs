// Enforce password complexity rules: Longer than 8 characters, contains at least one uppercase letter, one lowercase letter, one digit, and one special character
//
// Pseudo Code
// 1. Start
// 2. Accept password input from user
// 3. Check for rules one by one
// 4. If all rules pass, print success
//

do
{
    Console.WriteLine("Enter your password: ");
    string password = Console.ReadLine();

    if (password.Length <= 8)
    {
        Console.WriteLine("Your password must be longer than 8 characters");
        continue;
    }

    bool hasUpper = false;
    bool hasLower = false;
    bool hasDigit = false;
    bool hasSpecial = false;

    for (var i = 0; i < password.Length; i++)
    {
        // Check for upper case
        if (password[i] >= 'A' && password[i] <= 'Z')
        {
            hasUpper = true;
        }
        else if (password[i] >= 'a' && password[i] <= 'z')
        {
            hasLower = true;
        }
        else if (password[i] >= '0' && password[i] <= '9')
        {
            hasDigit = true;
        }
        else
        {
            // It is special if others are all false
            hasSpecial = true;
        }
    }
    if (hasUpper && hasLower && hasDigit && hasSpecial) {
        Console.WriteLine("You set your password: ");
        Console.WriteLine(password);
        break;
    } else {
        Console.WriteLine("Your password must be longer than 8 characters, contain at least 1 uppercase, 1 lowercase and 1 special character");
    }
}
while (true);

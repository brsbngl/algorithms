/*Kullanıcının şifresi, şifre değişimi için belirlenen bir soru ve cevabı olmalı. 
 * Kullanıcı sorunun cevabını doğru bildiğinde şifre değişimine izin verilmeli. 
 * Şifre değişimi işleminden sonra yeni şifre ekrana basılmalı.
 * (Program kullanıcı soruyu doğru bilene kadar sormaya devam etmeli.)*/

string securityQuestionsAnswer = "Ateş";
string password;

string securityQuestion = "En sevdiğiniz element nedir?";

while (true)
{
    Console.WriteLine("Güvenlik sorusunun cevabını giriniz: ");
    securityQuestion = Console.ReadLine();

    if (securityQuestion.ToLower().Trim() != securityQuestionsAnswer.ToLower().Trim())
    {
        Console.WriteLine("Güvenlik sorusunun cevabını doğru bilemediniz. Tekrar deneyiniz.");
    }
    else
    {
        Console.WriteLine("Cevap doğru!");
        break;
    }
}

Console.WriteLine("Güvenlik sorusu doğru, belirlemek istediğiniz şifreyi giriniz:");
password = Console.ReadLine();

Console.WriteLine($"Yeni şifreniz: {password}");

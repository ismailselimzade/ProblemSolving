/*
===========================================================================
PROBLEM DESCRIPTION / PROBLEMİN TƏSVİRİ:
---------------------------------------------------------------------------
# Debugging # Fundamentals

Platform: Codewars
Problem: 101 Dalmatians - squash the bugs, not the dogs!
Difficulty / Çətinlik: 8 kyu
Link: https://www.codewars.com/kata/56f6919a6b88de18ff000b36/train/csharp


Your friend has been out shopping for puppies (what a time to be alive!)... He arrives back with multiple dogs, and you simply do not know how to respond!
- Dostunuz küçüklər almağa getmişdi (yaşamaq üçün necə də gözəl vaxtdır!)... O, birdən çox itlə qayıdır və siz sadəcə nə cavab verəcəyinizi bilmirsiniz!

By repairing the function provided, you will find out exactly how you should respond, depending on the number of dogs he has.
- Verilən funksiyanı düzəltməklə, onun sahib olduğu itlərin sayından asılı olaraq dəqiq necə cavab verməli olduğunuzu tapacaqsınız.

The number of dogs will always be a number and there will always be at least 1 dog.
- İtlərin sayı həmişə bir ədəd olacaq və həmişə ən azı 1 it olacaq.

Good luck!
- Uğurlar!
===========================================================================
*/
public partial class Solution
{
    /// <summary>
    /// Returns a response based on the number of dogs / İtlərin sayına əsasən müvafiq cavabı qaytarır
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(1)
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(1)
    /// </summary>
    public string HowManyDalmatians(int number)
    {
        List<string> dogs = new List<string>()
        {
            "Hardly any",
            "More than a handful!",
            "Woah that's a lot of dogs!",
            "101 DALMATIONS!!!"
        };

        // netice
        string respond = "";

        if (number <= 10)
            respond = dogs[0];
        else if (number <= 50)
            respond = dogs[1];
        else if (number == 101)
            respond = dogs[3];
        else
            respond = dogs[2];

        return respond;
    }
}
/*
===========================================================================
PROBLEM DESCRIPTION / PROBLEMİN TƏSVİRİ:
---------------------------------------------------------------------------
Platform: Codewars
Problem: 8kyu interpreters: HQ9+
Difficulty / Çətinlik: 8 kyu (Easy / Asan)
Link: https://www.codewars.com/kata/591588d49f4056e13f000001/train/csharp

You task is to implement an simple interpreter for the notorious esoteric language HQ9+ that will work for a single character input:
- Sizin vəzifəniz məşhur ezoterik dil olan HQ9+ üçün tək simvollu girişlə işləyən sadə bir interpreter yazmaqdır:

If the input is 'H', return 'Hello World!'
- Əgər giriş 'H' olarsa, 'Hello World!' qaytarın

If the input is 'Q', return the input
- Əgər giriş 'Q' olarsa, girişin özünü qaytarın

- If the input is '9', return the full lyrics of 99 Bottles of Beer. It should be formatted like this:
- Əgər giriş '9' olarsa, "99 Bottles of Beer" mahnısının tam sözlərini qaytarın. O, aşağıdakı kimi formatlaşdırılmalıdır:

99 bottles of beer on the wall, 99 bottles of beer.
 - 99 şüşə pivə divarda, 99 şüşə pivə.

Take one down and pass it around, 98 bottles of beer on the wall.
 - Birini götür və əldən-ələ ötür, divarda 98 şüşə pivə.

98 bottles of beer on the wall, 98 bottles of beer.
 - 98 şüşə pivə divarda, 98 şüşə pivə.

Take one down and pass it around, 97 bottles of beer on the wall.
 - Birini götür və əldən-ələ ötür, divarda 97 şüşə pivə.

97 bottles of beer on the wall, 97 bottles of beer.
 - 97 şüşə pivə divarda, 97 şüşə pivə.

Take one down and pass it around, 96 bottles of beer on the wall.
 - Birini götür və əldən-ələ ötür, divarda 96 şüşə pivə.

...
...
...

2 bottles of beer on the wall, 2 bottles of beer.
 - 2 şüşə pivə divarda, 2 şüşə pivə.

Take one down and pass it around, 1 bottle of beer on the wall.
 - Birini götür və əldən-ələ ötür, divarda 1 şüşə pivə.

1 bottle of beer on the wall, 1 bottle of beer.
 - 1 şüşə pivə divarda, 1 şüşə pivə.

Take one down and pass it around, no more bottles of beer on the wall.
 - Birini götür və əldən-ələ ötür, divarda artıq şüşə pivə qalmadı.

No more bottles of beer on the wall, no more bottles of beer.
 - Divarda artıq şüşə pivə qalmadı, artıq şüşə pivə qalmadı.

Go to the store and buy some more, 99 bottles of beer on the wall.
 - Mağazaya get və bir az da al, divarda 99 şüşə pivə.

For everything else, don't return anything (return null in C#, None in Rust, and "" in Haskell).
- Digər hər şey üçün heç nə qaytarmayın (C#-da null qaytarın).

(+ has no visible effects so we can safely ignore it.)
- (+ simvolunun görünən heç bir təsiri yoxdur, ona görə də onu təhlükəsiz şəkildə nəzərə almaya bilərik.)
===========================================================================
*/

using System.Text;

public partial class Solution
{
    /// <summary>
    /// Interprets HQ9+ esoteric language commands / HQ9+ ezoterik dil komandalarını icra edir
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(1)
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(1)
    /// </summary>
    public string Interpret(string code)
    {
        // h verilibse hello world qaytariram.
        if (code == "H")
            return "Hello World!";
        // q verilibse ele ozunu qaytariram.
        else if (code == "Q")
            return code;
        // 9 yazilibsa hemin mahnini qaytariram
        else if (code == "9")
        {
            // umumi butulkalarin sayi
            int bottles = 99;
            // mahni metni
            // rahat birlesdirme ucun stringbuilder isledirem.
            StringBuilder interpreter = new();

            // dovr butulkalarin sayi bitene qeder davam edir.
            while (bottles > 0)
            {
                // eger 1 butulka qalibsa bottle (tekde), 1-den cox qalibsa bottles (cemde) yazilmalidir.
                // bu cumleden sonra butulkalarin sayini 1 eded azaldiram.
                if (bottles == 1)
                {
                    interpreter.Append($"{bottles} bottle of beer on the wall, {bottles--} bottle of beer.\n");
                }
                else
                {
                    interpreter.Append($"{bottles} bottles of beer on the wall, {bottles--} bottles of beer.\n");
                }

                // eger butulkalar bitdise mahninin sonluqunu elave edirem.
                if (bottles == 0)
                {
                    interpreter.Append($"Take one down and pass it around, no more bottles of beer on the wall.\n");
                    interpreter.Append($"No more bottles of beer on the wall, no more bottles of beer.\n");
                    interpreter.Append($"Go to the store and buy some more, 99 bottles of beer on the wall.");
                }
                else
                {
                    // eger bitmeyibse 1 butulka qalibsa bottle (tekde), 1-den cox qalibsa bottles (cemde) yazaraq
                    // mahnini yazmaga davam edirem.
                    if (bottles == 1)
                    {
                        interpreter.Append($"Take one down and pass it around, {bottles} bottle of beer on the wall.\n");
                    }
                    else
                    {
                        interpreter.Append($"Take one down and pass it around, {bottles} bottles of beer on the wall.\n");
                    }
                }
            }

            // sonda stringbuilderi stringe cevirib mahnini qaytariram.
            return interpreter.ToString();
        }

        // verilenler uygun olmadiqda
        return null;
    }
}
/*
===========================================================================
PROBLEM DESCRIPTION / PROBLEMİN TƏSVİRİ:
---------------------------------------------------------------------------
Platform: Codewars
Problem: A + B
Difficulty / Çətinlik: 8 kyu
Link: https://www.codewars.com/kata/5512a0b0509063e57d0003f5/train/csharp

Vasya Pupkin just started learning Java and C#. He wrote a program to sum two small numbers
(numbers and their sum fit in a byte), but it didn't work. Help him to correct the mistake.
- Vasya Pupkin Java və C# öyrənməyə yeni başlayıb. O, iki kiçik ədədi toplamaq üçün proqram yazdı
(ədədlər və onların cəmi byte tipinə sığır), lakin proqram işləmədi. Ona səhvi düzəltməyə kömək edin.
===========================================================================
*/

public partial class Solution
{
    /// <summary>
    /// Returns the sum of two bytes using Convert.ToByte for explicit conversion.
    /// İki byte ədədi Convert.ToByte istifadə edərək toplayır.
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(1)
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(1)
    /// </summary>
    public byte SumConvert(byte a, byte b)
    {
        // Convert.ToByte ilə çevirmə edərək toplayiram
        byte c = Convert.ToByte(a + b);
        return c;
    }

    public byte SumCast(byte a, byte b)
    {
        // Cast ilə byte-a çevirərək toplayiram
        byte c = (byte)(a + b);
        return c;
    }
}
/*
===========================================================================
PROBLEM DESCRIPTION / PROBLEMİN TƏSVİRİ:
---------------------------------------------------------------------------
Platform: Codewars
Problem: ASCII Total
Difficulty / Çətinlik: 8 kyu
Link: https://codewars.com/kata/572b6b2772a38bc1e700007a

You'll be given a string, and have to return the sum of all characters as an int. The function should be able to handle all printable ASCII characters.
- Sizə bir string veriləcək və bütün simvolların ASCII dəyərlərinin cəmini int kimi qaytarmalısınız. Funksiya bütün çap edilə bilən ASCII simvollarını idarə edə bilməlidir.

Examples / Nümunələr:
uniTotal("a") == 97
uniTotal("aaa") == 291
===========================================================================
*/

public partial class Solution
{
    /// <summary>
    /// Iterates through each character and accumulates its ASCII value using a foreach loop.
    /// Hər simvolu foreach ilə gəzərək ASCII dəyərini toplayır.
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(n)
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(1)
    /// </summary>
    public int UniTotalForeach(string str)
    {
        int total = 0;

        foreach (char c in str)
        {
            total += c;
        }

        return total;
    }

    /// <summary>
    /// Sums all character ASCII values using LINQ Sum.
    /// Bütün simvolların ASCII dəyərlərini LINQ Sum ilə toplayır.
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(n)
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(1)
    /// </summary>
    public int UniTotalLinq(string str)
    {
        return str.Sum(c => (int)c);
    }
}
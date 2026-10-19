/*
===========================================================================
PROBLEM DESCRIPTION / PROBLEMİN TƏSVİRİ:
---------------------------------------------------------------------------
# Restricted # Fundamentals # Puzzles

Platform: Codewars
Problem: Return Five / Həmişə 5 Qaytar
Difficulty / Çətinlik: 8 kyu (Easy / Asan)
Link: https://www.codewars.com/kata/59441520102eaa25260000bf/train/csharp

Write a function that always returns 5
- Həmişə 5 qaytaran bir funksiya yazın.

Sounds easy right? Just bear in mind that you can't use any of the following characters: 0123456789*+-/
- Asan səslənir, elə deyilmi? Amma nəzərə alın ki, aşağıdakı simvollardan heç birini istifadə edə bilməzsiniz: 0123456789*+-/

Good luck :)
- Uğurlar :)
===========================================================================
*/

public partial class Solution
{
    /// <summary>
    /// Returns 5 without using numbers or math operators / Rəqəm və ya riyazi simvol işlətmədən 5 qaytarır
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(1)
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(1)
    /// </summary>
    public int UnusualFive()
    {
        // 5 herf uzunlugunda bir stringin uzunlugunu qaytarmaqla
        return "abcdf".Length;
    }
}
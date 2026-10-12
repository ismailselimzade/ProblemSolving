/*
===========================================================================
PROBLEM DESCRIPTION / PROBLEMİN TƏSVİRİ:
---------------------------------------------------------------------------
Platform: LeetCode
Problem: 9. Palindrome Number
Difficulty / Çətinlik: Easy / Asan
Link: https://leetcode.com/problems/palindrome-number/

Given an integer x, return true if x is a palindrome, and false otherwise.
 - Sizə x tam ədədi verilir, əgər x palindromdursa true, əks halda false qaytarın.

Examples / Nümunələr:

Example 1:
Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.
 - İzah: 121 soldan sağa da, sağdan sola da 121 kimi oxunur.

Example 2:
Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
 - İzah: Soldan sağa -121 kimi oxunur. Sağdan sola isə 121- olur. Buna görə də palindrom deyil.

Example 3:
Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
 - İzah: Sağdan sola 01 kimi oxunur. Buna görə də palindrom deyil.
 
Constraints / Məhdudiyyətlər:
-2^31 <= x <= 2^31 - 1
 - x ədədi -2^31 ilə 2^31 - 1 aralığındadır.
 
Follow-up: Could you solve it without converting the integer to a string?
 - Əlavə sual: Ədədi string-ə çevirmədən həll edə bilərsinizmi?
===========================================================================
*/

public partial class Solution
{
    /// <summary>
    /// Solution using String Conversion / String-ə Çevirmə ilə Həll
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(n)
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(n)
    /// </summary>
    public bool IsPalindromeString(int x)
    {
        string xString = x.ToString(); // x-i stringe cevirirem
        string reversedXString = new string(xString.Reverse().ToArray()); // sonra tersine cevirirem

        if (xString.Equals(reversedXString))
        {
            return true;
        }

        return false;
    }

    /// <summary>
    /// Optimal Solution without String Conversion / String-ə Çevirmədən Optimal Həll
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(log10(x))
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(1)
    /// </summary>
    public bool IsPalindromeMathematical(int x)
    {
        // eger x menfidirse, sonu 0-la bitirse ve eyni zamanda 0 deyilse palindrom deyil
        if (x < 0 || x % 10 == 0 && x != 0) return false; 

        int reversedX = 0; // cevrilmis x-i bura kocurecem

        // x-i reqemlerinin yarisina qeder yoxluyuram
        // meselen x = 1221 olsa 12 ve 21(cevrilmis hali 12 olur reversedX-da) demeli palindromdur.
        // x ona gore reversedX dan kicik olarsa artiq yoxlama dayanir cunki yarisina catmis oluruq 12 > 12
        while (x > reversedX) 
        { 
            // x-in sonuncu reqemini tapiram qaliq kimi.
            int remainder = x % 10;
            // reversedX-i yenileyirem hazirki veziyyetini 10a vurub uzerine qaliq gelirem
            // bucur sonda x-in sag yarisinin cevrilmis hali emele gelir.
            reversedX = reversedX * 10 + remainder;

            // x-in sonundan sonuncu reqemini silirem en sonda sol yarisi qalir.
            x = x / 10;
        }

        // x-in sol yarisi ile sag yarisini(reversedX)-i yoxlayiram
        // x-in reqemlerinin sayi tekdirse ortadaki reqem reversedX-e elave olunmus ola biler.
        // ona gore de reversedX-in son reqemi silinmis hali ile de yoxlayiram.
        return reversedX == x || reversedX / 10 == x;
    }
}
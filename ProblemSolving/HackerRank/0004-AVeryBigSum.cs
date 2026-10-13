/*
===========================================================================
PROBLEM DESCRIPTION / PROBLEMİN TƏSVİRİ:
---------------------------------------------------------------------------
Platform: HackerRank
Problem: A Very Big Sum
Difficulty / Çətinlik: Easy / Asan
Link: https://www.hackerrank.com/challenges/a-very-big-sum/problem

Calculate and print the sum of elements in an array, considering that some integers may be very large.
- Bəzi tam ədədlər çox böyük ola biləcəyini nəzərə alaraq, massivdəki elementlərin cəmini hesablayın və çap edin.

Function Description / Funksiya Təsviri:
Complete the aVeryBigSum function.
- aVeryBigSum funksiyasını tamamlayın.

Parameters / Parametrlər:
int ar[n]: an array of integers
- int ar[n]: tam ədədlərdən ibarət massiv

Return / Qaytarır:
long: the sum of the array elements
- long: massiv elementlərinin cəmi

Examples / Nümunələr:

Example 1:
Input:  arr = [1000000001, 1000000002, 1000000003, 1000000004, 1000000005]
Output: 5000000015
Explanation: Sum of all elements.
 - İzah: Bütün elementlərin cəmi.

Constraints / Məhdudiyyətlər:
1 <= n <= 10
 - n massivinin uzunluğu 1 ilə 10 arasındadır.
0 <= ar[i] <= 10^10
 - Massivin hər bir elementi 0 ilə 10^10 arasındadır.
===========================================================================
*/

public partial class Solution
{
    /// <summary>
    /// Iterates through the array and returns the sum of all elements.
    /// Massivdəki bütün elementləri toplayaraq cəmini qaytarır.
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(n)
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(1)
    /// </summary>
    public long AVeryBigSumForEach(long[] ar)
    {
        long total = 0; // cəmi saxlayan dəyişən
        foreach (long element in ar) // massivi gəzirik
        {
            total += element; // hər elementi cəmə əlavə edirik
        }

        return total;
    }

    /// <summary>
    /// Iterates through the array and returns the sum of all elements using LINQ.
    /// Massivdəki bütün elementləri LINQ istifadə edərək toplayıb cəmini qaytarır.
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(n)
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(1)
    /// </summary>
    public long AVeryBigSumLinq(long[] ar)
    {
        // LINQ-in Sum metodu ilə bütün elementləri toplayırıq
        return ar.Sum();
    }
}
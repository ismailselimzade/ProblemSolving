/*
===========================================================================
PROBLEM DESCRIPTION / PROBLEMİN TƏSVİRİ:
---------------------------------------------------------------------------
Platform: HackerRank
Problem: Simple Array Sum
Difficulty / Çətinlik: Easy / Asan
Link: https://www.hackerrank.com/challenges/simple-array-sum/problem

Given an array of integers, find the sum of its elements.
- Tam ədədlərdən ibarət massiv verilir, elementlərin cəmini tapın.

Examples / Nümunələr:
ar = [1, 2, 3] -> Return 6.
- Nəticə 6 qaytarır[cite: 4].
 
Constraints / Məhdudiyyətlər:
0 < n, ar[i] <= 1000[cite: 4]
- n və massiv elementləri 1 ilə 1000 arasındadır.
===========================================================================
*/
public partial class Solution
{
    /// <summary>
    /// Calculates the sum of array elements / Massiv elementlərinin cəmini hesablayır
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(n)
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(1)
    /// </summary>
    public int SimpleArraySum(List<int> ar)
    {
        int total = 0; // umumi cem

        // her elementi bir bir umumi cem-e elave edirem
        foreach (int num in ar)
            total += num;
        
        return total;
    }
}
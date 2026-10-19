/*
===========================================================================
PROBLEM DESCRIPTION / PROBLEMİN TƏSVİRİ:
---------------------------------------------------------------------------
# Arrays

Platform: HackerRank
Problem: Arrays - DS
Difficulty / Çətinlik: Easy
Link: https://www.hackerrank.com/challenges/arrays-ds/problem

An array is a data structure that stores elements of the same type in a contiguous block of memory.
    - Massiv, yaddaşın bitişik blokunda eyni tipli elementləri saxlayan məlumat strukturudur.
In an array, A, of size N, each memory location has some unique index, i (where 0 ≤ i < N),
that can be referenced as A[i] or Ai.
    - Hər yaddaş yerinin unikal indeksi i var (0 ≤ i < N), A[i] kimi istinad edilə bilər.

Your task is to reverse an array of integers.
    - Tam ədədlərdən ibarət massivi tərsinə çevir.

Function Description / Funksiya təsviri:
Complete the function reverseArray with the following parameters:
    - int A[n]: the array to reverse / tərsinə çeviriləcək massiv

Returns / Qaytarır:
    - int[n]: the reversed array / tərsinə çevrilmiş massiv

Input Format / Giriş formatı:
The first line contains an integer, N, the number of integers in A.
    - Birinci sətir N tam ədədini ehtiva edir.
The second line contains N space-separated integers that make up A.
    - İkinci sətir A-nı təşkil edən N space-ayrılmış tam ədədləri ehtiva edir.

Constraints / Məhdudiyyətlər:
1 ≤ N ≤ 10^3
1 ≤ A[i] ≤ 10^4, where A[i] is the i^th integer in A
    - burada A[i] A-nın i-ci tam ədədidir.

Example:
  Input:  [1, 4, 3, 2]
  Output: [2, 3, 4, 1]
===========================================================================
*/

public partial class Solution
{
    /// <summary>
    /// Reverses the list in-place using List.Reverse() and returns it.
    /// List.Reverse() istifadə edərək siyahını yerində tərsinə çevirir və qaytarır.
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(n)
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(1)
    /// </summary>
    public List<int> ReverseArrayInPlace(List<int> a)
    {
        // List.Reverse() ilə massivi yerində tərsinə çevir
        a.Reverse();
        return a;
    }

    /// <summary>
    /// Reverses the list in-place using two-pointer swap and returns it.
    /// İki göstərici ilə massivi yerində tərsinə çevirir və qaytarır.
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(n)
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(1)
    /// </summary>
    public static List<int> ReverseArrayTwoPointer(List<int> a)
    {
        // İki göstərici: biri əvvəldən, biri sondan başlayır
        // Elementləri temp dəyişəni ilə yerləşdir
        // Orta nöqtəyə çatana qədər davam et
        for (int i = 0, j = a.Count - 1; i < j; i++, --j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
        return a;
    }
}
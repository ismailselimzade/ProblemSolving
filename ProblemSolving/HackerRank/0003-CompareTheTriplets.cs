/*
===========================================================================
PROBLEM DESCRIPTION / PROBLEMİN TƏSVİRİ:
---------------------------------------------------------------------------
Platform: HackerRank
Problem: Compare the Triplets
Difficulty / Çətinlik: Easy / Asan
Link: https://www.hackerrank.com/challenges/compare-the-triplets/problem

Alice and Bob each created one problem for HackerRank. A reviewer rates the two challenges, awarding points on a scale from 1 to 100 for three categories: problem clarity, originality, and difficulty.
- Alice və Bob HackerRank üçün hərəyə bir problem yaratdılar. Bir rəyçi hər iki problemi üç kateqoriya üzrə (məsələnin aydınlığı, orijinallıq və çətinlik) 1-dən 100-ə qədər şkala ilə qiymətləndirir.

The rating for Alice's challenge is the triplet a = (a[0], a[1], a[2]), and the rating for Bob's challenge is the triplet b = (b[0], b[1], b[2]).
- Alice-in probleminin reytinqi a = (a[0], a[1], a[2]) üçlüyüdür, Bob-un probleminin reytinqi isə b = (b[0], b[1], b[2]) üçlüyüdür.

The task is to calculate their comparison points by comparing each category:
- Tapşırıq hər kateqoriyanı müqayisə edərək onların müqayisə xallarını hesablamaqdır:

- If a[i] > b[i], then Alice is awarded 1 point.
  - Əgər a[i] > b[i] olarsa, Alice 1 xal qazanır.
- If a[i] < b[i], then Bob is awarded 1 point.
  - Əgər a[i] < b[i] olarsa, Bob 1 xal qazanır.
- If a[i] = b[i], then neither person receives a point.
  - Əgər a[i] = b[i] olarsa, heç kim xal qazanmır.

Example / Nümunə:

a = [1, 2, 3]
b = [3, 2, 1]
- For elements *0*, Bob is awarded a point because a[0] < b[0].
  - *0*-cı elementlər üçün Bob xal qazanır, çünki a[0] < b[0].
- For the equal elements a[1] and b[1], no points are earned.
  - Bərabər a[1] və b[1] elementləri üçün heç bir xal qazanılmır.
- Finally, for elements 2, a[2] > b[2] so Alice receives a point.
  - Nəhayət, 2-ci elementlər üçün a[2] > b[2] olduğuna görə Alice xal qazanır.

The return array is [1, 1] with Alice's score first and Bob's second.
- Qaytarılan massiv birinci Alice-in, ikinci isə Bob-un xalı olmaqla [1, 1] olur.

Function Description / Funksiyanın Təsviri:

Complete the function compareTriplets with the following parameter(s):
- compareTriplets funksiyasını aşağıdakı parametrlərlə tamamlayın:
- int a[3]: Alice's challenge rating
  - int a[3]: Alice-in problem reytinqi
- int b[3]: Bob's challenge rating
  - int b[3]: Bob-un problem reytinqi

Returns / Qaytarılan Dəyər:

- int[2]: the first element is Alice's score and the second is Bob's score
  - int[2]: birinci element Alice-in xalı, ikinci element isə Bob-un xalıdır.

Input Format / Daxil Olunma Formatı:

The first line contains 3 space-separated integers, a[0], a[1], and a[2], the respective values in triplet a.
- Birinci sətirdə a üçlüyünün müvafiq qiymətləri olan 3 boşluqla ayrılmış tam ədəd (a[0], a[1] və a[2]) yerləşir.
The second line contains 3 space-separated integers, b[0], b[1], and b[2], the respective values in triplet b.
- İkinci sətirdə b üçlüyünün müvafiq qiymətləri olan 3 boşluqla ayrılmış tam ədəd (b[0], b[1] və b[2]) yerləşir.

Constraints / Məhdudiyyətlər:

- 1 <= a[i] <= 100
- 1 <= b[i] <= 100

Sample Input 0 / Nümunə Daxil Olunan Məlumat 0:

5 6 7
3 6 10

Sample Output 0 / Nümunə Çıxış Məlumatı 0:

1 1

Explanation 0 / İzah 0:

In this example:
- Bu nümunədə:
a = (a[0], a[1], a[2]) = (5, 6, 7)
b = (b[0], b[1], b[2]) = (3, 6, 10)

Now, let's compare each individual score:
- İndi isə hər bir fərdi xalı müqayisə edək:
a[0] > b[0], so Alice receives 1 point.
  - a[0] > b[0], buna görə də Alice 1 xal qazanır.
a[1] = b[1], so nobody receives a point.
  - a[1] = b[1], buna görə də heç kim xal qazanmır.
a[2] < b[2], so Bob receives 1 point.
  - a[2] < b[2], buna görə də Bob 1 xal qazanır.

Alice's comparison score is 1, and Bob's comparison score is 1. Thus, we return the array [1, 1].
- Alice-in müqayisə xalı 1, Bob-un müqayisə xalı isə 1-dir. Beləliklə, [1, 1] massivini qaytarırıq.

Sample Input 1 / Nümunə Daxil Olunan Məlumat 1:

17 28 30
99 16 8

Sample Output 1 / Nümunə Çıxış Məlumatı 1:

2 1

Explanation 1 / İzah 1:

Comparing the 0th elements, 17 < 99 so Bob receives a point.
- 0-cı elementləri müqayisə etdikdə, 17 < 99 olduğundan Bob xal qazanır.
Comparing the 1st and 2nd elements, 28 > 16 and 30 > 8 so Alice receives two points.
- 1-ci və 2-ci elementləri müqayisə etdikdə, 28 > 16 və 30 > 8 olduğundan Alice iki xal qazanır.
The return array is [2, 1].
- Qaytarılan massiv [2, 1]-dir.
===========================================================================
*/
public partial class Solution
{
    /// <summary>
    /// Compares Alice's and Bob's ratings and returns their total scores / Alice və Bob-un xallarını müqayisə edərək ümumi nəticəni qaytarır
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(n)
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(1)
    /// </summary>
    public List<int> CompareTriplets(List<int> a, List<int> b)
    {
        // Alice ve Bobun qiymetleri
        List<int> AliceAndBob = new() {0,0};

        for (int i = 0; i < a.Count; i++)
        {
            int alice = a[i];
            int bob = b[i];

            if (alice > bob) 
                AliceAndBob[0]++; // alicenin qiymeti artir
            else if (bob > alice) 
                AliceAndBob[1]++; // bobun qiymeti artir
        }

        return AliceAndBob;
    }
}
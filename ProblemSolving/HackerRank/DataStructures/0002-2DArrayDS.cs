/*
===========================================================================
PROBLEM DESCRIPTION / PROBLEMİN TƏSVİRİ:
---------------------------------------------------------------------------
# Arrays

Platform: HackerRank
Problem: 2D Array - DS
Difficulty / Çətinlik: Easy
Link: https://www.hackerrank.com/challenges/2d-array/problem

Given a 6x6 2D array, arr, an hourglass is a subset of values with indices falling in the following pattern:
- 6x6 ölçülü 2D array, arr verilir. Saat şüşəsi (hourglass) aşağıdakı pattern-ə uyğun indeksləri olan dəyərlər toplusudur:

a b c
  d
e f g

There are 16 hourglasses in a 6x6 array. The hourglass sum is the sum of the values in an hourglass. Calculate the hourglass sum for every hourglass in arr, then print the maximum hourglass sum.
- arr-da 16 ədəd saat şüşəsi var. Saat şüşəsi cəmi, saatşüşəsindəki dəyərlərin cəmidir. arr-dakı hər saat şüşəsi üçün cəmi hesabla, sonra maksimum saat şüşəsi cəmini çap et.

Example / Nümunə:

arr =

-9 -9 -9  1  1  1
 0 -9  0  4  3  2
-9 -9 -9  1  2  3
 0  0  8  6  6  0
 0  0  0 -2  0  0
 0  0  1  2  4  0

The 16 hourglass sums are:
- 16 saat şüşəsinin cəmləri:

-63, -34,  -9, 12,
-10,   0,  28, 23,
-27, -11,  -2, 10,
  9,  17,  25, 18

The highest hourglass sum is 28 from the hourglass beginning at row 1, column 2:
- Ən yüksək saat şüşəsi cəmi 28-dir, 1-ci sətir, 2-ci sütundan başlayan saatşüşəsindən:

0 4 3
  1
8 6 6

Function Description / Funksiya Təsviri:

Complete the function hourglassSum with the following parameter(s):
- hourglassSum funksiyasını aşağıdakı parametrlərlə tamamlayın:

- int arr[6][6]: a 2-D array of integers
- int arr[6][6]: tam ədədlərdən ibarət 2D massiv

Returns / Qaytarır:

- int: the maximum hourglass sum
- int: maksimum saat şüşəsi cəmi

Input Format / Giriş Formatı:

Each of the 6 lines of inputs arr[i] contains 6 space-separated integers arr[i][j].
- Girişin hər 6 sətri arr[i] altı boşluqla ayrılmış tam ədəd arr[i][j] ehtiva edir.

Constraints / Məhdudiyyətlər:

-9 <= arr[i][j] <= 9
0 <= i, j <= 5

Sample Input / Nümunə Giriş:

1 1 1 0 0 0
0 1 0 0 0 0
1 1 1 0 0 0
0 0 2 4 4 0
0 0 0 2 0 0
0 0 1 2 4 0

Sample Output / Nümunə Çıxış:

19

Explanation / İzah:

arr contains the following hourglasses:
- arr aşağıdakı saat şüşələrini ehtiva edir:

1 1 1   1 1 0   1 0 0   0 0 0
  1       0       0       0
1 1 1   1 1 0   1 0 0   0 0 0

0 1 0   1 0 0   0 0 0   0 0 0
  1       1       0       0
0 0 2   0 2 4   2 4 4   4 4 0

1 1 1   1 1 0   1 0 0   0 0 0
  0       2       4       4
0 0 0   0 0 2   0 2 0   2 0 0

0 0 2   0 2 4   2 4 4   4 4 0
  0       0       2       0
0 0 1   0 1 2   1 2 4   2 4 0

The hourglass with the maximum sum (19) is:
- Maksimum cəmi (19) olan saat şüşəsi:

2 4 4
  2
1 2 4
===========================================================================
*/

public partial class Solution
{
    /// <summary>
    /// Iterate through all valid hourglass starting positions and track the maximum sum.
    /// Bütün etibarlı saatşüşəsi başlanğıc mövqelərini gəzərək maksimum cəmi izləyirik.
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(1)
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(1)
    /// </summary>
    public int hourglassSum(List<List<int>> arr)
    {
        // en boyuk toplami burda saxlayiram.
        // mumkun olan en kicik deyeri menimsediremki arr deyerlerinin hamisi bundan boyuk oldugunua gore bu deyer qalmayacaq sonda.
        int sum = int.MinValue;


        // r -> rowIndex-i temsil edir.
        // eger hazirki setirden asagida 2 setir varsa ora qeder saat susesi sxemine uygun geldiyi ucun davam edir.
        for (int r = 0; r + 2 < arr.Count; ++r)
        {
            // c -> columnIndex-i temsil edir.
            // hazirki sutundan sagda 2 setir de varsa ora qeder saat susesi sxemine uygun geldiyi ucun davam edir.
            for (int c = 0; c + 2 < arr[r].Count; c++)
            {
                // hazirki saat susesinin toplamini burda saxlayiram
                int tempSum = 0;

                // hourglass-in butun tereflerinin deyerini burdan tapiram
                /*
                        topLeft --- topCenter --- topRight
                                        |
                                    centerCenter
                                        |
                    bottomLeft --- bottomCenter --- bottomRight
                */
                int topLeft = arr[r][c];
                int topCenter = arr[r][c + 1];
                int topRight = arr[r][c + 2];
                int centerCenter = arr[r + 1][c + 1];
                int bottomLeft = arr[r + 2][c];
                int bottomCenter = arr[r + 2][c + 1];
                int bottomRight = arr[r + 2][c + 2];

                // hazirki saat susesinin deyerini tapiram.
                tempSum =
                    topLeft + topCenter + topRight
                            + centerCenter +
                    bottomLeft + bottomCenter + bottomRight;
                
                // eger hazirki toplam umumi toplamdan boyukdursa artiq umumi toplam kimi hazirki toplami esas gotururem.
                sum = tempSum > sum ? tempSum : sum;
            }
        }

        // umumi toplami qaytariram.
        return sum;
    }
}
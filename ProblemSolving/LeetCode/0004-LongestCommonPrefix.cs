/*
===========================================================================
PROBLEM DESCRIPTION / PROBLEMİN TƏSVİRİ:
---------------------------------------------------------------------------
# Array # String # Trie

Platform: LeetCode
Problem: 14. Longest Common Prefix / Ən Uzun Ortaq Prefiks
Difficulty / Çətinlik: Easy / Asan
Link: https://leetcode.com/problems/longest-common-prefix/

Write a function to find the longest common prefix string amongst an array of strings.
- Sətirlər massivi daxilində ən uzun ortaq prefiks sətrini tapan funksiya yazın.

If there is no common prefix, return an empty string "".
- Əgər ortaq prefiks yoxdursa, boş sətir "" qaytarın.

Example 1:
Input: strs = ["flower","flow","flight"]
Output: "fl"

Example 2:
Input: strs = ["dog","racecar","car"]
Output: ""
Explanation / İzah: 
There is no common prefix among the input strings.
- Daxil edilən sətirlər arasında ortaq prefiks yoxdur.

Constraints / Məhdudiyyətlər:
1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lowercase English letters if it is non-empty.
- strs[i] boş deyilsə, yalnız kiçik ingilis hərflərindən ibarətdir.
===========================================================================
*/

public partial class Solution
{
    /// <summary>
    /// Finds the longest common prefix using vertical scanning character by character / 
    /// - Simvol-simvol şaquli skan üsulu ilə ən uzun ortaq prefiksi tapır
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(N * M) - N massivdəki sətirlərin sayı, M birinci sətrin uzunluğudur
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(1) - Əlavə yaddaş tələb etməyən allocation-free həll
    /// </summary>
    public string LongestCommonPrefix_VerticalScanning(string[] strs)
    {
        // prefix indexi
        int prefixIndex = 0;

        // Birinci sözün hər bir hərfini indeks üzrə gəzirik.
        for (prefixIndex = 0; prefixIndex < strs[0].Length; ++prefixIndex)
        {
            // Digər sözlərin həmin indeksdəki simvollarını yoxlayırıq.
            for (int wordIndex = 1; wordIndex < strs.Length; ++wordIndex)
            {
                // Əgər cari sözün uzunluğu bitibsə və ya simvollar bir-birinə bərabər deyilsə,
                // deməli ortaq prefiks burada bitir, dərhal həmin hissəni kəsib qaytarırıq.
                if (prefixIndex >= strs[wordIndex].Length || strs[0][prefixIndex] != strs[wordIndex][prefixIndex])
                {
                    return strs[0].Substring(0, prefixIndex);
                }
            }
        }

        // Əgər dövr tam bitdisə, deməli birinci sözün tam özü bütün sözlərin ortaq prefiksidir.
        return strs[0];
    }


    /// <summary>
    /// Finds the longest common prefix by sorting the array and comparing only the first and last strings / 
    /// - Massivi sıralamaqla və yalnız birinci və sonuncu sətirləri müqayisə etməklə ən uzun ortaq prefiksi tapır
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(N log N * M) - N massivdəki sətirlərin sayı, M orta sətrin uzunluğudur
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(1) - Əlavə yaddaş tələb etməyən allocation-free həll
    /// </summary>
    public string LongestCommonPrefix_Sorting(string[] strs)
    {
        // massivi elifba sirasina gore siralayiram.
        strs.Sort();

        // massiv elifba sirasina gore siralandigi ucun
        // ortaq prefixi tapmaq ucun ilk indexdeki sozle son indexdeki sozu qarsilasdirmaq kifayet edir.
        string firstWord = strs[0];
        string lastWord = strs[strs.Length - 1];

        // ortaq prefixin index nomresi
        int prefixIndex = 0;

        // prefix indexi her iki sozun uzunlugundan kicik olana qeder
        while (prefixIndex < firstWord.Length && prefixIndex < lastWord.Length)
        {
            // eger her iki sozun eyni indexindeki herfler eynidirse
            if (firstWord[prefixIndex] == lastWord[prefixIndex])
                // prefix indexini artiriram.
                prefixIndex++;
            else
                // eks halda artiq dovr dayanir.
                break;
        }

        // prefix indexine qederki hisseni ilk sozden kesib qaytariram.
        return firstWord.Substring(0, prefixIndex);
    }
}
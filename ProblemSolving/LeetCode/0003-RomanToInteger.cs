/*
===========================================================================
PROBLEM DESCRIPTION / PROBLEMİN TƏSVİRİ:
---------------------------------------------------------------------------
# Hash Table # Math # String

Platform: LeetCode
Problem: 13. Roman to Integer / Roma Rəqəmlərindən Tam Ədədə
Difficulty / Çətinlik: Easy / Asan
Link: https://leetcode.com/problems/roman-to-integer/

Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
- Roma rəqəmləri yeddi fərqli simvolla təmsil olunur: I, V, X, L, C, D və M.

Symbol       Value
I            1
V            5
X            10
L            50
C            100
D            500
M            1000

For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.
- Məsələn, 2 Roma rəqəmi ilə II kimi yazılır, sadəcə iki ədəd birin cəmidir. 12 XII kimi yazılır, bu da sadəcə X + II deməkdir. 27 ədədi XXVII kimi yazılır, bu da XX + V + II deməkdir.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:
- Roma rəqəmləri adətən soldan sağa böyükdən kiçiyə doğru yazılır. Lakin dörd rəqəmi IIII kimi yazılmır. Əvəzində dörd rəqəmi IV kimi yazılır. Çünki bir beşdən əvvəl gəlir və biz onu çıxaraq dörd alırıq. Eyni prinsip IX kimi yazılan doqquz rəqəminə də tətbiq edilir. Çıxmanın istifadə olunduğu altı hal var:

I can be placed before V (5) and X (10) to make 4 and 9.
- I simvolu V (5) və X (10)-dan əvvəl qoyularaq 4 və 9 düzəldilə bilər.

X can be placed before L (50) and C (100) to make 40 and 90.
- X simvolu L (50) və C (100)-dən əvvəl qoyularaq 40 və 90 düzəldilə bilər.

C can be placed before D (500) and M (1000) to make 400 and 900.
- C simvolu D (500) və M (1000)-dən əvvəl qoyularaq 400 və 900 düzəldilə bilər.

Given a roman numeral, convert it to an integer.
- Verilmiş Roma rəqəmini tam ədədə (integer) çevirin.

Example 1:
Input: s = "III"
Output: 3
Explanation: III = 3.

Example 2:
Input: s = "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.

Example 3:
Input: s = "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.

Constraints / Məhdudiyyətlər:
1 <= s.length <= 15
s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
- s tərkibində yalnız ('I', 'V', 'X', 'L', 'C', 'D', 'M') simvolları var.
It is guaranteed that s is a valid roman numeral in the range [1, 3999].
- s-in [1, 3999] aralığında keçərli bir Roma rəqəmi olduğuna zəmanət verilir.
===========================================================================
*/

public partial class Solution
{
    /// <summary>
    /// Converts a Roman numeral string to an integer by using a lookup dictionary for adjacent symbol pairs / Qonşu simvol cütlükləri üçün axtarış lüğətindən (Dictionary) istifadə edərək Roma rəqəmləri sətrini tam ədədə çevirir
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(N) - N sətrin uzunluğudur
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(1) - Sabit ölçülü Dictionary və kiçik sətr obyektləri istifadə olunur
    /// </summary>
    public int RomanToInt_WithDictionary(string roman)
    {
        // roma reqemlerini deyerleri ile birlikte saxlayiram.
        Dictionary<string, int> romansNumbers = new()
        {
            {"I", 1 }, {"V", 5}, {"X", 10}, {"L", 50}, {"C", 100}, {"D", 500}, {"M", 1000},
            {"IV", 4}, {"IX", 9}, {"XL", 40}, {"XC", 90}, {"CD", 400}, {"CM", 900}
        };
           
        // bu reqemin tam eded qarsiliqi burda toplayib saxlayacam.
        int integer = 0;

        // verileni soldan saga oxuyuram.
        for (int i = 0; i < roman.Length; i++)
        {
            // hazirki secilen roman reqemi - meselen M[C]MXCIV
            string romanNum = roman[i].ToString();

            // eger verilenin sonuna hele 1 roma reqemi de varsa
            if (i + 1 < roman.Length)
            {
                // novbeti roma reqemi - meselen MC[M]XCIV
                string nextRomanNum = roman[i + 1].ToString();
                // hazirki roma reqemi ile novbeti roma reqemini cutleyirem. meselen [CM]
                string romanNums = "" + romanNum + nextRomanNum;

                // eger dictionary-de varsa
                if (romansNumbers.TryGetValue(romanNums, out int num))
                {
                    // bu cutluye qarsiliq gelen deyeri tam edede elave edirem. 0 + 50 [CM]
                    integer += num;
                    // novbeti roma reqemini yoxladigim ucun iterasiyani onun uzerinden kecirirem. -> meselen MCM[X]CIV
                    i++;
                    // novbeti iterasiyaya kecmek lazimdirki asagidaki kodlari icra etmesin.
                    continue;
                }
            }

            // eger verilenin sonuncu roma reqemidirse MCMXCI[V]
            // ve ya
            // eger novbeti reqemle cutluk tapilmadisa -> meselen [MC]MXCIV ->
            // hazirki roma reqeminin deyer qarsiligini tam eded elave edirem.
            integer += romansNumbers[romanNum];
        }

        // tam ededi qaytariram.
        return integer;
    }

    /// <summary>
    /// Converts a Roman numeral string to an integer by iterating from right to left and subtracting smaller prefix values 
    /// Sağdan sola doğru iterasiya edərək və kiçik prefiks dəyərləri çıxaraq Roma rəqəmləri sətrini tam ədədə çevirir
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(N) - N sətrin uzunluğudur
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(1) - Əlavə obyekt yaradılmır (Allocation-Free)
    /// </summary>
    public int RomanToInt_Optimal(string roman)
    {
        // tam ededi burda saxlayiram
        int integer = 0;

        // roma reqemini tam edede cevirmek ucun metod
        int GetValue(char romanNum) => romanNum switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 0
        };

        // verileni sagdan sola oxuyuram
        for (int i = roman.Length - 1; i >= 0; --i)
        {
            // hazirki roma reqeminin deyeri.
            int romanNumValue = GetValue(roman[i]);

            // eger verilenin evveline tam catmamisamsa
            if (i - 1 >= 0)
            {
                // evvelki roma reqeminin deyeri
                int beforeRomanNumVAlue = GetValue(roman[i - 1]);

                // eger evvelki indikinden kicikdirse 
                if (romanNumValue > beforeRomanNumVAlue)
                {
                    // indikinden evvelkini cixiram.
                    integer += romanNumValue - beforeRomanNumVAlue;
                    // evvelkinin uzerinden otmek ucun indexin deyerini azaldiram
                    --i;
                    // novbeti dovre kecirem
                    continue;
                }   
            }

            // verilenin ilk reqemindeyemse ve ya hazirki evvelkinden boyuk deyilse
            // toplama hazirki roma reqeminin deyerini elave edirem.
            integer += romanNumValue;
        }

        // tam ededi qaytariram.
        return integer;
    }
}
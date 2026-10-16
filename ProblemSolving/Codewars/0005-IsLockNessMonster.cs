/*
===========================================================================
PROBLEM DESCRIPTION / PROBLEMİN TƏSVİRİ:
---------------------------------------------------------------------------
Platform: Codewars
Problem: A Strange Trip to the Market
Difficulty / Çətinlik: 8 kyu
Link: https://www.codewars.com/kata/a-strange-trip-to-the-market

You're on your way to the market when you hear beautiful music coming from a nearby street performer.
- Bazara gedərkən yaxınlıqdakı küçə ifaçısından gözəl musiqi eşidirsən.
The notes come together like you wouldn't believe as the musician puts together patterns of tunes.
- Notallar inanılmaz dərəcədə bir-birinə qoşulur, musiqiçi müxtəlif melodiyalar yaradır.
As you wonder what kind of algorithm you could use to shift octaves by 8 pitches or something silly like that, 
it dawns on you that you have been watching the musician for some 10 odd minutes.
- Oktavları 8 pərdə dəyişdirmək üçün hansı alqoritmdən istifadə edə biləcəyini düşünərkən başa düşürsən ki, 
  musiqiçini artıq 10 dəqiqədir izləyirsən.
You ask, "how much do people normally tip for something like this?"
- Soruşursan: "Bu cür şeylər üçün adətən nə qədər bəxşiş verirlər?"
The artist looks up. "It's always gonna be about tree fiddy."
- Sənətkar başını qaldırır. "Bu həmişə tree fiddy-yə bərabər olacaq."

It was then that you realize the musician was a 400 foot tall beast from the paleolithic era!
- Məhz o anda başa düşürsən ki, musiqiçi paleolitik dövrdən gəlmiş 400 fut hündürlüyündə bir varlıqdır!
The Loch Ness Monster almost tricked you!
- Loch Ness Canavarı seni az qala aldatdı!

There are only 2 guaranteed ways to tell if you are speaking to The Loch Ness Monster:
- Loch Ness Canavarı ilə danışdığını anlamağın yalnız 2 etibarlı yolu var:
A) it is a 400 foot tall beast from the paleolithic era;
- A) paleolitik dövrdən gəlmiş 400 fut hündür bir heyvandır;
B) it will ask you for tree fiddy.
- B) səndən tree fiddy istəyəcək.

Since Nessie is a master of disguise, the only way accurately tell is to look for the phrase "tree fiddy".
- Nessie gizlənmə ustası olduğundan, onu dəqiq tanımağın yeganə yolu "tree fiddy" ifadəsini axtarmaqdır.
Since you are tired of being grifted by this monster, the time has come to code a solution for finding The Loch Ness Monster.
- Bu canavarın fırıldaqlarından bezdiyin üçün Loch Ness Canavarını tapmaq üçün kod yazmağın vaxtı gəldi.
Note that the phrase can also be written as "3.50" or "three fifty".
- Qeyd: ifadə "3.50" və ya "three fifty" kimi də yazıla bilər.
Your function should return true if you're talking with The Loch Ness Monster, false otherwise.
- Əgər Loch Ness Canavarı ilə danışırsansa `true`, əks halda `false` qaytar.
===========================================================================
*/

public partial class Solution
{
    /// <summary>
    /// Iterates through an array of key phrases and checks if the sentence contains any of them (case-insensitive).
    /// Açar sözlər massivi üzərində dövr edərək cümlənin onlardan birini ehtiva edib etmədiyini yoxlayır (böyük/kiçik hərf fərqi olmadan).
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(n)
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(1)
    /// </summary>
    public bool IsLockNessMonsterLoop(string sentence)
    {
        // butun acar sozler
        string[] prhases = {"3.50", "three fifty", "tree fiddy"};

        // bu acar sozleri bir bir yoxlayiram
        for (int i = 0; i < prhases.Length; ++i)
        {
            // eger hansisa biri cumlenin icerisinde varsa demeli bu LockNessMonster-dir.
            if (sentence.Contains(prhases[i], StringComparison.CurrentCultureIgnoreCase))
                return true;
        }

        return false;
    }

    /// <summary>
    /// Creates an inline array of key phrases and checks if the sentence contains any of them using LINQ Any() (case-insensitive).
    /// Açar sözlər massivi yaradaraq LINQ Any() ilə cümlənin onlardan birini ehtiva edib etmədiyini yoxlayır (böyük/kiçik hərf fərqi olmadan).
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(n)
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(1)
    /// </summary>
    public bool IsLockNessMonsterLinq(string sentence)
    {
        return 
        new string[]{"3.50", "three fifty", "tree fiddy"}
            .Any(phrase => sentence.Contains(phrase, StringComparison.CurrentCultureIgnoreCase));
    }
}
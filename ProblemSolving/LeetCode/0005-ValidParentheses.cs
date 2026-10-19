/*
===========================================================================
PROBLEM DESCRIPTION / PROBLEMİN TƏSVİRİ:
---------------------------------------------------------------------------
# String # Stack # Bracket Sequences

Platform: LeetCode
Problem: 20. Valid Parentheses
Difficulty / Çətinlik: Easy
Link: https://leetcode.com/problems/valid-parentheses/

Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
- Yalnız '(', ')', '{', '}', '[' və ']' simvollarından ibarət s stringi verilib, stringin etibarlı olub olmadığını müəyyən et.

An input string is valid if:
- Giriş stringi aşağıdakı hallarda etibarlıdır:

1. Open brackets must be closed by the same type of brackets.
- 1. Açıq mötərizələr eyni növ mötərizə ilə bağlanmalıdır.

2. Open brackets must be closed in the correct order.
- 2. Açıq mötərizələr düzgün sırada bağlanmalıdır.

3. Every close bracket has a corresponding open bracket of the same type.
- 3. Hər bağlayıcı mötərizənin eyni növdən müvafiq açıq mötərizəsi olmalıdır.

Example 1: Input: s = "()" → Output: true

Example 2: Input: s = "()[]{}" → Output: true

Example 3: Input: s = "(]" → Output: false

Example 4: Input: s = "([])" → Output: true

Example 5: Input: s = "([)]" → Output: false

Constraints / Məhdudiyyətlər:
- 1 <= s.length <= 10^4
- s consists of parentheses only '()[]{}'.
- s yalnız '()[]{}" mötərizə simvollarından ibarətdir.
===========================================================================
*/

using System.Text;

public partial class Solution
{
    /// <summary>
    /// Validates bracket pairing using a StringBuilder as a stack
    /// Mötərizə cütlüyünü StringBuilder stack ilə yoxlayır
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(n)
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(n)
    /// </summary>
    public bool IsValidStringBuilder(string s)
    {
        // moterizeleri bura yigiram
        StringBuilder stack = new();

        // verileni bir bir yoxluyub uygun emeliyyatlari yerine yetirirem
        for (int i = 0; i < s.Length; ++i)
        {
            // hazirki yoxladigim moterize
            char paranthes = s[i];

            // eger aciq moterizedirse elave edirem.
            // eger qapali moterizedirse 3 hala baxiram.
            // 1. stack bosdursa demeli duzgun deyil
            // 2. eger stackin sonuncu moterizesi eyni tipli moterizenin aciq versiyasidirsa demeli
            //    moterize duzgun baglanir ve hemin moterizeni stack-dan silirem.
            // 3. eks halda yene duzgun baglanmayan moterize oldugu ucun demeli yanlisdir.
            switch(paranthes)
            {
                case '(': stack.Append('('); break;
                case ')': 
                    if (stack.Length == 0)
                        return false;
                    else if (stack[^1] == '(')
                        stack.Length--;
                    else
                        return false;
                    break;
                case '{': stack.Append('{'); break;
                case '}': 
                    if (stack.Length == 0)
                        return false;
                    else if (stack[^1] == '{')
                        stack.Length--;
                    else
                        return false;
                    break;
                case '[': stack.Append('['); break;
                case ']': 
                    if (stack.Length == 0)
                        return false;
                    else if (stack[^1] == '[')
                        stack.Length--;
                    else
                        return false;
                    break;
            }
        }

        // eger sonda stack bosdursa demeli butun moterizeler duzgun siralama ile acilib ve baglanib.
        // eks halda yanlisdir.
        return stack.Length == 0;
    }

    /// <summary>
    /// Validates bracket pairing using a Stack and a Dictionary that maps each closing bracket to its opening counterpart.
    /// Hər bağlayıcı mötərizəni açıq qarşılığına map edən Dictionary və Stack istifadə edərək mötərizə cütlüyünü yoxlayır.
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(n)
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(n)
    /// </summary>
    public bool IsValidDictionaryStack(string s)
    {
        // moterizeler cutlukleri
        Dictionary<char, char> parantheses = new()
        {
            { ')', '('},
            { '}', '{'},
            { ']', '[' }
        };

        // moterizeleri yigacagim yer.
        Stack<char> stack = new();

        // verileni bir bir yoxluyuram.
        for (int i = 0; i < s.Length; i++)
        {
            // hazirki yoxlanilan moterize
            char paranthes = s[i];
            
            // eger hazirki moterize qapalidirsa onun dictionary-deki aciq qarsiliqini alib stack icerisinde yoxlayiram.
            if (parantheses.TryGetValue(paranthes, out char value))
            {
                // eger stack bosdursa yanlisdir.
                if (stack.Count == 0) return false;
                // eger sonuncu elementi aciq versiyasidirsa sonuncu elementi stack-den silirem.
                else if (stack.Peek() == value) stack.Pop();
                // eks halda yanlisdir.
                else return false;
            }
            else
                // eger qapali moterize deyilse hazirki demeli aciqdir. elave edirem stack-a
                stack.Push(paranthes);
        }

        // sonda stack bosdursa dogrudur. demeli butun moterizeler baglanib duzgun sekilde.
        return stack.Count == 0;
    }
}
/*
===========================================================================
PROBLEM DESCRIPTION / PROBLEMİN TƏSVİRİ:
---------------------------------------------------------------------------
# Junior # Array # Hash Table

Platform: LeetCode
Problem: 1. Two Sum
Difficulty / Çətinlik: Easy / Asan
Link: https://leetcode.com/problems/two-sum/

You are given an array of integers nums and an integer target, 
 - Sizə tam ədədlərdən ibarət nums massivi və bir target (hədəf) ədədi verilir,
return indices of the two numbers such that they add up to target.
 - cəmi target-ə bərabər olan iki ədədin indekslərini qaytarın.
You may assume that each input would have exactly one solution, 
 - Hər daxil edilən məlumat üçün dəqiq bir həllin olduğunu fərz edə bilərsiniz,
and you may not use the same element twice.
 - və eyni elementi iki dəfə istifadə edə bilməzsiniz.
You can return the answer in any order.
 - Nəticəni istənilən ardıcıllıqla qaytara bilərsiniz.

Examples / Nümunələr:

Example 1:
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
 - İzah: Çünki nums[0] + nums[1] == 9 dır, buna görə [0, 1] qaytarırıq.

Example 2:
Input: nums = [3,2,4], target = 6
Output: [1,2]

Example 3:
Input: nums = [3,3], target = 6
Output: [0,1]
 
Constraints / Məhdudiyyətlər:
2 <= nums.length <= 10^4
 - nums massivinin uzunluğu 2 ilə 10^4 arasındadır.
10^9 <= nums[i] <= 10^9
 - Massivin hər bir elementi -10^9 ilə 10^9 arasındadır.
10^9 <= target <= 10^9
 - Target ədədi -10^9 ilə 10^9 arasındadır.
Only one valid answer exists.
 - Yalnız bir düzgün cavab mövcuddur.
 
Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
 - Əlavə sual: O(n^2) vaxt mürəkkəbliyindən daha sürətli çalışan bir alqoritm təklif edə bilərsinizmi?
===========================================================================
*/

public partial class Solution
{
    /// <summary>
    /// Brute Force Solution / Bütün ehtimalları yoxlama həlli
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(n^2)
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(1)
    /// </summary>
    public int[] TwoSumBruteForce(int[] nums, int target)
    {
        // reqemlerin bir-bir sira ile yoxlayiram
        for (int i = 0; i < nums.Length - 1; ++i)
        {
            int num1 = nums[i]; // ilk eded
            for (int j = i + 1; j < nums.Length; ++j)
            {
                int num2 = nums[j]; // ikinci eded
                if (num1 + num2 == target) // eger toplamlari target-e beraberdirse indexlerini qaytariram
                    return new[] { i, j };
            }
        }

        return [];
    }

    /// <summary>
    /// Optimal Solution using Hash Map (Dictionary) / Hash Map ilə Optimal Həll
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(n)
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(n)
    /// </summary>
    public int[] TwoSumHashMap(int[] nums, int target)
    {
        // (reqem-index) 
        Dictionary<int, int> diffAndIndex = new();

        // numsu sira ile gezirem
        for (int i = 0; i < nums.Length; ++i)
        {
            int num = nums[i]; // hazirki eded
            int diff = target - num; // terget-den hazirki ededi cixib ferqi saxlayiram

            // eger bu ferqe beraber eded var idise evvel yoxladiqim ededler icerisinde
            // onu dictionary-den tapiram  
            if (diffAndIndex.TryGetValue(diff, out int value)) 
            {
                return [value, i]; // ve indexini hazirki reqemin indexi ile birlikte qaytariram
            }

            // eger ferqe uygun eded tapilmadisa hazirki ededi ve indexini dictionary-e elave edirem
            diffAndIndex[num] = i; 
        }

        return [];
    }
}
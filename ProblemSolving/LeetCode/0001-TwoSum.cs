/*
===========================================================================
PROBLEM DESCRIPTION / PROBLEMİN TƏSVİRİ:
---------------------------------------------------------------------------
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
İzah: Çünki nums[0] + nums[1] == 9 dır, buna görə [0, 1] qaytarırıq.

Example 2:
Input: nums = [3,2,4], target = 6
Output: [1,2]

Example 3:
Input: nums = [3,3], target = 6
Output: [0,1]
 
Constraints / Məhdudiyyətlər:
2 <= nums.length <= 10^4
-10^9 <= nums[i] <= 10^9
-10^9 <= target <= 10^9
Only one valid answer exists. / Yalnız bir düzgün cavab mövcuddur.
 
Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
Əlavə sual: O(n^2) vaxt mürəkkəbliyindən daha sürətli çalışan bir alqoritm təklif edə bilərsinizmi?
===========================================================================
*/

public partial class Solution
{
    /// <summary>
    /// [1. Two Sum] - Brute Force Solution / Bütün ehtimalları yoxlama həlli
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(n^2)
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(1)
    /// </summary>
    public int[] TwoSumBruteForce(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length - 1; ++i)
        {
            int num1 = nums[i];
            for (int j = i + 1; j < nums.Length; ++j)
            {
                int num2 = nums[j];
                if (num1 + num2 == target)
                    return new[] { i, j };
            }
        }

        return [];
    }

    /// <summary>
    /// [1. Two Sum] - Optimal Solution using Hash Map (Dictionary) / Hash Map ilə Optimal Həll
    /// Time Complexity / Vaxt Mürəkkəbliyi: O(n)
    /// Space Complexity / Yaddaş Mürəkkəbliyi: O(n)
    /// </summary>
    public int[] TwoSumHashMap(int[] nums, int target)
    {
        Dictionary<int, int> diffAndIndex = new();

        for (int i = 0; i < nums.Length; ++i)
        {
            int num = nums[i];
            int diff = target - num;

            if (diffAndIndex.TryGetValue(diff, out int value))
            {
                return [value, i];
            }

            diffAndIndex[num] = i;
        }

        return [];
    }
}
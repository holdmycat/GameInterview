using System.Collections.Generic;
using UnityEngine;

public class SlidingWindow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    //1. 给定一个整数数组 nums 和一个整数 k，返回 nums 中和为 k 的连续子数组的个数。
    int countSubarraysWithSum(int[] nums, int k) {
        int count = 0;
        int currentSum = 0;
        Dictionary<int, int> sumFrequency = new Dictionary<int, int>();
        sumFrequency[0] = 1;  // 前缀和为 0 的个数初始为 1

        foreach (var num in nums)
        {
            currentSum += num;

            if (sumFrequency.ContainsKey(currentSum - k)) {
                count += sumFrequency[currentSum - k];
            }

            if (!sumFrequency.ContainsKey(currentSum)) {
                sumFrequency[currentSum] = 0;
            }
            sumFrequency[currentSum]++;
        }
        return count;
    }
}

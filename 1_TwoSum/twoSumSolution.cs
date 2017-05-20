public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        //  O(n^2)
        
        if (nums.Length < 2)
                return new int[2];

        int add = nums[0] + nums[1]; 
        
        if (nums.Length < 3 && add == target)
            return new int[] {0,1};
            

        for (int i = 0; i < nums.Length - 1; i++)
        {
            for(int j = i + 1; j < nums.Length; j++)
            {
                add = nums[i] + nums[j];
                if (add == target)
                    return new int[] {i,j};
            }                
        }

        return new int[2];
        
    }
}
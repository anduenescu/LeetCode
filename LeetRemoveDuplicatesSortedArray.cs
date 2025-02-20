//https://leetcode.com/problems/remove-duplicates-from-sorted-array/?envType=problem-list-v2&envId=array

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int length = 0;
        for(int i=0; i<nums.Length; i++)
        
            for(int j=i+1; j<nums.Length; j++){{
                if(nums[j] > nums[i]){
                    nums[i+1] = nums[j];
                    //Console.WriteLine("j.index = "+ nums[j]);
                    //Console.WriteLine("i.index = "+ nums[i]);
                    //Console.WriteLine("j = " + j); 
                    //Console.WriteLine("i = " + i); 
                    break;
                }
               
            }
            
        }
        int maxValue = nums[0];

        for(int i = 0; i<nums.Length; i++){
           if(nums[i] > maxValue){
            maxValue = nums[i];
            length = i + 1;
           }
        }
        Console.WriteLine(length);
        return length;
        
    }
}
//nums = [0,0,1,1,1,2,2,3,3,4]
//nums = [0,1,1,1,1,2,2,3,3,4]
          //i   j

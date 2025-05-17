public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> result=new List<IList<int>>();
        Helper(nums,0,new List<int>(),result);
        return result;
    }
    void Helper(int[] nums,int start,List<int> path,IList<IList<int>> result){
        result.Add(new List<int>(path));
        for(int i=start;i<nums.Length;i++){
            path.Add(nums[i]);
            Helper(nums,i+1,path,result);
            path.RemoveAt(path.Count - 1);
        }
    }
}
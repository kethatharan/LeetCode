public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        IList<IList<int>> result=new List<IList<int>>();
        Helper(nums,new List<int>(),result);
        return result;
    }
    void Helper(int[] nums,List<int> path,IList<IList<int>> result){
        if(path.Count()==nums.Length){
        result.Add(new List<int>(path));
        }
        for(int i=0;i<nums.Length;i++){
            if(path.Contains(nums[i])){
                continue;
            }
            path.Add(nums[i]);
            Helper(nums,path,result);
            path.RemoveAt(path.Count-1);
        }
    }
}
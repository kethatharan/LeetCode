class Solution {
    public boolean isRectangleOverlap(int[] input1, int[] input2) {
        return input1[0]<input2[2] && input1[1]<input2[3] && input1[2]>input2[0] && input1[3]> input2[1];
    }
}
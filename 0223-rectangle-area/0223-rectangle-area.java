class Solution {
    public int computeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2) {
        int area1=(ay2-ay1)*(ax2-ax1);
        int area2=(by2-by1)*(bx2-bx1);
        int heightover=Math.max(0,Math.min(ay2,by2)-Math.max(ay1,by1));
        int width=Math.max(0,Math.min(ax2,bx2)-Math.max(ax1,bx1));
        return (area1+area2)-(heightover*width);
    }
}
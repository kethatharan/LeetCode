public class MyQueue {
    private Queue<int> q;
    public MyQueue() {
        q=new Queue<int>();
    }
    
    public void Push(int x) {
        q.Enqueue(x);
    }
    
    public int Pop() {
        return q.Dequeue();
    }
    
    public int Peek() {
        return q.Peek();
    }
    
    public bool Empty() {
        return q.Count()==0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
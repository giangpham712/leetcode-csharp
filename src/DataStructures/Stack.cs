namespace DataStructures;

/// <summary>
/// Last in First out (LIFO)
/// </summary>
public class Stack
{
    private int[] _ele;
    private int _top;
    private int _max;
    public Stack(int size)
    {
        _ele = new int[size]; // Maximum size of Stack
        _top = -1;
        _max = size;
    }
  
    public void Push(int item)
    {
        if (_top == _max - 1) {
            Console.WriteLine("Stack Overflow");
            return;
        }
        else {
            _ele[++_top] = item;
        }
    }
  
    public int Pop()
    {
        if (_top == -1) {
            Console.WriteLine("Stack is Empty");
            return -1;
        }
        else {
            Console.WriteLine("{0} popped from stack ", _ele[_top]);
            return _ele[_top--];
        }
    }
  
    public int Peek()
    {
        if (_top == -1) {
            Console.WriteLine("Stack is Empty");
            return -1;
        }
        else {
            Console.WriteLine("{0} popped from stack ", _ele[_top]);
            return _ele[_top];
        }
    }
  
    public void PrintStack()
    {
        if (_top == -1) {
            Console.WriteLine("Stack is Empty");
            return;
        }
        else {
            for (int i = 0; i <= _top; i++) {
                Console.WriteLine("{0} pushed into stack", _ele[i]);
            }
        }
    }
}
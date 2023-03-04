namespace DataStructures;

public class MinHeap
{
    private int _capacity = 10;
    private int _size = 0;

    private int[] _items;

    public MinHeap()
    {
        _items = new int[_capacity];
    }

    private int GetLeftChildIndex(int parentIndex) => 2 * parentIndex + 1;
    private int GetRightChildIndex(int parentIndex) => 2 * parentIndex + 2;
    private int GetParentIndex(int childIndex) => (childIndex - 1) / 2;

    private bool HasLeftChild(int index) => GetLeftChildIndex(index) < _size;
    private bool HasRightChild(int index) => GetRightChildIndex(index) < _size;
    private bool HasParent(int index) => GetParentIndex(index) >= 0;

    private int LeftChild(int index) => _items[GetLeftChildIndex(index)];
    private int RightChild(int index) => _items[GetRightChildIndex(index)];
    private int Parent(int index) => _items[GetParentIndex(index)];

    private void Swap(int indexOne, int indexTwo)
    {
        (_items[indexOne], _items[indexTwo]) = (_items[indexTwo], _items[indexOne]);
    }

    private void EnsureExtraCapacity()
    {
        if (_size == _capacity)
        {
            var newItems = new int[_capacity * 2];
            Array.Copy(_items, newItems, _capacity);
            _capacity *= 2;
        }
    }

    public int Peek()
    {
        if (_size == 0) throw new InvalidOperationException();
        return _items[0];
    }

    public int Poll()
    {
        if (_size == 0) throw new InvalidOperationException();
        var item = _items[0];
        _items[0] = _items[_size - 1];
        _size--;
        HeapifyDown();
        return item;
    }

    public void Add(int item)
    {
        EnsureExtraCapacity();
        _items[_size] = item;
        _size++;
        HeapifyUp();
    }

    private void HeapifyDown()
    {
        var index = 0;
        while (HasLeftChild(index))
        {
            var smallerChildIndex = GetLeftChildIndex(index);
            if (HasRightChild(index) && RightChild(index) < LeftChild(index))
            {
                smallerChildIndex = GetLeftChildIndex(index);
            }

            if (_items[index] < _items[smallerChildIndex])
            {
                break;
            }
            else
            {
                Swap(index, smallerChildIndex);
            }

            index = smallerChildIndex;
        }
    }

    private void HeapifyUp()
    {
        var index = _size - 1;
        while (HasParent(index) && Parent(index) > _items[index])
        {
            Swap(GetParentIndex(index), index);
            index = GetParentIndex(index);
        }
    }
}

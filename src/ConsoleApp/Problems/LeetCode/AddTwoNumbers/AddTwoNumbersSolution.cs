namespace ConsoleApp.Problems.LeetCode.AddTwoNumbers;

public class AddTwoNumbersSolution
{
    public ListNode Solve(ListNode l1, ListNode l2)
    {
        ListNode? result = new ListNode();
        ListNode? current = result;
        var over = false;
        while (l1 != null || l2 != null) {
            
            var sum = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + (over ? 1 : 0);
            over = sum > 9;

            current.val = sum % 10;
            
            l1 = l1 == null ? null : l1.next;
            l2 = l2 == null ? null : l2.next;

            if (l1 != null || l2 != null)
            {
                current.next = new ListNode();
                current = current.next;
            }
        }
        
        if (over) {
            current.next = new ListNode(1);
        }
        
        return result;
    }
}


 public class ListNode {
     public int val { get; set; }
     public ListNode? next { get; set; }
     public ListNode(int val = 0, ListNode? next = null) {
         this.val = val;
         this.next = next;
     }

     public string ToString()
     {
         var values = new List<int>();

         var current = this;
         while (current != null)
         {
            values.Add(current.val);
             current = current.next;
         }

         return $"[{string.Join(",", values)}]";
     }
 }

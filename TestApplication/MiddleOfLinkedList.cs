namespace TestApplication
{

    public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val=0, ListNode next=null) {
                this.val = val;
                this.next = next;
         }
      }
    public class MiddleOfLinkedList
    {
        
  
        public ListNode MiddleNode(ListNode head)
        {

            var firstNode = head;
            var secondNode = head;

            while (secondNode.next != null)
            {
                firstNode = firstNode.next;
                if (secondNode.next.next != null)
                {
                    secondNode = secondNode.next.next;
                } else{
                    secondNode = secondNode.next;
                }
            }

            return firstNode;
        }
    }
    
    
}
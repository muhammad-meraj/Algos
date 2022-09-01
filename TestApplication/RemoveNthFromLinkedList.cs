namespace TestApplication
{
    public class RemoveNthFromLinkedList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if(head.next == null) return null;
            var length = FindLength(head);
            if(length == n) return head.next;
            
            if (length == 2){
                if(n == 1){
                    head.next = null;
                    return head;
                }
            }
            var requiredNode = length - n;
            var nthNode = head;

            for (var i = 1; i < requiredNode; i++)
            {
                nthNode = nthNode.next;
            }

            nthNode.next = nthNode.next.next;
            return head;  
        }

        public int FindLength(ListNode head)
        {
            var count = 0;
            var length = 0;
            var first = head;
            var second = head;

            while (second.next != null)
            {
                if (second.next.next != null)
                {
                    second = second.next.next;
                    first = first.next;
                }
                else
                {
                    length = count + count + 2;
                    break;
                }

                count += 1;
                length = count + count + 1;
            }

            return length;
        }
    }
}
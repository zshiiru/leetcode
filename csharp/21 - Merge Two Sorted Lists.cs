
// the first solution i came up with
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        
        ListNode nextList = new ListNode(0, null);
        ListNode headList = new ListNode(0, nextList);
        
        ListNode current1 = list1;
        ListNode current2 = list2;

        while (current1 != null || current2 != null) {
            int val1 = current1 != null ? current1.val : 101;
            int val2 = current2 != null ? current2.val : 101;

            if (val1 < val2) {
                nextList.next = current1;
                current1 = current1.next;
            } else {
                nextList.next = current2;
                current2 = current2.next;
            }   

            nextList = nextList.next;
        }

        return headList.next.next;
    }
}

//revised solution
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        
        ListNode headList = new ListNode(0, null);
        ListNode nextList = headList;
        
        while (list1 != null && list2 != null) {

            if (list1.val < list2.val) {
                nextList.next = list1;
                list1 = list1.next;
            } else {
                nextList.next = list2;
                list2 = list2.next;
            }   

            nextList = nextList.next;
        }

        nextList.next = list1 ?? list2;

        return headList.next;
    }
}

using System;
using System.Collections.Generic;

namespace Intro.Lesson10
{
    public class MergeLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2) {

            ListNode current1 = list1;
            ListNode current2 = list2;
            ListNode result;
            ListNode temp;

            if (current1 == null) {
                return current2;
            }
            else if (current2 == null) {
                return current1;
            }

            if (current1.value < current2.value) {
                result = current1;
                current1 = current1.next;
            }
            else {
                result = current2;
                current2 = current2.next;
            }

            temp = result;

            while (current1 != null && current2 != null) {
                if (current1.value < current2.value) {
                    temp.next = current1;
                    current1 = current1.next;
                }
                else {
                    temp.next = current2;
                    current2 = current2.next;
                }
                temp = temp.next;
            }

            if (current1 == null) {
                temp.next = current2;
            }
            else {
                temp.next = current1;
            }

            return result;
        }
    }

    public class ListNode
    {
        public int value;
        public ListNode next;

        public ListNode(int value = 0, ListNode next = null) {
            this.value = value;
            this.next = next;
        }
    }
}
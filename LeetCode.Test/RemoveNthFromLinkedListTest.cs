using System;
using LeetCode.DataStructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class RemoveNthFromLinkedListTest
    {
        [TestMethod]
        public void Test()
        {
            var list =
                new ListNode(1,
                new ListNode(2,
                new ListNode(3,
                new ListNode(4,
                new ListNode(5)))));

            var result = new RemoveNthFromLinkedList().Solve(list, 2);
        }
        [TestMethod]
        public void Test2()
        {
            var list =
                new ListNode(1,
                new ListNode(2));

            var result = new RemoveNthFromLinkedList().Solve(list, 1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RandomLeetCode
{
    class N_aryTreePreorderTraversal
    {
        /// <summary>
        /// N-ary Tree Preorder Traversal
        /// https://leetcode.com/explore/learn/card/n-ary-tree/130/traversal/925/
        /// </summary>
        public static IList<int> Preorder(Node root)
        {
            IList<int> myList = new List<int>();
            Stack<Node> myStack = new Stack<Node>();
            if (root == null) return myList;
            myStack.Push(root);
            while (myStack.Count != 0)
            {
                Node temp = myStack.Pop();
                myList.Add(temp.val);
                if (temp.children != null)
                {
                    for (int i = temp.children.Count - 1; i >= 0; i--)
                    {
                        myStack.Push(temp.children[i]);
                    }
                }
            }
            return myList;
        }
    }
}

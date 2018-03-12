using System;
using System.Collections.Generic;

namespace RandomLeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node();
            root.val = 1;

            Node leftOne = new Node();
            leftOne.val = 2;
            Node middleOne = new Node();
            middleOne.val = 3;
            Node rightOne = new Node();
            rightOne.val = 4;

            Node leftLeft = new Node();
            leftLeft.val = 5;
            Node LeftRight = new Node();
            LeftRight.val = 6;

            leftOne.children = new List<Node> { leftLeft, LeftRight };
            root.children = new List<Node> { leftOne, middleOne, rightOne };

            IList<int> result = N_aryTreePreorderTraversal.Preorder(root);
            foreach (int num in result) Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
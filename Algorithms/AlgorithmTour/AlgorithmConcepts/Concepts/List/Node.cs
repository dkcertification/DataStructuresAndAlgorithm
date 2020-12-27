using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmConcepts.Concepts.List
{
    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

    }

    public class NodeBuilder
    {
        public static void BuildAndPrintNodes()
        {
            Node first = new Node() { Value = 5 };
            Node second = new Node() { Value = 1 };
            first.Next = second;
            Node third = new Node() { Value = 3 };
            second.Next = third;
            PrintNodes(first);
        }

        private static void PrintNodes(Node node)
        {
            while (node != null)
            {
                Console.WriteLine($"Node Value : {node.Value}");
                node = node.Next;
            }
        }
    }
}

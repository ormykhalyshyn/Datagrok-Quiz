using System;


namespace Datagrok_Quiz
{
    public class Node
    {
        public double value;
        public Node left, right;
    }
    class BinarySum
    {
        
        public static Node newNode(double value)
        {
            Node node = new Node();
            node.value = value;
            node.left = node.right = null;
            return (node);
        }

        public static double Sum(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            return (root.value + Sum(root.left) + Sum(root.right));
        }

    }
}
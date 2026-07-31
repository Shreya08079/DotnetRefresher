using System;
using System.Collections.Generic;

namespace TreeFlattenApp
{
    class TreeNode
    {
        public string Value { get; set; }
        public List<TreeNode> Children { get; set; } = new();
    }

    static class TreeHelper
    {
        public static List<string> FlattenTree(params TreeNode[] roots)
        {
            List<string> result = new();

            int depth = 0;

            void Traverse(TreeNode node, ref int currentDepth)
            {
                result.Add(node.Value);

                Console.WriteLine($"{node.Value} : Depth {currentDepth}");

                currentDepth++;

                foreach (var child in node.Children)
                {
                    Traverse(child, ref currentDepth);
                }

                currentDepth--;
            }

            foreach (var root in roots)
            {
                depth = 0;
                Traverse(root, ref depth);
            }

            return result;
        }
    }

    class Program
    {
        static void Main()
        {
            TreeNode a = new() { Value = "A" };
            a.Children.Add(new TreeNode { Value = "A1" });
            a.Children.Add(new TreeNode { Value = "A2" });

            TreeNode b = new() { Value = "B" };
            TreeNode b1 = new() { Value = "B1" };
            b1.Children.Add(new TreeNode { Value = "B1a" });
            b1.Children.Add(new TreeNode { Value = "B1b" });
            b.Children.Add(b1);

            TreeNode c = new() { Value = "C" };

            var list = TreeHelper.FlattenTree(a, b, c);

            Console.WriteLine("\nFlattened Tree");

            foreach (var item in list)
                Console.WriteLine(item);
        }
    }
}
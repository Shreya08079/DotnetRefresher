using System;
using System.Collections.Generic;

namespace RiskCalculator
{
    class Transaction
    {
        public string Id;
        public List<Transaction> Next = new();
    }

    static class RiskEngine
    {
        public static int CalculateRiskScore(Transaction transaction)
        {
            if (transaction == null)
                return -1;

            int depth = 0;

            HashSet<string> visited = new();

            int DFS(Transaction node, ref int level)
            {
                if (node == null)
                    return 0;

                if (visited.Contains(node.Id))
                    return 0;

                if (level >= 1000)
                    return -1;

                visited.Add(node.Id);

                level++;

                int score = 1;

                foreach (var child in node.Next)
                {
                    int result = DFS(child, ref level);

                    if (result == -1)
                        return -1;

                    score += result;
                }

                level--;

                return score;
            }

            return DFS(transaction, ref depth);
        }
    }

    class Program
    {
        static void Main()
        {
            Transaction t1 = new() { Id = "TX001" };
            Transaction t2 = new() { Id = "TX002" };
            Transaction t3 = new() { Id = "TX003" };

            t1.Next.Add(t2);
            t2.Next.Add(t3);
            t3.Next.Add(t1);

            int score = RiskEngine.CalculateRiskScore(t1);

            Console.WriteLine($"Risk Score : {score}");
        }
    }
}
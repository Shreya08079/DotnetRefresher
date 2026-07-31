using System;
using System.Text;

namespace SQLQueryBuilder
{
    class QueryBuilder
    {
        private readonly StringBuilder sql = new();

        public void AddWhereClause(string clause)
        {
            if (!sql.ToString().Contains("WHERE"))
                sql.AppendLine("WHERE " + clause);
            else
                sql.AppendLine("AND " + clause);
        }

        public void AddWhereClause(params Action<QueryBuilder>[] builders)
        {
            int indent = 1;

            sql.AppendLine("AND (");

            void Execute(Action<QueryBuilder>[] actions, ref int level)
            {
                foreach (var action in actions)
                {
                    action(this);
                }
            }

            Execute(builders, ref indent);

            sql.AppendLine(")");
        }

        public override string ToString()
        {
            return sql.ToString();
        }
    }

    class Program
    {
        static void Main()
        {
            QueryBuilder builder = new();

            builder.AddWhereClause("Status='Active'");

            builder.AddWhereClause(q =>
            {
                q.AddWhereClause("Age > 18");
                q.AddWhereClause("Age < 65");
            });

            Console.WriteLine(builder);
        }
    }
}
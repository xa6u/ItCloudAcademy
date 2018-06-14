using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_14_06_18
{
    class Program
    {
        static public long Factorial(int n)
        {
            if (n == 0)
            {
                return 1;

            }
            long factorialresult = Factorial(n - 1);
            long result = n * factorialresult;
            Console.Write(n + "*");
            return result;
        }

        public class TreeNode
        {
            public TreeNode ParentNode;
            public int nodeValue;
        }

        static void Main(string[] args)
        {
            //long result = Factorial(10);
            //Console.WriteLine($"Result = {result}");
            List<TreeNode> nodeList = new List<TreeNode>();

            int[,] treeNodes = { { 5, 2 }, { 1, 6 }, { 5, 4 }, { 3, 5 }, { 5, 7 }, { 3, 1 } };

            for (int i = 0; i < treeNodes.GetLength(0); i++)
            {
                TreeNode node = nodeList.Find(x => x.nodeValue == treeNodes[i, 1]);
                if (node!= null)
                {
                    node = new TreeNode { nodeValue = treeNodes[i, 1] };
                }
                nodeList.Add(node);

                TreeNode ParentNode = nodeList.Find(x => x.nodeValue == treeNodes[i, 0]);

                if (ParentNode == null)
                {
                    ParentNode = new TreeNode { nodeValue = treeNodes[i, 0] };
                }
                node.ParentNode = ParentNode;
                nodeList.Add(ParentNode);
            }
            foreach (var node in nodeList)
            {
                TreeNode treeNode = node;
                int level = 0;
                do
                {
                    Pare
                }
            }

        }
    }
}

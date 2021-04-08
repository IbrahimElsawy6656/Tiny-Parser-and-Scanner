using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiler
{
    public class Node
    {
        public enum NodeType
        {
            Undefined,
            Box,
            Circle
        }
        
        public NodeType Type;
        public string Title;
        public string Details;
        public Node Left;
        public Node Right;
        public Node ElsePart;
        public LinkedList<Node> NextTo = new LinkedList<Node>();

        public Node()
        {
            Type = NodeType.Undefined;
            Title = " ";
            Details = " ";
            Left = null;
            Right = null;
            ElsePart = null;
        }
    }
}

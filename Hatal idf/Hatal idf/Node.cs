using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatal_idf
{
    public class Node
    {
        public Message data;
        public Node left;
        public Node right;
        public Node(Message data)
        {
            this.data = data;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatal_idf
{
    public interface ITree
    {
        void Add(Message message);
        bool Find(Message target, Node current);
         void DisplayTree();
    }
}

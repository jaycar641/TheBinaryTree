using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node<T>
    {
        T data;

        public Node<T> link;
        public Node(T data)
        {
            this.data = data;

        }

        public T Data
       {
            get
            {
                return data;
            }

             set {
                value = data;
                 }


        }



    }
}

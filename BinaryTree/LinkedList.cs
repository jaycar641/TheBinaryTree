using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class LinkedList<T>
    {
        Dictionary<string, int> Greaterdictionary = new Dictionary<string, int>();
        Dictionary<string, int> LessThandictionary = new Dictionary<string, int>();
        string root = "";
        int count = 0;

        public Node<T> start = null;
        public void Add<T>(T data)
        {

            Node<T> start = null;

            Node<T> node1 = new Node<T>(data);

            if (start == null)
            {
                start = node1;/////////////dtart becomes the initiated node
            }

            Node<T> temp = start;  //passes-- temp becomes the start that has the data

            while (temp.link != null)
            {
                temp = temp.link; /////////////////temp beomes the link that creates the new node


            }

            Sort(Convert.ToString(data), Convert.ToInt32(count));

            temp.link = node1; //makes the link the new node
            count++;
        }

        public void Sort(string key, int value) //(number,  index)
        {
            string keyhold = "";

            if (value == 0)
            {
                LessThandictionary.Add(key, value);
                root += Convert.ToString(key);

                return;
            }
            keyhold = Convert.ToString(key);


            if (int.Parse(root) >= int.Parse(keyhold)) //for loop to move it to end
            {
                LessThandictionary.Add(key, value);

            }
            else
            {

                Greaterdictionary.Add(key, value);
            }



        }

        public void Search(int search)
        {
            foreach (string key in LessThandictionary.Keys)
            {

                if (key == Convert.ToString(search))
                {

                    Console.WriteLine("Key: " + key);
                    Console.WriteLine("Value: " + LessThandictionary[key]);
                    Console.ReadLine();
                    return;
                }

                else
                {

                    foreach (string key2 in Greaterdictionary.Keys)
                    {
                        if (key2 == Convert.ToString(search))
                        {

                            Console.WriteLine("Key: " + key2);
                            Console.WriteLine("Value: " + Greaterdictionary[key2]);
                            Console.ReadLine();
                            return;
                        }

                    }

                }


            }



        }
    
        public void PrintTree()
        {
            foreach(string key in Greaterdictionary.Keys)
            {

                Console.Write("Right" + key + " ");

            }
            Console.WriteLine("");
            foreach (string key in LessThandictionary.Keys)
            {
                Console.WriteLine("Left" + key);

            }
        }
    
    }
}



    


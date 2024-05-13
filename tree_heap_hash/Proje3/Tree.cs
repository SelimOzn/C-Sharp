using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje3


{

    internal class TreeNode
    {
        public milliPark data;
        public TreeNode leftChild;
        public TreeNode rightChild;

        public TreeNode()
        {

        }

        public TreeNode(milliPark data, TreeNode left, TreeNode right)
        {
            this.data = data;
            this.leftChild = left;
            this.rightChild = right;
        }

        public void displayNode()
        {
            Console.Write(" " + data + " ");
        }
    }
    internal class Tree
    {
        private TreeNode root;
        private int nodeCount = 0;
        private TreeNode current;
        List<string> kelimeList = new List<string>();
        public Tree() { root = null; }
        public TreeNode getRoot()
        { return root; }

        public int getNodeCount()
        { return nodeCount; }

        public void insert(milliPark newdata)// Ağaca yeni düğüm ekler.
        {
            TreeNode newNode = new TreeNode();
            newNode.data = newdata;
            if (root == null)
                root = newNode;
            else
            {
                TreeNode current = root;
                TreeNode parent;
                while (true)
                {
                    parent = current;
                    if (newdata.getAd().CompareTo(current.data.getAd()) == -1)//Verilen kelime şu anki düğümün kelimesinden küçükse sol çocuk tarafından devam edilir.

                    {
                        current = current.leftChild;
                        if (current == null)
                        {
                            parent.leftChild = newNode;
                            return;
                        }
                    }
                    else
                    {//Verilen kelime şu anki düğümün kelimesinden büyükse sağ
                        //çocuk tarafından devam edilir.
                        current = current.rightChild;
                        if (current == null)
                        {
                            parent.rightChild = newNode;
                            return;
                        }
                    }
                }
            }
        }

        public int maxDepth(TreeNode current, int maxDepth)//Ağacın derinliğinin bulunmasını sağlar.
        {


            if (current == null)
            {
                return maxDepth;
            }

            else
            {
                current.data.toString();
                nodeCount++;
                int a = this.maxDepth(current.leftChild, maxDepth + 1);
                int b = this.maxDepth(current.rightChild, maxDepth + 1);

                if (a > b) { return a; }
                else { return b; }
            }
        }

        public void sehirBul(string ad)//Parkın adının ilk 3 harfinin verilmesi ile bulunduğu şehrin yazdırılmasını sağlar.
        {
            current = this.root;
            while(current != null)
            {
                if(string.Compare(ad, current.data.getAd().Substring(0, 3)) == 1)
                {
                    current=current.rightChild;
                }

                else if(string.Compare(ad, current.data.getAd().Substring(0, 3)) == (-1))
                {
                    current=current.leftChild;
                }
                else
                {
                    Console.WriteLine("Girdiğiniz parkın bulunduğu şehir: " + current.data.getSehir());
                    break;
                }
            }
            if (current == null)
            {
                Console.WriteLine("Aradığınız milli park bulunmamaktadır.");
            }
        }

        public void inOrder(TreeNode localRoot)//Ağacı in order düzende dolaşmayı sağlar.
        {
            if (localRoot != null)
            {
                inOrder(localRoot.leftChild);
                foreach(string cümle in localRoot.data.getParag())
                {
                    string[] kelimeler = cümle.Split(" ");
                    foreach(string word in kelimeler)
                    {
                        kelimeList.Add(word);
                    }
                }
                inOrder(localRoot.rightChild);
            }
        }
        
        public KelimeAgaci kelimeAgaci()//Her düğümdeki parkın kelimelerinden yeni bir ağaç oluşturulmasını sapğlayan metot.
        {
            this.inOrder(this.getRoot());
            KelimeAgaci wordTree = new KelimeAgaci();
            foreach (string word in this.kelimeList)
            {
                wordTree.insert(word);
            }
            return wordTree;
        }

        public void dengeliAgacDerinlik() //Ağaç dengeli olsaydı derinliğinin kaç olacağını bulan metot.
        {
            Console.WriteLine("Ağacın düğüm sayısı: " + this.nodeCount);
            double balancedDepth = Math.Log2(nodeCount);
            Console.WriteLine("Ağaç dengeli olsaydı derinliği: " + Math.Ceiling((decimal)balancedDepth));
        }
    }
}

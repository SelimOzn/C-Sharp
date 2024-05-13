using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje3
{

    internal class TreeNodeKelime
    {
        public string kelime;
        public int sayi;
        public TreeNodeKelime leftChild;
        public TreeNodeKelime rightChild;

        public TreeNodeKelime()
        {

        }

        public TreeNodeKelime(string ad, int sayi, TreeNodeKelime left, TreeNodeKelime right)
        {
            this.kelime = ad;
            this.sayi = sayi;
            this.leftChild = left;
            this.rightChild = right;
        }

        public void displayNode()
        {
            Console.Write(" " + kelime + " " + sayi);
            Console.WriteLine();
        }
    }
    internal class KelimeAgaci
    {
        private TreeNodeKelime root;
        private int nodeCount = 0;
        private TreeNodeKelime current;
        public KelimeAgaci() { root = null; }
        public TreeNodeKelime getRoot()
        { return root; }



        public void insert(string ad)
        {
            TreeNodeKelime newNode = new TreeNodeKelime();
            newNode.kelime = ad;
            if (root == null)
                root = newNode;
            else
            {
                TreeNodeKelime current = root;
                TreeNodeKelime parent;
                while (true)
                {
                    parent = current;
                    if (ad.CompareTo(current.kelime) == -1) //Verilen kelime şu anki düğümün kelimesinden küçükse sol
                        //çocuk tarafından devam edilir.
                    {
                        current = current.leftChild;
                        if (current == null)
                        {
                            parent.leftChild = newNode;
                            newNode.sayi++;
                            return;
                        }
                    }

                    else if (ad.CompareTo(current.kelime) == 0)//Verilen kelime ile şu anki düğümün kelimesi aynı ise
                        //düğümün sayacı 1 arttırılır ve arama bitirilir.
                    {
                        current.sayi++;
                        return;
                    }
                    else//Verilen kelime şu anki düğümün kelimesinden büyükse sağ
                        //çocuk tarafından devam edilir.
                    {
                        current = current.rightChild;
                        if (current == null)
                        {
                            parent.rightChild = newNode;
                            newNode.sayi++;
                            return;
                        }
                    }
                }
            }
        }

        public void inOrder(TreeNodeKelime localRoot)// Ağacı in order düzeninde dolaşmayı sağlar.
        {
            if (localRoot != null)
            {
                inOrder(localRoot.leftChild);
                localRoot.displayNode();
                inOrder(localRoot.rightChild);
            }
        }
    }
}

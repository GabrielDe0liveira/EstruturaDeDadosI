using System;
using System.Linq;
using System.Threading.Tasks;

namespace Trees
{

    public class TreeNode<T>
    {
        public T Data { get; set; }
        //Atributo recursivo
        public TreeNode<T> Parent { get; set; }
        //Lista com chamada de tipo recursivo
        public List<TreeNode<T>> Children { get; set; } 
        //Definindo a altura da arvore
        public int GetHeight()
        {
            int height = 1;
            TreeNode<T> current = this;
            while(current.Parent != null)
            {
                height++;
                current = current.Parent;
            }
            return height;
        }

    }
}
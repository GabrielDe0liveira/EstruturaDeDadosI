using Trees;

Tree<int> tree = new Tree<int>();

//Inicializa o Nó raiz com o valor 1000.
tree.Root = new TreeNode<int>() 
{
    Data = 1000
};

//Troca o valor de Data no Nó raiz.
tree.Root.Data = 100;

//Informa carga de Nós filhos
tree.Root.Children = new List<TreeNode<int>>
{
    new TreeNode<int>(){Data = 50, Parent = tree.Root},
    new TreeNode<int>(){Data = 5, Parent = tree.Root}
};

//Adicionando Nó em tempo de execução
TreeNode<int> filho3 = new TreeNode<int>();
filho3.Data = 0;
filho3.Parent = tree.Root;
tree.Root.Children.Add(filho3);
/*Funciona exatamente como o exemplo acima, porem aqui voce está colocando na força bruta, enquanto em cima voce apenas abre chaves e atribui os valores economizando linhas.*/

//Adicionando netos de Root, ou seja
//Filhos do primeiro nivel de hereditáriedade
tree.Root.Children[0].Children = new List<TreeNode<int>>
{
    new TreeNode<int>(){Data = 50, Parent = tree.Root},
};

//Adicionando filho de root no segundo filho
TreeNode<int> neto2 = new TreeNode<int>();
neto2.Data = 200;
neto2.Parent = tree.Root.Children[1];

tree.Root.Children[1].Children = 
new List<TreeNode<int>>();
tree.Root.Children[1].Children.Add(neto2);


int level = neto2.GetHeight();
string message = $"Esta arvore contem {level} niveis";
Console.WriteLine(message);
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lhk.POS.Core.Domain;

namespace lhk.POS.Presentation.Components
{
    public partial class CategoryTreeView : TreeView
    {
        public CategoryTreeView()
        {
            InitializeComponent();
        }

        public void showTree(IEnumerable<Category> listCategory)
        {
            listCategory = from cat in listCategory orderby cat.Id select cat;

            Category root = listCategory.FirstOrDefault();

            TreeNode node = getAllNode(listCategory, root);

            this.Nodes.Add(node);
        }


        protected TreeNode getAllNode(IEnumerable<Category> listCategory, Category father)
        {
            IEnumerable<Category> listSubNode = getSubTree(listCategory, father);

            if (listSubNode == null)
            {
                TreeNode childNode = new TreeNode(father.Name);
                childNode.Tag = father;
                return childNode;
            }

            TreeNode node = new TreeNode(father.Name);
            node.Tag = father;

            foreach (Category cate in listSubNode)
            {
                node.Nodes.Add(getAllNode(listCategory, cate));
            }
            return node;
        }

        protected IEnumerable<Category> getSubTree(IEnumerable<Category> source, Category node)
        {
            IEnumerable<Category> listSubNode = from cat in source where cat.ParentId.Equals(node.Id) orderby cat.Id select cat;

            return listSubNode;
        }
        public Category getSelectedNode()
        {
            return (Category)this.SelectedNode.Tag;
        }
    }
}

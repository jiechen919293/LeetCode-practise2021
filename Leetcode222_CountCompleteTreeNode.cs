﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{

//    Given the root of a complete binary tree, return the number of the nodes in the tree.

//According to Wikipedia, every level, except possibly the last,
//is completely filled in a complete binary tree,
//and all nodes in the last level are as far left as possible.
//It can have between 1 and 2h nodes inclusive at the last level h.

//Design an algorithm that runs in less than O(n) time complexity.
//Input: root = [1,2,3,4,5,6]
//Output: 6
//Example 2:

//Input: root = []
//Output: 0
//Example 3:

//Input: root = [1]
//Output: 1


    public class Leetcode222_CountCompleteTreeNode
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        int count = 0;
        public int CountNodes(TreeNode root)
        {
            if (root == null) return 0;
            count++;
            CountNodes(root.left);
            CountNodes(root.right);
            return count;
        }
    }
}

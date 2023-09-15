﻿using System.Security.Cryptography;

namespace MiniProject
{
    public class TreeNode
    {
        public TreeNode? Parent;
        public TreeNode? LeftChild;
        public TreeNode? RightChild;
        public bool IsLeaf => RightChild==null && LeftChild == null;
        public bool IsRoot => Parent== null;
        public TreeNode(int value)
        {
            Value = value;
        }
        
        
        public TreeNode(int _value, TreeNode _parent, int _level)
        {
            this.Parent = _parent;
            Level = _level;
            Value = _value;
        }
        public int Value { get; }
        public int Level { get; set; }
    }
}
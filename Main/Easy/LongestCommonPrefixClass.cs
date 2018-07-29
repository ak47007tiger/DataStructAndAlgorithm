using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Main.Easy {
  public class LongestCommonPrefixClass {
    class Node {
      public char v;
      public List<Node> children;
      public void Insert(string s) {

      }
      public Node find(string s) {
        return null;
      }
      public bool insert(char c) {
        if (v == c)
          return false;
        if (children == null) {
          children = new List<Node>();
          var n = new Node();
          n.v = c;
          children.Add(n);
          return true;
        }
        bool inserted = false;
        foreach (var n in children) {
          inserted = n.insert(c);
          if (inserted)
            return true;
        }
        var newNode = new Node();
        newNode.v = c;
        children.Add(newNode);
        return true;
      }
      public bool cointain(char c) {
        if (v == c)
          return true;
        foreach (var n in children) {
          if (n.cointain(c))
            return true;
        }
        return false;
      }
    }
    string tire(string[] strs) {
      Node root = new Node();
      root.v = strs[0][0];
      foreach (var s in strs) {
        root.Insert(s);
      }
      Node n = root;
      List<char> str = new List<char>();
      while (n.children != null && n.children.Count == 1) {
        str.Add(n.v);
        n = n.children[0];
      }
      str.Add(n.v);
      return new string(str.ToArray());
    }

    public string LongestCommonPrefix(string[] strs) {
      if (strs == null || strs.Length == 0)
        return string.Empty;
      var min = strs[0];
      for (int i = 1; i < strs.Length; i++) {
        if (strs[i].Length < min.Length)
          min = strs[i];
      }
      int a = min.Length;
      while (a >= 0) {
        bool pass = true;
        for (int i = 0; i < strs.Length; i++) {
          var comp = strs[i];
          for (int j = 0; j < a; j++) {
            if (min[j] != comp[j]) {
              pass = false;
              break;
            }
          }
          if (!pass) {
            break;
          }
        }
        if (pass) {
          return min.Substring(0, a);
        }
        a--;
      }
      return string.Empty;
    }
  }
}
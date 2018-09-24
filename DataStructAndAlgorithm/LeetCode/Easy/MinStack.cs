using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

push(x) -- Push element x onto stack.
pop() -- Removes the element on top of the stack.
top() -- Get the top element.
getMin() -- Retrieve the minimum element in the stack.
Example:
MinStack minStack = new MinStack();
minStack.push(-2);
minStack.push(0);
minStack.push(-3);
minStack.getMin();   --> Returns -3.
minStack.pop();
minStack.top();      --> Returns 0.
minStack.getMin();   --> Returns -2.
 */

/*
栈
倒出来搜索，然后倒回去
 */

namespace LeetCode.Easy {
  public class MinStack {
    Stack<int> stack = new Stack<int>();
    Stack<int> min = new Stack<int>();

    /** initialize your data structure here. */
    public MinStack() {

    }

    public void Push(int x) {
      stack.Push(x);
      if(min.Count == 0){
        min.Push(x);
      } else if(x <= min.Peek()){
        min.Push(x);
      }
    }

    public void Pop() {
      if(stack.Count > 0){
        var top = Top();
        if(min.Peek() == top){
          min.Pop();
        }
        stack.Pop();
      }
    }

    public int Top() {
      if(stack.Count > 0){
        return stack.Peek();
      }
      return -1;
    }

    public int GetMin() {
      if(min.Count > 0){
        return min.Peek();
      }
      return -1;
    }
  }
}
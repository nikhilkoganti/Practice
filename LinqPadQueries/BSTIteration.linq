<Query Kind="Program" />

//NonBST
//
//	    	10
//  	4		7
// 1		2 6		9

//BST
//							10
//			5								15
//	2				7				13				18
//1		3		6		8		11		14		16		20

public void PrintPostOrderTraversal(Node node)
{
	Stack<Node> s = new Stack<Node>();
	Dictionary<Node, int> visitCount = new Dictionary<Node, int>();
	var newLine = Environment.NewLine;
	
	while(s.Count != 0 || node.left != null || node.right != null)
	{
//		Print(node.val + newLine);
		if(node.left != null && !visitCount.ContainsKey(node))
		{
//		Print("A:" + newLine);
			visitCount[node] = 1;
			s.Push(node);
			node = node.left;
		}
		else if(node.right != null && visitCount.ContainsKey(node) && visitCount[node] < 2)
		{
//		Print("B:" + newLine);
			visitCount[node] = 2;
			s.Push(node);
			node = node.right;
		}
		else
		{
//		Print("C:" + newLine);
			Print(node.val + ",");
			if(s.Count > 0)
				node = s.Pop();
			else
				break;
		}
	}
}

void Main()
{
	var rootNonBST = InitializeNonBST();
	var rootBST = InitializeBST();
	var newLine = Environment.NewLine;
	
	Print("NonBST" + newLine);
	Print("In Order: ");
	PrintInOrderTraversal(rootNonBST);
	Print(newLine);
	Print("Pre Order: ");
	PrintPreOrderTraversal(rootNonBST);
	Print(newLine);
	Print("Post Order: ");
	PrintPostOrderTraversal(rootNonBST);
	Print(newLine);
	
	Print("BST" + newLine);
	Print("In Order: ");
	PrintInOrderTraversal(rootBST);
	Print(newLine);
	Print("Pre Order: ");
	PrintPreOrderTraversal(rootBST);
	Print(newLine);
	Print("Post Order: ");
	PrintPostOrderTraversal(rootBST);
	Print(newLine);
}

//public void PrintPostOrderTraversal(Node node)
//{
//	Stack<Node> leftS = new Stack<Node>();
//	Stack<Node> rightS = new Stack<Node>();
//	var leftSJustPopped = false;
//	var rightSJustPopped = false;
//	
//	while(leftS.Count != 0 || rightS.Count != 0 || node.left != null || node.right != null)
//	{
//		if(node.left != null && !leftSJustPopped && !rightSJustPopped)
//		{
//			leftSJustPopped = false;
//			rightSJustPopped = false;
//			leftS.Push(node);
//			node = node.left;
//		}
//		else if(node.right != null && !rightSJustPopped)
//		{
//			leftSJustPopped = false;
//			rightSJustPopped = false;
//			rightS.Push(node);
//			node = node.right;
//		}
//		else
//		{
//			leftSJustPopped = false;
//			rightSJustPopped = false;
//			Print(node.val + ",");
//			if(rightS.Count > 0)
//			{
//				node = rightS.Pop();
//				rightSJustPopped = true;
//			}
//			else if(leftS.Count > 0)
//			{
//				node = leftS.Pop();
//				leftSJustPopped = true;	
//			}
//		}
//	}
//	Print(node.val);
//}

public void PrintPreOrderTraversal(Node node)
{
	Stack<Node> s = new Stack<Node>();
	bool justPopped = false;
	
	while(s.Count != 0 || node.left != null || node.right != null)
	{
		if(!justPopped)
			Print(node.val + ",");
		
		if(node.left != null && !justPopped)
		{
			s.Push(node);
			node = node.left;
		}
		else if(node.right != null)
		{
			justPopped = false;
			node = node.right;
		}
		else
		{
			node = s.Pop();
			justPopped = true;
		}		
	}
	Print(node.val);
}

public void PrintInOrderTraversal(Node node)
{
	Stack<Node> stack = new Stack<Node>();
	bool justPopped = false;
	
	while(stack.Count != 0 || node.left != null || node.right != null)
	{
		if (node.left != null && !justPopped)
		{
			stack.Push(node);
			node = node.left;
		}
		else if (node.right != null)
		{
			justPopped = false;
			Print(node.val + ",");
			node = node.right;
		}
		else
		{
			Print(node.val + ",");
			node = stack.Pop();
			justPopped = true;
		}
	}
	Print(node.val);
}

public void Print(string str, bool newLine = false)
{
	Console.Write(str);
}

public void Print(int str, bool newLine = false)
{
	Print(str + "", newLine);
}

// Define other methods and classes here
public class Node
{
	public Node(int val)
	{
		this.val = val;
	}
	public int val;
	public Node left;
	public Node right;
}

public Node InitializeNonBST()
{
	Node node = new Node(10);
	node.left = new Node(4);
	node.left.left = new Node(1);
	node.left.right = new Node(2);
	node.right = new Node(7);
	node.right.left = new Node(6);
	node.right.right = new Node(9);
	
	return node;
}

public Node InitializeBST()
{
	Node node = new Node(10);
	
	node.left = new Node(5);
	node.left.left = new Node(2);
	node.left.left.left = new Node(1);
	node.left.left.right = new Node(3);
	node.left.right = new Node(7);
	node.left.right.left = new Node(6);
	node.left.right.right = new Node(8);
	
	node.right = new Node(15);
	node.right.right = new Node(18);
	node.right.right.right = new Node(20);
	node.right.right.left = new Node(16);
	node.right.left = new Node(13);
	node.right.left.left = new Node(11);
	node.right.left.right = new Node(14);
	
	return node;
}
using System.ComponentModel.Design.Serialization;

public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        // Make sure that the inserted value is unique
        if (value == Data)
        {
            return;
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        // If value == Data, we find the value in the tree, and return true.
        if (value == Data)
        {
            return true;
        }

        // If value < Data, we recursively traverse the left tree and return the result
        if (value < Data)
        {
            if (Left == null)
            {
                return false;
            }

            return Left.Contains(value);           
        }
        
        // If value > Data, we recursively traverse the right tree and return the result
        else 
        {
            if (Right == null)
            {
                return false;
            }

            return Right.Contains(value);            
        }
       
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        // The height of any tree (or subtree) is defined as one plus the height of 
        // either the left subtree or the right subtree (whichever one is bigger).
        
        int leftHeight = 0;
        int rightHeight =0;
        // If Left is not equal null, we recursively traverse the left tree and return the count result
       if (Left != null)
        {
            leftHeight = Left.GetHeight();
        }
        // If Right is not equal null, we recursively traverse the right tree and return the count result
        if (Right != null)
        {
            rightHeight = Right.GetHeight();
        }
        
        // Choose the max one and + 1 (parent node)
        return Math.Max(leftHeight, rightHeight) + 1; // Replace this line with the correct return statement(s)
    }
}
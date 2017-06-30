
namespace VisualStudioTips
{
    public class DeletingText
    {
        public void Start()
        {
            // Put the cursor at the end of this line. Press Backspace to delete one character to the left of the cursor. 
            System.Console.WriteLine("Hello, World");

            // Now put the cursor at the beginning of this line. Press Delete to delete one character to the right of the cursor.
            System.Console.WriteLine("Hello, World");

            // Did you see the difference between Delete and Backspace?

            // Now, put the cursor at the end of this line again. This time, hold down Ctrl as you're pressing Backspace.
            // Note that you'll delete one word at a time. 
            System.Console.WriteLine("Hello, World");

            // Now, put the cursor at the beginning of this line. This time, hold down Ctrl as you're pressing Delete.
            // Note that you'll delete one word at a time. 
            System.Console.WriteLine("Hello, World");


            // Put the cursor anywhere on this line. Press Ctrl and L to delete the current line. 
            System.Console.WriteLine("Hello, World");
        }
    }
}

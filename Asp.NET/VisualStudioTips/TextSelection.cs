
namespace VisualStudioTips
{
    public class TextSelection
    {
        public void Start()
        {
            // Put the cursor at the beginning of this line. Use Ctrl, Shift and Right Arrow to select one word to the right of the cursor. 
            // Repeat a few times. 
            System.Console.WriteLine("Hello, World");

            // Put the cursor at the beginning of "Console" here. Press Shift and End to select everything from "Console" to the end of the line.
            // Then press Shift and Home to select everything from the beginning of the line up to "Console".
            System.Console.WriteLine("Hello, World");
        }
    }
}


using System;

namespace VisualStudioTips
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here's the comment for debugging. Put the cursor at the beginning of the "debugging.Start()" line and press F9 to insert a breakpoint.
            // Press F5 to run the application in the debug mode. Note that the execution stops on the line where you've got a breakpoint. Press F10. 
            // Notice how the execution continues to the next line "Console.Writeline". F10 is for stepping over a method. So we won't go inside the
            // "debugging.Start()" method. 
            //
            // Press Shift and F5 to stop the debugger. Now press F5 again to run the application in the debug mode again. This time, press F11 
            // (instead of F10) to step into "debugging.Start()" method. You can press Shift + F11 there to step out of that method.
            // 
            // So remember: F10 is for stepping over a method, F11 is for stepping into a method and Shift + F11 is for stepping out of a method.
            //
            // Press Shift and F5 to stop the debugging session. Run the application using Ctrl and F5. Note that the execution doesn't stop at the 
            // breakpoint. When you use Ctrl + F5, the application starts faster because debugging information is not loaded into the memory.
            // When you press F5 the application starts in the debug mode. 
            var debugging = new Debugging();
            debugging.Start();

            Console.WriteLine("Done");
        }
    }
}

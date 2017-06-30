
namespace VisualStudioTips
{
    public class Compiling
    {
        public void Start()
        {
            // Remove the semicolon from this line. 
            var x = 1;

            // Do the same here. 
            System.Console.WriteLine("Hello, World");

            // Now press Ctrl + Shift + B. This is to compile the application without running it. It's useful when you're working on a web application
            // and your application is already open in the browser. If you run the application using Ctrl + F5, everytime you'll get a new tab in the
            // browser. 

            // Because you removed semicolons you see two errors now. Press F8 to go to the next error. Fix the error and press F8 again. It's faster
            // than using the mouse to double-click in the errors window.
        }
    }
}

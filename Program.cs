using MidtermATM;
using System;
using System.Windows.Forms;
using ATMApp.Forms;

namespace ATMApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
//Unit testing is the process of testing individual components or methods by themselves to make sure they work as they should.
// It helps developers catch bugs early in the development process.
//By writing tests for critical methods such as login authentication, balance checks, or withdrawal logic, developers can make sure the code works immediately and modularly.
//Unit tests support refactoring because it helps test one thing at a time.
//They also serve as a form of documentation, helping future developers understand what the code should be doing.
//Automated unit tests can speed up the development cycle and improve quality.

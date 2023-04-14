using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog_226_S23_L4_Delegates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Action<type> - Delegate with a void return type
        // TResult Func<in T1, out TResult>(T1 value)
        // Predicate<type> - returns bool

        public delegate double MathDelegate(double num1, double num2);
        
        public MainWindow()
        {
            InitializeComponent();

            MathDelegate addNumbers = new MathDelegate(Add);

            Predicate<bool> returnsIfTrue = IsTrue;

            returnsIfTrue(false);

            Console.WriteLine(addNumbers(1,2));

        } // MainWindow()

        

        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public bool IsTrue(bool valid)
        {
            return true;
        }

    } // class

} // namespace

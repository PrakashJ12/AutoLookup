using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
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
            cbm.NewUrl += cbm_NewUrl;
        }
        private void cbm_NewUrl(string txt)
        {
            this.textBox_FQDN.Text = txt;
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

        public event NewUrlHandler NewUrl;
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
                        string txt = Clipboard.GetText();
                        if (this.NewUrl != null && this.IsValidUrl(txt))
                        {
                            this.NewUrl(txt);
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

        private bool IsValidUrl(string txt)
        {
            Uri uriResult;
            return Uri.TryCreate(txt.Trim(), UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

    }
}

using AutoLookup.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLookup
{
    public partial class Mainform : Form
    {
        bool autoLookup = false;

        bool pingSuccess = false;
        bool lookupSuccess = false;
        bool reverseLookupSuccess = false;

        bool tempDisableCopy = false;

        private ClipBoardMonitor cbm = null;
        BackgroundWorker backgroundWorker_Ping = new BackgroundWorker();
        BackgroundWorker backgroundWorker_Lookup = new BackgroundWorker();
        BackgroundWorker backgroundWorker_ReverseLookup = new BackgroundWorker();
        public Mainform()
        {
            InitializeComponent();

            this.TopMost = Properties.Settings.Default.AlwaysOnTop;
            checkBox_onTop.Checked = Properties.Settings.Default.AlwaysOnTop;

            autoLookup = Properties.Settings.Default.AutoLookup;
            checkBox_AutoLookup.Checked = Properties.Settings.Default.AutoLookup;

            //Tooltips for preference items
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.checkBox_Autocopy, "This setting wont persist.");
            ToolTip1.SetToolTip(this.checkBox_onTop, "This setting will persist between sessions.");
            ToolTip1.SetToolTip(this.checkBox_AutoLookup, "Not Implemented.");

            label_resultLookup.Text = "";
            label_resultPing.Text = "";
            label_resultReverse.Text = "";

            cbm = new ClipBoardMonitor();
            cbm.NewClipboardText += cbm_NewUrl;

            backgroundWorker_Ping.WorkerSupportsCancellation = true;
            backgroundWorker_Ping.WorkerReportsProgress = true;
            backgroundWorker_Ping.DoWork += Ping_DoWork;
            backgroundWorker_Ping.RunWorkerCompleted += Ping_Completed;
            backgroundWorker_Ping.ProgressChanged += Ping_ProgressChanged;

            backgroundWorker_Lookup.WorkerSupportsCancellation = true;
            backgroundWorker_Lookup.WorkerReportsProgress = true;
            backgroundWorker_Lookup.DoWork += Lookup_DoWork;
            backgroundWorker_Lookup.ProgressChanged += Lookup_ProgressChanged;
            backgroundWorker_Lookup.RunWorkerCompleted += Lookup_Completed;


            backgroundWorker_ReverseLookup.WorkerSupportsCancellation = true;
            backgroundWorker_ReverseLookup.WorkerReportsProgress = true;
            backgroundWorker_ReverseLookup.DoWork += Reverse_DoWork;
            backgroundWorker_ReverseLookup.ProgressChanged += Reverse_ProgressChanged;
            backgroundWorker_ReverseLookup.RunWorkerCompleted += Reverse_Completed;
        }

        private void Reverse_DoWork(object sender, DoWorkEventArgs e)
        {

            int pingAttempt = 1;
            reverseLookupSuccess = false;
            do
            {
                backgroundWorker_ReverseLookup.ReportProgress(pingAttempt);
                reverseLookupSuccess = Reverse(textBox_IP.Text, textBox_FQDN.Text);
                pingAttempt++;
            } while (pingAttempt < 4 && reverseLookupSuccess == false && !backgroundWorker_ReverseLookup.CancellationPending);
            if (backgroundWorker_ReverseLookup.CancellationPending) e.Cancel = true;
        }

        private void Reverse_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!backgroundWorker_ReverseLookup.CancellationPending)
            {
                label_resultReverse.Text = "Attempt: " + e.ProgressPercentage;
                progressBar_singleLookup.Value = 6 + e.ProgressPercentage;
            }
        }

        private void Reverse_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                if (reverseLookupSuccess)
                {
                    pictureBox_reverseLookup.Image = Resources.success;
                }
                else
                {
                    pictureBox_reverseLookup.Image = Resources.failed;
                }
                progressBar_singleLookup.Value = 10;
                tempDisableCopy = false;
            }
        }

        [STAThread]
        static bool Reverse(string ip, string fqdn)
        {
            try
            {
                IPHostEntry ipEntry = Dns.GetHostEntry(ip);

                if (ipEntry.HostName.Equals(fqdn))
                {
                    return true;
                }

                return false;
            }
            catch (System.Net.Sockets.SocketException se)
            {
                // The system had problems resolving the address passed
                Console.WriteLine(se.Message.ToString());
                return false;

            }
            catch (System.FormatException fe)
            {
                // Non unicode chars were probably passed 
                Console.WriteLine(fe.Message.ToString());
                return false;

            }
        }

        private void Lookup_DoWork(object sender, DoWorkEventArgs e)
        {

            int pingAttempt = 1;
            lookupSuccess = false;
            do
            {
                lookupSuccess = Lookup(textBox_FQDN.Text, textBox_IP.Text);
                backgroundWorker_Lookup.ReportProgress(pingAttempt);
                pingAttempt++;
            } while (pingAttempt < 4 && lookupSuccess == false && !backgroundWorker_Lookup.CancellationPending);

            if (backgroundWorker_Lookup.CancellationPending) e.Cancel = true;
        }

        private void Lookup_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!backgroundWorker_Lookup.CancellationPending)
            {
                label_resultLookup.Text = "Attempt: " + e.ProgressPercentage;
                progressBar_singleLookup.Value = 3 + e.ProgressPercentage;
            }
            
        }

        private void Lookup_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                if (lookupSuccess)
                {
                    pictureBox_lookup.Image = Resources.success;
                }
                else
                {
                    pictureBox_lookup.Image = Resources.failed;
                }
                pictureBox_reverseLookup.Image = Resources.progress;
                backgroundWorker_ReverseLookup.RunWorkerAsync();
            }
        }

        [STAThread]
        static bool Lookup(string fqdn, string ip)
        {
            try
            {
                //The IP or Host Entry to lookup
                IPHostEntry ipEntry;

                //The IP Address Array. Holds an array of resolved Host Names.
                IPAddress[] ipAddr;

                //Value of alpha characters
                char[] alpha = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ-".ToCharArray();

                ipEntry = Dns.GetHostEntry(fqdn);

                ipAddr = ipEntry.AddressList;

                foreach (var ipResult in ipAddr)
                {
                    if (ipResult.ToString().Equals(ip))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (System.Net.Sockets.SocketException se)
            {
                // The system had problems resolving the address passed
                Console.WriteLine(se.Message.ToString());
                return false;

            }
            catch (System.FormatException fe)
            {
                // Non unicode chars were probably passed 
                Console.WriteLine(fe.Message.ToString());
                return false;

            }
        }

        private void Ping_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                if (pingSuccess)
                {
                    pictureBox_ping.Image = Resources.success;
                }
                else
                {
                    pictureBox_ping.Image = Resources.failed;
                }
                pictureBox_lookup.Image = Resources.progress;
                backgroundWorker_Lookup.RunWorkerAsync();
            }
        }

        private void Ping_DoWork(object sender, DoWorkEventArgs e)
        {
            int defaultTimout = 1500;
            int pingAttempt = 1;
            pingSuccess = false;
            do
            {
                pingSuccess = doPing(textBox_FQDN.Text, defaultTimout * pingAttempt);
                backgroundWorker_Ping.ReportProgress(pingAttempt);
                pingAttempt++;
            } while (pingAttempt < 4 && pingSuccess == false && !backgroundWorker_Ping.CancellationPending);

            if (backgroundWorker_Ping.CancellationPending) e.Cancel = true;
        }

        private bool doPing(string fqdn, int timeout)
        {
            bool singlePingSuccess = false;
            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(fqdn, timeout);
                singlePingSuccess = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            return singlePingSuccess;
        }

        private void Ping_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!backgroundWorker_Ping.CancellationPending) {
                label_resultPing.Text = "Ping: " + e.ProgressPercentage;
                progressBar_singleLookup.Value = e.ProgressPercentage;
            }
            

        }

        private void cbm_NewUrl(string clipboardText)
        {
            if (checkBox_Autocopy.Checked && !tempDisableCopy)
            {
                if (IsValidFqdn(clipboardText))
                {
                    this.textBox_FQDN.Text = clipboardText;
                }
                else if (IsValidIp(clipboardText))
                {
                    this.textBox_IP.Text = clipboardText;
                }
                else
                {
                    Console.WriteLine("Not an FQDN or IP");
                }
            }

        }
        

        private void button_Lookup_Click(object sender, EventArgs e)
        {
            tempDisableCopy = true;
            pictureBox_lookup.Image = null;
            pictureBox_reverseLookup.Image = null;

            pictureBox_ping.Image = Resources.progress;

            backgroundWorker_Ping.RunWorkerAsync();
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

        private void checkBox_onTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBox_onTop.Checked;
            Properties.Settings.Default.AlwaysOnTop = checkBox_onTop.Checked; //Set the user preference for next  execution
            Properties.Settings.Default.Save(); //Save the user preference
        }

        private void checkBox_AutoLookup_CheckedChanged(object sender, EventArgs e)
        {
            autoLookup = checkBox_AutoLookup.Checked;
            Properties.Settings.Default.AutoLookup = checkBox_AutoLookup.Checked; //Set the user preference for next  execution
            Properties.Settings.Default.Save(); //Save the user preference
        }

        private void button_ClearCancel_Click(object sender, EventArgs e)
        {
            clearCancelLookup();
        }

        private void clearCancelLookup()
        {
            backgroundWorker_Ping.CancelAsync();
            backgroundWorker_Lookup.CancelAsync();
            backgroundWorker_ReverseLookup.CancelAsync();

            pictureBox_lookup.Image = null;
            pictureBox_reverseLookup.Image = null;
            pictureBox_ping.Image = null;

            //textBox_IP.Text = "";
            //textBox_FQDN.Text = "";

            label_resultPing.Text = "";
            label_resultLookup.Text = "";
            label_resultReverse.Text = "";

            tempDisableCopy = false;

            progressBar_singleLookup.Value = 0;
        }

        private void textBox_FQDN_TextChanged(object sender, EventArgs e)
        {
            clearCancelLookup();
        }

        private void button_BulkLookup_Click(object sender, EventArgs e)
        {
            BulkProcessForm bulkProcessForm = new BulkProcessForm();
            this.Hide();
            bulkProcessForm.Show();
        }

        private void button_OpenSource_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/PrakashJ12/AutoLookup");
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

            if ((isMatchFqdn || isMatchIp) && !(isMatchIp && isMatchFqdn))
            {
                return true;
            }
            return false;
        }



    }
}

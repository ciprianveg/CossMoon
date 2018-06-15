using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Cmd : Form
    {
        public Cmd()
        {
            InitializeComponent();
            Load();
            this.KeyPreview = true;
        }

        System.Diagnostics.Process p;
        StreamWriter inputStream;
        StreamReader outputStream;
        StreamReader errorStream;
        byte[] readOutputBuffer = new byte[4096];
        byte[] readErrorBuffer = new byte[4096];
        Font outputFont = new Font("Consolas", 10);
        Font errorFont = new Font("Consolas", 10, FontStyle.Bold);
        Color outputColor = Color.LightGray;
        Color errorColor = Color.Red;
        
        private void Load()
        {
            inputField.Select();
           // inputField.BackColor = Color.Black;
            //inputField.SelectionColor = outputColor;
            //inputField.SelectionFont = outputFont;
            outputField.BackColor = Color.Black;

            ProcessStartInfo ps = new ProcessStartInfo("cmd.exe");
            ps.RedirectStandardInput = true;
            ps.RedirectStandardOutput = true;
            ps.RedirectStandardError = true;
            ps.UseShellExecute = false;
            ps.CreateNoWindow = true;
            ps.StandardErrorEncoding = Encoding.ASCII;
            ps.StandardOutputEncoding = Encoding.ASCII;
            try
            {
                p = Process.Start(ps);
                inputStream = p.StandardInput;
                outputStream = p.StandardOutput;
                errorStream = p.StandardError;
                DoReadOutput();
                DoReadError();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Just in case there's a problem on your end. :-)
            }
        }

        void DoReadOutput()
        {
            outputStream.BaseStream.BeginRead(readOutputBuffer, 0, readOutputBuffer.Length, new AsyncCallback(OnReadOutputCompleted), null);
        }

        void OnReadOutputCompleted(IAsyncResult result)
        {
            int cbRead = outputStream.BaseStream.EndRead(result);
            ProcessOutput(readOutputBuffer, cbRead);
            DoReadOutput();
        }

        void DoReadError()
        {
            errorStream.BaseStream.BeginRead(readErrorBuffer, 0, readErrorBuffer.Length, new AsyncCallback(OnReadErrorCompleted), null);
        }

        void OnReadErrorCompleted(IAsyncResult result)
        {
            int cbRead = errorStream.BaseStream.EndRead(result);
            ProcessError(readErrorBuffer, cbRead);
            DoReadError();
        }

        private void ProcessOutput(byte[] buffer, int cbRead)
        {
            string text = p.StartInfo.StandardOutputEncoding.GetString(buffer, 0, cbRead);
            this.Invoke((Action)delegate
            {
                this.outputField.SelectionFont = outputFont;
                this.outputField.SelectionColor = outputColor;
                this.outputField.AppendText(text);
                this.outputField.SelectionStart = this.outputField.Text.Length;
                this.outputField.ScrollToCaret();
            });
        }

        private void ProcessError(byte[] buffer, int cbRead)
        {
            string text = p.StartInfo.StandardErrorEncoding.GetString(buffer, 0, cbRead);
            this.Invoke((Action)delegate
            {
                this.outputField.SelectionFont = errorFont;
                this.outputField.SelectionColor = errorColor;
                this.outputField.AppendText(text);
                this.outputField.SelectionStart = this.outputField.Text.Length;
                this.outputField.ScrollToCaret();
            });
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Send();
            }
            base.OnKeyDown(e);
        }

        void Send()
        {
            string text = this.inputField.Text+"\n";
            this.inputField.Text = "";
            byte[] bytes = Encoding.ASCII.GetBytes(text);
            if (bytes != null)
            {
                inputStream.BaseStream.Write(bytes, 0, bytes.Length);
                inputStream.Flush();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void buy_Click(object sender, EventArgs e)
        {

        }

        private void sellButton_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void balance_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void helpButton_Click(object sender, EventArgs e)
        {

        }

        private void pairDepthButton_Click(object sender, EventArgs e)
        {

        }

        private void orderHistoryButton_Click(object sender, EventArgs e)
        {

        }

        private void checkMarketParirsButton_Click(object sender, EventArgs e)
        {

        }

        private void marketTickerDataButton_Click(object sender, EventArgs e)
        {

        }

        private void allTickerDataButton_Click(object sender, EventArgs e)
        {

        }
    }
}

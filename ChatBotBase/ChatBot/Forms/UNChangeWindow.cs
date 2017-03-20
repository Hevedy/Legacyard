/*
===========================================================================

Chat Bot Basic MIT Source Code
Copyright (C) 2014-2017 Hevedy <github.com/Hevedy>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.

===========================================================================
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBot.Forms
{
    public partial class UNChangeWindow : Form
    {
        public UNChangeWindow()
        {
            InitializeComponent();
        }

        private void UNChangeWindow_Load(object sender, EventArgs e)
        {
            TB_UserName.Text = ChatBot.Properties.Settings.Default.UserName;
            CB_Remember.Checked = ChatBot.Properties.Settings.Default.RememberUN;
        }

        private void B_Ok_Click(object sender, EventArgs e)
        {
            if ((TB_UserName.Text == null) || (TB_UserName.Text == " ") || (TB_UserName.Text == ""))
            {
                TB_UserName.Text = "User";
                return;
            }
            else
            {
                if (CB_Remember.Checked == true)
                {
                    ChatBot.Properties.Settings.Default.UserName = TB_UserName.Text;
                    ChatBot.Properties.Settings.Default.RememberUN = true;
                    ChatBot.Properties.Settings.Default.Save();
                }
                else
                {
                    ChatBot.MainWindow.UserName = TB_UserName.Text;
                    ChatBot.Properties.Settings.Default.UserName = "User";
                    ChatBot.Properties.Settings.Default.RememberUN = false;
                    ChatBot.Properties.Settings.Default.Save();
                }
            }
            //Run Bot
            MainWindow OpenMain = new MainWindow();
            OpenMain.Show();
            this.Hide();
        }
    }
}

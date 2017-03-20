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


namespace ChatBot.Forms
{
    partial class UNChangeWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UNChangeWindow));
            this.B_Ok = new System.Windows.Forms.Button();
            this.CB_Remember = new System.Windows.Forms.CheckBox();
            this.TB_UserName = new System.Windows.Forms.TextBox();
            this.L_UserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B_Ok
            // 
            this.B_Ok.Location = new System.Drawing.Point(197, 87);
            this.B_Ok.Name = "B_Ok";
            this.B_Ok.Size = new System.Drawing.Size(75, 23);
            this.B_Ok.TabIndex = 0;
            this.B_Ok.Text = "Ok";
            this.B_Ok.UseVisualStyleBackColor = true;
            this.B_Ok.Click += new System.EventHandler(this.B_Ok_Click);
            // 
            // CB_Remember
            // 
            this.CB_Remember.AutoSize = true;
            this.CB_Remember.Location = new System.Drawing.Point(60, 74);
            this.CB_Remember.Name = "CB_Remember";
            this.CB_Remember.Size = new System.Drawing.Size(94, 17);
            this.CB_Remember.TabIndex = 1;
            this.CB_Remember.Text = "Remember me";
            this.CB_Remember.UseVisualStyleBackColor = true;
            // 
            // TB_UserName
            // 
            this.TB_UserName.Location = new System.Drawing.Point(60, 48);
            this.TB_UserName.MaxLength = 32;
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(139, 20);
            this.TB_UserName.TabIndex = 2;
            this.TB_UserName.Text = "Foo";
            // 
            // L_UserName
            // 
            this.L_UserName.AutoSize = true;
            this.L_UserName.Location = new System.Drawing.Point(57, 32);
            this.L_UserName.Name = "L_UserName";
            this.L_UserName.Size = new System.Drawing.Size(135, 13);
            this.L_UserName.TabIndex = 3;
            this.L_UserName.Text = "Your Name: (32 chars max)";
            // 
            // UNChangeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 122);
            this.Controls.Add(this.L_UserName);
            this.Controls.Add(this.TB_UserName);
            this.Controls.Add(this.CB_Remember);
            this.Controls.Add(this.B_Ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UNChangeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Bot - User Name";
            this.Load += new System.EventHandler(this.UNChangeWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Ok;
        private System.Windows.Forms.CheckBox CB_Remember;
        private System.Windows.Forms.TextBox TB_UserName;
        private System.Windows.Forms.Label L_UserName;
    }
}
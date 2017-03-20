//-----------------------------------------------------------------------------
// Copyright (c) 2014-2017 Hevedy <github.com/Hevedy>
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

namespace Love2DManager.Forms
{
    partial class ProjectManagerForm
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
            this.B_PM_Apply = new System.Windows.Forms.Button();
            this.B_PM_Cancel = new System.Windows.Forms.Button();
            this.TB_PName = new System.Windows.Forms.TextBox();
            this.TB_PGameName = new System.Windows.Forms.TextBox();
            this.TB_PAutor = new System.Windows.Forms.TextBox();
            this.TB_PVersion = new System.Windows.Forms.TextBox();
            this.L_PGameName = new System.Windows.Forms.Label();
            this.L_PVersion = new System.Windows.Forms.Label();
            this.L_PAutor = new System.Windows.Forms.Label();
            this.L_PName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B_PM_Apply
            // 
            this.B_PM_Apply.Location = new System.Drawing.Point(12, 172);
            this.B_PM_Apply.Name = "B_PM_Apply";
            this.B_PM_Apply.Size = new System.Drawing.Size(75, 23);
            this.B_PM_Apply.TabIndex = 0;
            this.B_PM_Apply.Text = "Apply";
            this.B_PM_Apply.UseVisualStyleBackColor = true;
            this.B_PM_Apply.Click += new System.EventHandler(this.B_PM_Apply_Click);
            // 
            // B_PM_Cancel
            // 
            this.B_PM_Cancel.Location = new System.Drawing.Point(265, 172);
            this.B_PM_Cancel.Name = "B_PM_Cancel";
            this.B_PM_Cancel.Size = new System.Drawing.Size(75, 23);
            this.B_PM_Cancel.TabIndex = 1;
            this.B_PM_Cancel.Text = "Cancel";
            this.B_PM_Cancel.UseVisualStyleBackColor = true;
            this.B_PM_Cancel.Click += new System.EventHandler(this.B_PM_Cancel_Click);
            // 
            // TB_PName
            // 
            this.TB_PName.Location = new System.Drawing.Point(94, 15);
            this.TB_PName.MaxLength = 20;
            this.TB_PName.Name = "TB_PName";
            this.TB_PName.Size = new System.Drawing.Size(246, 20);
            this.TB_PName.TabIndex = 2;
            // 
            // TB_PGameName
            // 
            this.TB_PGameName.Location = new System.Drawing.Point(94, 41);
            this.TB_PGameName.MaxLength = 20;
            this.TB_PGameName.Name = "TB_PGameName";
            this.TB_PGameName.Size = new System.Drawing.Size(246, 20);
            this.TB_PGameName.TabIndex = 3;
            // 
            // TB_PAutor
            // 
            this.TB_PAutor.Location = new System.Drawing.Point(94, 67);
            this.TB_PAutor.MaxLength = 60;
            this.TB_PAutor.Name = "TB_PAutor";
            this.TB_PAutor.Size = new System.Drawing.Size(246, 20);
            this.TB_PAutor.TabIndex = 4;
            // 
            // TB_PVersion
            // 
            this.TB_PVersion.Location = new System.Drawing.Point(94, 93);
            this.TB_PVersion.MaxLength = 20;
            this.TB_PVersion.Name = "TB_PVersion";
            this.TB_PVersion.Size = new System.Drawing.Size(246, 20);
            this.TB_PVersion.TabIndex = 5;
            // 
            // L_PGameName
            // 
            this.L_PGameName.AutoSize = true;
            this.L_PGameName.Location = new System.Drawing.Point(19, 44);
            this.L_PGameName.Name = "L_PGameName";
            this.L_PGameName.Size = new System.Drawing.Size(69, 13);
            this.L_PGameName.TabIndex = 12;
            this.L_PGameName.Text = "Game Name:";
            // 
            // L_PVersion
            // 
            this.L_PVersion.AutoSize = true;
            this.L_PVersion.Location = new System.Drawing.Point(43, 96);
            this.L_PVersion.Name = "L_PVersion";
            this.L_PVersion.Size = new System.Drawing.Size(45, 13);
            this.L_PVersion.TabIndex = 10;
            this.L_PVersion.Text = "Version:";
            // 
            // L_PAutor
            // 
            this.L_PAutor.AutoSize = true;
            this.L_PAutor.Location = new System.Drawing.Point(53, 70);
            this.L_PAutor.Name = "L_PAutor";
            this.L_PAutor.Size = new System.Drawing.Size(35, 13);
            this.L_PAutor.TabIndex = 9;
            this.L_PAutor.Text = "Autor:";
            // 
            // L_PName
            // 
            this.L_PName.AutoSize = true;
            this.L_PName.Location = new System.Drawing.Point(14, 18);
            this.L_PName.Name = "L_PName";
            this.L_PName.Size = new System.Drawing.Size(74, 13);
            this.L_PName.TabIndex = 8;
            this.L_PName.Text = "Project Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Please don´t write symbols or go to have problems.";
            // 
            // ProjectManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 207);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_PGameName);
            this.Controls.Add(this.L_PVersion);
            this.Controls.Add(this.L_PAutor);
            this.Controls.Add(this.L_PName);
            this.Controls.Add(this.TB_PVersion);
            this.Controls.Add(this.TB_PAutor);
            this.Controls.Add(this.TB_PGameName);
            this.Controls.Add(this.TB_PName);
            this.Controls.Add(this.B_PM_Cancel);
            this.Controls.Add(this.B_PM_Apply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Love 2D Game Engine - Frontend - Project Manager";
            this.Load += new System.EventHandler(this.ProjectManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_PM_Apply;
        private System.Windows.Forms.Button B_PM_Cancel;
        private System.Windows.Forms.TextBox TB_PName;
        private System.Windows.Forms.TextBox TB_PGameName;
        private System.Windows.Forms.TextBox TB_PAutor;
        private System.Windows.Forms.TextBox TB_PVersion;
        private System.Windows.Forms.Label L_PGameName;
        private System.Windows.Forms.Label L_PVersion;
        private System.Windows.Forms.Label L_PAutor;
        private System.Windows.Forms.Label L_PName;
        private System.Windows.Forms.Label label1;
    }
}
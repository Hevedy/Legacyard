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


namespace ChatBot
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TB_UserInput = new System.Windows.Forms.TextBox();
            this.TB_ChatBotOutput = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UB_Clear = new System.Windows.Forms.Button();
            this.UB_Send = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.L_UName = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSDDB_File = new System.Windows.Forms.ToolStripDropDownButton();
            this.TSMI_New = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_SLog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSDDB_Edit = new System.Windows.Forms.ToolStripDropDownButton();
            this.TSMI_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Send = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CBChat = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CUChat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Preferences = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Lang = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_LangEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_LangSpanish = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_User = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_UCName = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_UCWMicro = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_BotMode = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ModeHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ModeVS = new System.Windows.Forms.ToolStripMenuItem();
            this.TSDDB_Help = new System.Windows.Forms.ToolStripDropDownButton();
            this.TSMI_About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_CList = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.L_BotStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMS_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.CMS_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.CMS_Send = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TB_UserInput
            // 
            this.TB_UserInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_UserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_UserInput.Location = new System.Drawing.Point(58, 24);
            this.TB_UserInput.MaxLength = 1000;
            this.TB_UserInput.Multiline = true;
            this.TB_UserInput.Name = "TB_UserInput";
            this.TB_UserInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_UserInput.Size = new System.Drawing.Size(506, 90);
            this.TB_UserInput.TabIndex = 1;
            this.TB_UserInput.TextChanged += new System.EventHandler(this.TB_UserInput_TextChanged);
            this.TB_UserInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // TB_ChatBotOutput
            // 
            this.TB_ChatBotOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_ChatBotOutput.Enabled = false;
            this.TB_ChatBotOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ChatBotOutput.Location = new System.Drawing.Point(0, 24);
            this.TB_ChatBotOutput.Name = "TB_ChatBotOutput";
            this.TB_ChatBotOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.TB_ChatBotOutput.Size = new System.Drawing.Size(564, 181);
            this.TB_ChatBotOutput.TabIndex = 2;
            this.TB_ChatBotOutput.Text = "";
            this.TB_ChatBotOutput.TextChanged += new System.EventHandler(this.TB_ChatBotOutput_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(100, 79);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TB_ChatBotOutput);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TB_UserInput);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(564, 346);
            this.splitContainer1.SplitterDistance = 228;
            this.splitContainer1.TabIndex = 4;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 24);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chat Bot";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(0, 205);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(564, 23);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.UB_Clear);
            this.panel3.Controls.Add(this.UB_Send);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(58, 90);
            this.panel3.TabIndex = 6;
            // 
            // UB_Clear
            // 
            this.UB_Clear.Location = new System.Drawing.Point(3, 64);
            this.UB_Clear.Name = "UB_Clear";
            this.UB_Clear.Size = new System.Drawing.Size(52, 23);
            this.UB_Clear.TabIndex = 7;
            this.UB_Clear.Text = "Clear";
            this.UB_Clear.UseVisualStyleBackColor = true;
            this.UB_Clear.Click += new System.EventHandler(this.UB_Clear_Click);
            // 
            // UB_Send
            // 
            this.UB_Send.Location = new System.Drawing.Point(3, 3);
            this.UB_Send.Name = "UB_Send";
            this.UB_Send.Size = new System.Drawing.Size(52, 55);
            this.UB_Send.TabIndex = 2;
            this.UB_Send.Text = "Send";
            this.UB_Send.UseVisualStyleBackColor = true;
            this.UB_Send.Click += new System.EventHandler(this.UB_Send_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.L_UName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 24);
            this.panel2.TabIndex = 5;
            // 
            // L_UName
            // 
            this.L_UName.AutoSize = true;
            this.L_UName.Location = new System.Drawing.Point(3, 8);
            this.L_UName.Name = "L_UName";
            this.L_UName.Size = new System.Drawing.Size(26, 13);
            this.L_UName.TabIndex = 1;
            this.L_UName.Text = "You";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSDDB_File,
            this.TSDDB_Edit,
            this.TSDDB_Help});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(664, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSDDB_File
            // 
            this.TSDDB_File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSDDB_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_New,
            this.toolStripSeparator9,
            this.TSMI_SLog,
            this.toolStripSeparator1,
            this.TSMI_Exit});
            this.TSDDB_File.Image = ((System.Drawing.Image)(resources.GetObject("TSDDB_File.Image")));
            this.TSDDB_File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSDDB_File.Name = "TSDDB_File";
            this.TSDDB_File.ShowDropDownArrow = false;
            this.TSDDB_File.Size = new System.Drawing.Size(29, 22);
            this.TSDDB_File.Text = "&File";
            // 
            // TSMI_New
            // 
            this.TSMI_New.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_New.Image")));
            this.TSMI_New.Name = "TSMI_New";
            this.TSMI_New.Size = new System.Drawing.Size(171, 22);
            this.TSMI_New.Text = "New Conversation";
            this.TSMI_New.Click += new System.EventHandler(this.TSMI_New_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(168, 6);
            // 
            // TSMI_SLog
            // 
            this.TSMI_SLog.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_SLog.Image")));
            this.TSMI_SLog.Name = "TSMI_SLog";
            this.TSMI_SLog.Size = new System.Drawing.Size(171, 22);
            this.TSMI_SLog.Text = "Save Log";
            this.TSMI_SLog.Click += new System.EventHandler(this.TSMI_SLog_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // TSMI_Exit
            // 
            this.TSMI_Exit.Name = "TSMI_Exit";
            this.TSMI_Exit.Size = new System.Drawing.Size(171, 22);
            this.TSMI_Exit.Text = "Exit";
            this.TSMI_Exit.Click += new System.EventHandler(this.TSMI_Exit_Click);
            // 
            // TSDDB_Edit
            // 
            this.TSDDB_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSDDB_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Undo,
            this.TSMI_Redo,
            this.toolStripSeparator3,
            this.TSMI_Cut,
            this.TSMI_Copy,
            this.TSMI_Paste,
            this.TSMI_Delete,
            this.toolStripSeparator2,
            this.TSMI_SelectAll,
            this.toolStripSeparator4,
            this.TSMI_Send,
            this.TSMI_Clear,
            this.toolStripSeparator6,
            this.TSMI_Preferences});
            this.TSDDB_Edit.Image = ((System.Drawing.Image)(resources.GetObject("TSDDB_Edit.Image")));
            this.TSDDB_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSDDB_Edit.Name = "TSDDB_Edit";
            this.TSDDB_Edit.ShowDropDownArrow = false;
            this.TSDDB_Edit.Size = new System.Drawing.Size(31, 22);
            this.TSDDB_Edit.Text = "&Edit";
            // 
            // TSMI_Undo
            // 
            this.TSMI_Undo.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_Undo.Image")));
            this.TSMI_Undo.Name = "TSMI_Undo";
            this.TSMI_Undo.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Undo.Text = "Undo";
            this.TSMI_Undo.Click += new System.EventHandler(this.TSMI_Undo_Click);
            // 
            // TSMI_Redo
            // 
            this.TSMI_Redo.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_Redo.Image")));
            this.TSMI_Redo.Name = "TSMI_Redo";
            this.TSMI_Redo.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Redo.Text = "Redo";
            this.TSMI_Redo.Click += new System.EventHandler(this.TSMI_Redo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // TSMI_Cut
            // 
            this.TSMI_Cut.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_Cut.Image")));
            this.TSMI_Cut.Name = "TSMI_Cut";
            this.TSMI_Cut.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Cut.Text = "Cut";
            this.TSMI_Cut.Click += new System.EventHandler(this.TSMI_Cut_Click);
            // 
            // TSMI_Copy
            // 
            this.TSMI_Copy.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_Copy.Image")));
            this.TSMI_Copy.Name = "TSMI_Copy";
            this.TSMI_Copy.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Copy.Text = "Copy";
            this.TSMI_Copy.Click += new System.EventHandler(this.TSMI_Copy_Click);
            // 
            // TSMI_Paste
            // 
            this.TSMI_Paste.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_Paste.Image")));
            this.TSMI_Paste.Name = "TSMI_Paste";
            this.TSMI_Paste.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Paste.Text = "Paste";
            this.TSMI_Paste.Click += new System.EventHandler(this.TSMI_Paste_Click);
            // 
            // TSMI_Delete
            // 
            this.TSMI_Delete.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_Delete.Image")));
            this.TSMI_Delete.Name = "TSMI_Delete";
            this.TSMI_Delete.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Delete.Text = "Delete";
            this.TSMI_Delete.Click += new System.EventHandler(this.TSMI_Delete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // TSMI_SelectAll
            // 
            this.TSMI_SelectAll.Name = "TSMI_SelectAll";
            this.TSMI_SelectAll.Size = new System.Drawing.Size(152, 22);
            this.TSMI_SelectAll.Text = "Select All";
            this.TSMI_SelectAll.Click += new System.EventHandler(this.TSMI_SelectAll_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // TSMI_Send
            // 
            this.TSMI_Send.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_Send.Image")));
            this.TSMI_Send.Name = "TSMI_Send";
            this.TSMI_Send.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Send.Text = "Send";
            this.TSMI_Send.Click += new System.EventHandler(this.TSMI_Send_Click);
            // 
            // TSMI_Clear
            // 
            this.TSMI_Clear.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_CBChat,
            this.TSMI_CUChat});
            this.TSMI_Clear.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_Clear.Image")));
            this.TSMI_Clear.Name = "TSMI_Clear";
            this.TSMI_Clear.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Clear.Text = "Clear";
            // 
            // TSMI_CBChat
            // 
            this.TSMI_CBChat.Name = "TSMI_CBChat";
            this.TSMI_CBChat.Size = new System.Drawing.Size(152, 22);
            this.TSMI_CBChat.Text = "Chat Bot Chat";
            this.TSMI_CBChat.Click += new System.EventHandler(this.TSMI_CBChat_Click);
            // 
            // TSMI_CUChat
            // 
            this.TSMI_CUChat.Name = "TSMI_CUChat";
            this.TSMI_CUChat.Size = new System.Drawing.Size(152, 22);
            this.TSMI_CUChat.Text = "Me Chat";
            this.TSMI_CUChat.Click += new System.EventHandler(this.TSMI_CUChat_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(149, 6);
            // 
            // TSMI_Preferences
            // 
            this.TSMI_Preferences.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Lang,
            this.TSMI_User,
            this.TSMI_BotMode});
            this.TSMI_Preferences.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_Preferences.Image")));
            this.TSMI_Preferences.Name = "TSMI_Preferences";
            this.TSMI_Preferences.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Preferences.Text = "Preferences";
            // 
            // TSMI_Lang
            // 
            this.TSMI_Lang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_LangEnglish,
            this.TSMI_LangSpanish});
            this.TSMI_Lang.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_Lang.Image")));
            this.TSMI_Lang.Name = "TSMI_Lang";
            this.TSMI_Lang.Size = new System.Drawing.Size(154, 22);
            this.TSMI_Lang.Text = "Language";
            // 
            // TSMI_LangEnglish
            // 
            this.TSMI_LangEnglish.Checked = true;
            this.TSMI_LangEnglish.CheckOnClick = true;
            this.TSMI_LangEnglish.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMI_LangEnglish.Name = "TSMI_LangEnglish";
            this.TSMI_LangEnglish.Size = new System.Drawing.Size(152, 22);
            this.TSMI_LangEnglish.Text = "English";
            this.TSMI_LangEnglish.Click += new System.EventHandler(this.TSMI_LangEnglish_Click);
            // 
            // TSMI_LangSpanish
            // 
            this.TSMI_LangSpanish.CheckOnClick = true;
            this.TSMI_LangSpanish.Name = "TSMI_LangSpanish";
            this.TSMI_LangSpanish.Size = new System.Drawing.Size(152, 22);
            this.TSMI_LangSpanish.Text = "Spanish";
            this.TSMI_LangSpanish.Click += new System.EventHandler(this.TSMI_LangSpanish_Click);
            // 
            // TSMI_User
            // 
            this.TSMI_User.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_UCName,
            this.TSMI_UCWMicro});
            this.TSMI_User.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_User.Image")));
            this.TSMI_User.Name = "TSMI_User";
            this.TSMI_User.Size = new System.Drawing.Size(154, 22);
            this.TSMI_User.Text = "User";
            // 
            // TSMI_UCName
            // 
            this.TSMI_UCName.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_UCName.Image")));
            this.TSMI_UCName.Name = "TSMI_UCName";
            this.TSMI_UCName.Size = new System.Drawing.Size(208, 22);
            this.TSMI_UCName.Text = "Change Name";
            this.TSMI_UCName.Click += new System.EventHandler(this.TSMI_UCName_Click);
            // 
            // TSMI_UCWMicro
            // 
            this.TSMI_UCWMicro.CheckOnClick = true;
            this.TSMI_UCWMicro.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_UCWMicro.Image")));
            this.TSMI_UCWMicro.Name = "TSMI_UCWMicro";
            this.TSMI_UCWMicro.Size = new System.Drawing.Size(208, 22);
            this.TSMI_UCWMicro.Text = "Control with Microphone";
            this.TSMI_UCWMicro.Click += new System.EventHandler(this.TSMI_UCWMicro_Click);
            // 
            // TSMI_BotMode
            // 
            this.TSMI_BotMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_ModeHelp,
            this.TSMI_ModeVS});
            this.TSMI_BotMode.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_BotMode.Image")));
            this.TSMI_BotMode.Name = "TSMI_BotMode";
            this.TSMI_BotMode.Size = new System.Drawing.Size(154, 22);
            this.TSMI_BotMode.Text = "Chat Bot Mode";
            // 
            // TSMI_ModeHelp
            // 
            this.TSMI_ModeHelp.Checked = true;
            this.TSMI_ModeHelp.CheckOnClick = true;
            this.TSMI_ModeHelp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMI_ModeHelp.Name = "TSMI_ModeHelp";
            this.TSMI_ModeHelp.Size = new System.Drawing.Size(152, 22);
            this.TSMI_ModeHelp.Text = "Help";
            this.TSMI_ModeHelp.Click += new System.EventHandler(this.TSMI_ModeHelp_Click);
            // 
            // TSMI_ModeVS
            // 
            this.TSMI_ModeVS.CheckOnClick = true;
            this.TSMI_ModeVS.Enabled = false;
            this.TSMI_ModeVS.Name = "TSMI_ModeVS";
            this.TSMI_ModeVS.Size = new System.Drawing.Size(152, 22);
            this.TSMI_ModeVS.Text = "VS";
            this.TSMI_ModeVS.Click += new System.EventHandler(this.TSMI_ModeVS_Click);
            // 
            // TSDDB_Help
            // 
            this.TSDDB_Help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSDDB_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_About,
            this.toolStripSeparator5,
            this.TSMI_CList});
            this.TSDDB_Help.Image = ((System.Drawing.Image)(resources.GetObject("TSDDB_Help.Image")));
            this.TSDDB_Help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSDDB_Help.Name = "TSDDB_Help";
            this.TSDDB_Help.ShowDropDownArrow = false;
            this.TSDDB_Help.Size = new System.Drawing.Size(36, 22);
            this.TSDDB_Help.Text = "&Help";
            // 
            // TSMI_About
            // 
            this.TSMI_About.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_About.Image")));
            this.TSMI_About.Name = "TSMI_About";
            this.TSMI_About.Size = new System.Drawing.Size(152, 22);
            this.TSMI_About.Text = "About";
            this.TSMI_About.Click += new System.EventHandler(this.TSMI_About_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // TSMI_CList
            // 
            this.TSMI_CList.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_CList.Image")));
            this.TSMI_CList.Name = "TSMI_CList";
            this.TSMI_CList.Size = new System.Drawing.Size(152, 22);
            this.TSMI_CList.Text = "Command List";
            this.TSMI_CList.Click += new System.EventHandler(this.TSMI_CList_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.L_BotStatus,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 440);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(664, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // L_BotStatus
            // 
            this.L_BotStatus.Name = "L_BotStatus";
            this.L_BotStatus.Size = new System.Drawing.Size(95, 17);
            this.L_BotStatus.Text = "Status: Waiting...";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(352, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "By/Por Hevedy";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(100, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(564, 54);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox3.Location = new System.Drawing.Point(0, 425);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(664, 15);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMS_Cut,
            this.CMS_Copy,
            this.CMS_Paste,
            this.CMS_Delete,
            this.toolStripSeparator8,
            this.CMS_SelectAll,
            this.toolStripSeparator7,
            this.CMS_Send});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 148);
            // 
            // CMS_Cut
            // 
            this.CMS_Cut.Image = ((System.Drawing.Image)(resources.GetObject("CMS_Cut.Image")));
            this.CMS_Cut.Name = "CMS_Cut";
            this.CMS_Cut.Size = new System.Drawing.Size(122, 22);
            this.CMS_Cut.Text = "Cut";
            // 
            // CMS_Copy
            // 
            this.CMS_Copy.Image = ((System.Drawing.Image)(resources.GetObject("CMS_Copy.Image")));
            this.CMS_Copy.Name = "CMS_Copy";
            this.CMS_Copy.Size = new System.Drawing.Size(122, 22);
            this.CMS_Copy.Text = "Copy";
            // 
            // CMS_Paste
            // 
            this.CMS_Paste.Image = ((System.Drawing.Image)(resources.GetObject("CMS_Paste.Image")));
            this.CMS_Paste.Name = "CMS_Paste";
            this.CMS_Paste.Size = new System.Drawing.Size(122, 22);
            this.CMS_Paste.Text = "Paste";
            // 
            // CMS_Delete
            // 
            this.CMS_Delete.Image = ((System.Drawing.Image)(resources.GetObject("CMS_Delete.Image")));
            this.CMS_Delete.Name = "CMS_Delete";
            this.CMS_Delete.Size = new System.Drawing.Size(122, 22);
            this.CMS_Delete.Text = "Delete";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(119, 6);
            // 
            // CMS_SelectAll
            // 
            this.CMS_SelectAll.Name = "CMS_SelectAll";
            this.CMS_SelectAll.Size = new System.Drawing.Size(122, 22);
            this.CMS_SelectAll.Text = "Select All";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(119, 6);
            // 
            // CMS_Send
            // 
            this.CMS_Send.Image = ((System.Drawing.Image)(resources.GetObject("CMS_Send.Image")));
            this.CMS_Send.Name = "CMS_Send";
            this.CMS_Send.Size = new System.Drawing.Size(122, 22);
            this.CMS_Send.Text = "Send";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(664, 462);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Bot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AllAPPClose);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TB_UserInput;
        private System.Windows.Forms.RichTextBox TB_ChatBotOutput;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton TSDDB_File;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Exit;
        private System.Windows.Forms.ToolStripDropDownButton TSDDB_Help;
        private System.Windows.Forms.ToolStripMenuItem TSMI_About;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button UB_Send;
        private System.Windows.Forms.Button UB_Clear;
        private System.Windows.Forms.ToolStripDropDownButton TSDDB_Edit;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Undo;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Redo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Cut;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Copy;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Paste;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Send;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_UName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem TSMI_CList;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Clear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Preferences;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Lang;
        private System.Windows.Forms.ToolStripMenuItem TSMI_LangEnglish;
        private System.Windows.Forms.ToolStripMenuItem TSMI_User;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UCName;
        private System.Windows.Forms.ToolStripMenuItem TSMI_BotMode;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ModeHelp;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ModeVS;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem TSMI_LangSpanish;
        private System.Windows.Forms.ToolStripMenuItem TSMI_CBChat;
        private System.Windows.Forms.ToolStripMenuItem TSMI_CUChat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CMS_Cut;
        private System.Windows.Forms.ToolStripMenuItem CMS_Copy;
        private System.Windows.Forms.ToolStripMenuItem CMS_Paste;
        private System.Windows.Forms.ToolStripMenuItem CMS_Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem CMS_SelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem CMS_Send;
        private System.Windows.Forms.ToolStripMenuItem TSMI_New;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripStatusLabel L_BotStatus;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UCWMicro;
    }
}


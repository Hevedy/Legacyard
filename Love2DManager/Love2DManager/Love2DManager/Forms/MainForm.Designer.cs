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

namespace Love2DManager
{
    partial class MainForm
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
            this.CB_Console = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RB_FCompile = new System.Windows.Forms.RadioButton();
            this.RB_FCompilePack = new System.Windows.Forms.RadioButton();
            this.CB_Run = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.B_BuildAll = new System.Windows.Forms.Button();
            this.RTB_Console = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.B_EditP = new System.Windows.Forms.Button();
            this.L_PGameNameT = new System.Windows.Forms.Label();
            this.L_PLastBuildT = new System.Windows.Forms.Label();
            this.L_PVersionT = new System.Windows.Forms.Label();
            this.L_PAutorT = new System.Windows.Forms.Label();
            this.L_PNameT = new System.Windows.Forms.Label();
            this.L_PGameName = new System.Windows.Forms.Label();
            this.L_PLastBuild = new System.Windows.Forms.Label();
            this.L_PVersion = new System.Windows.Forms.Label();
            this.L_PAutor = new System.Windows.Forms.Label();
            this.L_PName = new System.Windows.Forms.Label();
            this.B_DeleteP = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.B_AddP = new System.Windows.Forms.Button();
            this.B_LaunchGame = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.B_Settings = new System.Windows.Forms.Button();
            this.B_LuaEditor = new System.Windows.Forms.Button();
            this.B_Root = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.B_GameReleasePackage = new System.Windows.Forms.Button();
            this.B_GameI = new System.Windows.Forms.Button();
            this.B_Shaders = new System.Windows.Forms.Button();
            this.B_Resources = new System.Windows.Forms.Button();
            this.B_Src = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_Console
            // 
            this.CB_Console.AutoSize = true;
            this.CB_Console.Checked = true;
            this.CB_Console.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_Console.Location = new System.Drawing.Point(19, 24);
            this.CB_Console.Name = "CB_Console";
            this.CB_Console.Size = new System.Drawing.Size(125, 17);
            this.CB_Console.TabIndex = 1;
            this.CB_Console.Text = "Open debug console";
            this.CB_Console.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // RB_FCompile
            // 
            this.RB_FCompile.AutoSize = true;
            this.RB_FCompile.Checked = true;
            this.RB_FCompile.Location = new System.Drawing.Point(15, 23);
            this.RB_FCompile.Name = "RB_FCompile";
            this.RB_FCompile.Size = new System.Drawing.Size(89, 17);
            this.RB_FCompile.TabIndex = 3;
            this.RB_FCompile.TabStop = true;
            this.RB_FCompile.Text = "Full recompile";
            this.RB_FCompile.UseVisualStyleBackColor = true;
            // 
            // RB_FCompilePack
            // 
            this.RB_FCompilePack.AutoSize = true;
            this.RB_FCompilePack.Location = new System.Drawing.Point(15, 46);
            this.RB_FCompilePack.Name = "RB_FCompilePack";
            this.RB_FCompilePack.Size = new System.Drawing.Size(173, 17);
            this.RB_FCompilePack.TabIndex = 4;
            this.RB_FCompilePack.Text = "Full recompile + Package game";
            this.RB_FCompilePack.UseVisualStyleBackColor = true;
            // 
            // CB_Run
            // 
            this.CB_Run.AutoSize = true;
            this.CB_Run.Checked = true;
            this.CB_Run.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_Run.Location = new System.Drawing.Point(18, 24);
            this.CB_Run.Name = "CB_Run";
            this.CB_Run.Size = new System.Drawing.Size(93, 17);
            this.CB_Run.TabIndex = 5;
            this.CB_Run.Text = "Run the game";
            this.CB_Run.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_FCompile);
            this.groupBox1.Controls.Add(this.RB_FCompilePack);
            this.groupBox1.Location = new System.Drawing.Point(188, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 80);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Build Mode";
            // 
            // B_BuildAll
            // 
            this.B_BuildAll.Location = new System.Drawing.Point(16, 60);
            this.B_BuildAll.Name = "B_BuildAll";
            this.B_BuildAll.Size = new System.Drawing.Size(135, 35);
            this.B_BuildAll.TabIndex = 7;
            this.B_BuildAll.Text = "Build";
            this.B_BuildAll.UseVisualStyleBackColor = true;
            this.B_BuildAll.Click += new System.EventHandler(this.B_BuildAll_Click);
            // 
            // RTB_Console
            // 
            this.RTB_Console.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.RTB_Console.Location = new System.Drawing.Point(15, 19);
            this.RTB_Console.Name = "RTB_Console";
            this.RTB_Console.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.RTB_Console.Size = new System.Drawing.Size(494, 160);
            this.RTB_Console.TabIndex = 8;
            this.RTB_Console.Text = "Love 2D Engine - Frontend Launcher started";
            this.RTB_Console.TextChanged += new System.EventHandler(this.RTB_Console_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 483);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(725, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(150, 17);
            this.toolStripStatusLabel1.Text = "By Hevedy";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(466, 17);
            this.toolStripStatusLabel3.Text = "                                                                                 " +
    "                                                                        ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(82, 17);
            this.toolStripStatusLabel2.Text = "Version 0.5.0.3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RTB_Console);
            this.groupBox2.Location = new System.Drawing.Point(188, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 185);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Console";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CB_Run);
            this.groupBox3.Location = new System.Drawing.Point(407, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(137, 80);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "After Build Options";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.B_EditP);
            this.groupBox4.Controls.Add(this.L_PGameNameT);
            this.groupBox4.Controls.Add(this.L_PLastBuildT);
            this.groupBox4.Controls.Add(this.L_PVersionT);
            this.groupBox4.Controls.Add(this.L_PAutorT);
            this.groupBox4.Controls.Add(this.L_PNameT);
            this.groupBox4.Controls.Add(this.L_PGameName);
            this.groupBox4.Controls.Add(this.L_PLastBuild);
            this.groupBox4.Controls.Add(this.L_PVersion);
            this.groupBox4.Controls.Add(this.L_PAutor);
            this.groupBox4.Controls.Add(this.L_PName);
            this.groupBox4.Controls.Add(this.B_DeleteP);
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Controls.Add(this.B_AddP);
            this.groupBox4.Location = new System.Drawing.Point(188, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(525, 180);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Project Selection";
            // 
            // B_EditP
            // 
            this.B_EditP.Location = new System.Drawing.Point(112, 139);
            this.B_EditP.Name = "B_EditP";
            this.B_EditP.Size = new System.Drawing.Size(41, 23);
            this.B_EditP.TabIndex = 14;
            this.B_EditP.Text = "Edit";
            this.B_EditP.UseVisualStyleBackColor = true;
            this.B_EditP.Click += new System.EventHandler(this.B_EditP_Click);
            // 
            // L_PGameNameT
            // 
            this.L_PGameNameT.AutoSize = true;
            this.L_PGameNameT.Location = new System.Drawing.Point(325, 38);
            this.L_PGameNameT.Name = "L_PGameNameT";
            this.L_PGameNameT.Size = new System.Drawing.Size(31, 13);
            this.L_PGameNameT.TabIndex = 12;
            this.L_PGameNameT.Text = "none";
            // 
            // L_PLastBuildT
            // 
            this.L_PLastBuildT.AutoSize = true;
            this.L_PLastBuildT.Location = new System.Drawing.Point(325, 110);
            this.L_PLastBuildT.Name = "L_PLastBuildT";
            this.L_PLastBuildT.Size = new System.Drawing.Size(31, 13);
            this.L_PLastBuildT.TabIndex = 11;
            this.L_PLastBuildT.Text = "none";
            // 
            // L_PVersionT
            // 
            this.L_PVersionT.AutoSize = true;
            this.L_PVersionT.Location = new System.Drawing.Point(325, 64);
            this.L_PVersionT.Name = "L_PVersionT";
            this.L_PVersionT.Size = new System.Drawing.Size(31, 13);
            this.L_PVersionT.TabIndex = 10;
            this.L_PVersionT.Text = "none";
            // 
            // L_PAutorT
            // 
            this.L_PAutorT.AutoSize = true;
            this.L_PAutorT.Location = new System.Drawing.Point(325, 51);
            this.L_PAutorT.Name = "L_PAutorT";
            this.L_PAutorT.Size = new System.Drawing.Size(31, 13);
            this.L_PAutorT.TabIndex = 9;
            this.L_PAutorT.Text = "none";
            // 
            // L_PNameT
            // 
            this.L_PNameT.AutoSize = true;
            this.L_PNameT.Location = new System.Drawing.Point(325, 25);
            this.L_PNameT.Name = "L_PNameT";
            this.L_PNameT.Size = new System.Drawing.Size(31, 13);
            this.L_PNameT.TabIndex = 8;
            this.L_PNameT.Text = "none";
            // 
            // L_PGameName
            // 
            this.L_PGameName.AutoSize = true;
            this.L_PGameName.Location = new System.Drawing.Point(245, 38);
            this.L_PGameName.Name = "L_PGameName";
            this.L_PGameName.Size = new System.Drawing.Size(69, 13);
            this.L_PGameName.TabIndex = 7;
            this.L_PGameName.Text = "Game Name:";
            // 
            // L_PLastBuild
            // 
            this.L_PLastBuild.AutoSize = true;
            this.L_PLastBuild.Location = new System.Drawing.Point(245, 110);
            this.L_PLastBuild.Name = "L_PLastBuild";
            this.L_PLastBuild.Size = new System.Drawing.Size(56, 13);
            this.L_PLastBuild.TabIndex = 6;
            this.L_PLastBuild.Text = "Last Build:";
            // 
            // L_PVersion
            // 
            this.L_PVersion.AutoSize = true;
            this.L_PVersion.Location = new System.Drawing.Point(245, 64);
            this.L_PVersion.Name = "L_PVersion";
            this.L_PVersion.Size = new System.Drawing.Size(45, 13);
            this.L_PVersion.TabIndex = 5;
            this.L_PVersion.Text = "Version:";
            // 
            // L_PAutor
            // 
            this.L_PAutor.AutoSize = true;
            this.L_PAutor.Location = new System.Drawing.Point(245, 51);
            this.L_PAutor.Name = "L_PAutor";
            this.L_PAutor.Size = new System.Drawing.Size(35, 13);
            this.L_PAutor.TabIndex = 4;
            this.L_PAutor.Text = "Autor:";
            // 
            // L_PName
            // 
            this.L_PName.AutoSize = true;
            this.L_PName.Location = new System.Drawing.Point(245, 25);
            this.L_PName.Name = "L_PName";
            this.L_PName.Size = new System.Drawing.Size(74, 13);
            this.L_PName.TabIndex = 3;
            this.L_PName.Text = "Project Name:";
            // 
            // B_DeleteP
            // 
            this.B_DeleteP.Location = new System.Drawing.Point(179, 139);
            this.B_DeleteP.Name = "B_DeleteP";
            this.B_DeleteP.Size = new System.Drawing.Size(60, 23);
            this.B_DeleteP.TabIndex = 2;
            this.B_DeleteP.Text = "Delete";
            this.B_DeleteP.UseVisualStyleBackColor = true;
            this.B_DeleteP.Click += new System.EventHandler(this.B_DeleteP_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 108);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // B_AddP
            // 
            this.B_AddP.Location = new System.Drawing.Point(18, 139);
            this.B_AddP.Name = "B_AddP";
            this.B_AddP.Size = new System.Drawing.Size(88, 23);
            this.B_AddP.TabIndex = 0;
            this.B_AddP.Text = "Add Project";
            this.B_AddP.UseVisualStyleBackColor = true;
            this.B_AddP.Click += new System.EventHandler(this.B_AddP_Click);
            // 
            // B_LaunchGame
            // 
            this.B_LaunchGame.Location = new System.Drawing.Point(16, 19);
            this.B_LaunchGame.Name = "B_LaunchGame";
            this.B_LaunchGame.Size = new System.Drawing.Size(135, 35);
            this.B_LaunchGame.TabIndex = 14;
            this.B_LaunchGame.Text = "Launch Game";
            this.B_LaunchGame.UseVisualStyleBackColor = true;
            this.B_LaunchGame.Click += new System.EventHandler(this.B_LaunchGame_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.B_LaunchGame);
            this.groupBox5.Controls.Add(this.B_Settings);
            this.groupBox5.Controls.Add(this.B_BuildAll);
            this.groupBox5.Controls.Add(this.B_LuaEditor);
            this.groupBox5.Location = new System.Drawing.Point(12, 97);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(170, 171);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tools";
            // 
            // B_Settings
            // 
            this.B_Settings.Location = new System.Drawing.Point(16, 141);
            this.B_Settings.Name = "B_Settings";
            this.B_Settings.Size = new System.Drawing.Size(135, 23);
            this.B_Settings.TabIndex = 17;
            this.B_Settings.Text = "Change Editor";
            this.B_Settings.UseVisualStyleBackColor = true;
            this.B_Settings.Click += new System.EventHandler(this.B_Settings_Click);
            // 
            // B_LuaEditor
            // 
            this.B_LuaEditor.Location = new System.Drawing.Point(16, 112);
            this.B_LuaEditor.Name = "B_LuaEditor";
            this.B_LuaEditor.Size = new System.Drawing.Size(135, 23);
            this.B_LuaEditor.TabIndex = 16;
            this.B_LuaEditor.Text = "Lua Editor";
            this.B_LuaEditor.UseVisualStyleBackColor = true;
            this.B_LuaEditor.Click += new System.EventHandler(this.B_LuaEditor_Click);
            // 
            // B_Root
            // 
            this.B_Root.Location = new System.Drawing.Point(16, 19);
            this.B_Root.Name = "B_Root";
            this.B_Root.Size = new System.Drawing.Size(135, 23);
            this.B_Root.TabIndex = 0;
            this.B_Root.Text = "Root";
            this.B_Root.UseVisualStyleBackColor = true;
            this.B_Root.Click += new System.EventHandler(this.B_Root_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.B_GameReleasePackage);
            this.groupBox6.Controls.Add(this.B_GameI);
            this.groupBox6.Controls.Add(this.B_Shaders);
            this.groupBox6.Controls.Add(this.B_Resources);
            this.groupBox6.Controls.Add(this.B_Src);
            this.groupBox6.Controls.Add(this.B_Root);
            this.groupBox6.Location = new System.Drawing.Point(12, 275);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(170, 194);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Game Shortcuts";
            // 
            // B_GameReleasePackage
            // 
            this.B_GameReleasePackage.Location = new System.Drawing.Point(16, 164);
            this.B_GameReleasePackage.Name = "B_GameReleasePackage";
            this.B_GameReleasePackage.Size = new System.Drawing.Size(135, 23);
            this.B_GameReleasePackage.TabIndex = 5;
            this.B_GameReleasePackage.Text = "Game Release Files";
            this.B_GameReleasePackage.UseVisualStyleBackColor = true;
            this.B_GameReleasePackage.Click += new System.EventHandler(this.B_GameReleasePackage_Click);
            // 
            // B_GameI
            // 
            this.B_GameI.Location = new System.Drawing.Point(16, 135);
            this.B_GameI.Name = "B_GameI";
            this.B_GameI.Size = new System.Drawing.Size(135, 23);
            this.B_GameI.TabIndex = 4;
            this.B_GameI.Text = "Game Internal";
            this.B_GameI.UseVisualStyleBackColor = true;
            this.B_GameI.Click += new System.EventHandler(this.B_GameI_Click);
            // 
            // B_Shaders
            // 
            this.B_Shaders.Location = new System.Drawing.Point(16, 77);
            this.B_Shaders.Name = "B_Shaders";
            this.B_Shaders.Size = new System.Drawing.Size(135, 23);
            this.B_Shaders.TabIndex = 3;
            this.B_Shaders.Text = "Shaders";
            this.B_Shaders.UseVisualStyleBackColor = true;
            this.B_Shaders.Click += new System.EventHandler(this.B_Shaders_Click);
            // 
            // B_Resources
            // 
            this.B_Resources.Location = new System.Drawing.Point(16, 106);
            this.B_Resources.Name = "B_Resources";
            this.B_Resources.Size = new System.Drawing.Size(135, 23);
            this.B_Resources.TabIndex = 2;
            this.B_Resources.Text = "Resources";
            this.B_Resources.UseVisualStyleBackColor = true;
            this.B_Resources.Click += new System.EventHandler(this.B_Resources_Click);
            // 
            // B_Src
            // 
            this.B_Src.Location = new System.Drawing.Point(16, 48);
            this.B_Src.Name = "B_Src";
            this.B_Src.Size = new System.Drawing.Size(135, 23);
            this.B_Src.TabIndex = 1;
            this.B_Src.Text = "Src";
            this.B_Src.UseVisualStyleBackColor = true;
            this.B_Src.Click += new System.EventHandler(this.B_Src_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.CB_Console);
            this.groupBox7.Location = new System.Drawing.Point(550, 198);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(163, 80);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Launch Options";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 505);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Love 2D Game Engine - Frontened";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CB_Console;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton RB_FCompile;
        private System.Windows.Forms.RadioButton RB_FCompilePack;
        private System.Windows.Forms.CheckBox CB_Run;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button B_BuildAll;
        private System.Windows.Forms.RichTextBox RTB_Console;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button B_AddP;
        private System.Windows.Forms.Button B_DeleteP;
        private System.Windows.Forms.Label L_PGameName;
        private System.Windows.Forms.Label L_PLastBuild;
        private System.Windows.Forms.Label L_PVersion;
        private System.Windows.Forms.Label L_PAutor;
        private System.Windows.Forms.Label L_PName;
        private System.Windows.Forms.Label L_PGameNameT;
        private System.Windows.Forms.Label L_PLastBuildT;
        private System.Windows.Forms.Label L_PVersionT;
        private System.Windows.Forms.Label L_PAutorT;
        private System.Windows.Forms.Label L_PNameT;
        private System.Windows.Forms.Button B_EditP;
        private System.Windows.Forms.Button B_LaunchGame;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button B_Root;
        private System.Windows.Forms.Button B_LuaEditor;
        private System.Windows.Forms.Button B_Settings;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button B_Shaders;
        private System.Windows.Forms.Button B_Resources;
        private System.Windows.Forms.Button B_Src;
        private System.Windows.Forms.Button B_GameI;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button B_GameReleasePackage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}


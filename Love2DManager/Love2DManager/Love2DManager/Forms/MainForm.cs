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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Security;
using System.Security.Cryptography;
using Love2DManager.Properties;
using Ionic.Zip;

namespace Love2DManager
{
    public partial class MainForm : Form
    {
        string projectname = @"";
        string gamename = @"";
        string autorname = @"";
        string buildversion = @"";
        string lastbuild = @"";

        //This is for logics
        const string actualengineprocess = @"";

        public MainForm()
        {
            InitializeComponent();
            Global_Vars();
            //ProjectListA();
            GetAllfiles();
        }

        public void Global_Vars()
        {

        }

        public void Ini_StartMain()
        {
            string curDir = Directory.GetCurrentDirectory();

            //IniParser parser = new IniParser(curDir + @"\T2DEProjects.ini");

            String newMessage;

            //newMessage = parser.GetSetting("Project", "msgpart1");
            //newMessage += parser.GetSetting("appsettings", "msgpart2");
            //newMessage += parser.GetSetting("punctuation", "ex");
            //parser.AddSetting("punctuation", "ex");
        }

        //ConsoleA1.ConsoleWrite_BuildAll_A();
        #region ConsoleWriteTexts

        public void ConsoleWrite_ScrollToEnd()
        {
            RTB_Console.SelectionStart = RTB_Console.Text.Length;
            RTB_Console.ScrollToCaret();
        }

        public void ConsoleWrite_Space()
        {
            RTB_Console.Text = RTB_Console.Text + Environment.NewLine + ">_";
        }

        public void ConsoleWrite_Line()
        {
            RTB_Console.Text = RTB_Console.Text + Environment.NewLine + ":-";
        }

        public void ConsoleWrite_OpenGameShortcut(string actualengineprocess)
        {
            ConsoleWrite_Line();
            RTB_Console.Text = RTB_Console.Text + Environment.NewLine + "::T2DE::-- Opening " +
                                "the directory " + "'" + actualengineprocess + "'" + " please wait...";
            RTB_Console.Text = RTB_Console.Text + Environment.NewLine + "::T2DE::-- Directory opened";
            //ConsoleWrite_Space();
            ConsoleWrite_ScrollToEnd();
        }

        public void ConsoleWrite_StartProcess(string actualengineprocess)
        {
            ConsoleWrite_Line();
            RTB_Console.Text = RTB_Console.Text + Environment.NewLine + "::T2DE::-- Opening " +
                                "the default " + "'" + actualengineprocess + "'" + " please wait...";
            RTB_Console.Text = RTB_Console.Text + Environment.NewLine + "::T2DE::-- " + actualengineprocess + " opened";
            //ConsoleWrite_Space();
            ConsoleWrite_ScrollToEnd();
        }

        public void ConsoleWrite_BuildAll_A()
        {
            RTB_Console.Text = RTB_Console.Text + Environment.NewLine + ":-";
        }

        public void ConsoleWrite_BuildAll_B()
        {

        }

        public void ConsoleWrite_BuildAll_C()
        {

        }

        public void ConsoleWrite_BuildAll_Compress()
        {

        }

        public void ConsoleWrite_BuildAll_CompressPackage()
        {

        }

        public void ConsoleWrite_End()
        {

        }

        public void ConsoleWrite_Close()
        {

        }

        #endregion 

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void B_BuildAll_Click(object sender, EventArgs e)
        {
            BuildLogic();
        }

        public void BuildGameLauncher(string f)
        {
            string PFName = listBox1.SelectedItem as String;
            string curDir = Directory.GetCurrentDirectory();

            Process startInfo = new Process();
            startInfo.StartInfo.FileName = curDir + @"\..\Games\" + PFName + @"\" + L_PGameNameT.Text + @".exe";
            startInfo.StartInfo.Arguments = f;
            startInfo.Start();
        }

        private void BuildLogic()
        {
            //Utils Ref
            string PFName = listBox1.SelectedItem as String;
            string PFGameName = L_PGameNameT.Text;
            string curDir = Directory.GetCurrentDirectory();
            //End ref

            B_LaunchGame.Enabled = false;
            DisableButtons("True");
            if (RB_FCompile.Checked == true && RB_FCompilePack.Checked == false)
            {
                CreateTemps("False");

            }
            else if (RB_FCompile.Checked == false && RB_FCompilePack.Checked == true)
            {
                CreateTemps("True");
            }

        }
        private void LaunchLogic()
        {
            //Utils Ref
            string PFName = listBox1.SelectedItem as String;
            string PFGameName = L_PGameNameT.Text;
            string curDir = Directory.GetCurrentDirectory();
            //End ref

            if (CB_Run.Checked == true)
            {
                if (CB_Console.Checked == true)
                {
                    //EnabledButtons("True");
                    StartGameBuildFiles(@"--console");
                }
                else
                {
                    //EnabledButtons("True");
                    StartGameBuildFiles(@"");
                }
            }
            else
            {
                EnabledButtons("True");
                //Procces Succes
            }

        }
        private void CreateTemps(string iszip)
        {
            //Utils Ref
            string PFName = listBox1.SelectedItem as String;
            string PFGameName = L_PGameNameT.Text;
            string curDir = Directory.GetCurrentDirectory();

            //Remove the old Temps && Build
            try
            {
                Directory.Delete(curDir + @"\..\Games\" + PFName + @"\Temp", true);
                Directory.Delete(curDir + @"\..\Games\" + PFName + @"\Build", true);

                Directory.CreateDirectory(curDir + @"\..\Games\" + PFName + @"\Temp");
                Directory.CreateDirectory(curDir + @"\..\Games\" + PFName + @"\Temp\Config");
                Directory.CreateDirectory(curDir + @"\..\Games\" + PFName + @"\Temp\Resources");
                Directory.CreateDirectory(curDir + @"\..\Games\" + PFName + @"\Temp\Shaders");

                Directory.CreateDirectory(curDir + @"\..\Games\" + PFName + @"\Build");
            }
            catch
            {
            }
            finally
            {
            }

            string SourcePath = curDir + @"\..\Games\" + PFName + @"\Src";
            string DestinationPath = curDir + @"\..\Games\" + PFName + @"\Temp";
            //End ref

            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(SourcePath, "*",
                SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(SourcePath, DestinationPath));

            //Copy all the files
            foreach (string newPath in Directory.GetFiles(SourcePath, "*.*",
                SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(SourcePath, DestinationPath));

            /////////////////////////////////////////////////////////////////////// Config
            SourcePath = curDir + @"\..\Games\" + PFName + @"\Config";
            DestinationPath = curDir + @"\..\Games\" + PFName + @"\Temp\Config";

            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(SourcePath, "*",
                SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(SourcePath, DestinationPath));

            //Copy all the files
            foreach (string newPath in Directory.GetFiles(SourcePath, "*.*",
                SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(SourcePath, DestinationPath));

            /////////////////////////////////////////////////////////////////////// Resources
            SourcePath = curDir + @"\..\Games\" + PFName + @"\Resources";
            DestinationPath = curDir + @"\..\Games\" + PFName + @"\Temp\Resources";

            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(SourcePath, "*",
                SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(SourcePath, DestinationPath));

            //Copy all the files
            foreach (string newPath in Directory.GetFiles(SourcePath, "*.*",
                SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(SourcePath, DestinationPath));

            /////////////////////////////////////////////////////////////////////// Shaders
            SourcePath = curDir + @"\..\Games\" + PFName + @"\Shaders";
            DestinationPath = curDir + @"\..\Games\" + PFName + @"\Temp\Shaders";

            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(SourcePath, "*",
                SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(SourcePath, DestinationPath));

            //Copy all the files
            foreach (string newPath in Directory.GetFiles(SourcePath, "*.*",
                SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(SourcePath, DestinationPath));


            /////////////////////////////////////////////////////////////////////// All to Build
            SourcePath = curDir + @"\..\Games\" + PFName + @"\Temp";
            DestinationPath = curDir + @"\..\Games\" + PFName + @"\Build";

            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(SourcePath, "*",
                SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(SourcePath, DestinationPath));

            //Copy all the files
            foreach (string newPath in Directory.GetFiles(SourcePath, "*.*",
                SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(SourcePath, DestinationPath));

            try
            {
                //Directory.Delete(curDir + @"\..\Games\" + PFName + @"\Temp\Src", true);

                //Directory.Move(curDir + @"\..\Games\" + PFName + @"\Src", curDir + @"\..\Games\" + NewPFName);
                //File.Copy(curDir + @"\..\Games\" + NewPFName + @"\" + PFGameName + @".exe", curDir + @"\..\Games\" + NewPFName + @"\" + TB_PGameName.Text + @".exe");
                //System.IO.File.Delete(curDir + @"\Projects\" + PFName + ".ini");

            }
            catch
            {
            }
            finally
            {
            }
            if (iszip == "True")
            {
                ZipAllFiles();
            }
            else
            {
                LaunchLogic();
            }
        }

        private void ZipAllFiles()
        {
            //Utils Ref
            string PFName = listBox1.SelectedItem as String;
            string PFGameName = L_PGameNameT.Text;
            string curDir = Directory.GetCurrentDirectory();
            //End ref

            try
            {
                File.Delete(curDir + @"\..\Games\" + PFName + @"\Package\" + PFGameName + @".tpkg");
            }
            catch
            {
            }
            finally
            {
            }

            using (ZipFile zip = new ZipFile())
            {
                zip.AddDirectory(curDir + @"\..\Games\" + PFName + @"\Temp");
                zip.Comment = "This package was created at " + System.DateTime.Now.ToString("G");
                zip.Save(curDir + @"\..\Games\" + PFName + @"\Package\" + PFGameName + @".tpkg");
            }

            CreateReleaseGame();
            //JoinZipANDGame();

        }

        private void JoinZipANDGame()
        {
            //Utils Ref
            string PFName = listBox1.SelectedItem as String;
            string PFGameName = L_PGameNameT.Text;
            string curDir = Directory.GetCurrentDirectory();

            string EngineEXE = curDir + @"\..\Games\" + PFName + @"\GameRelease\" + PFGameName + @".exe";
            string GamePackage = curDir + @"\..\Games\" + PFName + @"\Package\" + PFGameName + @".tpkg";
            string GameEXE = curDir + @"\..\Games\" + PFName + @"\GameRelease\" + PFGameName + @".exe";
            //End ref

            //Here compiler
            //MiniGameCompiler.exe for now external
            try
            {
                File.Copy(curDir + @"\" + @"MiniGameCompiler.exe", curDir + @"\..\Games\" + PFName + @"\GameRelease\" + @"MiniGameCompiler.exe");
                //File.Copy((EngineEXE GamePackage), GameEXE);

            }
            catch
            {
            }
            finally
            {
            }

            //Final
            LaunchTheCompiler();

        }

        public void LaunchTheCompiler()
        {
            string PFName = listBox1.SelectedItem as String;
            string PFGameName = L_PGameNameT.Text;
            string curDir = Directory.GetCurrentDirectory();

            Process startInfo = new Process();
            startInfo.StartInfo.FileName = curDir + @"\..\Games\" + PFName + @"\GameRelease\" + @"MiniGameCompiler.exe";
            startInfo.StartInfo.Arguments = @"..\Games\" + PFName + @"\GameRelease\" + PFGameName + @".tpkg";
            startInfo.Start();
            startInfo.WaitForExit();

            try
            {
                File.Delete(curDir + @"\..\Games\" + PFName + @"\GameRelease\" + PFGameName + @".tpkg");
                File.Delete(curDir + @"\..\Games\" + PFName + @"\GameRelease\" + @"MiniGameCompiler.exe");
                //File.Copy((EngineEXE GamePackage), GameEXE);

            }
            catch
            {
            }
            finally
            {
            }

            //End ?
            LaunchLogic();
        }

        private void CreateReleaseGame()
        {
            //Utils Ref
            string PFName = listBox1.SelectedItem as String;
            string PFGameName = L_PGameNameT.Text;
            string curDir = Directory.GetCurrentDirectory();
            //End ref

            try
            {
                Directory.Delete(curDir + @"\..\Games\" + PFName + @"\GameRelease", true);
                Directory.CreateDirectory(curDir + @"\..\Games\" + PFName + @"\GameRelease");


                File.Copy(curDir + @"\..\Games\" + PFName + @"\" + PFGameName + @".exe", curDir + @"\..\Games\" + PFName + @"\GameRelease\" + PFGameName + @".exe");

                File.Copy(curDir + @"\..\Games\" + PFName + @"\Package\" + PFGameName + @".tpkg", curDir + @"\..\Games\" + PFName + @"\GameRelease\" + PFGameName + @".tpkg");

                File.Copy(curDir + @"\..\Games\" + PFName + @"\" + @"DevIL.dll", curDir + @"\..\Games\" + PFName + @"\GameRelease\" + @"DevIL.dll");
                File.Copy(curDir + @"\..\Games\" + PFName + @"\" + @"OpenAL32.dll", curDir + @"\..\Games\" + PFName + @"\GameRelease\" + @"OpenAL32.dll");
                File.Copy(curDir + @"\..\Games\" + PFName + @"\" + @"SDL.dll", curDir + @"\..\Games\" + PFName + @"\GameRelease\" + @"SDL.dll");

                File.Copy(curDir + @"\..\Games\" + PFName + @"\" + PFName + @"License.txt", curDir + @"\..\Games\" + PFName + @"\GameRelease\" + PFName + @"License.txt");
                File.Copy(curDir + @"\..\Games\" + PFName + @"\" + @"Love2DGELicense.txt", curDir + @"\..\Games\" + PFName + @"\GameRelease\" + @"Love2DGELicense.txt");
            }
            catch
            {
            }
            finally
            {
            }

            JoinZipANDGame();
        }

        private void RTB_Console_TextChanged(object sender, EventArgs e)
        {

        }

        #region Shortcut Game Folders

        private void B_Root_Click(object sender, EventArgs e)
        {
            ConsoleWrite_OpenGameShortcut("Root");
            string PFName = listBox1.SelectedItem as String;
            string curDir = Directory.GetCurrentDirectory();
            Process.Start(curDir + @"\..\Games\" + PFName); ;
        }

        private void B_Src_Click(object sender, EventArgs e)
        {
            ConsoleWrite_OpenGameShortcut("Source Code");
            string PFName = listBox1.SelectedItem as String;
            string curDir = Directory.GetCurrentDirectory();
            Process.Start(curDir + @"\..\Games\" + PFName + @"\Src");
        }

        private void B_Shaders_Click(object sender, EventArgs e)
        {
            ConsoleWrite_OpenGameShortcut("Shaders");
            string PFName = listBox1.SelectedItem as String;
            string curDir = Directory.GetCurrentDirectory();
            Process.Start(curDir + @"\..\Games\" + PFName + @"\Shaders");
        }

        private void B_Resources_Click(object sender, EventArgs e)
        {
            ConsoleWrite_OpenGameShortcut("Resources");
            string PFName = listBox1.SelectedItem as String;
            string curDir = Directory.GetCurrentDirectory();
            Process.Start(curDir + @"\..\Games\" + PFName + @"\Resources");
        }

        private void B_GameI_Click(object sender, EventArgs e)
        {
            ConsoleWrite_OpenGameShortcut("Game Internal");
            string PFName = listBox1.SelectedItem as String;
            string curDir = Directory.GetCurrentDirectory();
            Process.Start(curDir + @"\..\Games\" + PFName + @"\Config");
        }

        private void B_GameReleasePackage_Click(object sender, EventArgs e)
        {
            ConsoleWrite_OpenGameShortcut("Game Release Package");
            string PFName = listBox1.SelectedItem as String;
            string curDir = Directory.GetCurrentDirectory();
            Process.Start(curDir + @"\..\Games\" + PFName + @"\Package");
        }

        #endregion

        public void StartGame(string f)
        {
            string PFName = listBox1.SelectedItem as String;
            string curDir = Directory.GetCurrentDirectory();

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = L_PGameNameT.Text + @".exe";
            startInfo.Arguments = f;
            Process.Start(curDir + @"\..\Games\" + PFName + @"\" + startInfo);
        }

        public void StartGameBuildA()
        {
            string PFName = listBox1.SelectedItem as String;
            string curDir = Directory.GetCurrentDirectory();
            string Engine = curDir + @"\..\Games\" + PFName + @"\" + L_PGameNameT.Text + @".exe";
            string GameSources = @"\test\examples.tpkg";
            System.Diagnostics.Process.Start(Engine, GameSources);
        }

        public void StartGameBuildFiles(string f)
        {
            string PFName = listBox1.SelectedItem as String;
            string curDir = Directory.GetCurrentDirectory();

            DisableButtons("True");
            Process startInfo = new Process();
            startInfo.StartInfo.FileName = curDir + @"\..\Games\" + PFName + @"\" + L_PGameNameT.Text + @".exe";
            startInfo.StartInfo.Arguments = @"..\Games\" + PFName + @"\Build" + " " + f;
            //startInfo.StartInfo.UseShellExecute = false;
            startInfo.Start();
            startInfo.WaitForExit();
            EnabledButtons( "True" );
            
        }

        public void StartGamePackageFiles(string f)
        {
            string PFName = listBox1.SelectedItem as String;
            string curDir = Directory.GetCurrentDirectory();

            DisableButtons("True");
            Process startInfo = new Process();
            startInfo.StartInfo.FileName = curDir + @"\..\Games\" + PFName + @"\" + L_PGameNameT.Text + @".exe";
            startInfo.StartInfo.Arguments = @"..\Games\" + PFName + @"\Package\" + PFName + @".tpkg" + " " + f;
            //startInfo.StartInfo.UseShellExecute = false;
            startInfo.Start();
            startInfo.WaitForExit();
            EnabledButtons("True");

        }

        private void B_LaunchGame_Click(object sender, EventArgs e)
        {
            string PFName = listBox1.SelectedItem as String;
            string curDir = Directory.GetCurrentDirectory();

            //DisableButtons( "True" );
            if (CB_Console.Checked == true)
            {
                //StartGameBuildA();
                StartGameBuildFiles(@"--console");
                //Process.Start(curDir + @"\..\Games\" + PFName + @"\" + L_PGameNameT.Text + @".exe" + );
            }
            else
            {
                StartGameBuildFiles(@"");
                //Process.Start(curDir + @"\..\Games\" + PFName + @"\" + L_PGameNameT.Text + @".exe");
            }


        }

        private void B_LuaEditor_Click(object sender, EventArgs e)
        {
            //string process = "@" + "'" + Properties.Settings.Default.DLuaEditor;
            ConsoleWrite_StartProcess("Lua Editor");
            System.Diagnostics.Process.Start(@"" + Properties.Settings.Default.DLuaEditor);
        }

        private void B_Settings_Click(object sender, EventArgs e)
        {
            //openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.DLuaEditor = openFileDialog1.FileName; //openFileDialog1.CheckPathExists + openFileDialog1.FileName;
                Properties.Settings.Default.Save();
                //Only for check
                //MessageBox.Show(openFileDialog1.FileName);
            }
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindProjectItem();
        }

        private void B_AddP_Click(object sender, EventArgs e)
        {

            //Forms.ProjectManagerForm ProjectManager = new Forms.ProjectManagerForm();
            //ProjectManager.Show();

            var ProjectManagerForm = new Forms.ProjectManagerForm("isnew");
            if (ProjectManagerForm.ShowDialog() == DialogResult.OK)
            {
                // process results here
                GetAllfiles();
            }
            else
            {

            }
            // The Add button was clicked.
            //_items.Add("New item " + DateTime.Now.Second); // <-- Any string you want

            // Change the DataSource.
            //listBox1.DataSource = null;
            //listBox1.DataSource = _items;
        }
        public void SendSaveInfo()
        {

            Properties.Settings.Default.S_PName = L_PNameT.Text;
            Properties.Settings.Default.S_PGameName = L_PGameNameT.Text;
            Properties.Settings.Default.S_PAutor = L_PAutorT.Text;
            Properties.Settings.Default.S_PVersion = L_PVersionT.Text;
            Properties.Settings.Default.Save();
        }
        private void B_EditP_Click(object sender, EventArgs e)
        {
            SendSaveInfo();
            var ProjectManagerForm = new Forms.ProjectManagerForm("isedit");
            if (ProjectManagerForm.ShowDialog() == DialogResult.OK)
            {
                // process results here
                GetAllfiles();
            }
            else
            {

            }
        }

        private void B_DeleteP_Click(object sender, EventArgs e)
        {
            string PFName = listBox1.SelectedItem as String;
            string curDir = Directory.GetCurrentDirectory();
            File.Delete(curDir + @"\Projects\" + PFName + ".ini");
            System.IO.DirectoryInfo RemoveProject = new DirectoryInfo(curDir + @"\..\Games\" + PFName);

            foreach (FileInfo file in RemoveProject.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in RemoveProject.GetDirectories())
            {
                dir.Delete(true);
            }
            System.IO.Directory.Delete(curDir + @"\..\Games\" + PFName);
            GetAllfiles();
            // The Remove button was clicked.
            //int selectedIndex = listBox1.SelectedIndex;

            //try
            //{
                // Remove the item in the List.
            //    _items.RemoveAt(selectedIndex);
            //    deletethis();
            //}
            //catch
            //{
            //}

            //listBox1.DataSource = null;
            //listBox1.DataSource = _items;
        }

        //Start To Find files
        private void GetAllfiles()
        {
            listBox1.Items.Clear();
            string curDir = Directory.GetCurrentDirectory() + @"\Projects\";
            ProjectsListBox(listBox1, curDir, "*.ini");
            if (this.listBox1.Items.Count == 0)
            {
                string PName = "None";
                string PGameName = "None";
                string PAutor = "None";
                string PVersion = "None";
                string PLastBuild = "None";

                //B_DeleteP.Enabled = false;
                //B_EditP.Enabled = false;
                //B_LaunchGame.Enabled = false;
                //B_BuildAll.Enabled = false;
                DisableButtons("True");
                L_PNameT.Text = PName;
                L_PGameNameT.Text = PGameName;
                L_PAutorT.Text = PAutor;
                L_PVersionT.Text = PVersion;
                L_PLastBuildT.Text = PLastBuild;

            }
            else
            {
                //B_DeleteP.Enabled = true;
                //B_EditP.Enabled = true;
                if (listBox1.SelectedValue as String == "")
                {
                    this.listBox1.Focus();
                    this.listBox1.SetSelected(0, true);
                    DisableButtons("True");
                    //B_DeleteP.Enabled = false;
                    //B_EditP.Enabled = false;
                    //B_LaunchGame.Enabled = false;
                    //B_BuildAll.Enabled = false;
                }
                else
                {
                    this.listBox1.Focus();
                    this.listBox1.SetSelected(0, true);
                    EnabledButtons("True");
                    //B_DeleteP.Enabled = true;
                    //B_EditP.Enabled = true;
                    //B_LaunchGame.Enabled = true;
                    //B_BuildAll.Enabled = true;
                    //MessageBox.Show(@"""" + listBox1.SelectedValue as String + @"""");
                }
            }

        }
        private void EnabledButtons(string isfull)
        {
            B_DeleteP.Enabled = true;
            B_EditP.Enabled = true;

            B_LaunchGame.Enabled = true;
            B_BuildAll.Enabled = true;

            B_Root.Enabled = true;
            B_Shaders.Enabled = true;
            B_Src.Enabled = true;
            B_Resources.Enabled = true;
            B_GameI.Enabled = true;
            B_GameReleasePackage.Enabled = true;

            groupBox1.Enabled = true;
            groupBox3.Enabled = true;
            groupBox7.Enabled = true;

            if (isfull == "True")
            {
                groupBox5.Enabled = true;
                groupBox4.Enabled = true;
            }

        }

        private void DisableButtons(string isfull)
        {
            B_DeleteP.Enabled = false;
            B_EditP.Enabled = false;

            B_LaunchGame.Enabled = false;
            B_BuildAll.Enabled = false;

            B_Root.Enabled = false;
            B_Shaders.Enabled = false;
            B_Src.Enabled = false;
            B_Resources.Enabled = false;
            B_GameI.Enabled = false;
            B_GameReleasePackage.Enabled = false;

            groupBox1.Enabled = false;
            groupBox3.Enabled = false;
            groupBox7.Enabled = false;

            if (isfull == "True")
            {
                groupBox5.Enabled = false;
                groupBox4.Enabled = false;
            }

        }

        private void ProjectsListBox(ListBox lsb, string Folder, string FileType)
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles(FileType);
            foreach (FileInfo file in Files)
            {
                lsb.Items.Add(file.Name.Remove(file.Name.Length - 4));
            }
        }
        //End Find files

        private void FindProjectItem()
        {

            string PFName = listBox1.SelectedItem as String;
            string curDir = Directory.GetCurrentDirectory();
            IniFile ini = new IniFile(curDir + @"\Projects\" + PFName + ".ini");
            //string curDir = Directory.GetCurrentDirectory();
            //IniParser parser = new IniParser(curDir + @"\T2DEProjects.ini");
            //IniFile ini = new IniFile(curDir + @"\T2DEProjects.ini");


            string PName = "";
            string PGameName = "";
            string PAutor = "";
            string PVersion = "";
            string PLastBuild = "";

            L_PNameT.Text = PName;
            L_PGameNameT.Text = PGameName;
            L_PAutorT.Text = PAutor;
            L_PVersionT.Text = PVersion;
            L_PLastBuildT.Text = PLastBuild;

            L_PNameT.Text = ini.IniReadValue(PFName, "PName");
            L_PGameNameT.Text = ini.IniReadValue(PFName, "PGameName");
            L_PAutorT.Text = ini.IniReadValue(PFName, "PAutor");
            L_PVersionT.Text = ini.IniReadValue(PFName, "PVersion");
            L_PLastBuildT.Text = ini.IniReadValue(PFName, "PLastBuild");

            //L_PNameT.Text = parser.GetSetting(PFName, "PName");
            //L_PGameNameT.Text = parser.GetSetting(PFName, "PGameName");
            //L_PAutorT.Text = parser.GetSetting(PFName, "PAutor");
            //L_PVersionT.Text = parser.GetSetting(PFName, "PVersion");
            //L_PLastBuildT.Text = parser.GetSetting(PFName, "PLastBuild");
        }

        #region IniFiles

        #endregion


        // DateTime time = DateTime.Now;
        //string format = "MMM ddd d HH - mm yyyy";

            //string format = "MMM ddd d HH:mm yyyy";
            //string format2 = time.ToString(format);
        //Nextweek
        //Build Button + process & play game button
    }
}

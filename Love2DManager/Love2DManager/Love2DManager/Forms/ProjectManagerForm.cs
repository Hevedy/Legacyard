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
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Xml;

namespace Love2DManager.Forms
{
    public partial class ProjectManagerForm : Form
    {
        public static class GlobalVar
        {
            /// <summary>
            /// Global variable that is constant.
            /// </summary>
            public const string GlobalString = "";
            /// <summary>
            /// Static value protected by access routine.
            /// </summary>
            static int _globalValue;

            /// <summary>
            /// Access routine for global variable.
            /// </summary>
            public static int GlobalValue
            {
                get
                {
                    return _globalValue;
                }
                set
                {
                    _globalValue = value;
                }
            }

            /// <summary>
            /// Global static field.
            /// </summary>
            public static bool GlobalBoolean;
        }
        public ProjectManagerForm(string type)
        {
            InitializeComponent();
            if (type == "isnew")
            {
                GlobalVar.GlobalValue = 1;
                ResetThis();
            }
            else
            {
                GlobalVar.GlobalValue = 2;
                LoadInfo();
            }
        }

        private void ProjectManagerForm_Load(object sender, EventArgs e)
        {

        }
        public void LoadInfo()
        {
            TB_PName.Text = Properties.Settings.Default.S_PName;
            TB_PGameName.Text = Properties.Settings.Default.S_PGameName;
            TB_PAutor.Text = Properties.Settings.Default.S_PAutor;
            TB_PVersion.Text = Properties.Settings.Default.S_PVersion;
            B_PM_Cancel.Enabled = true;
            B_PM_Apply.Enabled = true;
            TB_PName.Enabled = true;
            TB_PGameName.Enabled = true;
            TB_PAutor.Enabled = true;
            TB_PVersion.Enabled = true;
        }
        public void ResetThis()
        {
            TB_PName.Text = "";
            TB_PGameName.Text = "";
            TB_PAutor.Text = "";
            TB_PVersion.Text = "";
            B_PM_Cancel.Enabled = true;
            B_PM_Apply.Enabled = true;
            TB_PName.Enabled = true;
            TB_PGameName.Enabled = true;
            TB_PAutor.Enabled = true;
            TB_PVersion.Enabled = true;


        }
        private void CreateNewGameFouldersSystem()
        {
            string curDir = Directory.GetCurrentDirectory();
            string NewPName = TB_PName.Text;

            Directory.CreateDirectory(curDir + @"\..\Games\" + NewPName);
            Directory.CreateDirectory(curDir + @"\..\Games\" + NewPName + @"\Resources");
            Directory.CreateDirectory(curDir + @"\..\Games\" + NewPName + @"\Resources\Graphics");
            Directory.CreateDirectory(curDir + @"\..\Games\" + NewPName + @"\Resources\Graphics\Icons");
            Directory.CreateDirectory(curDir + @"\..\Games\" + NewPName + @"\Resources\Sounds");
            Directory.CreateDirectory(curDir + @"\..\Games\" + NewPName + @"\Resources\Music");
            Directory.CreateDirectory(curDir + @"\..\Games\" + NewPName + @"\Resources\Fonts");
            Directory.CreateDirectory(curDir + @"\..\Games\" + NewPName + @"\Shaders");
            Directory.CreateDirectory(curDir + @"\..\Games\" + NewPName + @"\Config");
            Directory.CreateDirectory(curDir + @"\..\Games\" + NewPName + @"\Src");

            Directory.CreateDirectory(curDir + @"\..\Games\" + NewPName + @"\Build");
            Directory.CreateDirectory(curDir + @"\..\Games\" + NewPName + @"\Temp");
            Directory.CreateDirectory(curDir + @"\..\Games\" + NewPName + @"\Package");
            Directory.CreateDirectory(curDir + @"\..\Games\" + NewPName + @"\GameRelease");

            //Next
            CopyEngineToGame();
        }

        private void CopyEngineToGame()
        {
            string curDir = Directory.GetCurrentDirectory();
            string PFName = TB_PName.Text;
            string PFGameName = TB_PGameName.Text;

            try
            {
                File.Copy(curDir + @"\..\Engine\" + @"Love2DEngine.exe", curDir + @"\..\Games\" + PFName + @"\" + PFGameName + @".exe");
                File.Copy(curDir + @"\..\Engine\" + @"DevIL.dll", curDir + @"\..\Games\" + PFName + @"\" + @"DevIL.dll");
                File.Copy(curDir + @"\..\Engine\" + @"OpenAL32.dll", curDir + @"\..\Games\" + PFName + @"\" + @"OpenAL32.dll");
                File.Copy(curDir + @"\..\Engine\" + @"SDL.dll", curDir + @"\..\Games\" + PFName + @"\" + @"SDL.dll");

                //Copy the base game files
                File.Copy(curDir + @"\..\GamesBR\Src\" + @"conf.lua", curDir + @"\..\Games\" + PFName + @"\Src" + @"conf.lua");
                File.Copy(curDir + @"\..\GamesBR\Src\" + @"main.lua", curDir + @"\..\Games\" + PFName + @"\Src" + @"main.lua");

                File.Copy(curDir + @"\..\GamesBR\" + @"MyGameLicense.txt", curDir + @"\..\Games\" + PFName + @"\" + PFName + @"License.txt");
                File.Copy(curDir + @"\..\GamesBR\" + @"Love2DGELicense.txt", curDir + @"\..\Games\" + PFName + @"\" +  @"Love2DGELicense.txt");
            }
            catch
            {
            }
            finally
            {
            }

            //Next
            CreateProjectFile();
        }
        private void CreateProjectFile()
        {
            // Create a new file 
            string PFName = TB_PName.Text;
            string curDir = Directory.GetCurrentDirectory();
            using (StreamWriter sw = File.CreateText(curDir + @"\Projects\" + PFName + ".ini"))
            {
                sw.WriteLine(@"[" + PFName + @"]");
                sw.WriteLine("PName=" + TB_PName.Text);
                sw.WriteLine("PGameName=" + TB_PGameName.Text);
                sw.WriteLine("PAutor=" + TB_PAutor.Text);
                sw.WriteLine("PVersion=" + TB_PVersion.Text);
                sw.WriteLine("PLastBuild={0}", DateTime.Now.ToString());
            }

            this.Close();
        }
        private void B_PM_Apply_Click(object sender, EventArgs e)
        {
            //Diseable Form
            if (TB_PName.Text == "" && TB_PGameName.Text == "")
            {
                try
                {
                MessageBox.Show("Bad Names", "Please enter the correct names");
                return;
                }       
                catch
                {
                }
                finally
                {
                }
            }
            else
            {
                string[] BadCharList = { @"/", @"\", @"<", @">", @",", @".", @"?", @"¿", @":", @"|", @"""", @"+", @"*", @" ", @"" };
                foreach (string BadCharacter in BadCharList)
                {
                    if (BadCharacter.Contains(TB_PName.Text) || BadCharacter.Contains(TB_PGameName.Text) || BadCharacter.Contains(TB_PAutor.Text) || BadCharacter.Contains(TB_PVersion.Text))
                    {
                        try
                        {
                            MessageBox.Show("Bad Names", "Please enter the correct symbols");
                            return;
                        }
                        catch
                        {
                        }
                        finally
                        {
                        }
                    }
                    else
                    {
                        B_PM_Cancel.Enabled = false;
                        B_PM_Apply.Enabled = false;
                        TB_PName.Enabled = false;
                        TB_PGameName.Enabled = false;
                        TB_PAutor.Enabled = false;
                        TB_PVersion.Enabled = false;

                        if (GlobalVar.GlobalValue == 1)
                        {
                            //Create Base
                            CreateNewGameFouldersSystem();
                            //Copy Engine
                            //CopyEngineToGame();
                        }
                        else
                        {
                            UpdateFile();
                            //For test
                            //MessageBox.Show("sdsdsdsd", "ddddddd");
                        }

                        this.DialogResult = DialogResult.OK;
                    }
                }
            }

        }

        private void UpdateFile()
        {
            string PFName = Properties.Settings.Default.S_PName;
            string PFGameName = Properties.Settings.Default.S_PGameName;
            string NewPFName = TB_PName.Text;
            string curDir = Directory.GetCurrentDirectory();
            //IniFile ini = new IniFile(curDir + @"\Projects\" + PFName + ".ini");

            //ini.IniWriteValue(PFName, "PName", TB_PName.Text);
            //ini.IniWriteValue(PFName, "PGameName", TB_PGameName.Text);
            //ini.IniWriteValue(PFName, "PAutor", TB_PAutor.Text);
            //ini.IniWriteValue(PFName, "PVersion", TB_PVersion.Text);
            try
            {
                System.IO.Directory.Move(curDir + @"\..\Games\" + PFName, curDir + @"\..\Games\" + NewPFName);
                File.Copy(curDir + @"\..\Games\" + NewPFName + @"\" + PFGameName + @".exe", curDir + @"\..\Games\" + NewPFName + @"\" + TB_PGameName.Text + @".exe");
                File.Copy(curDir + @"\..\Games\" + NewPFName + @"\" + PFGameName + @"License.txt", curDir + @"\..\Games\" + NewPFName + @"\" + TB_PGameName.Text + @"License.txt");
                //System.IO.File.Move(curDir + @"\Projects\" + PFName + ".ini", curDir + @"\Projects\" + NewPFName + ".ini");
                System.IO.File.Delete(curDir + @"\Projects\" + PFName + ".ini");
                System.IO.File.Delete(curDir + @"\..\Games\" + NewPFName + @"\" + PFGameName + @".exe");
                System.IO.File.Delete(curDir + @"\..\Games\" + NewPFName + @"\" + PFGameName + @"License.txt");
                //System.IO.Directory.Move(curDir + @"\..\Games\" + PFName, curDir + @"\..\Games\" + NewPFName);
            }
            catch
            {
            }
            finally
            {
            }

            CreateProjectFile();
            //return;
        }
        private void B_PM_Cancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }

    }
}

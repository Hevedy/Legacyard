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
using ChatBot.Src;
using ChatBot.Forms;
using ChatBot.Properties;
using System.Speech.Recognition;
using System.Resources;

namespace ChatBot
{
    public partial class MainWindow : Form
    {
        //Langs
        public ResourceManager LangRMang;    
        public CultureInfo LangCult;    

        //User Settings
        public static string UserName = ChatBot.Properties.Settings.Default.UserName;
        public static string SelectedLang = ChatBot.Properties.Settings.Default.Language;
        //Startup

        //Language Prop
        public static int LangDir = 0;

        //New Vars
        #region BaseVars
        static int Vfull = 123;
        static string SoftwareName = "ChatBot";
        static string SoftwarePublicName = "Chat Bot -";
        static string SoftwareIversion = "";
        static string SoftwareOversion = "";

        //User Folders
        public string SoftwareDir = Directory.GetCurrentDirectory();
        public string SoftwareBinDir = Directory.GetCurrentDirectory() + @"\Bin";
        public string SoftwareDataDir = Directory.GetCurrentDirectory() + @"\Data";
        public string SoftwareRefDataDir = Directory.GetCurrentDirectory() + @"\BotTextRef";
        public string UserFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\" + SoftwareName + @"\"; //User Folder
        public string UserFolderLogs = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\" + SoftwareName + @"\Logs\"; //User Folder
        public string FullDirA;
        public string FullDirB;
        public string FullDir;
        public string FilePreExt;

        public string FilesAExt = @".cfg";
        public string FilesBExt = @"";
        #endregion

        //Network Support
        public string Niplocal = @"127.0.0.1";
        public string Nport = @"25550";
        public string Nipconnect = @"127.0.0.1";


        //Internal
        public string WhatisTheFile;
        public string TypeOfString;
        public int StringN;

        //User String
        public string UserInput;

        //Bot Prediction
        public string[] LastMsnB = new string[5];
        public string[] LastMsnU = new string[5];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void TSMI_New_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_SLog_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_Exit_Click(object sender, EventArgs e)
        {
            CloseAll();
        }
        public void CloseAll()
        {
            Application.Exit();
            //this.Close();
        }
        private void TSMI_About_Click(object sender, EventArgs e)
        {
            var AboutWindow = new Forms.AboutWindow();
            AboutWindow.ShowDialog();
        }

        private void TSMI_CList_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_LangEnglish_Click(object sender, EventArgs e)
        {
            ChatBot.Properties.Settings.Default.Language = "English";
            ChatBot.Properties.Settings.Default.Save();
            TSMI_LangEnglish.Checked = true;
            TSMI_LangSpanish.Checked = false;
            CheckLanguage();
        }

        private void TSMI_LangSpanish_Click(object sender, EventArgs e)
        {
            ChatBot.Properties.Settings.Default.Language = "Spanish";
            ChatBot.Properties.Settings.Default.Save();
            TSMI_LangSpanish.Checked = true;
            TSMI_LangEnglish.Checked = false;
            CheckLanguage();
        }

        private void TSMI_UCName_Click(object sender, EventArgs e)
        {
            var UNChangeWindow = new Forms.UNChangeWindow();
            UNChangeWindow.ShowDialog();
        }

        private void TSMI_ModeHelp_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_ModeVS_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_CBChat_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_CUChat_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_Send_Click(object sender, EventArgs e)
        {
            SendToCheck(TB_UserInput.Text);
        }

        private void TSMI_Undo_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_Redo_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_Cut_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_Copy_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_Paste_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_Delete_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_SelectAll_Click(object sender, EventArgs e)
        {

        }

        private void UB_Send_Click(object sender, EventArgs e)
        {
            SendToCheck(TB_UserInput.Text);
        }
        public void UserTextWrite()
        {
            CheckLanguage();
            TB_ChatBotOutput.Text = TB_ChatBotOutput.Text + Environment.NewLine + UserName + ": " + TB_UserInput.Text;
            TB_UserInput.Text = "";
            UserInput = "";
        }
        public void SendToCheck(string UserText)
        {
            //Read the ini file
            if (UserText.Contains("´") || UserText.Contains("[") || UserText.Contains("(") ||
                UserText.Contains("`") || UserText.Contains("]") || UserText.Contains(")") ||
                UserText.Contains("!") || UserText.Contains("|") || UserText.Contains("/") ||
                //UserText.Contains(".") || UserText.Contains(":") || UserText.Contains(",") || UserText.Contains(";") ||
                UserText.Contains("<") || UserText.Contains(">") || UserText.Contains("{") || UserText.Contains("}") ||
                UserText.Contains(@"""") || UserText.Contains("%") || UserText.Contains("&"))
            {
                MessageBox.Show("Sorry but the bot only read text without mayus or others symbols", "Read Error");
            }
            else
            {
                if (UserText == null || UserText == " " || UserText == "")
                {
                    MessageBox.Show("Please write some text", "No text found");

                }
                else
                {
                    UserTextWrite();
                    UserInput = UserText;
                    FilePreExt = "";
                    CreateaReply(UserText);
                }
            }
        }

        public void CreateaReply(string UserText)
        {
            if (UserText.Contains("bot."))
            {
                //Problems
                FullDirB = FullDirA + @"\Commands\Command";
                Bot_CommandG(UserText);

            }
            else if (UserText.Contains("problema") || UserText.Contains("problem"))
            {
                //Problems
                FullDirB = FullDirA + @"\Problems\Problem";
                Bot_ProblemG(UserText);

            }
            else if (UserText.Contains("error"))
            {
                //Errors
                FullDirB = FullDirA + @"\Errors\Error";
                Bot_ErrorG(UserText);

            }
            else if (UserText.Contains("advertencia") || UserText.Contains("warning"))
            {
                //Warning
                FullDirB = FullDirA + @"\Warnings\Warning";
                Bot_WarningG(UserText);

            }
            else if (UserText.Contains("ayuda") || UserText.Contains("pregunta") || UserText.Contains("help") || UserText.Contains("question"))
            {
                //Help
                FullDirB = FullDirA + @"\Helps\Help";
                Bot_HelpG(UserText);
            }
            else if (UserText.Contains("hi") || UserText.Contains("hello") || UserText.Contains("hey") || UserText.Contains("hola") || 
                UserText.Contains("saludos"))
            {
                //Other
                FullDirB = FullDirA + @"\Others\Other";
                Bot_OtherG(UserText);
            }
            else
            {
                //No found
                MessageBox.Show("Sorry have a problem", "Problem");
            }
        }
        #region Filters
        //All Filters (to other class)
        //Global Filters A
        public void Bot_CommandG(string InText)
        {
            int VarNun = 999;
            string VarType = "";
            string ID = "";
            for (int i = 0; i <= 10; i++)
            {
                string Search;
                Search = BotFinderExt("Execution", i.ToString());
                if (InText.Contains(Search) && !Search.Contains("") && !Search.Contains(null))
                {
                    int Act = NewMessageBox("Test," + i.ToString() + "," + Search, InText + FullDir + BotFinderExt("ExecutionR", i.ToString()), 1);
                    if (Act == 1)
                    {
                        VarNun = i;
                        VarType = "Execution";
                        FilePreExt = "_" + i.ToString();
                    }
                    else if (Act == 2)
                    {
                    }
                    else
                    {
                    }
                    break;
                    //return;
                }
            }
            for (int i = 0; i <= 10; i++)
            {
                string Search;
                Search = BotFinderExt("Search", i.ToString());
                if (InText.Contains(Search) && !InText.Contains("") && !InText.Contains(null))
                {
                    VarNun = i;
                    VarType = "Search";
                    FilePreExt = "_" + i.ToString();
                    break;
                    //return;
                }
            }
            //User Text, ID, VarN
            BotFinderOut(InText, ID, VarNun);
        }
        public void Bot_ProblemG(string InText)
        {

        }
        public void Bot_ErrorG(string InText)
        {

        }
        public void Bot_WarningG(string InText)
        {

        }
        public void Bot_HelpG(string InText)
        {

        }
        public void Bot_OtherG(string InText)
        {
            for (int i = 0; i <= 10; i++)
            {
                if (InText.Contains("hola"))
                {
                    TypeOfString = "Normal";
                    StringN = 1;
                }
            }
            BotWrite("none");
        }

        //Global Filters B
        #endregion
        //Bot Finder
        public string BotFinderExt(string Zone, string Name)
        {
            string ValueOut;
            FullDir = FullDirB + FilePreExt + FilesAExt;
            INIFileReader LangBase = new INIFileReader(FullDir);
            string StringNa = StringN.ToString();
            ValueOut = LangBase.IniReadValue(Zone, Name);

            return ValueOut;
        }
        public void BotFinderOut(string UserText, string Type, int TypeN)
        {
            for (int i = 0; i <= 10; i++)
            {
                string Search;
                Search = BotFinderExt("GeneralR", i.ToString());
                if (UserText.Contains(Search))
                {
                    BotWrite(i.ToString());
                    break;
                    //return;
                }
            }


        }
        public int NewMessageBox(string Title, string Body, int type)
        {
            int Out = 0;
            if (MessageBox.Show(Body, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Out = 1;
            }
            else
            {
                Out = 2;
            }
            return Out;
        }
        public void BotWrite(string N)
        {
            BotNewMessage(N);
        }

        public void BotNewMessage(string N)
        {
            if (N == null)
            {
                if (SelectedLang == "English")
                {
                    TB_ChatBotOutput.Text = TB_ChatBotOutput.Text + Environment.NewLine + "Chat Bot: Error 404";
                }
                else
                {
                    TB_ChatBotOutput.Text = TB_ChatBotOutput.Text + Environment.NewLine + "Chat Bot: Error 404";
                }
            }
            else
            {
                TB_ChatBotOutput.Text = TB_ChatBotOutput.Text + Environment.NewLine + "Chat Bot: " + IniTextReaded( N );
            }
        }

        public string IniTextReaded(string N)
        {
            string ValueOut;
            FullDir = FullDirB + FilePreExt + FilesAExt;
            INIFileReader LangBase = new INIFileReader(FullDir);
            string StringNa = StringN.ToString();
            ValueOut = LangBase.IniReadValue("GeneralR", N);
            if (ValueOut == null)
            {
                if (SelectedLang == "English")
                {
                    ValueOut = "Sorry but i dont have instructions for this.";
                }
                else
                {
                    ValueOut = "Lo siento pero no tengo instrucciones para esto.";
                }
            }

            return ValueOut;
        }

        private void UB_Clear_Click(object sender, EventArgs e)
        {
            TB_UserInput.Text = "";
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //this.MinimumSize = new Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(680, 500); //800, 600
            UserName = ChatBot.Properties.Settings.Default.UserName;
            SelectedLang = ChatBot.Properties.Settings.Default.Language;
            if (SelectedLang == "English")
            {
                TSMI_LangEnglish.Checked = true;
                TSMI_LangSpanish.Checked = false;
            }
            else
            {
                TSMI_LangSpanish.Checked = true;
                TSMI_LangEnglish.Checked = false;
            }
            LangRMang = new ResourceManager("MultiLanguageApp.Global", typeof(MainWindow).Assembly);
            StartChat();
            //CheckLanguage();
        }
        private void StartChat()
        {
            if (SelectedLang == "English")
            {
                TB_ChatBotOutput.Text = "Rules:" + Environment.NewLine + 
                    "1º.Please don't use MAYUS or $ymbols to talk with the bot." + Environment.NewLine +
                    "2º.For best work use the chat commands or write with small phrases." + Environment.NewLine + Environment.NewLine +
                    "Chat Bot: Welcome " + UserName;
            }
            else
            {
                TB_ChatBotOutput.Text = "Reglas:" + Environment.NewLine +
                    "1º.Por favor no utilices en MAYUSCULAS o $imbolos para hablar con la maquina." + Environment.NewLine +
                    "2º.Para un mejor funcionamiento usa los comandos del chat o escribe con frases cortas." + Environment.NewLine + Environment.NewLine +
                    "Chat Bot: Bienvenido " + UserName;
            }
        }
        public void CheckDirs(int X)
        {
            //string FullDirA;
            if (X == 0)
            {

                FullDirA = SoftwareRefDataDir + @"\English";
                LangCult = CultureInfo.CreateSpecificCulture("en");
                //UpdateLang();
            }
            else
            {
                FullDirA = SoftwareRefDataDir + @"\Spanish";
                LangCult = CultureInfo.CreateSpecificCulture("es");
                //UpdateLang();
            }
        }

        public void CheckLanguage()
        {
            if (SelectedLang == "English")
            {

                //English
                CheckDirs(0);

            }
            else
            {
                //Spanish
                CheckDirs(1);

            }

        }
        //Language Global
        public void UpdateLang()
        {
            //Form
            for (int i = 0; i <= 10; i++)
            {
                ItemList(LangSoftwareIni("Form", i.ToString()), i.ToString());
            }

            //ToolBar
            for (int i = 0; i <= 10; i++)
            {
                ItemList(LangSoftwareIni("ToolBar", i.ToString()), i.ToString());
            }

            //Buttons and Text
            for (int i = 0; i <= 10; i++)
            {
                ItemList(LangSoftwareIni("Info", i.ToString()), i.ToString());
            }

        }

        public string LangSoftwareIni(string Tool, string Name)
        {
            string ValueOut;
            string Dir;
            Dir = FullDirA + @"\Global.ini";
            INIFileReader LangBase = new INIFileReader(Dir);
            string StringNa = StringN.ToString();
            ValueOut = LangBase.IniReadValue(Tool, Name);

            return ValueOut;
        }

        public void ItemList(string Name, string N)
        {
            //Form 1
            //Forms.UNChangeWindow.TB_UserName.Text;



        }

        private void TB_UserInput_TextChanged(object sender, EventArgs e)
        {


        }

        private void TB_ChatBotOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void AllAPPClose(object sender, FormClosingEventArgs e)
        {
            CloseAll();
        }
        public void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // Enter key pressed
                SendToCheck(TB_UserInput.Text);
            }

        }
        private void TB_UserInput_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e) //KeyPressEventArgs e
        {
            //CheckKey();
            if (e.KeyCode == Keys.Enter)
            {
                SendToCheck(TB_UserInput.Text);
            }
        }

        //Network
        public void NetClient()
        {

        }
        public void NetServer()
        {

        }

        //Speech Check
        private SpeechRecognitionEngine Speech_A = new SpeechRecognitionEngine();

        private void Speech_Start()
        {
            Speech_A.SetInputToDefaultAudioDevice();
            Speech_A.LoadGrammar(new DictationGrammar());
            Speech_A.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Speech_A_SpeechRecognized);
            Speech_A.RecognizeAsync(RecognizeMode.Multiple);
        }
        private void SpeechB_Start()
        {
            SpeechRecognitionEngine Speech_B = new SpeechRecognitionEngine();
            Speech_B.RequestRecognizerUpdate();
            Speech_B.LoadGrammar(new Grammar(new GrammarBuilder("exit")));
            Speech_B.RequestRecognizerUpdate();
            Speech_B.LoadGrammar(new DictationGrammar());
            Speech_B.SpeechRecognized += _recognizer_SpeechRecognized;
            Speech_B.SetInputToDefaultAudioDevice(); // set input to default audio device
            Speech_B.RecognizeAsync(RecognizeMode.Multiple); // recognize speech 
        }
        void _recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == "exit")
            {
                //manualResetEvent.Set();
                return;
            }
            TB_UserInput.Text = TB_UserInput.Text + e.Result.Text;
            //Console.WriteLine("You said: " + e.Result.Text);
        }
        void Speech_A_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //Test
            foreach (RecognizedWordUnit word in e.Result.Words)
            {
                if ((word.Text == "enter") || (word.Text == "enviar"))
                {
                    SendToCheck(TB_UserInput.Text);
                }
                else if ((word.Text == "limpiar") || (word.Text == "borra"))
                {
                    TB_UserInput.Text = "";
                }
                else
                {
                    TB_UserInput.Text = TB_UserInput.Text + word.Text;
                }
            }
        }

        private void TSMI_UCWMicro_Click(object sender, EventArgs e)
        {
            if (TSMI_UCWMicro.Checked == true)
            {

            }
            else
            {
                SpeechB_Start();
            }
        }


    }
}

'-----------------------------------------------------------------------------
' Copyright (c) 2014-2017 Hevedy <github.com/Hevedy>
'
' Permission is hereby granted, free of charge, to any person obtaining a copy
' of this software and associated documentation files (the "Software"), to
' deal in the Software without restriction, including without limitation the
' rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
' sell copies of the Software, and to permit persons to whom the Software is
' furnished to do so, subject to the following conditions:
'
' The above copyright notice and this permission notice shall be included in
' all copies or substantial portions of the Software.
'
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
' IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
' FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
' AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
' LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
' FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
' IN THE SOFTWARE.
'----------------------------------------------------------------------------

Public Class MainWindow

    Private Sub MainWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Me.Close()
        FormList()

    End Sub

    Private Sub FormList()
        MainWFastCommands.Close()
        MainWFastNotes.Close()
        'MainWindow.Close()
        MWCredits.Close()
        MWAHTMLEditorBaseInfo.Close()
        Startup.Close()
        Tips.Close()

    End Sub

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Startup_Process()

    End Sub

    Private Sub Startup_Process()
        If My.Settings.Startup_Tips = True Then
            Tips.Show()
        Else

        End If
        AddNew_File()

    End Sub

    Private Sub AddNew_File()
        RTBE_First.Clear()
        RTBE_First.Text = "<!DOCTYPE html PUBLIC - File created in HTML Editor Base>" _
                            + vbNewLine + "<html>" _
                            + vbNewLine + "<head>" + vbNewLine _
                            + vbNewLine + "</head>" _
                            + vbNewLine + "<body>" + vbNewLine _
                            + vbNewLine + "</body>" _
                            + vbNewLine + "</html>"

    End Sub

    Private Sub ToolStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip2.ItemClicked

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        'Application.Exit()

    End Sub

    Private Sub FastCommandsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FastCommandsToolStripMenuItem.Click
        Check_FCW()

    End Sub

    Private Sub FastNotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FastNotesToolStripMenuItem.Click
        Check_FNW()

    End Sub

    Private Sub TSB_OpenFC_Click(sender As Object, e As EventArgs) Handles TSB_OpenFC.Click
        Check_FCW()

    End Sub

    Private Sub TSB_OpenFN_Click(sender As Object, e As EventArgs) Handles TSB_OpenFN.Click
        Check_FNW()

    End Sub

    Private Sub Check_FCW()
        If MainWFastCommands.Visible = True Then
            MainWFastCommands.Hide()
            FastCommandsToolStripMenuItem.CheckState = CheckState.Unchecked
            TSB_OpenFC.CheckState = CheckState.Unchecked
        Else
            MainWFastCommands.Show()
            FastCommandsToolStripMenuItem.CheckState = CheckState.Checked
            TSB_OpenFC.CheckState = CheckState.Checked
        End If

    End Sub

    Private Sub Check_FNW()
        If MainWFastNotes.Visible = True Then
            MainWFastNotes.Hide()
            FastNotesToolStripMenuItem.CheckState = CheckState.Unchecked
            TSB_OpenFN.CheckState = CheckState.Unchecked
        Else
            MainWFastNotes.Show()
            FastNotesToolStripMenuItem.CheckState = CheckState.Checked
            TSB_OpenFN.CheckState = CheckState.Checked
        End If

    End Sub

    Private Sub AboutHTMLEditorBaseBasicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutHTMLEditorBaseBasicToolStripMenuItem.Click
        MWAHTMLEditorBaseInfo.Show()

    End Sub

    Private Sub CreditsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditsToolStripMenuItem.Click
        MWCredits.Show()

    End Sub

    Private Sub TSB_Reload_Click(sender As Object, e As EventArgs) Handles TSB_Reload.Click
        TB_Reload()

    End Sub

    Private Sub TSB_AutoReload_Click(sender As Object, e As EventArgs) Handles TSB_AutoReload.Click
        TB_Auto_Reload()

    End Sub

    Private Sub Reload_Timer1_Tick(sender As Object, e As EventArgs) Handles Reload_Timer1.Tick
        If RTBE_First.Focused Then
            WBV1.DocumentText = RTBE_First.Text
        End If

    End Sub

    Private Sub TSB_OpenIB_Click(sender As Object, e As EventArgs) Handles TSB_OpenIB.Click

    End Sub

    '------------------------------
    'Logics
    '------------------------------

    Private Sub TB_NewProject()


    End Sub

    Private Sub TB_OpenProject()
        Dim open As New OpenFileDialog()
        Dim mystreamreader As System.IO.StreamReader
        open.Filter = "HTML Editor Base Project (*.pheb)|*.pheb|HVH (*.heb)|*.heb|HTML (*.html)|*.html"
        open.Title = "Open Project..."
        open.ShowDialog(Me)
        Try
            open.OpenFile()
            mystreamreader = System.IO.File.OpenText(open.FileName)
            RTBE_First.Text = mystreamreader.ReadToEnd()
        Catch ex As Exception
            ' Do nothing on excepcions
        End Try

    End Sub

    Private Sub TB_AddEmptyFileToProject()
        RTBE_First.Clear()
        RTBE_First.Text = "<!DOCTYPE html PUBLIC - File created in HTML Editor Base>" _
                            + vbNewLine + "<html>" _
                            + vbNewLine + "<head>" + vbNewLine _
                            + vbNewLine + "</head>" _
                            + vbNewLine + "<body>" + vbNewLine _
                            + vbNewLine + "</body>" _
                            + vbNewLine + "</html>"

    End Sub

    Private Sub TB_AddFileToProject()
        Dim open As New OpenFileDialog()
        Dim mystreamreader As System.IO.StreamReader
        open.Filter = "HTML (*.html)|*.html|XHTML (*.xhtml)|*.xhtml|HTM (*.htm)|*.htm|CSS (*.css)|*.css|HEB (*.heb)|*.heb|Text Document (*.txt)|*.txt|All Files (*.*)|*.*"
        open.Title = "Open ..."
        open.ShowDialog(Me)
        Try
            open.OpenFile()
            mystreamreader = System.IO.File.OpenText(open.FileName)
            RTBE_First.Text = mystreamreader.ReadToEnd()
        Catch ex As Exception
            ' Do nothing on excepcions
        End Try

    End Sub

    Private Sub TB_SaveFileProject()


    End Sub

    Private Sub TB_SaveAllFilesProject()


    End Sub

    '------------------------------
    'End Logics
    '------------------------------
    '**************************************
    '------------------------------
    'Basics
    '------------------------------

    Private Sub TB_Undo()
        RTBE_First.Undo()

    End Sub

    Private Sub TB_Redo()
        RTBE_First.Redo()

    End Sub

    Private Sub TB_Cut()
        RTBE_First.Cut()

    End Sub

    Private Sub TB_Copy()
        RTBE_First.Copy()

    End Sub

    Private Sub TB_Paste()
        RTBE_First.Paste()

    End Sub

    Private Sub TB_Remove()
        RTBE_First.SelectedText = ""

    End Sub

    Private Sub TB_Select_All()
        RTBE_First.SelectAll()

    End Sub

    Private Sub TB_Reload()
        WBV1.DocumentText = RTBE_First.Text

    End Sub

    Private Sub TB_Auto_Reload()
        If Reload_Timer1.Enabled = True Then
            Reload_Timer1.Stop()
        Else
            Reload_Timer1.Start()
        End If

    End Sub

    Private Sub TB_OpeninBrowser()
        'Process.Start()

    End Sub

    '------------------------------
    'End Basics
    '------------------------------

    Private Sub TSB_Cut_Click(sender As Object, e As EventArgs) Handles TSB_Cut.Click
        TB_Cut()

    End Sub

    Private Sub TSB_Copy_Click(sender As Object, e As EventArgs) Handles TSB_Copy.Click
        TB_Copy()

    End Sub

    Private Sub TSB_Paste_Click(sender As Object, e As EventArgs) Handles TSB_Paste.Click
        TB_Paste()

    End Sub

    Private Sub TSB_Remove_Click(sender As Object, e As EventArgs) Handles TSB_Remove.Click
        TB_Remove()

    End Sub

    Private Sub CutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem1.Click
        TB_Cut()

    End Sub

    Private Sub CopyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem1.Click
        TB_Copy()

    End Sub

    Private Sub PasteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem1.Click
        TB_Paste()

    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        TB_Remove()

    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        TB_Cut()

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        TB_Copy()

    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        TB_Paste()

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        TB_Remove()

    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        TB_Select_All()

    End Sub

    Private Sub SelectAllToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem1.Click
        TB_Select_All()

    End Sub

    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        TB_Reload()

    End Sub

    Private Sub TSB_Undo_Click(sender As Object, e As EventArgs) Handles TSB_Undo.Click
        TB_Undo()

    End Sub

    Private Sub TSB_Redo_Click(sender As Object, e As EventArgs) Handles TSB_Redo.Click
        TB_Redo()

    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        TB_Undo()

    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        TB_Redo()

    End Sub


    '*************************
    'The management system
    '*************************
    Private Sub TSB_NewProject_Click(sender As Object, e As EventArgs) Handles TSB_NewProject.Click
        TB_NewProject()

    End Sub

    Private Sub TSB_OpenProject_Click(sender As Object, e As EventArgs) Handles TSB_OpenProject.Click
        TB_OpenProject()

    End Sub

    Private Sub TSB_Save_Click(sender As Object, e As EventArgs) Handles TSB_Save.Click
        TB_SaveFileProject()

    End Sub

    Private Sub TSB_SaveAll_Click(sender As Object, e As EventArgs) Handles TSB_SaveAll.Click
        TB_SaveAllFilesProject()

    End Sub

    Private Sub NewProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProjectToolStripMenuItem.Click
        TB_NewProject()

    End Sub

    Private Sub OpenProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenProjectToolStripMenuItem.Click
        TB_OpenProject()

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        TB_SaveFileProject()

    End Sub

    Private Sub SaveAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAllToolStripMenuItem.Click
        TB_SaveAllFilesProject()

    End Sub

    Private Sub TSB_AddFile_Click(sender As Object, e As EventArgs) Handles TSB_AddFile.Click
        TB_AddEmptyFileToProject()

    End Sub

    Private Sub TSB_SearchFiletoAdd_Click(sender As Object, e As EventArgs) Handles TSB_SearchFiletoAdd.Click
        TB_AddFileToProject()

    End Sub

    Private Sub NewFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewFileToolStripMenuItem.Click
        TB_AddEmptyFileToProject()

    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        TB_AddFileToProject()

    End Sub

    '*************************
    'End management system
    '*************************

    '---------------------
    'Features
    '---------------------



    '---------------------
    'End Features
    '---------------------

    Public Sub CorrectAllTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorrectAllTextToolStripMenuItem.Click
        HTMLEditorBase.CodeRefOne.EX_ASCII_ISO_Syn_To()

    End Sub

    Private Sub ResetAllTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetAllTextToolStripMenuItem.Click
        HTMLEditorBase.CodeRefOne.EX_ASCII_ISO_Syn_Reset()

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        MainWSettings.Show()

    End Sub

    Private Sub WBV1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WBV1.DocumentCompleted
        WBV1_WN.Text = "Page Name: " + WBV1.Url.ToString
        'ToolStripProgressBar1.Value = 0

    End Sub

    Private Sub WBV1_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles WBV1.ProgressChanged
        ToolStripProgressBar1.Maximum = e.MaximumProgress
        ToolStripProgressBar1.Value = e.CurrentProgress

    End Sub

    Private Sub ColorValueToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ColorValueToolStripMenuItem1.Click
        Dim colorDialog1 As New ColorDialog()

        colorDialog1.Color = Color.White

        If (colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then

            ' Change the selection color to the user specified color.
            RTBE_First.SelectedText = System.Drawing.ColorTranslator.ToHtml(colorDialog1.Color)
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        RTBE_First.SelectedText = "<" + RTBE_First.SelectedText + ">"

    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        RTBE_First.SelectedText = "</" + RTBE_First.SelectedText + ">"

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        RTBE_First.SelectedText = "(" + RTBE_First.SelectedText + ")"

    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        RTBE_First.SelectedText = "{" + RTBE_First.SelectedText + "}"

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        RTBE_First.SelectedText = "[" + RTBE_First.SelectedText + "]"

    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        RTBE_First.SelectedText = "|" + RTBE_First.SelectedText + "|"

    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        RTBE_First.SelectedText = """" + RTBE_First.SelectedText + """"

    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        RTBE_First.SelectedText = ":" + RTBE_First.SelectedText + ":"

    End Sub

    Private Sub OpenWebBrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenWebBrowserToolStripMenuItem.Click
        TB_OpeninBrowser()

    End Sub

    Private Sub UpdateWebsiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateWebsiteToolStripMenuItem.Click
        TB_Reload()

    End Sub

    Private Sub AutoUpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoUpdateToolStripMenuItem.Click
        TB_Auto_Reload()

    End Sub

    Private Sub RTBE_First_TextChanged(sender As Object, e As EventArgs) Handles RTBE_First.TextChanged

    End Sub

End Class

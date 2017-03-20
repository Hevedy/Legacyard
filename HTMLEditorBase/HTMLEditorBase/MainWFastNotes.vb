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

Public Class MainWFastNotes

    Dim ActiveBoxB As New TextBox

    Private Sub MainWFastNotes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        MainWindow.FastNotesToolStripMenuItem.Checked = False
        MainWindow.TSB_OpenFN.Checked = False
    End Sub

    Private Sub MainWFastNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BringToFront()
        Me.TopMost = True
    End Sub

    Private Sub MWFN_B_Close_Click(sender As Object, e As EventArgs) Handles MWFN_B_Close.Click
        MainWindow.FastNotesToolStripMenuItem.Checked = False
        MainWindow.TSB_OpenFN.Checked = False
        Me.Hide()
    End Sub

    Private Sub B_N_1_Click(sender As Object, e As EventArgs) Handles B_N_1.Click
        TB_N_1.SelectAll()
        TB_N_1.Copy()

        MainWindow.RTBE_First.Paste()
    End Sub

    Private Sub B_N_2_Click(sender As Object, e As EventArgs) Handles B_N_2.Click
        TB_N_2.SelectAll()
        TB_N_2.Copy()

        MainWindow.RTBE_First.Paste()
    End Sub

    Private Sub MWFN_B_AddS_Click(sender As Object, e As EventArgs) Handles MWFN_B_AddS.Click
        Dim CurText_MWFN As TextBox = sender

        If CurText_MWFN.Equals(TB_N_1) Then
            TB_N_1.Select()
            TB_N_1.Copy()

        ElseIf CurText_MWFN.Equals(TB_N_2) Then
            TB_N_2.Select()
            TB_N_2.Copy()

        End If

        MainWindow.RTBE_First.Paste()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        ActiveBoxB.Cut()

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        ActiveBoxB.Copy()

    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        ActiveBoxB.Paste()

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        ActiveBoxB.SelectedText = ""

    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        ActiveBoxB.SelectAll()

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ActiveBoxB.Clear()

    End Sub

    Private Sub TB_N_1_Click(sender As Object, e As EventArgs) Handles TB_N_1.Click
        ActiveBoxB = TB_N_1
    End Sub


    Private Sub TB_N_1_TextChanged(sender As Object, e As EventArgs) Handles TB_N_1.TextChanged
        ActiveBoxB = TB_N_1

    End Sub

    Private Sub TB_N_2_Click(sender As Object, e As EventArgs) Handles TB_N_2.Click
        ActiveBoxB = TB_N_2

    End Sub

    Private Sub TB_N_2_TextChanged(sender As Object, e As EventArgs) Handles TB_N_2.TextChanged
        ActiveBoxB = TB_N_2

    End Sub
End Class
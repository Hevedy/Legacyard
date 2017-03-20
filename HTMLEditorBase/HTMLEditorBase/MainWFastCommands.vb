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

Public Class MainWFastCommands

    'Private Property ActiveBox As String
    Dim ActiveBoxA As New TextBox

    Private Sub MainWFastCommands_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        MainWindow.FastCommandsToolStripMenuItem.Checked = False
        MainWindow.TSB_OpenFC.Checked = False
    End Sub

    Private Sub MainWFastCommands_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BringToFront()
        Me.TopMost = True
    End Sub

    Private Sub B_SC_1_Click(sender As Object, e As EventArgs) Handles B_SC_1.Click
        TB_SC_1.SelectAll()
        TB_SC_1.Copy()

        MainWindow.RTBE_First.Paste()
    End Sub

    Private Sub B_SC_2_Click(sender As Object, e As EventArgs) Handles B_SC_2.Click
        TB_SC_2.SelectAll()
        TB_SC_2.Copy()

        MainWindow.RTBE_First.Paste()
    End Sub

    Private Sub B_SC_3_Click(sender As Object, e As EventArgs) Handles B_SC_3.Click
        TB_SC_3.SelectAll()
        TB_SC_3.Copy()

        MainWindow.RTBE_First.Paste()
    End Sub

    Private Sub B_LC_1_Click(sender As Object, e As EventArgs) Handles B_LC_1.Click
        TB_LC_1.SelectAll()
        TB_LC_1.Copy()

        MainWindow.RTBE_First.Paste()
    End Sub

    Private Sub B_LC_2_Click(sender As Object, e As EventArgs) Handles B_LC_2.Click
        TB_LC_2.SelectAll()
        TB_LC_2.Copy()

        MainWindow.RTBE_First.Paste()
    End Sub

    Private Sub B_LC_3_Click(sender As Object, e As EventArgs) Handles B_LC_3.Click
        TB_LC_3.SelectAll()
        TB_LC_3.Copy()

        MainWindow.RTBE_First.Paste()
    End Sub

    Private Sub MWFC_B_Close_Click(sender As Object, e As EventArgs) Handles MWFC_B_Close.Click
        MainWindow.FastCommandsToolStripMenuItem.Checked = False
        MainWindow.TSB_OpenFC.Checked = False
        Me.Hide()
    End Sub

    Private Sub MWFC_B_AddS_Click(sender As Object, e As EventArgs) Handles MWFC_B_AddS.Click
        Dim CurText_MWFC As TextBox = sender

        If CurText_MWFC.Equals(TB_SC_1) Then
            TB_SC_1.Select()
            TB_SC_1.Copy()

        ElseIf CurText_MWFC.Equals(TB_SC_2) Then
            TB_SC_2.Select()
            TB_SC_2.Copy()

        ElseIf CurText_MWFC.Equals(TB_SC_3) Then
            TB_SC_3.Select()
            TB_SC_3.Copy()

        ElseIf CurText_MWFC.Equals(TB_LC_1) Then
            TB_LC_1.Select()
            TB_LC_1.Copy()

        ElseIf CurText_MWFC.Equals(TB_LC_2) Then
            TB_LC_2.Select()
            TB_LC_2.Copy()

        ElseIf CurText_MWFC.Equals(TB_LC_3) Then
            TB_LC_3.Select()
            TB_LC_3.Copy()

        End If

        MainWindow.RTBE_First.Paste()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        ActiveBoxA.Cut()

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        ActiveBoxA.Copy()

    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        ActiveBoxA.Paste()

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        ActiveBoxA.SelectedText = ""

    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        ActiveBoxA.SelectAll()

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ActiveBoxA.Clear()

    End Sub

    Private Sub TB_SC_1_Click(sender As Object, e As EventArgs) Handles TB_SC_1.Click
        ActiveBoxA = TB_SC_1

    End Sub


    Private Sub TB_SC_1_TextChanged(sender As Object, e As EventArgs) Handles TB_SC_1.TextChanged
        ActiveBoxA = TB_SC_1

    End Sub

    Private Sub TB_SC_2_Click(sender As Object, e As EventArgs) Handles TB_SC_2.Click
        ActiveBoxA = TB_SC_2

    End Sub

    Private Sub TB_SC_2_TextChanged(sender As Object, e As EventArgs) Handles TB_SC_2.TextChanged
        ActiveBoxA = TB_SC_2

    End Sub

    Private Sub TB_SC_3_Click(sender As Object, e As EventArgs) Handles TB_SC_3.Click
        ActiveBoxA = TB_SC_3

    End Sub

    Private Sub TB_SC_3_TextChanged(sender As Object, e As EventArgs) Handles TB_SC_3.TextChanged
        ActiveBoxA = TB_SC_3

    End Sub

    Private Sub TB_LC_1_Click(sender As Object, e As EventArgs) Handles TB_LC_1.Click
        ActiveBoxA = TB_LC_1

    End Sub

    Private Sub TB_LC_1_TextChanged(sender As Object, e As EventArgs) Handles TB_LC_1.TextChanged
        ActiveBoxA = TB_LC_1

    End Sub

    Private Sub TB_LC_2_Click(sender As Object, e As EventArgs) Handles TB_LC_2.Click
        ActiveBoxA = TB_LC_2

    End Sub

    Private Sub TB_LC_2_TextChanged(sender As Object, e As EventArgs) Handles TB_LC_2.TextChanged
        ActiveBoxA = TB_LC_2

    End Sub

    Private Sub TB_LC_3_Click(sender As Object, e As EventArgs) Handles TB_LC_3.Click
        ActiveBoxA = TB_LC_3

    End Sub

    Private Sub TB_LC_3_TextChanged(sender As Object, e As EventArgs) Handles TB_LC_3.TextChanged
        ActiveBoxA = TB_LC_3

    End Sub

End Class
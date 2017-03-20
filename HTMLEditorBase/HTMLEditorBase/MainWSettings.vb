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

Public Class MainWSettings


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub MainWSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TestTextLoad()

    End Sub

    Private Sub TestTextLoad()
        RichTextBox_Test.Text = "HTML Editor Base" _
            + vbNewLine + vbNewLine + "<html>" + vbNewLine + vbNewLine + "This is a example text" _
        + vbNewLine + "1. The line one" + vbNewLine + "2. The line two" + vbNewLine + vbNewLine + _
        "1234567890" + vbNewLine + "ABCDEFGHIJKLMNOPQRSTUVWXYZ" + vbNewLine + "abcdefghijklmnopqrstuvwxyz" _
        + vbNewLine + "<body></body>" + vbNewLine + "</html>"

        RichTextBox_Test.BackColor = MainWindow.RTBE_First.BackColor
        RichTextBox_Test.ForeColor = MainWindow.RTBE_First.ForeColor
        RichTextBox_Test.Font = MainWindow.RTBE_First.Font
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim colorDialog1 As New ColorDialog()

        ' Set the initial color of the dialog to the current text color.
        colorDialog1.Color = RichTextBox_Test.BackColor

        ' Determine if the user clicked OK in the dialog and that the color has 
        ' changed. 
        If (colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) _
            And Not (colorDialog1.Color.Equals(RichTextBox_Test.BackColor)) Then

            ' Change the selection color to the user specified color.
            RichTextBox_Test.BackColor = colorDialog1.Color
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim colorDialog2 As New ColorDialog()

        ' Set the initial color of the dialog to the current text color.
        colorDialog2.Color = RichTextBox_Test.ForeColor

        ' Determine if the user clicked OK in the dialog and that the color has 
        ' changed. 
        If (colorDialog2.ShowDialog() = System.Windows.Forms.DialogResult.OK) _
            And Not (colorDialog2.Color.Equals(RichTextBox_Test.ForeColor)) Then

            ' Change the selection color to the user specified color.
            RichTextBox_Test.ForeColor = colorDialog2.Color
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim fontDialog1 As New FontDialog()

        ' Set the initial color of the dialog to the current text color.
        fontDialog1.Font = RichTextBox_Test.Font

        ' Determine if the user clicked OK in the dialog and that the color has 
        ' changed. 
        If (fontDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) _
            And Not (fontDialog1.Font.Equals(RichTextBox_Test.Font)) Then

            ' Change the selection color to the user specified color.
            RichTextBox_Test.Font = fontDialog1.Font
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.CanSelect Then
            MainWindow.RTBE_First.Font = RichTextBox_Test.Font
            MainWindow.RTBE_First.ForeColor = RichTextBox_Test.ForeColor
            MainWindow.RTBE_First.BackColor = RichTextBox_Test.BackColor
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        GroupBox2.Enabled = True
        GroupBox1.Enabled = False

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        GroupBox1.Enabled = True
        GroupBox2.Enabled = False

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Default" Then
            RichTextBox_Test.Font = New System.Drawing.Font("Courier New", 10, FontStyle.Regular)
            RichTextBox_Test.ForeColor = Color.Black
            RichTextBox_Test.BackColor = Color.White

        ElseIf ComboBox1.Text = "Obsidian" Then
            RichTextBox_Test.Font = New System.Drawing.Font("Courier New", 10, FontStyle.Regular)
            RichTextBox_Test.ForeColor = Color.FromArgb(224, 226, 228)
            RichTextBox_Test.BackColor = Color.FromArgb(41, 49, 52)

        ElseIf ComboBox1.Text = "BluePower" Then
            RichTextBox_Test.Font = New System.Drawing.Font("Courier New", 10, FontStyle.Regular)
            RichTextBox_Test.ForeColor = Color.WhiteSmoke
            RichTextBox_Test.BackColor = Color.DarkBlue
            'RichTextBox_Test.ForeColor = Color.FromArgb(224, 226, 228)
            'RichTextBox_Test.BackColor = Color.FromArgb(41, 49, 52)

        ElseIf ComboBox1.Text = "Hacker" Then
            RichTextBox_Test.Font = New System.Drawing.Font("Courier New", 10, FontStyle.Regular)
            RichTextBox_Test.ForeColor = Color.Green
            RichTextBox_Test.BackColor = Color.Black

        Else
            MsgBox("This Style don´t exist", MessageBoxIcon.Error)

        End If

    End Sub
End Class
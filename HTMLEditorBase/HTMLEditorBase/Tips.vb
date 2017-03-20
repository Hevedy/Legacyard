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

Public Class Tips

    Private Sub Tips_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tips_Gen()
        Me.BringToFront()
        Me.TopMost = True
    End Sub

    Private Sub T_B_Next_Click(sender As Object, e As EventArgs) Handles T_B_Next.Click
        Tips_Gen()
    End Sub

    Private Sub Tips_Gen()
        TB_Tips.Text = Int(Rnd() * 12)
        Select Case TB_Tips.Text
            Case 0
                TB_Tips.Text = "Use the new Shortcuts (F1,F2,F3,F4,F5,F6,F7)."
            Case 1
                TB_Tips.Text = "With new tools for your website."
            Case 2
                TB_Tips.Text = "Original made by Hevedy."
            Case 3
                TB_Tips.Text = "Multiple save formats."
            Case 4
                TB_Tips.Text = "Make good websites with HTML Editor Base."
            Case 5
                TB_Tips.Text = "Make Websites with this tools."
            Case 6
                TB_Tips.Text = "See the license."
            Case 7
                TB_Tips.Text = "You're free to do whatever you want."
            Case 8
                TB_Tips.Text = ";) :O."
            Case 9
                TB_Tips.Text = "Free for all."
            Case 10
                TB_Tips.Text = "Visit the original repository of HTML Editor Base at https://github.com/Hevedy ."
            Case 11
                TB_Tips.Text = "Contributes to the development of HTML Editor Base in https://github.com/Hevedy . ;)"
        End Select
    End Sub

    Private Sub T_B_Close_Click(sender As Object, e As EventArgs) Handles T_B_Close.Click
        Me.Hide()
    End Sub

End Class
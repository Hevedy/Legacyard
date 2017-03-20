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

Public Class Startup

    Private Sub Startup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BringToFront()
        Me.TopMost = True
        S_T_LoadFile.Text = "Loading..."
        Timer1.Start()
        Timer2.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        S_PB_FL.Increment(4)
        If S_PB_FL.Value = S_PB_FL.Maximum Then
            Timer1.Stop()
            Timer2.Stop()
            S_T_LoadFile.Text = "Initiating..."
            MainWindow.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Fake_LoadFile_Gen()

    End Sub

    Private Sub Fake_LoadFile_Gen()
        S_T_LoadFile.Text = Int(Rnd() * 10)
        Select Case S_T_LoadFile.Text
            Case 0
                S_T_LoadFile.Text = "Loading Interfaces..."
            Case 1
                S_T_LoadFile.Text = "Loading ToolBoxs..."
            Case 2
                S_T_LoadFile.Text = "Loading Bars..."
            Case 3
                S_T_LoadFile.Text = "Loading File Formats..."
            Case 4
                S_T_LoadFile.Text = "Loading Windows..."
            Case 5
                S_T_LoadFile.Text = "Loading Bars..."
            Case 6
                S_T_LoadFile.Text = "Loading Menus..."
            Case 7
                S_T_LoadFile.Text = "Checking Configs..."
            Case 8
                S_T_LoadFile.Text = "Starting..."
            Case 9
                S_T_LoadFile.Text = "Loading Images...."
        End Select

    End Sub

End Class
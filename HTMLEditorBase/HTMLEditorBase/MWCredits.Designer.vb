'-----------------------------------------------------------------------------
' Copyright (c) 2014-2016 Hevedy <github.com/Hevedy>
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

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MWCredits
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.S_T_C_2 = New System.Windows.Forms.Label()
        Me.S_T_C_1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.S_T_Credits = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(56, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Hevedy"
        '
        'S_T_C_2
        '
        Me.S_T_C_2.AutoSize = True
        Me.S_T_C_2.BackColor = System.Drawing.Color.Transparent
        Me.S_T_C_2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S_T_C_2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.S_T_C_2.Location = New System.Drawing.Point(46, 102)
        Me.S_T_C_2.Name = "S_T_C_2"
        Me.S_T_C_2.Size = New System.Drawing.Size(70, 17)
        Me.S_T_C_2.TabIndex = 20
        Me.S_T_C_2.Text = "Designers:"
        '
        'S_T_C_1
        '
        Me.S_T_C_1.AutoSize = True
        Me.S_T_C_1.BackColor = System.Drawing.Color.Transparent
        Me.S_T_C_1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S_T_C_1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.S_T_C_1.Location = New System.Drawing.Point(46, 54)
        Me.S_T_C_1.Name = "S_T_C_1"
        Me.S_T_C_1.Size = New System.Drawing.Size(94, 17)
        Me.S_T_C_1.TabIndex = 18
        Me.S_T_C_1.Text = "Programmers:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(56, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Hevedy"
        '
        'S_T_Credits
        '
        Me.S_T_Credits.AutoSize = True
        Me.S_T_Credits.BackColor = System.Drawing.Color.Transparent
        Me.S_T_Credits.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S_T_Credits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.S_T_Credits.Location = New System.Drawing.Point(32, 27)
        Me.S_T_Credits.Name = "S_T_Credits"
        Me.S_T_Credits.Size = New System.Drawing.Size(53, 17)
        Me.S_T_Credits.TabIndex = 16
        Me.S_T_Credits.Text = "Credits:"
        '
        'MWCredits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 205)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.S_T_C_2)
        Me.Controls.Add(Me.S_T_C_1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.S_T_Credits)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MWCredits"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Credits of HTML Editor Base"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents S_T_C_2 As System.Windows.Forms.Label
    Friend WithEvents S_T_C_1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents S_T_Credits As System.Windows.Forms.Label
End Class

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

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tips
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
        Me.TB_Tips = New System.Windows.Forms.TextBox()
        Me.T_B_Next = New System.Windows.Forms.Button()
        Me.T_B_Close = New System.Windows.Forms.Button()
        Me.T_T_1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TB_Tips
        '
        Me.TB_Tips.Enabled = False
        Me.TB_Tips.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Tips.Location = New System.Drawing.Point(12, 33)
        Me.TB_Tips.MaxLength = 500
        Me.TB_Tips.Multiline = True
        Me.TB_Tips.Name = "TB_Tips"
        Me.TB_Tips.Size = New System.Drawing.Size(260, 202)
        Me.TB_Tips.TabIndex = 0
        '
        'T_B_Next
        '
        Me.T_B_Next.Location = New System.Drawing.Point(197, 252)
        Me.T_B_Next.Name = "T_B_Next"
        Me.T_B_Next.Size = New System.Drawing.Size(75, 23)
        Me.T_B_Next.TabIndex = 1
        Me.T_B_Next.Text = "Next >>"
        Me.T_B_Next.UseVisualStyleBackColor = True
        '
        'T_B_Close
        '
        Me.T_B_Close.Location = New System.Drawing.Point(12, 252)
        Me.T_B_Close.Name = "T_B_Close"
        Me.T_B_Close.Size = New System.Drawing.Size(75, 23)
        Me.T_B_Close.TabIndex = 2
        Me.T_B_Close.Text = "Close"
        Me.T_B_Close.UseVisualStyleBackColor = True
        '
        'T_T_1
        '
        Me.T_T_1.AutoSize = True
        Me.T_T_1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_T_1.Location = New System.Drawing.Point(12, 10)
        Me.T_T_1.Name = "T_T_1"
        Me.T_T_1.Size = New System.Drawing.Size(39, 20)
        Me.T_T_1.TabIndex = 3
        Me.T_T_1.Text = "Tips:"
        '
        'Tips
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 287)
        Me.Controls.Add(Me.T_T_1)
        Me.Controls.Add(Me.T_B_Close)
        Me.Controls.Add(Me.T_B_Next)
        Me.Controls.Add(Me.TB_Tips)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tips"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tips"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_Tips As System.Windows.Forms.TextBox
    Friend WithEvents T_B_Next As System.Windows.Forms.Button
    Friend WithEvents T_B_Close As System.Windows.Forms.Button
    Friend WithEvents T_T_1 As System.Windows.Forms.Label
End Class

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
Partial Class Startup
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
        Me.components = New System.ComponentModel.Container()
        Me.S_T_License = New System.Windows.Forms.Label()
        Me.S_T_Product = New System.Windows.Forms.Label()
        Me.S_T_Credits = New System.Windows.Forms.Label()
        Me.S_PB_FL = New System.Windows.Forms.ProgressBar()
        Me.S_T_PT = New System.Windows.Forms.Label()
        Me.S_T_Version = New System.Windows.Forms.Label()
        Me.S_T_VT = New System.Windows.Forms.Label()
        Me.S_T_LT = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.S_T_LoadFile = New System.Windows.Forms.Label()
        Me.S_T_C_1 = New System.Windows.Forms.Label()
        Me.S_T_C_2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'S_T_License
        '
        Me.S_T_License.AutoSize = True
        Me.S_T_License.BackColor = System.Drawing.Color.Transparent
        Me.S_T_License.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S_T_License.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.S_T_License.Location = New System.Drawing.Point(120, 272)
        Me.S_T_License.Name = "S_T_License"
        Me.S_T_License.Size = New System.Drawing.Size(54, 17)
        Me.S_T_License.TabIndex = 0
        Me.S_T_License.Text = "License:"
        '
        'S_T_Product
        '
        Me.S_T_Product.AutoSize = True
        Me.S_T_Product.BackColor = System.Drawing.Color.Transparent
        Me.S_T_Product.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S_T_Product.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.S_T_Product.Location = New System.Drawing.Point(120, 172)
        Me.S_T_Product.Name = "S_T_Product"
        Me.S_T_Product.Size = New System.Drawing.Size(59, 17)
        Me.S_T_Product.TabIndex = 2
        Me.S_T_Product.Text = "Product:"
        '
        'S_T_Credits
        '
        Me.S_T_Credits.AutoSize = True
        Me.S_T_Credits.BackColor = System.Drawing.Color.Transparent
        Me.S_T_Credits.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S_T_Credits.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.S_T_Credits.Location = New System.Drawing.Point(473, 112)
        Me.S_T_Credits.Name = "S_T_Credits"
        Me.S_T_Credits.Size = New System.Drawing.Size(53, 17)
        Me.S_T_Credits.TabIndex = 3
        Me.S_T_Credits.Text = "Credits:"
        '
        'S_PB_FL
        '
        Me.S_PB_FL.Location = New System.Drawing.Point(279, 305)
        Me.S_PB_FL.Name = "S_PB_FL"
        Me.S_PB_FL.Size = New System.Drawing.Size(226, 10)
        Me.S_PB_FL.TabIndex = 5
        '
        'S_T_PT
        '
        Me.S_T_PT.AutoSize = True
        Me.S_T_PT.BackColor = System.Drawing.Color.Transparent
        Me.S_T_PT.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.S_T_PT.Location = New System.Drawing.Point(134, 193)
        Me.S_T_PT.Name = "S_T_PT"
        Me.S_T_PT.Size = New System.Drawing.Size(94, 13)
        Me.S_T_PT.TabIndex = 6
        Me.S_T_PT.Text = "HTML Editor Base"
        '
        'S_T_Version
        '
        Me.S_T_Version.AutoSize = True
        Me.S_T_Version.BackColor = System.Drawing.Color.Transparent
        Me.S_T_Version.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S_T_Version.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.S_T_Version.Location = New System.Drawing.Point(120, 223)
        Me.S_T_Version.Name = "S_T_Version"
        Me.S_T_Version.Size = New System.Drawing.Size(56, 17)
        Me.S_T_Version.TabIndex = 7
        Me.S_T_Version.Text = "Version:"
        '
        'S_T_VT
        '
        Me.S_T_VT.AutoSize = True
        Me.S_T_VT.BackColor = System.Drawing.Color.Transparent
        Me.S_T_VT.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.S_T_VT.Location = New System.Drawing.Point(134, 245)
        Me.S_T_VT.Name = "S_T_VT"
        Me.S_T_VT.Size = New System.Drawing.Size(46, 13)
        Me.S_T_VT.TabIndex = 8
        Me.S_T_VT.Text = "1.0.3.13"
        '
        'S_T_LT
        '
        Me.S_T_LT.AutoSize = True
        Me.S_T_LT.BackColor = System.Drawing.Color.Transparent
        Me.S_T_LT.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.S_T_LT.Location = New System.Drawing.Point(134, 293)
        Me.S_T_LT.Name = "S_T_LT"
        Me.S_T_LT.Size = New System.Drawing.Size(26, 13)
        Me.S_T_LT.TabIndex = 9
        Me.S_T_LT.Text = "MIT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.Location = New System.Drawing.Point(497, 160)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Hevedy"
        '
        'S_T_LoadFile
        '
        Me.S_T_LoadFile.AutoSize = True
        Me.S_T_LoadFile.BackColor = System.Drawing.Color.Transparent
        Me.S_T_LoadFile.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.S_T_LoadFile.Location = New System.Drawing.Point(276, 289)
        Me.S_T_LoadFile.Name = "S_T_LoadFile"
        Me.S_T_LoadFile.Size = New System.Drawing.Size(67, 13)
        Me.S_T_LoadFile.TabIndex = 11
        Me.S_T_LoadFile.Text = "Loading_File"
        '
        'S_T_C_1
        '
        Me.S_T_C_1.AutoSize = True
        Me.S_T_C_1.BackColor = System.Drawing.Color.Transparent
        Me.S_T_C_1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S_T_C_1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.S_T_C_1.Location = New System.Drawing.Point(487, 139)
        Me.S_T_C_1.Name = "S_T_C_1"
        Me.S_T_C_1.Size = New System.Drawing.Size(94, 17)
        Me.S_T_C_1.TabIndex = 12
        Me.S_T_C_1.Text = "Programmers:"
        '
        'S_T_C_2
        '
        Me.S_T_C_2.AutoSize = True
        Me.S_T_C_2.BackColor = System.Drawing.Color.Transparent
        Me.S_T_C_2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S_T_C_2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.S_T_C_2.Location = New System.Drawing.Point(487, 187)
        Me.S_T_C_2.Name = "S_T_C_2"
        Me.S_T_C_2.Size = New System.Drawing.Size(70, 17)
        Me.S_T_C_2.TabIndex = 14
        Me.S_T_C_2.Text = "Designers:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(497, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Hevedy"
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 300
        '
        'Startup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 350)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.S_T_C_2)
        Me.Controls.Add(Me.S_T_C_1)
        Me.Controls.Add(Me.S_T_LoadFile)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.S_T_LT)
        Me.Controls.Add(Me.S_T_VT)
        Me.Controls.Add(Me.S_T_Version)
        Me.Controls.Add(Me.S_T_PT)
        Me.Controls.Add(Me.S_PB_FL)
        Me.Controls.Add(Me.S_T_Credits)
        Me.Controls.Add(Me.S_T_Product)
        Me.Controls.Add(Me.S_T_License)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Startup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Startup"
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents S_T_License As System.Windows.Forms.Label
    Friend WithEvents S_T_Product As System.Windows.Forms.Label
    Friend WithEvents S_T_Credits As System.Windows.Forms.Label
    Friend WithEvents S_PB_FL As System.Windows.Forms.ProgressBar
    Friend WithEvents S_T_PT As System.Windows.Forms.Label
    Friend WithEvents S_T_Version As System.Windows.Forms.Label
    Friend WithEvents S_T_VT As System.Windows.Forms.Label
    Friend WithEvents S_T_LT As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents S_T_LoadFile As System.Windows.Forms.Label
    Friend WithEvents S_T_C_1 As System.Windows.Forms.Label
    Friend WithEvents S_T_C_2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class

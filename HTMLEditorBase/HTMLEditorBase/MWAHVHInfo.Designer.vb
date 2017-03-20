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
Partial Class MWAHTMLEditorBaseInfo
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
        Me.S_T_LT = New System.Windows.Forms.Label()
        Me.S_T_VT = New System.Windows.Forms.Label()
        Me.S_T_Version = New System.Windows.Forms.Label()
        Me.S_T_PT = New System.Windows.Forms.Label()
        Me.S_T_Product = New System.Windows.Forms.Label()
        Me.S_T_License = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'S_T_LT
        '
        Me.S_T_LT.AutoSize = True
        Me.S_T_LT.BackColor = System.Drawing.Color.Transparent
        Me.S_T_LT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.S_T_LT.Location = New System.Drawing.Point(49, 165)
        Me.S_T_LT.Name = "S_T_LT"
        Me.S_T_LT.Size = New System.Drawing.Size(26, 13)
        Me.S_T_LT.TabIndex = 15
        Me.S_T_LT.Text = "MIT"
        '
        'S_T_VT
        '
        Me.S_T_VT.AutoSize = True
        Me.S_T_VT.BackColor = System.Drawing.Color.Transparent
        Me.S_T_VT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.S_T_VT.Location = New System.Drawing.Point(49, 117)
        Me.S_T_VT.Name = "S_T_VT"
        Me.S_T_VT.Size = New System.Drawing.Size(46, 13)
        Me.S_T_VT.TabIndex = 14
        Me.S_T_VT.Text = "1.0.3.13"
        '
        'S_T_Version
        '
        Me.S_T_Version.AutoSize = True
        Me.S_T_Version.BackColor = System.Drawing.Color.Transparent
        Me.S_T_Version.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S_T_Version.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.S_T_Version.Location = New System.Drawing.Point(35, 95)
        Me.S_T_Version.Name = "S_T_Version"
        Me.S_T_Version.Size = New System.Drawing.Size(56, 17)
        Me.S_T_Version.TabIndex = 13
        Me.S_T_Version.Text = "Version:"
        '
        'S_T_PT
        '
        Me.S_T_PT.AutoSize = True
        Me.S_T_PT.BackColor = System.Drawing.Color.Transparent
        Me.S_T_PT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.S_T_PT.Location = New System.Drawing.Point(49, 65)
        Me.S_T_PT.Name = "S_T_PT"
        Me.S_T_PT.Size = New System.Drawing.Size(94, 13)
        Me.S_T_PT.TabIndex = 12
        Me.S_T_PT.Text = "HTML Editor Base"
        '
        'S_T_Product
        '
        Me.S_T_Product.AutoSize = True
        Me.S_T_Product.BackColor = System.Drawing.Color.Transparent
        Me.S_T_Product.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S_T_Product.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.S_T_Product.Location = New System.Drawing.Point(35, 44)
        Me.S_T_Product.Name = "S_T_Product"
        Me.S_T_Product.Size = New System.Drawing.Size(59, 17)
        Me.S_T_Product.TabIndex = 11
        Me.S_T_Product.Text = "Product:"
        '
        'S_T_License
        '
        Me.S_T_License.AutoSize = True
        Me.S_T_License.BackColor = System.Drawing.Color.Transparent
        Me.S_T_License.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S_T_License.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.S_T_License.Location = New System.Drawing.Point(35, 144)
        Me.S_T_License.Name = "S_T_License"
        Me.S_T_License.Size = New System.Drawing.Size(54, 17)
        Me.S_T_License.TabIndex = 10
        Me.S_T_License.Text = "License:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(165, 130)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'MWAHTMLEditorBaseInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 229)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.S_T_LT)
        Me.Controls.Add(Me.S_T_VT)
        Me.Controls.Add(Me.S_T_Version)
        Me.Controls.Add(Me.S_T_PT)
        Me.Controls.Add(Me.S_T_Product)
        Me.Controls.Add(Me.S_T_License)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MWAHTMLEditorBaseInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About HTML Editor Base"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents S_T_LT As System.Windows.Forms.Label
    Friend WithEvents S_T_VT As System.Windows.Forms.Label
    Friend WithEvents S_T_Version As System.Windows.Forms.Label
    Friend WithEvents S_T_PT As System.Windows.Forms.Label
    Friend WithEvents S_T_Product As System.Windows.Forms.Label
    Friend WithEvents S_T_License As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

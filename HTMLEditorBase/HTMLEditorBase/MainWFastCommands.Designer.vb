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
Partial Class MainWFastCommands
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWFastCommands))
        Me.TB_SC_1 = New System.Windows.Forms.TextBox()
        Me.GCMS_Basic_FC = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TB_SC_2 = New System.Windows.Forms.TextBox()
        Me.TB_SC_3 = New System.Windows.Forms.TextBox()
        Me.MWFC_B_Close = New System.Windows.Forms.Button()
        Me.MWFC_B_AddS = New System.Windows.Forms.Button()
        Me.GB_SC = New System.Windows.Forms.GroupBox()
        Me.B_SC_3 = New System.Windows.Forms.Button()
        Me.B_SC_2 = New System.Windows.Forms.Button()
        Me.B_SC_1 = New System.Windows.Forms.Button()
        Me.GB_LC = New System.Windows.Forms.GroupBox()
        Me.B_LC_3 = New System.Windows.Forms.Button()
        Me.B_LC_2 = New System.Windows.Forms.Button()
        Me.B_LC_1 = New System.Windows.Forms.Button()
        Me.TB_LC_1 = New System.Windows.Forms.TextBox()
        Me.TB_LC_2 = New System.Windows.Forms.TextBox()
        Me.TB_LC_3 = New System.Windows.Forms.TextBox()
        Me.MWFC_T_1 = New System.Windows.Forms.Label()
        Me.GCMS_Basic_FC.SuspendLayout()
        Me.GB_SC.SuspendLayout()
        Me.GB_LC.SuspendLayout()
        Me.SuspendLayout()
        '
        'TB_SC_1
        '
        Me.TB_SC_1.ContextMenuStrip = Me.GCMS_Basic_FC
        Me.TB_SC_1.Location = New System.Drawing.Point(6, 19)
        Me.TB_SC_1.MaxLength = 50
        Me.TB_SC_1.Name = "TB_SC_1"
        Me.TB_SC_1.Size = New System.Drawing.Size(278, 20)
        Me.TB_SC_1.TabIndex = 0
        '
        'GCMS_Basic_FC
        '
        Me.GCMS_Basic_FC.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator2, Me.SelectAllToolStripMenuItem, Me.ToolStripSeparator1, Me.ClearToolStripMenuItem})
        Me.GCMS_Basic_FC.Name = "GCMS_Basic_FC"
        Me.GCMS_Basic_FC.Size = New System.Drawing.Size(123, 148)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = CType(resources.GetObject("DeleteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(119, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(119, 6)
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Image = CType(resources.GetObject("ClearToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'TB_SC_2
        '
        Me.TB_SC_2.ContextMenuStrip = Me.GCMS_Basic_FC
        Me.TB_SC_2.Location = New System.Drawing.Point(6, 45)
        Me.TB_SC_2.MaxLength = 50
        Me.TB_SC_2.Name = "TB_SC_2"
        Me.TB_SC_2.Size = New System.Drawing.Size(278, 20)
        Me.TB_SC_2.TabIndex = 1
        '
        'TB_SC_3
        '
        Me.TB_SC_3.ContextMenuStrip = Me.GCMS_Basic_FC
        Me.TB_SC_3.Location = New System.Drawing.Point(6, 71)
        Me.TB_SC_3.MaxLength = 50
        Me.TB_SC_3.Name = "TB_SC_3"
        Me.TB_SC_3.Size = New System.Drawing.Size(278, 20)
        Me.TB_SC_3.TabIndex = 2
        '
        'MWFC_B_Close
        '
        Me.MWFC_B_Close.Location = New System.Drawing.Point(12, 318)
        Me.MWFC_B_Close.Name = "MWFC_B_Close"
        Me.MWFC_B_Close.Size = New System.Drawing.Size(75, 23)
        Me.MWFC_B_Close.TabIndex = 5
        Me.MWFC_B_Close.Text = "Hide"
        Me.MWFC_B_Close.UseVisualStyleBackColor = True
        '
        'MWFC_B_AddS
        '
        Me.MWFC_B_AddS.Location = New System.Drawing.Point(219, 318)
        Me.MWFC_B_AddS.Name = "MWFC_B_AddS"
        Me.MWFC_B_AddS.Size = New System.Drawing.Size(116, 23)
        Me.MWFC_B_AddS.TabIndex = 6
        Me.MWFC_B_AddS.Text = "Add Selected"
        Me.MWFC_B_AddS.UseVisualStyleBackColor = True
        '
        'GB_SC
        '
        Me.GB_SC.Controls.Add(Me.B_SC_3)
        Me.GB_SC.Controls.Add(Me.B_SC_2)
        Me.GB_SC.Controls.Add(Me.B_SC_1)
        Me.GB_SC.Controls.Add(Me.TB_SC_1)
        Me.GB_SC.Controls.Add(Me.TB_SC_2)
        Me.GB_SC.Controls.Add(Me.TB_SC_3)
        Me.GB_SC.Location = New System.Drawing.Point(12, 33)
        Me.GB_SC.Name = "GB_SC"
        Me.GB_SC.Size = New System.Drawing.Size(323, 100)
        Me.GB_SC.TabIndex = 7
        Me.GB_SC.TabStop = False
        Me.GB_SC.Text = "Small Commands"
        '
        'B_SC_3
        '
        Me.B_SC_3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.B_SC_3.Location = New System.Drawing.Point(290, 70)
        Me.B_SC_3.Name = "B_SC_3"
        Me.B_SC_3.Size = New System.Drawing.Size(27, 20)
        Me.B_SC_3.TabIndex = 10
        Me.B_SC_3.Text = ">"
        Me.B_SC_3.UseVisualStyleBackColor = True
        '
        'B_SC_2
        '
        Me.B_SC_2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.B_SC_2.Location = New System.Drawing.Point(290, 45)
        Me.B_SC_2.Name = "B_SC_2"
        Me.B_SC_2.Size = New System.Drawing.Size(27, 20)
        Me.B_SC_2.TabIndex = 9
        Me.B_SC_2.Text = ">"
        Me.B_SC_2.UseVisualStyleBackColor = True
        '
        'B_SC_1
        '
        Me.B_SC_1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.B_SC_1.Location = New System.Drawing.Point(290, 19)
        Me.B_SC_1.Name = "B_SC_1"
        Me.B_SC_1.Size = New System.Drawing.Size(27, 20)
        Me.B_SC_1.TabIndex = 8
        Me.B_SC_1.Text = ">"
        Me.B_SC_1.UseVisualStyleBackColor = True
        '
        'GB_LC
        '
        Me.GB_LC.Controls.Add(Me.B_LC_3)
        Me.GB_LC.Controls.Add(Me.B_LC_2)
        Me.GB_LC.Controls.Add(Me.B_LC_1)
        Me.GB_LC.Controls.Add(Me.TB_LC_1)
        Me.GB_LC.Controls.Add(Me.TB_LC_2)
        Me.GB_LC.Controls.Add(Me.TB_LC_3)
        Me.GB_LC.Location = New System.Drawing.Point(12, 142)
        Me.GB_LC.Name = "GB_LC"
        Me.GB_LC.Size = New System.Drawing.Size(323, 161)
        Me.GB_LC.TabIndex = 8
        Me.GB_LC.TabStop = False
        Me.GB_LC.Text = "Large Commands"
        '
        'B_LC_3
        '
        Me.B_LC_3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.B_LC_3.Location = New System.Drawing.Point(290, 131)
        Me.B_LC_3.Name = "B_LC_3"
        Me.B_LC_3.Size = New System.Drawing.Size(27, 20)
        Me.B_LC_3.TabIndex = 10
        Me.B_LC_3.Text = ">"
        Me.B_LC_3.UseVisualStyleBackColor = True
        '
        'B_LC_2
        '
        Me.B_LC_2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.B_LC_2.Location = New System.Drawing.Point(290, 85)
        Me.B_LC_2.Name = "B_LC_2"
        Me.B_LC_2.Size = New System.Drawing.Size(27, 20)
        Me.B_LC_2.TabIndex = 9
        Me.B_LC_2.Text = ">"
        Me.B_LC_2.UseVisualStyleBackColor = True
        '
        'B_LC_1
        '
        Me.B_LC_1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.B_LC_1.Location = New System.Drawing.Point(290, 39)
        Me.B_LC_1.Name = "B_LC_1"
        Me.B_LC_1.Size = New System.Drawing.Size(27, 20)
        Me.B_LC_1.TabIndex = 8
        Me.B_LC_1.Text = ">"
        Me.B_LC_1.UseVisualStyleBackColor = True
        '
        'TB_LC_1
        '
        Me.TB_LC_1.ContextMenuStrip = Me.GCMS_Basic_FC
        Me.TB_LC_1.Location = New System.Drawing.Point(6, 19)
        Me.TB_LC_1.MaxLength = 120
        Me.TB_LC_1.Multiline = True
        Me.TB_LC_1.Name = "TB_LC_1"
        Me.TB_LC_1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TB_LC_1.Size = New System.Drawing.Size(278, 40)
        Me.TB_LC_1.TabIndex = 0
        '
        'TB_LC_2
        '
        Me.TB_LC_2.ContextMenuStrip = Me.GCMS_Basic_FC
        Me.TB_LC_2.Location = New System.Drawing.Point(6, 65)
        Me.TB_LC_2.MaxLength = 120
        Me.TB_LC_2.Multiline = True
        Me.TB_LC_2.Name = "TB_LC_2"
        Me.TB_LC_2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TB_LC_2.Size = New System.Drawing.Size(278, 40)
        Me.TB_LC_2.TabIndex = 1
        '
        'TB_LC_3
        '
        Me.TB_LC_3.ContextMenuStrip = Me.GCMS_Basic_FC
        Me.TB_LC_3.Location = New System.Drawing.Point(6, 111)
        Me.TB_LC_3.MaxLength = 120
        Me.TB_LC_3.Multiline = True
        Me.TB_LC_3.Name = "TB_LC_3"
        Me.TB_LC_3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TB_LC_3.Size = New System.Drawing.Size(278, 40)
        Me.TB_LC_3.TabIndex = 2
        '
        'MWFC_T_1
        '
        Me.MWFC_T_1.AutoSize = True
        Me.MWFC_T_1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MWFC_T_1.Location = New System.Drawing.Point(12, 9)
        Me.MWFC_T_1.Name = "MWFC_T_1"
        Me.MWFC_T_1.Size = New System.Drawing.Size(117, 20)
        Me.MWFC_T_1.TabIndex = 9
        Me.MWFC_T_1.Text = "Fast Commands:"
        '
        'MainWFastCommands
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 352)
        Me.Controls.Add(Me.MWFC_T_1)
        Me.Controls.Add(Me.GB_LC)
        Me.Controls.Add(Me.GB_SC)
        Me.Controls.Add(Me.MWFC_B_AddS)
        Me.Controls.Add(Me.MWFC_B_Close)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "MainWFastCommands"
        Me.Text = "Fast Commands"
        Me.GCMS_Basic_FC.ResumeLayout(False)
        Me.GB_SC.ResumeLayout(False)
        Me.GB_SC.PerformLayout()
        Me.GB_LC.ResumeLayout(False)
        Me.GB_LC.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_SC_1 As System.Windows.Forms.TextBox
    Friend WithEvents TB_SC_2 As System.Windows.Forms.TextBox
    Friend WithEvents TB_SC_3 As System.Windows.Forms.TextBox
    Friend WithEvents MWFC_B_Close As System.Windows.Forms.Button
    Friend WithEvents MWFC_B_AddS As System.Windows.Forms.Button
    Friend WithEvents GB_SC As System.Windows.Forms.GroupBox
    Friend WithEvents B_SC_3 As System.Windows.Forms.Button
    Friend WithEvents B_SC_2 As System.Windows.Forms.Button
    Friend WithEvents B_SC_1 As System.Windows.Forms.Button
    Friend WithEvents GB_LC As System.Windows.Forms.GroupBox
    Friend WithEvents B_LC_3 As System.Windows.Forms.Button
    Friend WithEvents B_LC_2 As System.Windows.Forms.Button
    Friend WithEvents B_LC_1 As System.Windows.Forms.Button
    Friend WithEvents TB_LC_1 As System.Windows.Forms.TextBox
    Friend WithEvents TB_LC_2 As System.Windows.Forms.TextBox
    Friend WithEvents TB_LC_3 As System.Windows.Forms.TextBox
    Friend WithEvents MWFC_T_1 As System.Windows.Forms.Label
    Friend WithEvents GCMS_Basic_FC As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

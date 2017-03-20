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
Partial Class MainWFastNotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWFastNotes))
        Me.TB_N_1 = New System.Windows.Forms.TextBox()
        Me.GCMS_Basic_FN = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MWFN_B_Close = New System.Windows.Forms.Button()
        Me.MWFN_B_AddS = New System.Windows.Forms.Button()
        Me.GB_N = New System.Windows.Forms.GroupBox()
        Me.B_N_2 = New System.Windows.Forms.Button()
        Me.TB_N_2 = New System.Windows.Forms.TextBox()
        Me.B_N_1 = New System.Windows.Forms.Button()
        Me.MWFN_T_1 = New System.Windows.Forms.Label()
        Me.GCMS_Basic_FN.SuspendLayout()
        Me.GB_N.SuspendLayout()
        Me.SuspendLayout()
        '
        'TB_N_1
        '
        Me.TB_N_1.ContextMenuStrip = Me.GCMS_Basic_FN
        Me.TB_N_1.Location = New System.Drawing.Point(6, 19)
        Me.TB_N_1.MaxLength = 1000
        Me.TB_N_1.Multiline = True
        Me.TB_N_1.Name = "TB_N_1"
        Me.TB_N_1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TB_N_1.Size = New System.Drawing.Size(239, 80)
        Me.TB_N_1.TabIndex = 0
        '
        'GCMS_Basic_FN
        '
        Me.GCMS_Basic_FN.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator2, Me.SelectAllToolStripMenuItem, Me.ToolStripSeparator1, Me.ClearToolStripMenuItem})
        Me.GCMS_Basic_FN.Name = "GCMS_Basic_FN"
        Me.GCMS_Basic_FN.Size = New System.Drawing.Size(123, 148)
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
        'MWFN_B_Close
        '
        Me.MWFN_B_Close.Location = New System.Drawing.Point(12, 308)
        Me.MWFN_B_Close.Name = "MWFN_B_Close"
        Me.MWFN_B_Close.Size = New System.Drawing.Size(75, 23)
        Me.MWFN_B_Close.TabIndex = 1
        Me.MWFN_B_Close.Text = "Hide"
        Me.MWFN_B_Close.UseVisualStyleBackColor = True
        '
        'MWFN_B_AddS
        '
        Me.MWFN_B_AddS.Location = New System.Drawing.Point(150, 308)
        Me.MWFN_B_AddS.Name = "MWFN_B_AddS"
        Me.MWFN_B_AddS.Size = New System.Drawing.Size(114, 23)
        Me.MWFN_B_AddS.TabIndex = 2
        Me.MWFN_B_AddS.Text = "Add Selected"
        Me.MWFN_B_AddS.UseVisualStyleBackColor = True
        '
        'GB_N
        '
        Me.GB_N.Controls.Add(Me.B_N_2)
        Me.GB_N.Controls.Add(Me.TB_N_2)
        Me.GB_N.Controls.Add(Me.B_N_1)
        Me.GB_N.Controls.Add(Me.TB_N_1)
        Me.GB_N.Location = New System.Drawing.Point(12, 29)
        Me.GB_N.Name = "GB_N"
        Me.GB_N.Size = New System.Drawing.Size(251, 261)
        Me.GB_N.TabIndex = 3
        Me.GB_N.TabStop = False
        Me.GB_N.Text = "Notes"
        '
        'B_N_2
        '
        Me.B_N_2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.B_N_2.Location = New System.Drawing.Point(6, 228)
        Me.B_N_2.Name = "B_N_2"
        Me.B_N_2.Size = New System.Drawing.Size(239, 20)
        Me.B_N_2.TabIndex = 3
        Me.B_N_2.Text = "Add this note"
        Me.B_N_2.UseVisualStyleBackColor = True
        '
        'TB_N_2
        '
        Me.TB_N_2.ContextMenuStrip = Me.GCMS_Basic_FN
        Me.TB_N_2.Location = New System.Drawing.Point(6, 142)
        Me.TB_N_2.MaxLength = 1000
        Me.TB_N_2.Multiline = True
        Me.TB_N_2.Name = "TB_N_2"
        Me.TB_N_2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TB_N_2.Size = New System.Drawing.Size(239, 80)
        Me.TB_N_2.TabIndex = 2
        '
        'B_N_1
        '
        Me.B_N_1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.B_N_1.Location = New System.Drawing.Point(6, 105)
        Me.B_N_1.Name = "B_N_1"
        Me.B_N_1.Size = New System.Drawing.Size(239, 20)
        Me.B_N_1.TabIndex = 1
        Me.B_N_1.Text = "Add this note"
        Me.B_N_1.UseVisualStyleBackColor = True
        '
        'MWFN_T_1
        '
        Me.MWFN_T_1.AutoSize = True
        Me.MWFN_T_1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MWFN_T_1.Location = New System.Drawing.Point(12, 9)
        Me.MWFN_T_1.Name = "MWFN_T_1"
        Me.MWFN_T_1.Size = New System.Drawing.Size(81, 20)
        Me.MWFN_T_1.TabIndex = 4
        Me.MWFN_T_1.Text = "Fast Notes:"
        '
        'MainWFastNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 343)
        Me.Controls.Add(Me.MWFN_T_1)
        Me.Controls.Add(Me.GB_N)
        Me.Controls.Add(Me.MWFN_B_AddS)
        Me.Controls.Add(Me.MWFN_B_Close)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "MainWFastNotes"
        Me.Text = "Fast Notes"
        Me.GCMS_Basic_FN.ResumeLayout(False)
        Me.GB_N.ResumeLayout(False)
        Me.GB_N.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_N_1 As System.Windows.Forms.TextBox
    Friend WithEvents MWFN_B_Close As System.Windows.Forms.Button
    Friend WithEvents MWFN_B_AddS As System.Windows.Forms.Button
    Friend WithEvents GB_N As System.Windows.Forms.GroupBox
    Friend WithEvents B_N_1 As System.Windows.Forms.Button
    Friend WithEvents B_N_2 As System.Windows.Forms.Button
    Friend WithEvents TB_N_2 As System.Windows.Forms.TextBox
    Friend WithEvents MWFN_T_1 As System.Windows.Forms.Label
    Friend WithEvents GCMS_Basic_FN As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BankAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CashReceiptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassMasterListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeniorSurveyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.B_Exit = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TablesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(599, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TablesToolStripMenuItem
        '
        Me.TablesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BankAccountToolStripMenuItem, Me.CashReceiptToolStripMenuItem, Me.OrderToolStripMenuItem, Me.ClassMasterListToolStripMenuItem, Me.SeniorSurveyToolStripMenuItem})
        Me.TablesToolStripMenuItem.Name = "TablesToolStripMenuItem"
        Me.TablesToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.TablesToolStripMenuItem.Text = "Tables"
        '
        'BankAccountToolStripMenuItem
        '
        Me.BankAccountToolStripMenuItem.Name = "BankAccountToolStripMenuItem"
        Me.BankAccountToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.BankAccountToolStripMenuItem.Text = "Review Form"
        '
        'CashReceiptToolStripMenuItem
        '
        Me.CashReceiptToolStripMenuItem.Name = "CashReceiptToolStripMenuItem"
        Me.CashReceiptToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.CashReceiptToolStripMenuItem.Text = "Adivsor Form"
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.OrderToolStripMenuItem.Text = "Roster"
        '
        'ClassMasterListToolStripMenuItem
        '
        Me.ClassMasterListToolStripMenuItem.Name = "ClassMasterListToolStripMenuItem"
        Me.ClassMasterListToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ClassMasterListToolStripMenuItem.Text = "Class Master List"
        '
        'SeniorSurveyToolStripMenuItem
        '
        Me.SeniorSurveyToolStripMenuItem.Name = "SeniorSurveyToolStripMenuItem"
        Me.SeniorSurveyToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SeniorSurveyToolStripMenuItem.Text = "Senior Survey"
        '
        'B_Exit
        '
        Me.B_Exit.Location = New System.Drawing.Point(265, 106)
        Me.B_Exit.Name = "B_Exit"
        Me.B_Exit.Size = New System.Drawing.Size(57, 33)
        Me.B_Exit.TabIndex = 1
        Me.B_Exit.Text = "EXIT"
        Me.B_Exit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 157)
        Me.Controls.Add(Me.B_Exit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Main Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TablesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BankAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CashReceiptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents B_Exit As Button
    Friend WithEvents OrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClassMasterListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeniorSurveyToolStripMenuItem As ToolStripMenuItem
End Class

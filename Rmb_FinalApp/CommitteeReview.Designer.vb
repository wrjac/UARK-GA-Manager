<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Committee_Review
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CommitteeDataGrid = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Interviewtextbox = New System.Windows.Forms.RichTextBox()
        Me.Reviewtextbox = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.CommitteeDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"301", "302", "303", "304", "305"})
        Me.ComboBox1.Location = New System.Drawing.Point(140, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(140, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Committee"
        '
        'CommitteeDataGrid
        '
        Me.CommitteeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CommitteeDataGrid.Location = New System.Drawing.Point(52, 171)
        Me.CommitteeDataGrid.Name = "CommitteeDataGrid"
        Me.CommitteeDataGrid.Size = New System.Drawing.Size(651, 237)
        Me.CommitteeDataGrid.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Applicant"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(140, 123)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(138, 21)
        Me.ComboBox2.TabIndex = 6
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"PMIS", "MIS", " "})
        Me.ComboBox3.Location = New System.Drawing.Point(140, 67)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(141, 21)
        Me.ComboBox3.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Program"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(23, 442)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Applicant Review Form"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(160, 442)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Advisor Form"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(192, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "or"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(607, 441)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Select for Program"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.FormsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(848, 24)
        Me.MenuStrip1.TabIndex = 14
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'FormsToolStripMenuItem
        '
        Me.FormsToolStripMenuItem.Name = "FormsToolStripMenuItem"
        Me.FormsToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.FormsToolStripMenuItem.Text = "Forms"
        '
        'Interviewtextbox
        '
        Me.Interviewtextbox.Location = New System.Drawing.Point(493, 27)
        Me.Interviewtextbox.Name = "Interviewtextbox"
        Me.Interviewtextbox.Size = New System.Drawing.Size(220, 61)
        Me.Interviewtextbox.TabIndex = 15
        Me.Interviewtextbox.Text = ""
        '
        'Reviewtextbox
        '
        Me.Reviewtextbox.Location = New System.Drawing.Point(493, 94)
        Me.Reviewtextbox.Name = "Reviewtextbox"
        Me.Reviewtextbox.Size = New System.Drawing.Size(220, 60)
        Me.Reviewtextbox.TabIndex = 16
        Me.Reviewtextbox.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(382, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Interview Comments:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(389, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Review Comments:"
        '
        'Committee_Review
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 477)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Reviewtextbox)
        Me.Controls.Add(Me.Interviewtextbox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CommitteeDataGrid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Committee_Review"
        Me.Text = "Committee Review"
        CType(Me.CommitteeDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CommitteeDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Interviewtextbox As RichTextBox
    Friend WithEvents Reviewtextbox As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
End Class

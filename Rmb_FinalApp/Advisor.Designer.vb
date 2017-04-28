<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Advisor
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
        Me.ProgramComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StudentComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AdvisorComboBox = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ClassIDTextBox = New System.Windows.Forms.TextBox()
        Me.ClassNameTextBox = New System.Windows.Forms.TextBox()
        Me.HoursTextBox = New System.Windows.Forms.TextBox()
        Me.EnrollDateTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.EnrollTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgramComboBox
        '
        Me.ProgramComboBox.FormattingEnabled = True
        Me.ProgramComboBox.Items.AddRange(New Object() {"PMIS", "MIS"})
        Me.ProgramComboBox.Location = New System.Drawing.Point(171, 60)
        Me.ProgramComboBox.Name = "ProgramComboBox"
        Me.ProgramComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ProgramComboBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Program"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Student"
        '
        'StudentComboBox
        '
        Me.StudentComboBox.FormattingEnabled = True
        Me.StudentComboBox.Location = New System.Drawing.Point(171, 98)
        Me.StudentComboBox.Name = "StudentComboBox"
        Me.StudentComboBox.Size = New System.Drawing.Size(121, 21)
        Me.StudentComboBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(298, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "*displays only their students"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(123, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Advisor"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'AdvisorComboBox
        '
        Me.AdvisorComboBox.FormattingEnabled = True
        Me.AdvisorComboBox.Items.AddRange(New Object() {"710", "720"})
        Me.AdvisorComboBox.Location = New System.Drawing.Point(171, 24)
        Me.AdvisorComboBox.Name = "AdvisorComboBox"
        Me.AdvisorComboBox.Size = New System.Drawing.Size(121, 21)
        Me.AdvisorComboBox.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(55, 187)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(550, 172)
        Me.DataGridView1.TabIndex = 7
        '
        'ClassIDTextBox
        '
        Me.ClassIDTextBox.Location = New System.Drawing.Point(100, 418)
        Me.ClassIDTextBox.Name = "ClassIDTextBox"
        Me.ClassIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClassIDTextBox.TabIndex = 11
        '
        'ClassNameTextBox
        '
        Me.ClassNameTextBox.Location = New System.Drawing.Point(292, 376)
        Me.ClassNameTextBox.Name = "ClassNameTextBox"
        Me.ClassNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClassNameTextBox.TabIndex = 12
        '
        'HoursTextBox
        '
        Me.HoursTextBox.Location = New System.Drawing.Point(292, 417)
        Me.HoursTextBox.Name = "HoursTextBox"
        Me.HoursTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HoursTextBox.TabIndex = 13
        '
        'EnrollDateTextBox
        '
        Me.EnrollDateTextBox.Location = New System.Drawing.Point(505, 417)
        Me.EnrollDateTextBox.Name = "EnrollDateTextBox"
        Me.EnrollDateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EnrollDateTextBox.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 420)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "ClassID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(223, 380)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Class Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(251, 420)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Hours"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(440, 421)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Enroll Date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(51, 380)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "EnrollID"
        '
        'EnrollTextBox
        '
        Me.EnrollTextBox.Location = New System.Drawing.Point(101, 376)
        Me.EnrollTextBox.Name = "EnrollTextBox"
        Me.EnrollTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EnrollTextBox.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(429, 502)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Modify"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(530, 502)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Insert New"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(328, 502)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(19, 502)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(136, 23)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Authorize Graduation"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(463, 379)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Grade"
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Location = New System.Drawing.Point(505, 377)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GradeTextBox.TabIndex = 28
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(171, 502)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(136, 23)
        Me.Button5.TabIndex = 32
        Me.Button5.Text = "View All Classes"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Advisor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 537)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GradeTextBox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.EnrollTextBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.EnrollDateTextBox)
        Me.Controls.Add(Me.HoursTextBox)
        Me.Controls.Add(Me.ClassNameTextBox)
        Me.Controls.Add(Me.ClassIDTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.AdvisorComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StudentComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgramComboBox)
        Me.Name = "Advisor"
        Me.Text = "Advisor"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgramComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StudentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AdvisorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ClassIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClassNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HoursTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnrollDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents EnrollTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GradeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class

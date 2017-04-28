<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.MemberIDTextbox = New System.Windows.Forms.TextBox()
        Me.AdmittedSalaryTextBox = New System.Windows.Forms.TextBox()
        Me.AlumniStatusTextBox = New System.Windows.Forms.TextBox()
        Me.EnrollIDTextBox = New System.Windows.Forms.TextBox()
        Me.AdmittedGraduationStatusTextBox = New System.Windows.Forms.TextBox()
        Me.GPATextBox = New System.Windows.Forms.TextBox()
        Me.AdmittedJobTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(172, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(140, 20)
        Me.TextBox1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(47, 97)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(490, 194)
        Me.DataGridView1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(329, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(412, 435)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Insert"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(329, 68)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(125, 23)
        Me.RefreshButton.TabIndex = 8
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'MemberIDTextbox
        '
        Me.MemberIDTextbox.Location = New System.Drawing.Point(6, 39)
        Me.MemberIDTextbox.Name = "MemberIDTextbox"
        Me.MemberIDTextbox.Size = New System.Drawing.Size(41, 20)
        Me.MemberIDTextbox.TabIndex = 9
        '
        'AdmittedSalaryTextBox
        '
        Me.AdmittedSalaryTextBox.Location = New System.Drawing.Point(363, 336)
        Me.AdmittedSalaryTextBox.Name = "AdmittedSalaryTextBox"
        Me.AdmittedSalaryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AdmittedSalaryTextBox.TabIndex = 10
        '
        'AlumniStatusTextBox
        '
        Me.AlumniStatusTextBox.Location = New System.Drawing.Point(363, 381)
        Me.AlumniStatusTextBox.Name = "AlumniStatusTextBox"
        Me.AlumniStatusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AlumniStatusTextBox.TabIndex = 11
        '
        'EnrollIDTextBox
        '
        Me.EnrollIDTextBox.Location = New System.Drawing.Point(6, 13)
        Me.EnrollIDTextBox.Name = "EnrollIDTextBox"
        Me.EnrollIDTextBox.Size = New System.Drawing.Size(41, 20)
        Me.EnrollIDTextBox.TabIndex = 12
        '
        'AdmittedGraduationStatusTextBox
        '
        Me.AdmittedGraduationStatusTextBox.Location = New System.Drawing.Point(148, 324)
        Me.AdmittedGraduationStatusTextBox.Name = "AdmittedGraduationStatusTextBox"
        Me.AdmittedGraduationStatusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AdmittedGraduationStatusTextBox.TabIndex = 13
        '
        'GPATextBox
        '
        Me.GPATextBox.Location = New System.Drawing.Point(148, 360)
        Me.GPATextBox.Name = "GPATextBox"
        Me.GPATextBox.Size = New System.Drawing.Size(100, 20)
        Me.GPATextBox.TabIndex = 14
        '
        'AdmittedJobTextBox
        '
        Me.AdmittedJobTextBox.Location = New System.Drawing.Point(148, 397)
        Me.AdmittedJobTextBox.Name = "AdmittedJobTextBox"
        Me.AdmittedJobTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AdmittedJobTextBox.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 327)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Grad Status:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 367)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "GPA:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 400)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Job:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(307, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Salary:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(289, 384)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Alumni Status:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 486)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AdmittedJobTextBox)
        Me.Controls.Add(Me.GPATextBox)
        Me.Controls.Add(Me.AdmittedGraduationStatusTextBox)
        Me.Controls.Add(Me.EnrollIDTextBox)
        Me.Controls.Add(Me.AlumniStatusTextBox)
        Me.Controls.Add(Me.AdmittedSalaryTextBox)
        Me.Controls.Add(Me.MemberIDTextbox)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Degree Audit & Senior Survey"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RefreshButton As Button
    Friend WithEvents MemberIDTextbox As TextBox
    Friend WithEvents AdmittedSalaryTextBox As TextBox
    Friend WithEvents AlumniStatusTextBox As TextBox
    Friend WithEvents EnrollIDTextBox As TextBox
    Friend WithEvents AdmittedGraduationStatusTextBox As TextBox
    Friend WithEvents GPATextBox As TextBox
    Friend WithEvents AdmittedJobTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class

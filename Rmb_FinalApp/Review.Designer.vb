<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Review
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
        Me.ReviewDataGrid = New System.Windows.Forms.DataGridView()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.PROJECTS1720DataSet = New Rmb_FinalApp.PROJECTS1720DataSet()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CommitteeFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DegreeTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.EMailTextBox = New System.Windows.Forms.TextBox()
        Me.TestNameTextBox = New System.Windows.Forms.TextBox()
        Me.MajorTextBox = New System.Windows.Forms.TextBox()
        Me.GPATextBox = New System.Windows.Forms.TextBox()
        Me.QuantScoreTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.VerbalScoreTextBox = New System.Windows.Forms.TextBox()
        Me.VQScoreTextBox = New System.Windows.Forms.TextBox()
        Me.TestDateTextBox = New System.Windows.Forms.TextBox()
        Me.EndDateTextBox = New System.Windows.Forms.TextBox()
        Me.StartTextBox = New System.Windows.Forms.TextBox()
        Me.SchoolNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ProgramTextBox = New System.Windows.Forms.TextBox()
        Me.Label123 = New System.Windows.Forms.Label()
        Me.PMISButton = New System.Windows.Forms.Button()
        Me.MISButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.InterviewDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ApplicantScoreTextBox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.RecComboBox = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.InterviewScoreTextBox = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ReviewCommentsTextBox = New System.Windows.Forms.RichTextBox()
        Me.InterviewCommentsTextBox = New System.Windows.Forms.RichTextBox()
        Me.CommitteeIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ApplicantIDTextBox = New System.Windows.Forms.TextBox()
        Me.RefreshButton = New System.Windows.Forms.Button()
        CType(Me.ReviewDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTS1720DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReviewDataGrid
        '
        Me.ReviewDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReviewDataGrid.Location = New System.Drawing.Point(76, 224)
        Me.ReviewDataGrid.Name = "ReviewDataGrid"
        Me.ReviewDataGrid.Size = New System.Drawing.Size(977, 126)
        Me.ReviewDataGrid.TabIndex = 14
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(551, 564)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(143, 23)
        Me.SubmitButton.TabIndex = 29
        Me.SubmitButton.Text = "Submit for Director Review"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'PROJECTS1720DataSet
        '
        Me.PROJECTS1720DataSet.DataSetName = "PROJECTS1720DataSet"
        Me.PROJECTS1720DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CommitteeFormToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1098, 24)
        Me.MenuStrip1.TabIndex = 38
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CommitteeFormToolStripMenuItem
        '
        Me.CommitteeFormToolStripMenuItem.Name = "CommitteeFormToolStripMenuItem"
        Me.CommitteeFormToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.CommitteeFormToolStripMenuItem.Text = "Committee Form"
        '
        'DegreeTextBox
        '
        Me.DegreeTextBox.Location = New System.Drawing.Point(680, 77)
        Me.DegreeTextBox.Name = "DegreeTextBox"
        Me.DegreeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DegreeTextBox.TabIndex = 39
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(108, 43)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 40
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(108, 71)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 41
        '
        'EMailTextBox
        '
        Me.EMailTextBox.Location = New System.Drawing.Point(108, 103)
        Me.EMailTextBox.Name = "EMailTextBox"
        Me.EMailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EMailTextBox.TabIndex = 42
        '
        'TestNameTextBox
        '
        Me.TestNameTextBox.Location = New System.Drawing.Point(381, 44)
        Me.TestNameTextBox.Name = "TestNameTextBox"
        Me.TestNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TestNameTextBox.TabIndex = 43
        '
        'MajorTextBox
        '
        Me.MajorTextBox.Location = New System.Drawing.Point(680, 108)
        Me.MajorTextBox.Name = "MajorTextBox"
        Me.MajorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MajorTextBox.TabIndex = 44
        '
        'GPATextBox
        '
        Me.GPATextBox.Location = New System.Drawing.Point(947, 43)
        Me.GPATextBox.Name = "GPATextBox"
        Me.GPATextBox.Size = New System.Drawing.Size(100, 20)
        Me.GPATextBox.TabIndex = 45
        '
        'QuantScoreTextBox
        '
        Me.QuantScoreTextBox.Location = New System.Drawing.Point(680, 46)
        Me.QuantScoreTextBox.Name = "QuantScoreTextBox"
        Me.QuantScoreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QuantScoreTextBox.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "E-Mail"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(309, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Test Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(310, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "VQ Score"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(310, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Verbal Score"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(609, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Quant Score"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(625, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Degree"
        '
        'VerbalScoreTextBox
        '
        Me.VerbalScoreTextBox.Location = New System.Drawing.Point(381, 132)
        Me.VerbalScoreTextBox.Name = "VerbalScoreTextBox"
        Me.VerbalScoreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VerbalScoreTextBox.TabIndex = 66
        '
        'VQScoreTextBox
        '
        Me.VQScoreTextBox.Location = New System.Drawing.Point(381, 101)
        Me.VQScoreTextBox.Name = "VQScoreTextBox"
        Me.VQScoreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VQScoreTextBox.TabIndex = 65
        '
        'TestDateTextBox
        '
        Me.TestDateTextBox.Location = New System.Drawing.Point(381, 70)
        Me.TestDateTextBox.Name = "TestDateTextBox"
        Me.TestDateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TestDateTextBox.TabIndex = 64
        '
        'EndDateTextBox
        '
        Me.EndDateTextBox.Location = New System.Drawing.Point(947, 129)
        Me.EndDateTextBox.Name = "EndDateTextBox"
        Me.EndDateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EndDateTextBox.TabIndex = 63
        '
        'StartTextBox
        '
        Me.StartTextBox.Location = New System.Drawing.Point(947, 97)
        Me.StartTextBox.Name = "StartTextBox"
        Me.StartTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StartTextBox.TabIndex = 62
        '
        'SchoolNameTextBox
        '
        Me.SchoolNameTextBox.Location = New System.Drawing.Point(947, 69)
        Me.SchoolNameTextBox.Name = "SchoolNameTextBox"
        Me.SchoolNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SchoolNameTextBox.TabIndex = 61
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(625, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Major"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(886, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "GPA"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(874, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "School Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(874, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "Start Date"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(874, 132)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "End Date"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(308, 73)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "Test Date"
        '
        'ProgramTextBox
        '
        Me.ProgramTextBox.Location = New System.Drawing.Point(108, 132)
        Me.ProgramTextBox.Name = "ProgramTextBox"
        Me.ProgramTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProgramTextBox.TabIndex = 78
        '
        'Label123
        '
        Me.Label123.AutoSize = True
        Me.Label123.Location = New System.Drawing.Point(36, 135)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(46, 13)
        Me.Label123.TabIndex = 79
        Me.Label123.Text = "Program"
        '
        'PMISButton
        '
        Me.PMISButton.Location = New System.Drawing.Point(98, 19)
        Me.PMISButton.Name = "PMISButton"
        Me.PMISButton.Size = New System.Drawing.Size(48, 23)
        Me.PMISButton.TabIndex = 80
        Me.PMISButton.Text = "PMIS"
        Me.PMISButton.UseVisualStyleBackColor = True
        '
        'MISButton
        '
        Me.MISButton.Location = New System.Drawing.Point(15, 19)
        Me.MISButton.Name = "MISButton"
        Me.MISButton.Size = New System.Drawing.Size(52, 23)
        Me.MISButton.TabIndex = 81
        Me.MISButton.Text = "MIS"
        Me.MISButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MISButton)
        Me.GroupBox1.Controls.Add(Me.PMISButton)
        Me.GroupBox1.Location = New System.Drawing.Point(907, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(157, 51)
        Me.GroupBox1.TabIndex = 82
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FIlter by:"
        '
        'InterviewDateTimePicker
        '
        Me.InterviewDateTimePicker.Location = New System.Drawing.Point(107, 470)
        Me.InterviewDateTimePicker.Name = "InterviewDateTimePicker"
        Me.InterviewDateTimePicker.Size = New System.Drawing.Size(183, 20)
        Me.InterviewDateTimePicker.TabIndex = 83
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 470)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 13)
        Me.Label15.TabIndex = 84
        Me.Label15.Text = "Interview Date:"
        '
        'ApplicantScoreTextBox
        '
        Me.ApplicantScoreTextBox.Location = New System.Drawing.Point(413, 415)
        Me.ApplicantScoreTextBox.Name = "ApplicantScoreTextBox"
        Me.ApplicantScoreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApplicantScoreTextBox.TabIndex = 85
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(322, 418)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 13)
        Me.Label16.TabIndex = 86
        Me.Label16.Text = "Applicant Score:"
        '
        'RecComboBox
        '
        Me.RecComboBox.FormattingEnabled = True
        Me.RecComboBox.Items.AddRange(New Object() {"Gold", "Silver", "Waitlist", "No"})
        Me.RecComboBox.Location = New System.Drawing.Point(413, 500)
        Me.RecComboBox.Name = "RecComboBox"
        Me.RecComboBox.Size = New System.Drawing.Size(100, 21)
        Me.RecComboBox.TabIndex = 87
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(310, 503)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(93, 13)
        Me.Label17.TabIndex = 88
        Me.Label17.Text = "Recommendation:"
        '
        'InterviewScoreTextBox
        '
        Me.InterviewScoreTextBox.Location = New System.Drawing.Point(413, 457)
        Me.InterviewScoreTextBox.Name = "InterviewScoreTextBox"
        Me.InterviewScoreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.InterviewScoreTextBox.TabIndex = 89
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(322, 460)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 13)
        Me.Label18.TabIndex = 90
        Me.Label18.Text = "Interview Score:"
        '
        'ReviewCommentsTextBox
        '
        Me.ReviewCommentsTextBox.Location = New System.Drawing.Point(803, 414)
        Me.ReviewCommentsTextBox.Name = "ReviewCommentsTextBox"
        Me.ReviewCommentsTextBox.Size = New System.Drawing.Size(233, 51)
        Me.ReviewCommentsTextBox.TabIndex = 91
        Me.ReviewCommentsTextBox.Text = ""
        '
        'InterviewCommentsTextBox
        '
        Me.InterviewCommentsTextBox.Location = New System.Drawing.Point(803, 503)
        Me.InterviewCommentsTextBox.Name = "InterviewCommentsTextBox"
        Me.InterviewCommentsTextBox.Size = New System.Drawing.Size(233, 51)
        Me.InterviewCommentsTextBox.TabIndex = 92
        Me.InterviewCommentsTextBox.Text = ""
        '
        'CommitteeIDTextBox
        '
        Me.CommitteeIDTextBox.Location = New System.Drawing.Point(148, 425)
        Me.CommitteeIDTextBox.Name = "CommitteeIDTextBox"
        Me.CommitteeIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CommitteeIDTextBox.TabIndex = 93
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(11, 427)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(109, 13)
        Me.Label19.TabIndex = 94
        Me.Label19.Text = "Committee Leader ID:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(699, 425)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(98, 13)
        Me.Label20.TabIndex = 95
        Me.Label20.Text = "Review Comments:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(688, 524)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(105, 13)
        Me.Label21.TabIndex = 96
        Me.Label21.Text = "Interview Comments:"
        '
        'ApplicantIDTextBox
        '
        Me.ApplicantIDTextBox.Location = New System.Drawing.Point(107, 177)
        Me.ApplicantIDTextBox.Name = "ApplicantIDTextBox"
        Me.ApplicantIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApplicantIDTextBox.TabIndex = 97
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(381, 564)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(143, 23)
        Me.RefreshButton.TabIndex = 98
        Me.RefreshButton.Text = "Refresh Form"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'Review
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 599)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.ApplicantIDTextBox)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.CommitteeIDTextBox)
        Me.Controls.Add(Me.InterviewCommentsTextBox)
        Me.Controls.Add(Me.ReviewCommentsTextBox)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.InterviewScoreTextBox)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.RecComboBox)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ApplicantScoreTextBox)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.InterviewDateTimePicker)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label123)
        Me.Controls.Add(Me.ProgramTextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.VerbalScoreTextBox)
        Me.Controls.Add(Me.VQScoreTextBox)
        Me.Controls.Add(Me.TestDateTextBox)
        Me.Controls.Add(Me.EndDateTextBox)
        Me.Controls.Add(Me.StartTextBox)
        Me.Controls.Add(Me.SchoolNameTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.QuantScoreTextBox)
        Me.Controls.Add(Me.GPATextBox)
        Me.Controls.Add(Me.MajorTextBox)
        Me.Controls.Add(Me.TestNameTextBox)
        Me.Controls.Add(Me.EMailTextBox)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.DegreeTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.ReviewDataGrid)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Review"
        Me.Text = "Review Form"
        CType(Me.ReviewDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTS1720DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReviewDataGrid As DataGridView
    Friend WithEvents SubmitButton As Button
    Friend WithEvents PROJECTS1720DataSet As PROJECTS1720DataSet
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CommitteeFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DegreeTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents EMailTextBox As TextBox
    Friend WithEvents TestNameTextBox As TextBox
    Friend WithEvents MajorTextBox As TextBox
    Friend WithEvents GPATextBox As TextBox
    Friend WithEvents QuantScoreTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents VerbalScoreTextBox As TextBox
    Friend WithEvents VQScoreTextBox As TextBox
    Friend WithEvents TestDateTextBox As TextBox
    Friend WithEvents EndDateTextBox As TextBox
    Friend WithEvents StartTextBox As TextBox
    Friend WithEvents SchoolNameTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents ProgramTextBox As TextBox
    Friend WithEvents Label123 As Label
    Friend WithEvents PMISButton As Button
    Friend WithEvents MISButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents InterviewDateTimePicker As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents ApplicantScoreTextBox As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents RecComboBox As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents InterviewScoreTextBox As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents ReviewCommentsTextBox As RichTextBox
    Friend WithEvents InterviewCommentsTextBox As RichTextBox
    Friend WithEvents CommitteeIDTextBox As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents ApplicantIDTextBox As TextBox
    Friend WithEvents RefreshButton As Button
End Class

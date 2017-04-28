<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Display_Classes
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
        Me.InsertButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ClassID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ClassTermTextBox = New System.Windows.Forms.TextBox()
        Me.ClassHoursTextBox = New System.Windows.Forms.TextBox()
        Me.ClassNameTextBox = New System.Windows.Forms.TextBox()
        Me.ClassIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InsertButton
        '
        Me.InsertButton.Location = New System.Drawing.Point(167, 492)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(215, 23)
        Me.InsertButton.TabIndex = 10
        Me.InsertButton.Text = "Insert New Class"
        Me.InsertButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(271, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(67, 113)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(419, 227)
        Me.DataGridView1.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(114, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(140, 20)
        Me.TextBox1.TabIndex = 7
        '
        'ClassID
        '
        Me.ClassID.AutoSize = True
        Me.ClassID.Location = New System.Drawing.Point(64, 32)
        Me.ClassID.Name = "ClassID"
        Me.ClassID.Size = New System.Drawing.Size(43, 13)
        Me.ClassID.TabIndex = 6
        Me.ClassID.Text = "ClassID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(234, 355)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Add new class"
        '
        'ClassTermTextBox
        '
        Me.ClassTermTextBox.Location = New System.Drawing.Point(434, 452)
        Me.ClassTermTextBox.Name = "ClassTermTextBox"
        Me.ClassTermTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClassTermTextBox.TabIndex = 13
        '
        'ClassHoursTextBox
        '
        Me.ClassHoursTextBox.Location = New System.Drawing.Point(132, 449)
        Me.ClassHoursTextBox.Name = "ClassHoursTextBox"
        Me.ClassHoursTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClassHoursTextBox.TabIndex = 14
        '
        'ClassNameTextBox
        '
        Me.ClassNameTextBox.Location = New System.Drawing.Point(132, 388)
        Me.ClassNameTextBox.Name = "ClassNameTextBox"
        Me.ClassNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClassNameTextBox.TabIndex = 15
        '
        'ClassIDTextBox
        '
        Me.ClassIDTextBox.Location = New System.Drawing.Point(434, 388)
        Me.ClassIDTextBox.Name = "ClassIDTextBox"
        Me.ClassIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClassIDTextBox.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(264, 391)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Class ID (grad level classes only):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 455)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Class Hours:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 391)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Class Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(268, 455)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Class Term:"
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(271, 56)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(125, 23)
        Me.RefreshButton.TabIndex = 21
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(411, 44)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 23)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Display Class Roster"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Display_Classes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 527)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ClassIDTextBox)
        Me.Controls.Add(Me.ClassNameTextBox)
        Me.Controls.Add(Me.ClassHoursTextBox)
        Me.Controls.Add(Me.ClassTermTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.InsertButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ClassID)
        Me.Name = "Display_Classes"
        Me.Text = "Display_Classes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InsertButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ClassID As System.Windows.Forms.Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ClassTermTextBox As TextBox
    Friend WithEvents ClassHoursTextBox As TextBox
    Friend WithEvents ClassNameTextBox As TextBox
    Friend WithEvents ClassIDTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RefreshButton As Button
    Friend WithEvents Button2 As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmResidents
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
        Me.dgResidents = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpCalendar = New System.Windows.Forms.DateTimePicker()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClearFields = New System.Windows.Forms.Button()
        CType(Me.dgResidents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgResidents
        '
        Me.dgResidents.AllowUserToAddRows = False
        Me.dgResidents.AllowUserToDeleteRows = False
        Me.dgResidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgResidents.Location = New System.Drawing.Point(30, 25)
        Me.dgResidents.Name = "dgResidents"
        Me.dgResidents.ReadOnly = True
        Me.dgResidents.Size = New System.Drawing.Size(362, 298)
        Me.dgResidents.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 357)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(102, 353)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(302, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 389)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Last Name:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(102, 385)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(302, 20)
        Me.txtLastName.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 421)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 453)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "City:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(447, 357)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "State:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(447, 389)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Zip Code:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(447, 421)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Calendar:"
        '
        'dtpCalendar
        '
        Me.dtpCalendar.Location = New System.Drawing.Point(537, 417)
        Me.dtpCalendar.Name = "dtpCalendar"
        Me.dtpCalendar.Size = New System.Drawing.Size(200, 20)
        Me.dtpCalendar.TabIndex = 14
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(102, 417)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(302, 20)
        Me.txtAddress.TabIndex = 6
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(102, 449)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(302, 20)
        Me.txtCity.TabIndex = 8
        '
        'cboState
        '
        Me.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboState.FormattingEnabled = True
        Me.cboState.Location = New System.Drawing.Point(537, 353)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(121, 21)
        Me.cboState.TabIndex = 10
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(537, 385)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(121, 20)
        Me.txtZipCode.TabIndex = 12
        '
        'btnHistory
        '
        Me.btnHistory.Location = New System.Drawing.Point(537, 466)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(179, 47)
        Me.btnHistory.TabIndex = 15
        Me.btnHistory.Text = "History"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(359, 570)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 16
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClearFields
        '
        Me.btnClearFields.Location = New System.Drawing.Point(490, 570)
        Me.btnClearFields.Name = "btnClearFields"
        Me.btnClearFields.Size = New System.Drawing.Size(75, 23)
        Me.btnClearFields.TabIndex = 17
        Me.btnClearFields.Text = "Clear Fields"
        Me.btnClearFields.UseVisualStyleBackColor = True
        '
        'frmResidents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 614)
        Me.Controls.Add(Me.btnClearFields)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.txtZipCode)
        Me.Controls.Add(Me.cboState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.dtpCalendar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgResidents)
        Me.Name = "frmResidents"
        Me.Text = "frmResidents"
        CType(Me.dgResidents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgResidents As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpCalendar As DateTimePicker
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents cboState As ComboBox
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClearFields As Button
End Class

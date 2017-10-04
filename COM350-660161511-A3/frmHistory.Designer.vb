<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHistory
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
        Me.dgKeycards = New System.Windows.Forms.DataGridView()
        CType(Me.dgKeycards, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgKeycards
        '
        Me.dgKeycards.AllowUserToAddRows = False
        Me.dgKeycards.AllowUserToDeleteRows = False
        Me.dgKeycards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgKeycards.Location = New System.Drawing.Point(12, 12)
        Me.dgKeycards.Name = "dgKeycards"
        Me.dgKeycards.ReadOnly = True
        Me.dgKeycards.Size = New System.Drawing.Size(642, 267)
        Me.dgKeycards.TabIndex = 0
        '
        'frmHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 295)
        Me.Controls.Add(Me.dgKeycards)
        Me.Name = "frmHistory"
        Me.Text = "frmHistory"
        CType(Me.dgKeycards, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgKeycards As DataGridView
End Class

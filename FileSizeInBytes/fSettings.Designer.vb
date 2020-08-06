<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fSettings))
        Me.cbDebug = New System.Windows.Forms.CheckBox()
        Me.lblErrorLogs = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbDebug
        '
        Me.cbDebug.AutoSize = True
        Me.cbDebug.Location = New System.Drawing.Point(15, 33)
        Me.cbDebug.Name = "cbDebug"
        Me.cbDebug.Size = New System.Drawing.Size(73, 17)
        Me.cbDebug.TabIndex = 0
        Me.cbDebug.Text = "cbDebug"
        Me.cbDebug.UseVisualStyleBackColor = True
        Me.cbDebug.Visible = False
        '
        'lblErrorLogs
        '
        Me.lblErrorLogs.AutoSize = True
        Me.lblErrorLogs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorLogs.Location = New System.Drawing.Point(12, 17)
        Me.lblErrorLogs.Name = "lblErrorLogs"
        Me.lblErrorLogs.Size = New System.Drawing.Size(71, 13)
        Me.lblErrorLogs.TabIndex = 17
        Me.lblErrorLogs.Text = "Error Logs: 0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(108, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Open Logs Folder"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'fSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(228, 65)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblErrorLogs)
        Me.Controls.Add(Me.cbDebug)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fSettings"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbDebug As System.Windows.Forms.CheckBox
    Friend WithEvents lblErrorLogs As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

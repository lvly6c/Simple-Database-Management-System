<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnection
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
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(45, 53)
        Me.btnConnect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(214, 59)
        Me.btnConnect.TabIndex = 0
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Enabled = False
        Me.btnDisconnect.Location = New System.Drawing.Point(281, 53)
        Me.btnDisconnect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(214, 59)
        Me.btnDisconnect.TabIndex = 1
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Connection State:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(164, 131)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(170, 19)
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Connected / Disconnected"
        '
        'frmConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 196)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmConnection"
        Me.Text = "frmConnection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConnect As Button
    Friend WithEvents btnDisconnect As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStatus As Label
End Class

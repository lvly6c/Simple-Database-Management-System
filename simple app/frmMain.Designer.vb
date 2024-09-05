<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtIDNumber = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(488, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(488, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "First name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(488, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Last name"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(75, 6)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(407, 29)
        Me.txtSearch.TabIndex = 4
        '
        'txtIDNumber
        '
        Me.txtIDNumber.Location = New System.Drawing.Point(492, 77)
        Me.txtIDNumber.Name = "txtIDNumber"
        Me.txtIDNumber.ReadOnly = True
        Me.txtIDNumber.Size = New System.Drawing.Size(215, 29)
        Me.txtIDNumber.TabIndex = 5
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(492, 145)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(215, 29)
        Me.txtFirstName.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(492, 248)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(215, 32)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "&Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(492, 213)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(215, 29)
        Me.txtLastName.TabIndex = 8
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(492, 286)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(104, 32)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(602, 286)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(104, 32)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(12, 53)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(470, 265)
        Me.DataGridView1.TabIndex = 11
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(491, 3)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(215, 32)
        Me.btnRefresh.TabIndex = 12
        Me.btnRefresh.Text = "REFRESH DB"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 331)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtIDNumber)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple Database Management System"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtIDNumber As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnRefresh As Button
End Class

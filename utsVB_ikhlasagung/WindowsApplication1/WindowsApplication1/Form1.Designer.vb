<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tbname = New System.Windows.Forms.TextBox()
        Me.TbId = New System.Windows.Forms.TextBox()
        Me.TbUnit = New System.Windows.Forms.TextBox()
        Me.TbReg = New System.Windows.Forms.TextBox()
        Me.tbUandD = New System.Windows.Forms.TextBox()
        Me.Tbphone = New System.Windows.Forms.TextBox()
        Me.CBtransport = New System.Windows.Forms.ComboBox()
        Me.DtpIssue = New System.Windows.Forms.DateTimePicker()
        Me.Tbinstruction = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Btsend = New System.Windows.Forms.Button()
        Me.Tbtransport = New System.Windows.Forms.TextBox()
        Me.LVRequest = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Id = New System.Windows.Forms.TextBox()
        Me.Btupdate = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name of Request"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Unit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date of issue"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Instructions"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(347, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "to Unit/Destination"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(347, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "A/C Reg"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(347, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Transportation"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(347, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Ext. Phone/Hp"
        '
        'Tbname
        '
        Me.Tbname.Location = New System.Drawing.Point(125, 55)
        Me.Tbname.Name = "Tbname"
        Me.Tbname.Size = New System.Drawing.Size(156, 20)
        Me.Tbname.TabIndex = 9
        '
        'TbId
        '
        Me.TbId.Location = New System.Drawing.Point(125, 90)
        Me.TbId.Name = "TbId"
        Me.TbId.Size = New System.Drawing.Size(100, 20)
        Me.TbId.TabIndex = 10
        '
        'TbUnit
        '
        Me.TbUnit.Location = New System.Drawing.Point(125, 125)
        Me.TbUnit.Name = "TbUnit"
        Me.TbUnit.Size = New System.Drawing.Size(100, 20)
        Me.TbUnit.TabIndex = 11
        '
        'TbReg
        '
        Me.TbReg.Location = New System.Drawing.Point(440, 90)
        Me.TbReg.Name = "TbReg"
        Me.TbReg.Size = New System.Drawing.Size(100, 20)
        Me.TbReg.TabIndex = 12
        '
        'tbUandD
        '
        Me.tbUandD.Location = New System.Drawing.Point(440, 51)
        Me.tbUandD.Name = "tbUandD"
        Me.tbUandD.Size = New System.Drawing.Size(100, 20)
        Me.tbUandD.TabIndex = 13
        '
        'Tbphone
        '
        Me.Tbphone.Location = New System.Drawing.Point(440, 182)
        Me.Tbphone.Name = "Tbphone"
        Me.Tbphone.Size = New System.Drawing.Size(100, 20)
        Me.Tbphone.TabIndex = 14
        '
        'CBtransport
        '
        Me.CBtransport.FormattingEnabled = True
        Me.CBtransport.Location = New System.Drawing.Point(440, 129)
        Me.CBtransport.Name = "CBtransport"
        Me.CBtransport.Size = New System.Drawing.Size(121, 21)
        Me.CBtransport.TabIndex = 15
        '
        'DtpIssue
        '
        Me.DtpIssue.Location = New System.Drawing.Point(125, 167)
        Me.DtpIssue.Name = "DtpIssue"
        Me.DtpIssue.Size = New System.Drawing.Size(200, 20)
        Me.DtpIssue.TabIndex = 16
        '
        'Tbinstruction
        '
        Me.Tbinstruction.Location = New System.Drawing.Point(125, 218)
        Me.Tbinstruction.Multiline = True
        Me.Tbinstruction.Name = "Tbinstruction"
        Me.Tbinstruction.Size = New System.Drawing.Size(428, 85)
        Me.Tbinstruction.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(139, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Transportation Request Form"
        '
        'Btsend
        '
        Me.Btsend.Location = New System.Drawing.Point(125, 309)
        Me.Btsend.Name = "Btsend"
        Me.Btsend.Size = New System.Drawing.Size(75, 23)
        Me.Btsend.TabIndex = 19
        Me.Btsend.Text = "Send Request"
        Me.Btsend.UseVisualStyleBackColor = True
        '
        'Tbtransport
        '
        Me.Tbtransport.Location = New System.Drawing.Point(440, 156)
        Me.Tbtransport.Name = "Tbtransport"
        Me.Tbtransport.Size = New System.Drawing.Size(100, 20)
        Me.Tbtransport.TabIndex = 20
        '
        'LVRequest
        '
        Me.LVRequest.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LVRequest.Location = New System.Drawing.Point(567, 40)
        Me.LVRequest.Name = "LVRequest"
        Me.LVRequest.Size = New System.Drawing.Size(428, 263)
        Me.LVRequest.TabIndex = 21
        Me.LVRequest.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(107, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.EditToolStripMenuItem.Text = "edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.DeleteToolStripMenuItem.Text = "delete"
        '
        'Id
        '
        Me.Id.Location = New System.Drawing.Point(125, 26)
        Me.Id.Name = "Id"
        Me.Id.Size = New System.Drawing.Size(100, 20)
        Me.Id.TabIndex = 22
        '
        'Btupdate
        '
        Me.Btupdate.Location = New System.Drawing.Point(249, 310)
        Me.Btupdate.Name = "Btupdate"
        Me.Btupdate.Size = New System.Drawing.Size(75, 23)
        Me.Btupdate.TabIndex = 23
        Me.Btupdate.Text = "update"
        Me.Btupdate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 352)
        Me.Controls.Add(Me.Btupdate)
        Me.Controls.Add(Me.Id)
        Me.Controls.Add(Me.LVRequest)
        Me.Controls.Add(Me.Tbtransport)
        Me.Controls.Add(Me.Btsend)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Tbinstruction)
        Me.Controls.Add(Me.DtpIssue)
        Me.Controls.Add(Me.CBtransport)
        Me.Controls.Add(Me.Tbphone)
        Me.Controls.Add(Me.tbUandD)
        Me.Controls.Add(Me.TbReg)
        Me.Controls.Add(Me.TbUnit)
        Me.Controls.Add(Me.TbId)
        Me.Controls.Add(Me.Tbname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Tbname As System.Windows.Forms.TextBox
    Friend WithEvents TbId As System.Windows.Forms.TextBox
    Friend WithEvents TbUnit As System.Windows.Forms.TextBox
    Friend WithEvents TbReg As System.Windows.Forms.TextBox
    Friend WithEvents tbUandD As System.Windows.Forms.TextBox
    Friend WithEvents Tbphone As System.Windows.Forms.TextBox
    Friend WithEvents CBtransport As System.Windows.Forms.ComboBox
    Friend WithEvents DtpIssue As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tbinstruction As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Btsend As System.Windows.Forms.Button
    Friend WithEvents Tbtransport As System.Windows.Forms.TextBox
    Friend WithEvents LVRequest As System.Windows.Forms.ListView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Id As System.Windows.Forms.TextBox
    Friend WithEvents Btupdate As System.Windows.Forms.Button

End Class

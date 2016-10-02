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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblNOH = New System.Windows.Forms.Label()
        Me.lblPayrate = New System.Windows.Forms.Label()
        Me.lblCat = New System.Windows.Forms.Label()
        Me.lblLeave = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtNOH = New System.Windows.Forms.TextBox()
        Me.txtPayrate = New System.Windows.Forms.TextBox()
        Me.txtLeave = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmbCat = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtOT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(65, 51)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'lblNOH
        '
        Me.lblNOH.AutoSize = True
        Me.lblNOH.Location = New System.Drawing.Point(65, 127)
        Me.lblNOH.Name = "lblNOH"
        Me.lblNOH.Size = New System.Drawing.Size(89, 13)
        Me.lblNOH.TabIndex = 0
        Me.lblNOH.Text = "Number Of Hours"
        '
        'lblPayrate
        '
        Me.lblPayrate.AutoSize = True
        Me.lblPayrate.Location = New System.Drawing.Point(65, 202)
        Me.lblPayrate.Name = "lblPayrate"
        Me.lblPayrate.Size = New System.Drawing.Size(43, 13)
        Me.lblPayrate.TabIndex = 0
        Me.lblPayrate.Text = "Payrate"
        '
        'lblCat
        '
        Me.lblCat.AutoSize = True
        Me.lblCat.Location = New System.Drawing.Point(316, 51)
        Me.lblCat.Name = "lblCat"
        Me.lblCat.Size = New System.Drawing.Size(49, 13)
        Me.lblCat.TabIndex = 0
        Me.lblCat.Text = "Category"
        '
        'lblLeave
        '
        Me.lblLeave.AutoSize = True
        Me.lblLeave.Location = New System.Drawing.Point(13, 22)
        Me.lblLeave.Name = "lblLeave"
        Me.lblLeave.Size = New System.Drawing.Size(96, 13)
        Me.lblLeave.TabIndex = 0
        Me.lblLeave.Text = "Number Of Leaves"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(169, 51)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'txtNOH
        '
        Me.txtNOH.Location = New System.Drawing.Point(169, 120)
        Me.txtNOH.Name = "txtNOH"
        Me.txtNOH.Size = New System.Drawing.Size(100, 20)
        Me.txtNOH.TabIndex = 1
        '
        'txtPayrate
        '
        Me.txtPayrate.Location = New System.Drawing.Point(169, 202)
        Me.txtPayrate.Name = "txtPayrate"
        Me.txtPayrate.Size = New System.Drawing.Size(100, 20)
        Me.txtPayrate.TabIndex = 1
        '
        'txtLeave
        '
        Me.txtLeave.Location = New System.Drawing.Point(126, 22)
        Me.txtLeave.Name = "txtLeave"
        Me.txtLeave.Size = New System.Drawing.Size(100, 20)
        Me.txtLeave.TabIndex = 1
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(193, 329)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(409, 328)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmbCat
        '
        Me.cmbCat.FormattingEnabled = True
        Me.cmbCat.Items.AddRange(New Object() {"Executive", "Non-Executive", "Casual"})
        Me.cmbCat.Location = New System.Drawing.Point(429, 42)
        Me.cmbCat.Name = "cmbCat"
        Me.cmbCat.Size = New System.Drawing.Size(121, 21)
        Me.cmbCat.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtLeave)
        Me.Panel1.Controls.Add(Me.lblLeave)
        Me.Panel1.Location = New System.Drawing.Point(319, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 70)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtOT)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(319, 214)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(238, 70)
        Me.Panel2.TabIndex = 6
        '
        'txtOT
        '
        Me.txtOT.Location = New System.Drawing.Point(126, 22)
        Me.txtOT.Name = "txtOT"
        Me.txtOT.Size = New System.Drawing.Size(100, 20)
        Me.txtOT.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "OT"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 451)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmbCat)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtPayrate)
        Me.Controls.Add(Me.txtNOH)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblPayrate)
        Me.Controls.Add(Me.lblNOH)
        Me.Controls.Add(Me.lblCat)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblNOH As Label
    Friend WithEvents lblPayrate As Label
    Friend WithEvents lblCat As Label
    Friend WithEvents lblLeave As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNOH As TextBox
    Friend WithEvents txtPayrate As TextBox
    Friend WithEvents txtLeave As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cmbCat As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtOT As TextBox
    Friend WithEvents Label1 As Label
End Class

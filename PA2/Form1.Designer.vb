<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblPWD = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPWD = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(182, 169)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(94, 45)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(57, 13)
        Me.lblUserName.TabIndex = 1
        Me.lblUserName.Text = "UserName"
        '
        'lblPWD
        '
        Me.lblPWD.AutoSize = True
        Me.lblPWD.Location = New System.Drawing.Point(94, 97)
        Me.lblPWD.Name = "lblPWD"
        Me.lblPWD.Size = New System.Drawing.Size(30, 13)
        Me.lblPWD.TabIndex = 1
        Me.lblPWD.Text = "Pass"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(182, 37)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(100, 20)
        Me.txtUserName.TabIndex = 2
        '
        'txtPWD
        '
        Me.txtPWD.Location = New System.Drawing.Point(182, 94)
        Me.txtPWD.Name = "txtPWD"
        Me.txtPWD.Size = New System.Drawing.Size(100, 20)
        Me.txtPWD.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 242)
        Me.Controls.Add(Me.txtPWD)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblPWD)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.btnLogin)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblPWD As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPWD As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.txt_pwd_config = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.pass_conf = New System.Windows.Forms.CheckBox()
        Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_username = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackgroundImage = CType(resources.GetObject("panel1.BackgroundImage"), System.Drawing.Image)
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel1.Controls.Add(Me.panel2)
        Me.panel1.Location = New System.Drawing.Point(26, 23)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(583, 350)
        Me.panel1.TabIndex = 1
        '
        'panel2
        '
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel2.Controls.Add(Me.txt_pwd_config)
        Me.panel2.Controls.Add(Me.pass_conf)
        Me.panel2.Controls.Add(Me.simpleButton1)
        Me.panel2.Controls.Add(Me.txt_username)
        Me.panel2.Location = New System.Drawing.Point(33, 17)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(279, 300)
        Me.panel2.TabIndex = 0
        '
        'txt_pwd_config
        '
        Me.txt_pwd_config.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_pwd_config.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_pwd_config.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_pwd_config.HintForeColor = System.Drawing.Color.Empty
        Me.txt_pwd_config.HintText = ""
        Me.txt_pwd_config.isPassword = True
        Me.txt_pwd_config.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_pwd_config.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_pwd_config.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_pwd_config.LineThickness = 3
        Me.txt_pwd_config.Location = New System.Drawing.Point(22, 136)
        Me.txt_pwd_config.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_pwd_config.Name = "txt_pwd_config"
        Me.txt_pwd_config.Size = New System.Drawing.Size(162, 22)
        Me.txt_pwd_config.TabIndex = 28
        Me.txt_pwd_config.Text = "enter pwd here"
        Me.txt_pwd_config.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pass_conf
        '
        Me.pass_conf.AutoSize = True
        Me.pass_conf.Location = New System.Drawing.Point(194, 141)
        Me.pass_conf.Name = "pass_conf"
        Me.pass_conf.Size = New System.Drawing.Size(51, 17)
        Me.pass_conf.TabIndex = 27
        Me.pass_conf.Text = "show"
        Me.pass_conf.UseVisualStyleBackColor = True
        '
        'simpleButton1
        '
        Me.simpleButton1.Location = New System.Drawing.Point(74, 211)
        Me.simpleButton1.Name = "simpleButton1"
        Me.simpleButton1.Size = New System.Drawing.Size(117, 44)
        Me.simpleButton1.TabIndex = 2
        Me.simpleButton1.Text = "CONNECTEZ-VOUS"
        '
        'txt_username
        '
        Me.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_username.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_username.HintForeColor = System.Drawing.Color.Empty
        Me.txt_username.HintText = ""
        Me.txt_username.isPassword = False
        Me.txt_username.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_username.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_username.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_username.LineThickness = 3
        Me.txt_username.Location = New System.Drawing.Point(29, 55)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(216, 44)
        Me.txt_username.TabIndex = 0
        Me.txt_username.Text = "enter your username"
        Me.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 397)
        Me.Controls.Add(Me.panel1)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_login"
        Me.panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents panel2 As Panel
    Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
    Private WithEvents txt_username As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_pwd_config As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents pass_conf As CheckBox
End Class

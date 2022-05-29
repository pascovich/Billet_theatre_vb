<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class configuration_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(configuration_frm))
        Me.pass_conf = New System.Windows.Forms.CheckBox()
        Me.btn_back_login = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_configurer = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txt_nom_serveur = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txt_nom_user = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txt_nom_BD = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_pwd_config = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pass_conf
        '
        Me.pass_conf.AutoSize = True
        Me.pass_conf.Location = New System.Drawing.Point(599, 238)
        Me.pass_conf.Name = "pass_conf"
        Me.pass_conf.Size = New System.Drawing.Size(51, 17)
        Me.pass_conf.TabIndex = 16
        Me.pass_conf.Text = "show"
        Me.pass_conf.UseVisualStyleBackColor = True
        '
        'btn_back_login
        '
        Me.btn_back_login.Image = CType(resources.GetObject("btn_back_login.Image"), System.Drawing.Image)
        Me.btn_back_login.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btn_back_login.Location = New System.Drawing.Point(7, 10)
        Me.btn_back_login.Name = "btn_back_login"
        Me.btn_back_login.Size = New System.Drawing.Size(104, 28)
        Me.btn_back_login.TabIndex = 15
        Me.btn_back_login.Text = "back to login"
        '
        'btn_configurer
        '
        Me.btn_configurer.Appearance.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_configurer.Appearance.Options.UseFont = True
        Me.btn_configurer.Image = CType(resources.GetObject("btn_configurer.Image"), System.Drawing.Image)
        Me.btn_configurer.Location = New System.Drawing.Point(430, 338)
        Me.btn_configurer.Name = "btn_configurer"
        Me.btn_configurer.Size = New System.Drawing.Size(132, 39)
        Me.btn_configurer.TabIndex = 14
        Me.btn_configurer.Text = "Enregistrer"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(1, 52)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(307, 322)
        Me.PictureEdit1.TabIndex = 13
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Blue
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(117, 11)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(467, 24)
        Me.BunifuCustomLabel1.TabIndex = 17
        Me.BunifuCustomLabel1.Text = "Faites la configuration de l'application ici"
        '
        'txt_nom_serveur
        '
        Me.txt_nom_serveur.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nom_serveur.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_nom_serveur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_nom_serveur.HintForeColor = System.Drawing.Color.Empty
        Me.txt_nom_serveur.HintText = ""
        Me.txt_nom_serveur.isPassword = False
        Me.txt_nom_serveur.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_nom_serveur.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_nom_serveur.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_nom_serveur.LineThickness = 3
        Me.txt_nom_serveur.Location = New System.Drawing.Point(334, 100)
        Me.txt_nom_serveur.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nom_serveur.Name = "txt_nom_serveur"
        Me.txt_nom_serveur.Size = New System.Drawing.Size(277, 21)
        Me.txt_nom_serveur.TabIndex = 18
        Me.txt_nom_serveur.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(406, 73)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(145, 18)
        Me.BunifuCustomLabel2.TabIndex = 19
        Me.BunifuCustomLabel2.Text = "Nom du serveur"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(406, 140)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(142, 18)
        Me.BunifuCustomLabel3.TabIndex = 20
        Me.BunifuCustomLabel3.Text = "Nom utilisateur"
        '
        'txt_nom_user
        '
        Me.txt_nom_user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nom_user.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_nom_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_nom_user.HintForeColor = System.Drawing.Color.Empty
        Me.txt_nom_user.HintText = ""
        Me.txt_nom_user.isPassword = False
        Me.txt_nom_user.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_nom_user.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_nom_user.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_nom_user.LineThickness = 3
        Me.txt_nom_user.Location = New System.Drawing.Point(334, 162)
        Me.txt_nom_user.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nom_user.Name = "txt_nom_user"
        Me.txt_nom_user.Size = New System.Drawing.Size(277, 21)
        Me.txt_nom_user.TabIndex = 21
        Me.txt_nom_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(406, 204)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(175, 18)
        Me.BunifuCustomLabel4.TabIndex = 22
        Me.BunifuCustomLabel4.Text = "Password du server"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(417, 270)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(121, 18)
        Me.BunifuCustomLabel5.TabIndex = 24
        Me.BunifuCustomLabel5.Text = "Nom de la BD"
        '
        'txt_nom_BD
        '
        Me.txt_nom_BD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nom_BD.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_nom_BD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_nom_BD.HintForeColor = System.Drawing.Color.Empty
        Me.txt_nom_BD.HintText = ""
        Me.txt_nom_BD.isPassword = False
        Me.txt_nom_BD.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_nom_BD.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_nom_BD.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_nom_BD.LineThickness = 3
        Me.txt_nom_BD.Location = New System.Drawing.Point(334, 294)
        Me.txt_nom_BD.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nom_BD.Name = "txt_nom_BD"
        Me.txt_nom_BD.Size = New System.Drawing.Size(258, 21)
        Me.txt_nom_BD.TabIndex = 25
        Me.txt_nom_BD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.txt_pwd_config.Location = New System.Drawing.Point(334, 238)
        Me.txt_pwd_config.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_pwd_config.Name = "txt_pwd_config"
        Me.txt_pwd_config.Size = New System.Drawing.Size(247, 22)
        Me.txt_pwd_config.TabIndex = 26
        Me.txt_pwd_config.Text = "enter pwd here"
        Me.txt_pwd_config.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'configuration_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 386)
        Me.Controls.Add(Me.txt_pwd_config)
        Me.Controls.Add(Me.txt_nom_BD)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.txt_nom_user)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.txt_nom_serveur)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.pass_conf)
        Me.Controls.Add(Me.btn_back_login)
        Me.Controls.Add(Me.btn_configurer)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Name = "configuration_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "configuration_frm"
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pass_conf As CheckBox
    Friend WithEvents btn_back_login As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_configurer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txt_nom_serveur As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txt_nom_user As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txt_nom_BD As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_pwd_config As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class

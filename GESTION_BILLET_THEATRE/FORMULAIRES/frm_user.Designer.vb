<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_user
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_user))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_username = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txt_id_taux = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txt_pwd_config = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.pass_conf = New System.Windows.Forms.CheckBox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txt_confirm = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel1.Controls.Add(Me.txt_confirm)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Controls.Add(Me.txt_pwd_config)
        Me.Panel1.Controls.Add(Me.pass_conf)
        Me.Panel1.Controls.Add(Me.txt_username)
        Me.Panel1.Controls.Add(Me.GridControl1)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.BunifuFlatButton1)
        Me.Panel1.Controls.Add(Me.txt_id_taux)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(746, 280)
        Me.Panel1.TabIndex = 1
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
        Me.txt_username.Location = New System.Drawing.Point(123, 71)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(215, 26)
        Me.txt_username.TabIndex = 12
        Me.txt_username.Text = "here the username"
        Me.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(388, 34)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(363, 226)
        Me.GridControl1.TabIndex = 11
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(10, 42)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(27, 18)
        Me.BunifuCustomLabel1.TabIndex = 10
        Me.BunifuCustomLabel1.Text = "ID"
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "AJOUTER"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(126, 212)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(144, 48)
        Me.BunifuFlatButton1.TabIndex = 8
        Me.BunifuFlatButton1.Text = "AJOUTER"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txt_id_taux
        '
        Me.txt_id_taux.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_id_taux.Enabled = False
        Me.txt_id_taux.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_id_taux.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_id_taux.HintForeColor = System.Drawing.Color.Empty
        Me.txt_id_taux.HintText = ""
        Me.txt_id_taux.isPassword = False
        Me.txt_id_taux.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_id_taux.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_id_taux.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_id_taux.LineThickness = 3
        Me.txt_id_taux.Location = New System.Drawing.Point(122, 34)
        Me.txt_id_taux.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_id_taux.Name = "txt_id_taux"
        Me.txt_id_taux.Size = New System.Drawing.Size(215, 26)
        Me.txt_id_taux.TabIndex = 7
        Me.txt_id_taux.Text = "identifiant"
        Me.txt_id_taux.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(10, 79)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(90, 18)
        Me.BunifuCustomLabel2.TabIndex = 6
        Me.BunifuCustomLabel2.Text = "Username"
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
        Me.txt_pwd_config.Location = New System.Drawing.Point(122, 123)
        Me.txt_pwd_config.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_pwd_config.Name = "txt_pwd_config"
        Me.txt_pwd_config.Size = New System.Drawing.Size(201, 22)
        Me.txt_pwd_config.TabIndex = 28
        Me.txt_pwd_config.Text = "enter pwd here"
        Me.txt_pwd_config.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pass_conf
        '
        Me.pass_conf.AutoSize = True
        Me.pass_conf.Location = New System.Drawing.Point(330, 128)
        Me.pass_conf.Name = "pass_conf"
        Me.pass_conf.Size = New System.Drawing.Size(51, 17)
        Me.pass_conf.TabIndex = 27
        Me.pass_conf.Text = "show"
        Me.pass_conf.UseVisualStyleBackColor = True
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(10, 125)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(85, 18)
        Me.BunifuCustomLabel3.TabIndex = 29
        Me.BunifuCustomLabel3.Text = "Password"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(10, 164)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(71, 18)
        Me.BunifuCustomLabel4.TabIndex = 31
        Me.BunifuCustomLabel4.Text = "Confirm"
        '
        'txt_confirm
        '
        Me.txt_confirm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_confirm.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_confirm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_confirm.HintForeColor = System.Drawing.Color.Empty
        Me.txt_confirm.HintText = ""
        Me.txt_confirm.isPassword = True
        Me.txt_confirm.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_confirm.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_confirm.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_confirm.LineThickness = 3
        Me.txt_confirm.Location = New System.Drawing.Point(122, 162)
        Me.txt_confirm.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_confirm.Name = "txt_confirm"
        Me.txt_confirm.Size = New System.Drawing.Size(201, 22)
        Me.txt_confirm.TabIndex = 30
        Me.txt_confirm.Text = "enter pwd here"
        Me.txt_confirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frm_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 302)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_user"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_user"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_username As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txt_id_taux As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txt_confirm As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txt_pwd_config As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents pass_conf As CheckBox
End Class

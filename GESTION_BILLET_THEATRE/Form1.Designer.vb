Partial Public Class Form1
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim GalleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonGalleryBarItem1 = New DevExpress.XtraBars.RibbonGalleryBarItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.NavigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_supp = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_update = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_add = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_adresse = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_search = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_prenom = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_file = New System.Windows.Forms.TextBox()
        Me.btn_pacourir = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.txt_postnom = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_nom = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txt_telephone = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cb_sexe = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NavigationPage3 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txt_chaise_salle = New DevExpress.XtraEditors.TextEdit()
        Me.txt_id_salle = New System.Windows.Forms.TextBox()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_nom_salle = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_id_theatre = New System.Windows.Forms.TextBox()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_description_theatre = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_nom_theatre = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.NavigationPage4 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.SimpleButton17 = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_id_programme = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton9 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txt_heure_fin = New DevExpress.XtraEditors.TextEdit()
        Me.txt_heure_debut = New DevExpress.XtraEditors.TextEdit()
        Me.cb_salle = New System.Windows.Forms.ComboBox()
        Me.cb_theatre = New System.Windows.Forms.ComboBox()
        Me.date_ceremony = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NavigationPage5 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.GroupBox27 = New System.Windows.Forms.GroupBox()
        Me.GroupBox28 = New System.Windows.Forms.GroupBox()
        Me.SimpleButton18 = New DevExpress.XtraEditors.SimpleButton()
        Me.BunifuSeparator6 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txt_id_programmation = New System.Windows.Forms.TextBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.SimpleButton10 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton11 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton12 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.txt_prix_programmation = New DevExpress.XtraEditors.TextEdit()
        Me.cb_type_billet = New System.Windows.Forms.ComboBox()
        Me.cb_programme = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.NavigationPage7 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.GroupBox24 = New System.Windows.Forms.GroupBox()
        Me.GroupBox26 = New System.Windows.Forms.GroupBox()
        Me.SimpleButton16 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl6 = New DevExpress.XtraGrid.GridControl()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox25 = New System.Windows.Forms.GroupBox()
        Me.txt_montant_paye = New DevExpress.XtraEditors.TextEdit()
        Me.cb_billet = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.date_paie = New System.Windows.Forms.DateTimePicker()
        Me.txt_designation = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuSeparator4 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txt_montant_a_payer = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_id_paiement = New System.Windows.Forms.TextBox()
        Me.GroupBox23 = New System.Windows.Forms.GroupBox()
        Me.SimpleButton20 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.GroupBox22 = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.NavigationPage6 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.txt_id_billet = New System.Windows.Forms.TextBox()
        Me.GroupBox21 = New System.Windows.Forms.GroupBox()
        Me.SimpleButton19 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.GridControl5 = New DevExpress.XtraGrid.GridControl()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.SimpleButton13 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton14 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton15 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.txt_reduction = New DevExpress.XtraEditors.TextEdit()
        Me.cb_programmation = New System.Windows.Forms.ComboBox()
        Me.cb_client = New System.Windows.Forms.ComboBox()
        Me.BunifuSeparator5 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.txt_prix_a_payer = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPane1.SuspendLayout()
        Me.NavigationPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPage3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.txt_chaise_salle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.NavigationPage4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.txt_heure_fin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_heure_debut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPage5.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox27.SuspendLayout()
        Me.GroupBox28.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox16.SuspendLayout()
        CType(Me.txt_prix_programmation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPage7.SuspendLayout()
        Me.GroupBox24.SuspendLayout()
        Me.GroupBox26.SuspendLayout()
        CType(Me.GridControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox25.SuspendLayout()
        CType(Me.txt_montant_paye.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox23.SuspendLayout()
        Me.GroupBox22.SuspendLayout()
        Me.NavigationPage6.SuspendLayout()
        Me.GroupBox21.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox17.SuspendLayout()
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox20.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        CType(Me.txt_reduction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.RibbonGalleryBarItem1})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 7
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribbonControl1.Size = New System.Drawing.Size(1268, 162)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "USERS"
        Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.LargeGlyph = CType(resources.GetObject("BarButtonItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "REFRESH"
        Me.BarButtonItem2.Glyph = CType(resources.GetObject("BarButtonItem2.Glyph"), System.Drawing.Image)
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.LargeGlyph = CType(resources.GetObject("BarButtonItem2.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "SETTINGS"
        Me.BarButtonItem3.Glyph = CType(resources.GetObject("BarButtonItem3.Glyph"), System.Drawing.Image)
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.LargeGlyph = CType(resources.GetObject("BarButtonItem3.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'RibbonGalleryBarItem1
        '
        Me.RibbonGalleryBarItem1.Caption = "RibbonGalleryBarItem1"
        '
        '
        '
        GalleryItemGroup1.Caption = "Group2"
        Me.RibbonGalleryBarItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup1})
        Me.RibbonGalleryBarItem1.Id = 6
        Me.RibbonGalleryBarItem1.Name = "RibbonGalleryBarItem1"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
        Me.ribbonPage1.Image = CType(resources.GetObject("ribbonPage1.Image"), System.Drawing.Image)
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "PASCOVICH"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.Glyph = CType(resources.GetObject("ribbonPageGroup1.Glyph"), System.Drawing.Image)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.BarButtonItem2)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.BarButtonItem3)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.RibbonGalleryBarItem1)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
        '
        'NavigationPane1
        '
        Me.NavigationPane1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.NavigationPane1.Controls.Add(Me.NavigationPage2)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage3)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage4)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage5)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage7)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage1)
        Me.NavigationPane1.Controls.Add(Me.NavigationPage6)
        Me.NavigationPane1.Location = New System.Drawing.Point(0, 168)
        Me.NavigationPane1.Name = "NavigationPane1"
        Me.NavigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.NavigationPage1, Me.NavigationPage2, Me.NavigationPage3, Me.NavigationPage4, Me.NavigationPage5, Me.NavigationPage6, Me.NavigationPage7})
        Me.NavigationPane1.RegularSize = New System.Drawing.Size(1256, 587)
        Me.NavigationPane1.SelectedPage = Me.NavigationPage2
        Me.NavigationPane1.SelectedPageIndex = 4
        Me.NavigationPane1.Size = New System.Drawing.Size(1256, 587)
        Me.NavigationPane1.TabIndex = 1
        Me.NavigationPane1.Text = "NNN"
        '
        'NavigationPage2
        '
        Me.NavigationPage2.Caption = "CLIENT"
        Me.NavigationPage2.Controls.Add(Me.DataGridView1)
        Me.NavigationPage2.Controls.Add(Me.GroupBox3)
        Me.NavigationPage2.Controls.Add(Me.GroupBox1)
        Me.NavigationPage2.Image = CType(resources.GetObject("NavigationPage2.Image"), System.Drawing.Image)
        Me.NavigationPage2.Name = "NavigationPage2"
        Me.NavigationPage2.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText
        Me.NavigationPage2.Size = New System.Drawing.Size(1098, 527)
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(371, 323)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(713, 185)
        Me.DataGridView1.TabIndex = 24
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_supp)
        Me.GroupBox3.Controls.Add(Me.btn_update)
        Me.GroupBox3.Controls.Add(Me.btn_add)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(11, 323)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(332, 103)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ACTIONS"
        '
        'btn_supp
        '
        Me.btn_supp.Image = CType(resources.GetObject("btn_supp.Image"), System.Drawing.Image)
        Me.btn_supp.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btn_supp.Location = New System.Drawing.Point(232, 42)
        Me.btn_supp.Name = "btn_supp"
        Me.btn_supp.Size = New System.Drawing.Size(91, 45)
        Me.btn_supp.TabIndex = 8
        Me.btn_supp.Text = "DELETE"
        '
        'btn_update
        '
        Me.btn_update.Image = CType(resources.GetObject("btn_update.Image"), System.Drawing.Image)
        Me.btn_update.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btn_update.Location = New System.Drawing.Point(133, 42)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(93, 45)
        Me.btn_update.TabIndex = 7
        Me.btn_update.Text = "UPDATE"
        '
        'btn_add
        '
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btn_add.Location = New System.Drawing.Point(39, 42)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(88, 45)
        Me.btn_add.TabIndex = 6
        Me.btn_add.Text = "INSERT"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.txt_adresse)
        Me.GroupBox1.Controls.Add(Me.txt_search)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_prenom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_file)
        Me.GroupBox1.Controls.Add(Me.btn_pacourir)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.txt_postnom)
        Me.GroupBox1.Controls.Add(Me.txt_nom)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txt_telephone)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cb_sexe)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1066, 295)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PERSONAL INFORMATION"
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(480, 226)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(25, 23)
        Me.txt_id.TabIndex = 24
        '
        'txt_adresse
        '
        Me.txt_adresse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_adresse.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_adresse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_adresse.HintForeColor = System.Drawing.Color.Empty
        Me.txt_adresse.HintText = ""
        Me.txt_adresse.isPassword = False
        Me.txt_adresse.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_adresse.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_adresse.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_adresse.LineThickness = 3
        Me.txt_adresse.Location = New System.Drawing.Point(580, 47)
        Me.txt_adresse.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_adresse.Name = "txt_adresse"
        Me.txt_adresse.Size = New System.Drawing.Size(232, 23)
        Me.txt_adresse.TabIndex = 23
        Me.txt_adresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_search
        '
        Me.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_search.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_search.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_search.HintForeColor = System.Drawing.Color.Empty
        Me.txt_search.HintText = ""
        Me.txt_search.isPassword = False
        Me.txt_search.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_search.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_search.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_search.LineThickness = 3
        Me.txt_search.Location = New System.Drawing.Point(550, 267)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(243, 21)
        Me.txt_search.TabIndex = 23
        Me.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(467, 267)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(62, 18)
        Me.BunifuCustomLabel3.TabIndex = 22
        Me.BunifuCustomLabel3.Text = "Search"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(477, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "ADRESSE"
        '
        'txt_prenom
        '
        Me.txt_prenom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_prenom.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_prenom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_prenom.HintForeColor = System.Drawing.Color.Empty
        Me.txt_prenom.HintText = ""
        Me.txt_prenom.isPassword = False
        Me.txt_prenom.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_prenom.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_prenom.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_prenom.LineThickness = 3
        Me.txt_prenom.Location = New System.Drawing.Point(149, 146)
        Me.txt_prenom.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_prenom.Name = "txt_prenom"
        Me.txt_prenom.Size = New System.Drawing.Size(298, 23)
        Me.txt_prenom.TabIndex = 21
        Me.txt_prenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "PRENOM"
        '
        'txt_file
        '
        Me.txt_file.Location = New System.Drawing.Point(854, 261)
        Me.txt_file.Name = "txt_file"
        Me.txt_file.Size = New System.Drawing.Size(200, 23)
        Me.txt_file.TabIndex = 19
        '
        'btn_pacourir
        '
        Me.btn_pacourir.Image = CType(resources.GetObject("btn_pacourir.Image"), System.Drawing.Image)
        Me.btn_pacourir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btn_pacourir.Location = New System.Drawing.Point(903, 199)
        Me.btn_pacourir.Name = "btn_pacourir"
        Me.btn_pacourir.Size = New System.Drawing.Size(113, 48)
        Me.btn_pacourir.TabIndex = 18
        Me.btn_pacourir.Text = "BROWSER"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureEdit1)
        Me.Panel1.Location = New System.Drawing.Point(854, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 175)
        Me.Panel1.TabIndex = 17
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Location = New System.Drawing.Point(13, 15)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(174, 143)
        Me.PictureEdit1.TabIndex = 0
        '
        'txt_postnom
        '
        Me.txt_postnom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_postnom.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_postnom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_postnom.HintForeColor = System.Drawing.Color.Empty
        Me.txt_postnom.HintText = ""
        Me.txt_postnom.isPassword = False
        Me.txt_postnom.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_postnom.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_postnom.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_postnom.LineThickness = 3
        Me.txt_postnom.Location = New System.Drawing.Point(149, 95)
        Me.txt_postnom.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_postnom.Name = "txt_postnom"
        Me.txt_postnom.Size = New System.Drawing.Size(298, 23)
        Me.txt_postnom.TabIndex = 16
        Me.txt_postnom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_nom
        '
        Me.txt_nom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nom.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_nom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_nom.HintForeColor = System.Drawing.Color.Empty
        Me.txt_nom.HintText = ""
        Me.txt_nom.isPassword = False
        Me.txt_nom.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_nom.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_nom.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_nom.LineThickness = 3
        Me.txt_nom.Location = New System.Drawing.Point(149, 49)
        Me.txt_nom.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(298, 21)
        Me.txt_nom.TabIndex = 15
        Me.txt_nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(149, 226)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(298, 23)
        Me.DateTimePicker1.TabIndex = 14
        '
        'txt_telephone
        '
        Me.txt_telephone.Location = New System.Drawing.Point(580, 95)
        Me.txt_telephone.Mask = "00 00 00 00 00"
        Me.txt_telephone.Name = "txt_telephone"
        Me.txt_telephone.Size = New System.Drawing.Size(232, 23)
        Me.txt_telephone.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "DATE NAISSANCE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(468, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "TELEPHONE"
        '
        'cb_sexe
        '
        Me.cb_sexe.FormattingEnabled = True
        Me.cb_sexe.Items.AddRange(New Object() {"M", "F", "NONE"})
        Me.cb_sexe.Location = New System.Drawing.Point(149, 189)
        Me.cb_sexe.Name = "cb_sexe"
        Me.cb_sexe.Size = New System.Drawing.Size(298, 24)
        Me.cb_sexe.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "SEXE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "POSTNOM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NOM"
        '
        'NavigationPage3
        '
        Me.NavigationPage3.Caption = "THEATRE/SALLE"
        Me.NavigationPage3.Controls.Add(Me.GroupBox5)
        Me.NavigationPage3.Controls.Add(Me.GroupBox2)
        Me.NavigationPage3.Image = CType(resources.GetObject("NavigationPage3.Image"), System.Drawing.Image)
        Me.NavigationPage3.Name = "NavigationPage3"
        Me.NavigationPage3.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText
        Me.NavigationPage3.Size = New System.Drawing.Size(1098, 527)
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txt_chaise_salle)
        Me.GroupBox5.Controls.Add(Me.txt_id_salle)
        Me.GroupBox5.Controls.Add(Me.GridControl2)
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.txt_nom_salle)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(566, 34)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(495, 490)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "SALLE MANAGER"
        '
        'txt_chaise_salle
        '
        Me.txt_chaise_salle.Location = New System.Drawing.Point(167, 85)
        Me.txt_chaise_salle.Name = "txt_chaise_salle"
        Me.txt_chaise_salle.Properties.Mask.EditMask = "d"
        Me.txt_chaise_salle.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_chaise_salle.Size = New System.Drawing.Size(280, 20)
        Me.txt_chaise_salle.TabIndex = 30
        '
        'txt_id_salle
        '
        Me.txt_id_salle.Location = New System.Drawing.Point(409, 193)
        Me.txt_id_salle.Name = "txt_id_salle"
        Me.txt_id_salle.Size = New System.Drawing.Size(15, 23)
        Me.txt_id_salle.TabIndex = 20
        '
        'GridControl2
        '
        Me.GridControl2.Location = New System.Drawing.Point(25, 240)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.MenuManager = Me.ribbonControl1
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(464, 229)
        Me.GridControl2.TabIndex = 18
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsFind.AlwaysVisible = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.SimpleButton4)
        Me.GroupBox6.Controls.Add(Me.SimpleButton5)
        Me.GroupBox6.Controls.Add(Me.SimpleButton6)
        Me.GroupBox6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(55, 143)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(332, 80)
        Me.GroupBox6.TabIndex = 17
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "ACTIONS"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton4.Location = New System.Drawing.Point(232, 28)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(91, 45)
        Me.SimpleButton4.TabIndex = 8
        Me.SimpleButton4.Text = "DELETE"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton5.Location = New System.Drawing.Point(133, 28)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(93, 45)
        Me.SimpleButton5.TabIndex = 7
        Me.SimpleButton5.Text = "UPDATE"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Image = CType(resources.GetObject("SimpleButton6.Image"), System.Drawing.Image)
        Me.SimpleButton6.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton6.Location = New System.Drawing.Point(39, 28)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(88, 45)
        Me.SimpleButton6.TabIndex = 6
        Me.SimpleButton6.Text = "INSERT"
        '
        'txt_nom_salle
        '
        Me.txt_nom_salle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nom_salle.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_nom_salle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_nom_salle.HintForeColor = System.Drawing.Color.Empty
        Me.txt_nom_salle.HintText = ""
        Me.txt_nom_salle.isPassword = False
        Me.txt_nom_salle.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_nom_salle.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_nom_salle.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_nom_salle.LineThickness = 3
        Me.txt_nom_salle.Location = New System.Drawing.Point(167, 39)
        Me.txt_nom_salle.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nom_salle.Name = "txt_nom_salle"
        Me.txt_nom_salle.Size = New System.Drawing.Size(280, 21)
        Me.txt_nom_salle.TabIndex = 15
        Me.txt_nom_salle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "CHAISE DISPONIBLE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 16)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "NOM SALLE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_id_theatre)
        Me.GroupBox2.Controls.Add(Me.GridControl1)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.txt_description_theatre)
        Me.GroupBox2.Controls.Add(Me.txt_nom_theatre)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(520, 490)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "THEATER MANAGER"
        '
        'txt_id_theatre
        '
        Me.txt_id_theatre.Location = New System.Drawing.Point(253, 234)
        Me.txt_id_theatre.Name = "txt_id_theatre"
        Me.txt_id_theatre.Size = New System.Drawing.Size(15, 23)
        Me.txt_id_theatre.TabIndex = 19
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(25, 255)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.ribbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(453, 229)
        Me.GridControl1.TabIndex = 18
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFind.AlwaysVisible = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.SimpleButton1)
        Me.GroupBox4.Controls.Add(Me.SimpleButton2)
        Me.GroupBox4.Controls.Add(Me.SimpleButton3)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(55, 156)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(332, 93)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ACTIONS"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton1.Location = New System.Drawing.Point(232, 35)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(91, 45)
        Me.SimpleButton1.TabIndex = 8
        Me.SimpleButton1.Text = "DELETE"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton2.Location = New System.Drawing.Point(133, 35)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(93, 45)
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "UPDATE"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton3.Location = New System.Drawing.Point(39, 35)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(88, 45)
        Me.SimpleButton3.TabIndex = 6
        Me.SimpleButton3.Text = "INSERT"
        '
        'txt_description_theatre
        '
        Me.txt_description_theatre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_description_theatre.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_description_theatre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_description_theatre.HintForeColor = System.Drawing.Color.Empty
        Me.txt_description_theatre.HintText = ""
        Me.txt_description_theatre.isPassword = False
        Me.txt_description_theatre.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_description_theatre.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_description_theatre.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_description_theatre.LineThickness = 3
        Me.txt_description_theatre.Location = New System.Drawing.Point(149, 88)
        Me.txt_description_theatre.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_description_theatre.Name = "txt_description_theatre"
        Me.txt_description_theatre.Size = New System.Drawing.Size(298, 23)
        Me.txt_description_theatre.TabIndex = 16
        Me.txt_description_theatre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_nom_theatre
        '
        Me.txt_nom_theatre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nom_theatre.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_nom_theatre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_nom_theatre.HintForeColor = System.Drawing.Color.Empty
        Me.txt_nom_theatre.HintText = ""
        Me.txt_nom_theatre.isPassword = False
        Me.txt_nom_theatre.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_nom_theatre.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_nom_theatre.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_nom_theatre.LineThickness = 3
        Me.txt_nom_theatre.Location = New System.Drawing.Point(149, 49)
        Me.txt_nom_theatre.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nom_theatre.Name = "txt_nom_theatre"
        Me.txt_nom_theatre.Size = New System.Drawing.Size(298, 21)
        Me.txt_nom_theatre.TabIndex = 15
        Me.txt_nom_theatre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 16)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "DESCRIPTION"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 16)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "NOM THEATRE"
        '
        'NavigationPage4
        '
        Me.NavigationPage4.Caption = "PROGRAMME"
        Me.NavigationPage4.Controls.Add(Me.GroupBox7)
        Me.NavigationPage4.Image = CType(resources.GetObject("NavigationPage4.Image"), System.Drawing.Image)
        Me.NavigationPage4.Name = "NavigationPage4"
        Me.NavigationPage4.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText
        Me.NavigationPage4.Size = New System.Drawing.Size(1098, 527)
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.SimpleButton17)
        Me.GroupBox7.Controls.Add(Me.txt_id_programme)
        Me.GroupBox7.Controls.Add(Me.GroupBox9)
        Me.GroupBox7.Controls.Add(Me.GridControl3)
        Me.GroupBox7.Controls.Add(Me.GroupBox8)
        Me.GroupBox7.Location = New System.Drawing.Point(23, 18)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1058, 479)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "FAITES VOS PROGRAMMES"
        '
        'SimpleButton17
        '
        Me.SimpleButton17.Image = CType(resources.GetObject("SimpleButton17.Image"), System.Drawing.Image)
        Me.SimpleButton17.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton17.Location = New System.Drawing.Point(40, 286)
        Me.SimpleButton17.Name = "SimpleButton17"
        Me.SimpleButton17.Size = New System.Drawing.Size(88, 45)
        Me.SimpleButton17.TabIndex = 21
        Me.SimpleButton17.Text = "EG"
        '
        'txt_id_programme
        '
        Me.txt_id_programme.Location = New System.Drawing.Point(522, 229)
        Me.txt_id_programme.Name = "txt_id_programme"
        Me.txt_id_programme.Size = New System.Drawing.Size(15, 21)
        Me.txt_id_programme.TabIndex = 20
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.GroupBox10)
        Me.GroupBox9.Location = New System.Drawing.Point(635, 29)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(423, 206)
        Me.GroupBox9.TabIndex = 3
        Me.GroupBox9.TabStop = False
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.GroupBox11)
        Me.GroupBox10.Location = New System.Drawing.Point(23, 31)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(379, 158)
        Me.GroupBox10.TabIndex = 0
        Me.GroupBox10.TabStop = False
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.SimpleButton7)
        Me.GroupBox11.Controls.Add(Me.SimpleButton8)
        Me.GroupBox11.Controls.Add(Me.SimpleButton9)
        Me.GroupBox11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.Location = New System.Drawing.Point(23, 33)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(332, 93)
        Me.GroupBox11.TabIndex = 18
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "ACTIONS"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Image = CType(resources.GetObject("SimpleButton7.Image"), System.Drawing.Image)
        Me.SimpleButton7.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton7.Location = New System.Drawing.Point(232, 35)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(91, 45)
        Me.SimpleButton7.TabIndex = 8
        Me.SimpleButton7.Text = "DELETE"
        '
        'SimpleButton8
        '
        Me.SimpleButton8.Image = CType(resources.GetObject("SimpleButton8.Image"), System.Drawing.Image)
        Me.SimpleButton8.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton8.Location = New System.Drawing.Point(133, 35)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(93, 45)
        Me.SimpleButton8.TabIndex = 7
        Me.SimpleButton8.Text = "UPDATE"
        '
        'SimpleButton9
        '
        Me.SimpleButton9.Image = CType(resources.GetObject("SimpleButton9.Image"), System.Drawing.Image)
        Me.SimpleButton9.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton9.Location = New System.Drawing.Point(39, 35)
        Me.SimpleButton9.Name = "SimpleButton9"
        Me.SimpleButton9.Size = New System.Drawing.Size(88, 45)
        Me.SimpleButton9.TabIndex = 6
        Me.SimpleButton9.Text = "INSERT"
        '
        'GridControl3
        '
        Me.GridControl3.Location = New System.Drawing.Point(152, 255)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.MenuManager = Me.ribbonControl1
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(798, 200)
        Me.GridControl3.TabIndex = 2
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsFind.AlwaysVisible = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txt_heure_fin)
        Me.GroupBox8.Controls.Add(Me.txt_heure_debut)
        Me.GroupBox8.Controls.Add(Me.cb_salle)
        Me.GroupBox8.Controls.Add(Me.cb_theatre)
        Me.GroupBox8.Controls.Add(Me.date_ceremony)
        Me.GroupBox8.Controls.Add(Me.Label16)
        Me.GroupBox8.Controls.Add(Me.Label15)
        Me.GroupBox8.Controls.Add(Me.Label12)
        Me.GroupBox8.Controls.Add(Me.Label11)
        Me.GroupBox8.Controls.Add(Me.Label10)
        Me.GroupBox8.Location = New System.Drawing.Point(19, 29)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(563, 206)
        Me.GroupBox8.TabIndex = 1
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "#DIFFERENTES INFOS##"
        '
        'txt_heure_fin
        '
        Me.txt_heure_fin.Location = New System.Drawing.Point(161, 163)
        Me.txt_heure_fin.Name = "txt_heure_fin"
        Me.txt_heure_fin.Properties.Mask.EditMask = "d"
        Me.txt_heure_fin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_heure_fin.Size = New System.Drawing.Size(298, 20)
        Me.txt_heure_fin.TabIndex = 28
        '
        'txt_heure_debut
        '
        Me.txt_heure_debut.Location = New System.Drawing.Point(161, 129)
        Me.txt_heure_debut.Name = "txt_heure_debut"
        Me.txt_heure_debut.Properties.Mask.EditMask = "d"
        Me.txt_heure_debut.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_heure_debut.Size = New System.Drawing.Size(298, 20)
        Me.txt_heure_debut.TabIndex = 22
        '
        'cb_salle
        '
        Me.cb_salle.FormattingEnabled = True
        Me.cb_salle.Location = New System.Drawing.Point(161, 96)
        Me.cb_salle.Name = "cb_salle"
        Me.cb_salle.Size = New System.Drawing.Size(298, 21)
        Me.cb_salle.TabIndex = 27
        '
        'cb_theatre
        '
        Me.cb_theatre.FormattingEnabled = True
        Me.cb_theatre.Location = New System.Drawing.Point(161, 67)
        Me.cb_theatre.Name = "cb_theatre"
        Me.cb_theatre.Size = New System.Drawing.Size(298, 21)
        Me.cb_theatre.TabIndex = 21
        '
        'date_ceremony
        '
        Me.date_ceremony.Location = New System.Drawing.Point(161, 31)
        Me.date_ceremony.Name = "date_ceremony"
        Me.date_ceremony.Size = New System.Drawing.Size(298, 21)
        Me.date_ceremony.TabIndex = 26
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(17, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 13)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "SALLE"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(18, 166)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 13)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "HEURE FIN"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 136)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "HEURE DEBUT"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "THEATRE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "DATE CEREMONIE"
        '
        'NavigationPage5
        '
        Me.NavigationPage5.Caption = "PROGRAMMATION"
        Me.NavigationPage5.Controls.Add(Me.GroupBox12)
        Me.NavigationPage5.Image = CType(resources.GetObject("NavigationPage5.Image"), System.Drawing.Image)
        Me.NavigationPage5.Name = "NavigationPage5"
        Me.NavigationPage5.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText
        Me.NavigationPage5.Size = New System.Drawing.Size(1098, 527)
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.GroupBox27)
        Me.GroupBox12.Controls.Add(Me.txt_id_programmation)
        Me.GroupBox12.Controls.Add(Me.GroupBox13)
        Me.GroupBox12.Controls.Add(Me.GridControl4)
        Me.GroupBox12.Controls.Add(Me.GroupBox16)
        Me.GroupBox12.Location = New System.Drawing.Point(20, 24)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(1058, 479)
        Me.GroupBox12.TabIndex = 1
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "FAITES VOS AFFICHES ICI"
        '
        'GroupBox27
        '
        Me.GroupBox27.Controls.Add(Me.GroupBox28)
        Me.GroupBox27.Controls.Add(Me.BunifuSeparator6)
        Me.GroupBox27.Controls.Add(Me.BunifuCustomLabel4)
        Me.GroupBox27.Location = New System.Drawing.Point(837, 255)
        Me.GroupBox27.Name = "GroupBox27"
        Me.GroupBox27.Size = New System.Drawing.Size(200, 200)
        Me.GroupBox27.TabIndex = 22
        Me.GroupBox27.TabStop = False
        '
        'GroupBox28
        '
        Me.GroupBox28.Controls.Add(Me.SimpleButton18)
        Me.GroupBox28.Location = New System.Drawing.Point(30, 64)
        Me.GroupBox28.Name = "GroupBox28"
        Me.GroupBox28.Size = New System.Drawing.Size(148, 125)
        Me.GroupBox28.TabIndex = 7
        Me.GroupBox28.TabStop = False
        '
        'SimpleButton18
        '
        Me.SimpleButton18.Image = CType(resources.GetObject("SimpleButton18.Image"), System.Drawing.Image)
        Me.SimpleButton18.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton18.Location = New System.Drawing.Point(23, 40)
        Me.SimpleButton18.Name = "SimpleButton18"
        Me.SimpleButton18.Size = New System.Drawing.Size(107, 45)
        Me.SimpleButton18.TabIndex = 7
        Me.SimpleButton18.Text = "IMPRIMER"
        '
        'BunifuSeparator6
        '
        Me.BunifuSeparator6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator6.LineThickness = 1
        Me.BunifuSeparator6.Location = New System.Drawing.Point(19, 43)
        Me.BunifuSeparator6.Name = "BunifuSeparator6"
        Me.BunifuSeparator6.Size = New System.Drawing.Size(167, 23)
        Me.BunifuSeparator6.TabIndex = 6
        Me.BunifuSeparator6.Transparency = 255
        Me.BunifuSeparator6.Vertical = False
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(49, 19)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(105, 24)
        Me.BunifuCustomLabel4.TabIndex = 5
        Me.BunifuCustomLabel4.Text = "AFFICHE"
        '
        'txt_id_programmation
        '
        Me.txt_id_programmation.Location = New System.Drawing.Point(522, 229)
        Me.txt_id_programmation.Name = "txt_id_programmation"
        Me.txt_id_programmation.Size = New System.Drawing.Size(15, 21)
        Me.txt_id_programmation.TabIndex = 21
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.GroupBox14)
        Me.GroupBox13.Location = New System.Drawing.Point(635, 29)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(423, 206)
        Me.GroupBox13.TabIndex = 3
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "OTHERS"
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.GroupBox15)
        Me.GroupBox14.Location = New System.Drawing.Point(23, 31)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(379, 158)
        Me.GroupBox14.TabIndex = 0
        Me.GroupBox14.TabStop = False
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.SimpleButton10)
        Me.GroupBox15.Controls.Add(Me.SimpleButton11)
        Me.GroupBox15.Controls.Add(Me.SimpleButton12)
        Me.GroupBox15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox15.Location = New System.Drawing.Point(23, 33)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(332, 93)
        Me.GroupBox15.TabIndex = 18
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "ACTIONS"
        '
        'SimpleButton10
        '
        Me.SimpleButton10.Image = CType(resources.GetObject("SimpleButton10.Image"), System.Drawing.Image)
        Me.SimpleButton10.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton10.Location = New System.Drawing.Point(232, 35)
        Me.SimpleButton10.Name = "SimpleButton10"
        Me.SimpleButton10.Size = New System.Drawing.Size(91, 45)
        Me.SimpleButton10.TabIndex = 8
        Me.SimpleButton10.Text = "DELETE"
        '
        'SimpleButton11
        '
        Me.SimpleButton11.Image = CType(resources.GetObject("SimpleButton11.Image"), System.Drawing.Image)
        Me.SimpleButton11.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton11.Location = New System.Drawing.Point(133, 35)
        Me.SimpleButton11.Name = "SimpleButton11"
        Me.SimpleButton11.Size = New System.Drawing.Size(93, 45)
        Me.SimpleButton11.TabIndex = 7
        Me.SimpleButton11.Text = "UPDATE"
        '
        'SimpleButton12
        '
        Me.SimpleButton12.Image = CType(resources.GetObject("SimpleButton12.Image"), System.Drawing.Image)
        Me.SimpleButton12.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton12.Location = New System.Drawing.Point(39, 35)
        Me.SimpleButton12.Name = "SimpleButton12"
        Me.SimpleButton12.Size = New System.Drawing.Size(88, 45)
        Me.SimpleButton12.TabIndex = 6
        Me.SimpleButton12.Text = "INSERT"
        '
        'GridControl4
        '
        Me.GridControl4.Location = New System.Drawing.Point(23, 255)
        Me.GridControl4.MainView = Me.GridView4
        Me.GridControl4.MenuManager = Me.ribbonControl1
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.Size = New System.Drawing.Size(798, 200)
        Me.GridControl4.TabIndex = 2
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.GridControl4
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsFind.AlwaysVisible = True
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.txt_prix_programmation)
        Me.GroupBox16.Controls.Add(Me.cb_type_billet)
        Me.GroupBox16.Controls.Add(Me.cb_programme)
        Me.GroupBox16.Controls.Add(Me.Label17)
        Me.GroupBox16.Controls.Add(Me.Label19)
        Me.GroupBox16.Controls.Add(Me.Label20)
        Me.GroupBox16.Location = New System.Drawing.Point(19, 29)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(563, 206)
        Me.GroupBox16.TabIndex = 1
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "ENTER DIFFERENTS INFORMATIONS"
        '
        'txt_prix_programmation
        '
        Me.txt_prix_programmation.Location = New System.Drawing.Point(161, 133)
        Me.txt_prix_programmation.Name = "txt_prix_programmation"
        Me.txt_prix_programmation.Properties.Mask.EditMask = "d"
        Me.txt_prix_programmation.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_prix_programmation.Size = New System.Drawing.Size(298, 20)
        Me.txt_prix_programmation.TabIndex = 29
        '
        'cb_type_billet
        '
        Me.cb_type_billet.FormattingEnabled = True
        Me.cb_type_billet.Location = New System.Drawing.Point(161, 96)
        Me.cb_type_billet.Name = "cb_type_billet"
        Me.cb_type_billet.Size = New System.Drawing.Size(298, 21)
        Me.cb_type_billet.TabIndex = 26
        '
        'cb_programme
        '
        Me.cb_programme.FormattingEnabled = True
        Me.cb_programme.Location = New System.Drawing.Point(161, 67)
        Me.cb_programme.Name = "cb_programme"
        Me.cb_programme.Size = New System.Drawing.Size(298, 21)
        Me.cb_programme.TabIndex = 25
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(17, 104)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 13)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "TYPE BILLET"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(18, 136)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 13)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "PRIX"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(18, 70)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 13)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "PROGRAMME"
        '
        'NavigationPage7
        '
        Me.NavigationPage7.Caption = "PAIEMENT"
        Me.NavigationPage7.Controls.Add(Me.GroupBox24)
        Me.NavigationPage7.Controls.Add(Me.Panel2)
        Me.NavigationPage7.Image = CType(resources.GetObject("NavigationPage7.Image"), System.Drawing.Image)
        Me.NavigationPage7.Name = "NavigationPage7"
        Me.NavigationPage7.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText
        Me.NavigationPage7.Size = New System.Drawing.Size(1098, 527)
        '
        'GroupBox24
        '
        Me.GroupBox24.Controls.Add(Me.GroupBox26)
        Me.GroupBox24.Controls.Add(Me.GridControl6)
        Me.GroupBox24.Controls.Add(Me.GroupBox25)
        Me.GroupBox24.Location = New System.Drawing.Point(399, 27)
        Me.GroupBox24.Name = "GroupBox24"
        Me.GroupBox24.Size = New System.Drawing.Size(670, 470)
        Me.GroupBox24.TabIndex = 1
        Me.GroupBox24.TabStop = False
        '
        'GroupBox26
        '
        Me.GroupBox26.Controls.Add(Me.SimpleButton16)
        Me.GroupBox26.Location = New System.Drawing.Point(511, 26)
        Me.GroupBox26.Name = "GroupBox26"
        Me.GroupBox26.Size = New System.Drawing.Size(138, 195)
        Me.GroupBox26.TabIndex = 3
        Me.GroupBox26.TabStop = False
        '
        'SimpleButton16
        '
        Me.SimpleButton16.Location = New System.Drawing.Point(26, 38)
        Me.SimpleButton16.Name = "SimpleButton16"
        Me.SimpleButton16.Size = New System.Drawing.Size(86, 43)
        Me.SimpleButton16.TabIndex = 0
        Me.SimpleButton16.Text = "VALIDER"
        '
        'GridControl6
        '
        Me.GridControl6.Location = New System.Drawing.Point(15, 242)
        Me.GridControl6.MainView = Me.GridView6
        Me.GridControl6.MenuManager = Me.ribbonControl1
        Me.GridControl6.Name = "GridControl6"
        Me.GridControl6.Size = New System.Drawing.Size(649, 200)
        Me.GridControl6.TabIndex = 2
        Me.GridControl6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView6})
        '
        'GridView6
        '
        Me.GridView6.GridControl = Me.GridControl6
        Me.GridView6.Name = "GridView6"
        '
        'GroupBox25
        '
        Me.GroupBox25.Controls.Add(Me.txt_montant_paye)
        Me.GroupBox25.Controls.Add(Me.cb_billet)
        Me.GroupBox25.Controls.Add(Me.Label35)
        Me.GroupBox25.Controls.Add(Me.Label34)
        Me.GroupBox25.Controls.Add(Me.date_paie)
        Me.GroupBox25.Controls.Add(Me.txt_designation)
        Me.GroupBox25.Controls.Add(Me.BunifuSeparator4)
        Me.GroupBox25.Controls.Add(Me.Label32)
        Me.GroupBox25.Controls.Add(Me.txt_montant_a_payer)
        Me.GroupBox25.Controls.Add(Me.Label30)
        Me.GroupBox25.Controls.Add(Me.Label33)
        Me.GroupBox25.Location = New System.Drawing.Point(15, 20)
        Me.GroupBox25.Name = "GroupBox25"
        Me.GroupBox25.Size = New System.Drawing.Size(471, 201)
        Me.GroupBox25.TabIndex = 1
        Me.GroupBox25.TabStop = False
        '
        'txt_montant_paye
        '
        Me.txt_montant_paye.Location = New System.Drawing.Point(154, 171)
        Me.txt_montant_paye.Name = "txt_montant_paye"
        Me.txt_montant_paye.Properties.Mask.EditMask = "d"
        Me.txt_montant_paye.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_montant_paye.Size = New System.Drawing.Size(293, 20)
        Me.txt_montant_paye.TabIndex = 40
        '
        'cb_billet
        '
        Me.cb_billet.FormattingEnabled = True
        Me.cb_billet.Location = New System.Drawing.Point(149, 104)
        Me.cb_billet.Name = "cb_billet"
        Me.cb_billet.Size = New System.Drawing.Size(299, 21)
        Me.cb_billet.TabIndex = 39
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(6, 166)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(142, 24)
        Me.Label35.TabIndex = 38
        Me.Label35.Text = "MONTANT PAYE"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(14, 68)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(54, 24)
        Me.Label34.TabIndex = 37
        Me.Label34.Text = "DATE"
        '
        'date_paie
        '
        Me.date_paie.Location = New System.Drawing.Point(150, 70)
        Me.date_paie.Name = "date_paie"
        Me.date_paie.Size = New System.Drawing.Size(298, 21)
        Me.date_paie.TabIndex = 36
        '
        'txt_designation
        '
        Me.txt_designation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_designation.Enabled = False
        Me.txt_designation.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_designation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_designation.HintForeColor = System.Drawing.Color.Empty
        Me.txt_designation.HintText = ""
        Me.txt_designation.isPassword = False
        Me.txt_designation.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_designation.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_designation.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_designation.LineThickness = 3
        Me.txt_designation.Location = New System.Drawing.Point(149, 30)
        Me.txt_designation.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_designation.Name = "txt_designation"
        Me.txt_designation.Size = New System.Drawing.Size(166, 21)
        Me.txt_designation.TabIndex = 2
        Me.txt_designation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuSeparator4
        '
        Me.BunifuSeparator4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator4.LineThickness = 1
        Me.BunifuSeparator4.Location = New System.Drawing.Point(16, 44)
        Me.BunifuSeparator4.Name = "BunifuSeparator4"
        Me.BunifuSeparator4.Size = New System.Drawing.Size(65, 11)
        Me.BunifuSeparator4.TabIndex = 21
        Me.BunifuSeparator4.Transparency = 255
        Me.BunifuSeparator4.Vertical = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(14, 101)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(70, 24)
        Me.Label32.TabIndex = 35
        Me.Label32.Text = "BILLET"
        '
        'txt_montant_a_payer
        '
        Me.txt_montant_a_payer.AutoSize = True
        Me.txt_montant_a_payer.Font = New System.Drawing.Font("Sitka Small", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_montant_a_payer.Location = New System.Drawing.Point(309, 119)
        Me.txt_montant_a_payer.Name = "txt_montant_a_payer"
        Me.txt_montant_a_payer.Size = New System.Drawing.Size(36, 40)
        Me.txt_montant_a_payer.TabIndex = 34
        Me.txt_montant_a_payer.Text = "0"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(173, 134)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(130, 24)
        Me.Label30.TabIndex = 33
        Me.Label30.Text = "PRIX A PAYER"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(12, 24)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(74, 24)
        Me.Label33.TabIndex = 26
        Me.Label33.Text = "N° PAIE"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txt_id_paiement)
        Me.Panel2.Controls.Add(Me.GroupBox23)
        Me.Panel2.Controls.Add(Me.GroupBox22)
        Me.Panel2.Controls.Add(Me.BunifuSeparator2)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel2.Location = New System.Drawing.Point(37, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(334, 470)
        Me.Panel2.TabIndex = 0
        '
        'txt_id_paiement
        '
        Me.txt_id_paiement.Location = New System.Drawing.Point(291, 224)
        Me.txt_id_paiement.Name = "txt_id_paiement"
        Me.txt_id_paiement.Size = New System.Drawing.Size(15, 21)
        Me.txt_id_paiement.TabIndex = 23
        '
        'GroupBox23
        '
        Me.GroupBox23.Controls.Add(Me.SimpleButton20)
        Me.GroupBox23.Controls.Add(Me.Label36)
        Me.GroupBox23.Controls.Add(Me.Label31)
        Me.GroupBox23.Controls.Add(Me.BunifuSeparator3)
        Me.GroupBox23.Controls.Add(Me.Label28)
        Me.GroupBox23.Location = New System.Drawing.Point(56, 171)
        Me.GroupBox23.Name = "GroupBox23"
        Me.GroupBox23.Size = New System.Drawing.Size(218, 259)
        Me.GroupBox23.TabIndex = 8
        Me.GroupBox23.TabStop = False
        '
        'SimpleButton20
        '
        Me.SimpleButton20.Image = CType(resources.GetObject("SimpleButton20.Image"), System.Drawing.Image)
        Me.SimpleButton20.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton20.Location = New System.Drawing.Point(52, 172)
        Me.SimpleButton20.Name = "SimpleButton20"
        Me.SimpleButton20.Size = New System.Drawing.Size(84, 45)
        Me.SimpleButton20.TabIndex = 23
        Me.SimpleButton20.Text = "RECU"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label36.Location = New System.Drawing.Point(19, 110)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(152, 19)
        Me.Label36.TabIndex = 22
        Me.Label36.Text = "# NO ELECTRONIC M"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(19, 79)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(59, 19)
        Me.Label31.TabIndex = 21
        Me.Label31.Text = "# CASH"
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 1
        Me.BunifuSeparator3.Location = New System.Drawing.Point(11, 53)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(199, 23)
        Me.BunifuSeparator3.TabIndex = 20
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(19, 26)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(191, 24)
        Me.Label28.TabIndex = 19
        Me.Label28.Text = "MODE DE PAIEMENT"
        '
        'GroupBox22
        '
        Me.GroupBox22.Controls.Add(Me.Label27)
        Me.GroupBox22.Location = New System.Drawing.Point(57, 88)
        Me.GroupBox22.Name = "GroupBox22"
        Me.GroupBox22.Size = New System.Drawing.Size(218, 65)
        Me.GroupBox22.TabIndex = 7
        Me.GroupBox22.TabStop = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(38, 26)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(135, 19)
        Me.Label27.TabIndex = 19
        Me.Label27.Text = "IN GOD WE TRUST"
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(36, 48)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(258, 23)
        Me.BunifuSeparator2.TabIndex = 6
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(57, 24)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(213, 24)
        Me.BunifuCustomLabel2.TabIndex = 5
        Me.BunifuCustomLabel2.Text = "PAYEMENT BILLET"
        '
        'NavigationPage1
        '
        Me.NavigationPage1.Caption = "HOME"
        Me.NavigationPage1.Image = CType(resources.GetObject("NavigationPage1.Image"), System.Drawing.Image)
        Me.NavigationPage1.Name = "NavigationPage1"
        Me.NavigationPage1.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText
        Me.NavigationPage1.Size = New System.Drawing.Size(1098, 527)
        '
        'NavigationPage6
        '
        Me.NavigationPage6.Caption = "GUICHET"
        Me.NavigationPage6.Controls.Add(Me.txt_id_billet)
        Me.NavigationPage6.Controls.Add(Me.GroupBox21)
        Me.NavigationPage6.Controls.Add(Me.BunifuSeparator1)
        Me.NavigationPage6.Controls.Add(Me.BunifuCustomLabel1)
        Me.NavigationPage6.Controls.Add(Me.GroupBox18)
        Me.NavigationPage6.Controls.Add(Me.GroupBox17)
        Me.NavigationPage6.Image = CType(resources.GetObject("NavigationPage6.Image"), System.Drawing.Image)
        Me.NavigationPage6.Name = "NavigationPage6"
        Me.NavigationPage6.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText
        Me.NavigationPage6.Size = New System.Drawing.Size(1098, 527)
        '
        'txt_id_billet
        '
        Me.txt_id_billet.Location = New System.Drawing.Point(542, 253)
        Me.txt_id_billet.Name = "txt_id_billet"
        Me.txt_id_billet.Size = New System.Drawing.Size(15, 21)
        Me.txt_id_billet.TabIndex = 22
        '
        'GroupBox21
        '
        Me.GroupBox21.Controls.Add(Me.SimpleButton19)
        Me.GroupBox21.Controls.Add(Me.Label26)
        Me.GroupBox21.Location = New System.Drawing.Point(61, 315)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Size = New System.Drawing.Size(218, 174)
        Me.GroupBox21.TabIndex = 4
        Me.GroupBox21.TabStop = False
        '
        'SimpleButton19
        '
        Me.SimpleButton19.Image = CType(resources.GetObject("SimpleButton19.Image"), System.Drawing.Image)
        Me.SimpleButton19.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton19.Location = New System.Drawing.Point(56, 65)
        Me.SimpleButton19.Name = "SimpleButton19"
        Me.SimpleButton19.Size = New System.Drawing.Size(107, 45)
        Me.SimpleButton19.TabIndex = 20
        Me.SimpleButton19.Text = "BILLET"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(52, 26)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(97, 13)
        Me.Label26.TabIndex = 19
        Me.Label26.Text = "IN GOD WE TRUST"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(40, 289)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(258, 23)
        Me.BunifuSeparator1.TabIndex = 3
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(99, 265)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(135, 24)
        Me.BunifuCustomLabel1.TabIndex = 2
        Me.BunifuCustomLabel1.Text = "BILLETERIE"
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.PictureEdit2)
        Me.GroupBox18.Location = New System.Drawing.Point(24, 28)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(297, 221)
        Me.GroupBox18.TabIndex = 1
        Me.GroupBox18.TabStop = False
        '
        'PictureEdit2
        '
        Me.PictureEdit2.Location = New System.Drawing.Point(20, 20)
        Me.PictureEdit2.MenuManager = Me.ribbonControl1
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit2.Size = New System.Drawing.Size(257, 178)
        Me.PictureEdit2.TabIndex = 0
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.GridControl5)
        Me.GroupBox17.Controls.Add(Me.GroupBox20)
        Me.GroupBox17.Controls.Add(Me.GroupBox19)
        Me.GroupBox17.Location = New System.Drawing.Point(339, 28)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(733, 480)
        Me.GroupBox17.TabIndex = 0
        Me.GroupBox17.TabStop = False
        '
        'GridControl5
        '
        Me.GridControl5.Location = New System.Drawing.Point(32, 261)
        Me.GridControl5.MainView = Me.GridView5
        Me.GridControl5.MenuManager = Me.ribbonControl1
        Me.GridControl5.Name = "GridControl5"
        Me.GridControl5.Size = New System.Drawing.Size(683, 200)
        Me.GridControl5.TabIndex = 20
        Me.GridControl5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
        '
        'GridView5
        '
        Me.GridView5.GridControl = Me.GridControl5
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsFind.AlwaysVisible = True
        '
        'GroupBox20
        '
        Me.GroupBox20.Controls.Add(Me.SimpleButton13)
        Me.GroupBox20.Controls.Add(Me.SimpleButton14)
        Me.GroupBox20.Controls.Add(Me.SimpleButton15)
        Me.GroupBox20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox20.Location = New System.Drawing.Point(579, 28)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(136, 184)
        Me.GroupBox20.TabIndex = 19
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "ACTIONS"
        '
        'SimpleButton13
        '
        Me.SimpleButton13.Image = CType(resources.GetObject("SimpleButton13.Image"), System.Drawing.Image)
        Me.SimpleButton13.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton13.Location = New System.Drawing.Point(20, 126)
        Me.SimpleButton13.Name = "SimpleButton13"
        Me.SimpleButton13.Size = New System.Drawing.Size(86, 45)
        Me.SimpleButton13.TabIndex = 8
        Me.SimpleButton13.Text = "DELETE"
        '
        'SimpleButton14
        '
        Me.SimpleButton14.Image = CType(resources.GetObject("SimpleButton14.Image"), System.Drawing.Image)
        Me.SimpleButton14.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton14.Location = New System.Drawing.Point(18, 75)
        Me.SimpleButton14.Name = "SimpleButton14"
        Me.SimpleButton14.Size = New System.Drawing.Size(88, 45)
        Me.SimpleButton14.TabIndex = 7
        Me.SimpleButton14.Text = "UPDATE"
        '
        'SimpleButton15
        '
        Me.SimpleButton15.Image = CType(resources.GetObject("SimpleButton15.Image"), System.Drawing.Image)
        Me.SimpleButton15.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton15.Location = New System.Drawing.Point(18, 24)
        Me.SimpleButton15.Name = "SimpleButton15"
        Me.SimpleButton15.Size = New System.Drawing.Size(88, 45)
        Me.SimpleButton15.TabIndex = 6
        Me.SimpleButton15.Text = "INSERT"
        '
        'GroupBox19
        '
        Me.GroupBox19.Controls.Add(Me.txt_reduction)
        Me.GroupBox19.Controls.Add(Me.cb_programmation)
        Me.GroupBox19.Controls.Add(Me.cb_client)
        Me.GroupBox19.Controls.Add(Me.BunifuSeparator5)
        Me.GroupBox19.Controls.Add(Me.txt_prix_a_payer)
        Me.GroupBox19.Controls.Add(Me.Label24)
        Me.GroupBox19.Controls.Add(Me.Label23)
        Me.GroupBox19.Controls.Add(Me.Label22)
        Me.GroupBox19.Controls.Add(Me.Label21)
        Me.GroupBox19.Location = New System.Drawing.Point(22, 20)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(522, 201)
        Me.GroupBox19.TabIndex = 0
        Me.GroupBox19.TabStop = False
        '
        'txt_reduction
        '
        Me.txt_reduction.Location = New System.Drawing.Point(149, 172)
        Me.txt_reduction.Name = "txt_reduction"
        Me.txt_reduction.Properties.Mask.EditMask = "d"
        Me.txt_reduction.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_reduction.Size = New System.Drawing.Size(298, 20)
        Me.txt_reduction.TabIndex = 38
        '
        'cb_programmation
        '
        Me.cb_programmation.FormattingEnabled = True
        Me.cb_programmation.Location = New System.Drawing.Point(149, 28)
        Me.cb_programmation.Name = "cb_programmation"
        Me.cb_programmation.Size = New System.Drawing.Size(299, 21)
        Me.cb_programmation.TabIndex = 36
        '
        'cb_client
        '
        Me.cb_client.FormattingEnabled = True
        Me.cb_client.Location = New System.Drawing.Point(149, 65)
        Me.cb_client.Name = "cb_client"
        Me.cb_client.Size = New System.Drawing.Size(299, 21)
        Me.cb_client.TabIndex = 35
        '
        'BunifuSeparator5
        '
        Me.BunifuSeparator5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator5.LineThickness = 1
        Me.BunifuSeparator5.Location = New System.Drawing.Point(156, 141)
        Me.BunifuSeparator5.Name = "BunifuSeparator5"
        Me.BunifuSeparator5.Size = New System.Drawing.Size(147, 10)
        Me.BunifuSeparator5.TabIndex = 21
        Me.BunifuSeparator5.Transparency = 255
        Me.BunifuSeparator5.Vertical = False
        '
        'txt_prix_a_payer
        '
        Me.txt_prix_a_payer.AutoSize = True
        Me.txt_prix_a_payer.Font = New System.Drawing.Font("Sitka Small", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prix_a_payer.Location = New System.Drawing.Point(310, 107)
        Me.txt_prix_a_payer.Name = "txt_prix_a_payer"
        Me.txt_prix_a_payer.Size = New System.Drawing.Size(36, 40)
        Me.txt_prix_a_payer.TabIndex = 34
        Me.txt_prix_a_payer.Text = "0"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(162, 119)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(130, 24)
        Me.Label24.TabIndex = 33
        Me.Label24.Text = "PRIX A PAYER"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(7, 179)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(66, 13)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "REDUCTION"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(7, 65)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(42, 13)
        Me.Label22.TabIndex = 28
        Me.Label22.Text = "CLIENT"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(7, 31)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(97, 13)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "PROGRAMMATION"
        '
        'Form1
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 767)
        Me.Controls.Add(Me.NavigationPane1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.Name = "Form1"
        Me.Ribbon = Me.ribbonControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "THEATER MANAGEMENT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPane1.ResumeLayout(False)
        Me.NavigationPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPage3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.txt_chaise_salle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.NavigationPage4.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.txt_heure_fin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_heure_debut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPage5.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox27.ResumeLayout(False)
        Me.GroupBox27.PerformLayout()
        Me.GroupBox28.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox15.ResumeLayout(False)
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        CType(Me.txt_prix_programmation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPage7.ResumeLayout(False)
        Me.GroupBox24.ResumeLayout(False)
        Me.GroupBox26.ResumeLayout(False)
        CType(Me.GridControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox25.ResumeLayout(False)
        Me.GroupBox25.PerformLayout()
        CType(Me.txt_montant_paye.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox23.ResumeLayout(False)
        Me.GroupBox23.PerformLayout()
        Me.GroupBox22.ResumeLayout(False)
        Me.GroupBox22.PerformLayout()
        Me.NavigationPage6.ResumeLayout(False)
        Me.NavigationPage6.PerformLayout()
        Me.GroupBox21.ResumeLayout(False)
        Me.GroupBox21.PerformLayout()
        Me.GroupBox18.ResumeLayout(False)
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox17.ResumeLayout(False)
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox19.PerformLayout()
        CType(Me.txt_reduction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents NavigationPane1 As DevExpress.XtraBars.Navigation.NavigationPane
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage3 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonGalleryBarItem1 As DevExpress.XtraBars.RibbonGalleryBarItem
    Friend WithEvents NavigationPage4 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage5 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage6 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage7 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_postnom As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_nom As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txt_telephone As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cb_sexe As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_file As TextBox
    Friend WithEvents btn_pacourir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_supp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_update As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_add As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_search As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_adresse As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_prenom As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_description_theatre As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_nom_theatre As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_nom_salle As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents SimpleButton10 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton11 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton12 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox17 As GroupBox
    Friend WithEvents GroupBox18 As GroupBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents GroupBox19 As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txt_prix_a_payer As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents GroupBox20 As GroupBox
    Friend WithEvents SimpleButton13 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton14 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton15 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox21 As GroupBox
    Friend WithEvents Label26 As Label
    Friend WithEvents GridControl5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox23 As GroupBox
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label28 As Label
    Friend WithEvents GroupBox22 As GroupBox
    Friend WithEvents Label27 As Label
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GroupBox24 As GroupBox
    Friend WithEvents GroupBox25 As GroupBox
    Friend WithEvents txt_designation As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuSeparator4 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label32 As Label
    Friend WithEvents txt_montant_a_payer As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents date_paie As DateTimePicker
    Friend WithEvents BunifuSeparator5 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label35 As Label
    Friend WithEvents GroupBox26 As GroupBox
    Friend WithEvents SimpleButton16 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl6 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label36 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_id_theatre As TextBox
    Friend WithEvents txt_id_salle As TextBox
    Friend WithEvents txt_id_programme As TextBox
    Friend WithEvents date_ceremony As DateTimePicker
    Friend WithEvents cb_salle As ComboBox
    Friend WithEvents cb_theatre As ComboBox
    Friend WithEvents SimpleButton17 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_heure_fin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_heure_debut As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_prix_programmation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cb_type_billet As ComboBox
    Friend WithEvents cb_programme As ComboBox
    Friend WithEvents txt_id_programmation As TextBox
    Friend WithEvents cb_programmation As ComboBox
    Friend WithEvents cb_client As ComboBox
    Friend WithEvents txt_reduction As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_id_billet As TextBox
    Friend WithEvents txt_chaise_salle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_montant_paye As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cb_billet As ComboBox
    Friend WithEvents txt_id_paiement As TextBox
    Friend WithEvents GroupBox27 As GroupBox
    Friend WithEvents GroupBox28 As GroupBox
    Friend WithEvents SimpleButton18 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BunifuSeparator6 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents SimpleButton19 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton20 As DevExpress.XtraEditors.SimpleButton
End Class

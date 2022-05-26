Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text
Imports DevExpress.XtraReports.UI

Partial Public Class Form1

    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    Public var As String

    Dim con As New SqlConnection
    Dim cmd As SqlCommand
    Dim dt As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cnx As New connexion_class
    Dim clt As client_class
    Dim prins_object As principal_class
    Public chem As New chemin_acces_classe
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub
    'Dim prins_object As principal_class
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            prins_object = New principal_class
            'prins_object.innitialise_connexion()
            prins_object.GetTable("client", DataGridView1)
            prins_object.GetTablegrid("theatre", GridControl1)
            prins_object.GetTablegrid("salle", GridControl2)
            prins_object.GetTablegrid("programme_table_view", GridControl3)
            prins_object.GetTablegrid("programmation_table_view", GridControl4)
            prins_object.GetTablegrid("billet_table_view", GridControl5)
            prins_object.GetTablegrid("paiement", GridControl6)


            txt_designation.Text = prins_object.GetNumFact()

            prins_object.chargementComboBox(cb_salle, "nom_salle", "salle")
            prins_object.chargementComboBox(cb_theatre, "nom_theatre", "theatre")
            prins_object.chargementComboBox(cb_programme, "id_programme", "programme")
            prins_object.chargementComboBox(cb_type_billet, "designation", "type_billet")
            prins_object.chargementComboBox(cb_client, "nom", "client")
            prins_object.chargementComboBox(cb_programmation, "id_programmation", "programmation")
            'prins_object.chargementComboBox(cb_programmation, "id_programmation", "programmation")

            prins_object.chargementComboBoxTestExist(cb_billet, "id_billet", "select distinct id_billet from billet where check_paie=0")
            'prins_object.chargementComboBoxTestExist(cb_billet, "id_programme", "select id_programme from programme")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub NavigationPage6_Paint(sender As Object, e As PaintEventArgs) Handles NavigationPage6.Paint

    End Sub
    Private Sub init_client()
        txt_id.Text = ""
        txt_nom.Text = ""
        txt_postnom.Text = ""
        txt_prenom.Text = ""
        cb_sexe.Text = ""
        PictureEdit1.EditValue = ""
        txt_file.Text = ""
        txt_adresse.Text = ""
        txt_telephone.Text = ""
    End Sub



    Dim id As Integer
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If (txt_nom.Text <> "" And txt_postnom.Text <> "" And txt_prenom.Text <> "" And DateTimePicker1.Text <> "" And txt_telephone.Text <> "" And cb_sexe.Text <> "" And txt_file.Text <> "" And txt_adresse.Text <> "") Then
            Try

                clt = New client_class
                clt.Id1 = id
                clt.Nom1 = txt_nom.Text
                clt.Postnom1 = txt_postnom.Text
                clt.Prenom1 = txt_prenom.Text
                clt.Sexe1 = cb_sexe.Text
                clt.Telephone1 = txt_telephone.Text
                clt.Adresse1 = txt_adresse.Text
                clt.Date_naissance1 = DateTime.Parse(DateTimePicker1.Text)

                prins_object.operation_client(clt, PictureEdit1)
                init_client()
                'prins_object.GetTablegrid("tmembre", GridControl1)
                prins_object.GetTable("client", DataGridView1)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Else
            MessageBox.Show("les champs sont requis")

        End If
    End Sub

    Private Sub btn_pacourir_Click(sender As Object, e As EventArgs) Handles btn_pacourir.Click
        Try
            Dim fr As New OpenFileDialog
            fr.ShowDialog()
            If (Len(fr.FileName) <> 0) Then
                txt_file.Text = fr.FileName
                PictureEdit1.Image = Image.FromFile(fr.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If (txt_nom.Text <> "" And txt_postnom.Text <> "" And txt_prenom.Text <> "" And DateTimePicker1.Text <> "" And txt_telephone.Text <> "" And cb_sexe.Text <> "" And txt_file.Text <> "" And txt_adresse.Text <> "") Then
            Try
                clt = New client_class
                clt.Id1 = Integer.Parse(txt_id.Text)
                clt.Nom1 = txt_nom.Text
                clt.Postnom1 = txt_postnom.Text
                clt.Prenom1 = txt_prenom.Text
                clt.Sexe1 = cb_sexe.Text
                clt.Adresse1 = txt_adresse.Text
                clt.Date_naissance1 = DateTime.Parse(DateTimePicker1.Text)
                ' member.Ref_categorie1 = Integer.Parse(principal_class.GetID("id_categorie", "tcategorie_membre", "designation", cb_categorie.Text))
                clt.Telephone1 = txt_telephone.Text

                prins_object.operation_client(clt, PictureEdit1)
                init_client()
                'prins_object.GetTablegrid("tmembre", GridControl1)
                prins_object.GetTable("client", DataGridView1)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Else
            MessageBox.Show("les champs sont requis")

        End If
    End Sub

    Private Sub btn_supp_Click(sender As Object, e As EventArgs) Handles btn_supp.Click
        Try
            Dim réponse As DialogResult = MessageBox.Show("Voulez-vous vraiment ce client", "Suppression", MessageBoxButtons.YesNo,
MessageBoxIcon.Question)
            If réponse = DialogResult.Yes Then
                prins_object.Supprimer("client", "id_client", Integer.Parse(txt_id.Text))
                prins_object.GetTable("client", DataGridView1)
                'prins_object.GetTablegrid("tmembre", GridControl1)
                init_client()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Try
            txt_id.Text = DataGridView1.CurrentRow.Cells("id_client").Value.ToString
            txt_nom.Text = DataGridView1.CurrentRow.Cells("nom").Value.ToString
            txt_postnom.Text = DataGridView1.CurrentRow.Cells("postnom").Value.ToString
            txt_prenom.Text = DataGridView1.CurrentRow.Cells("prenom").Value.ToString
            cb_sexe.Text = DataGridView1.CurrentRow.Cells("sexe").Value.ToString
            'DateTimePicker1.Text = DataGridView1.CurrentRow.Cells("date_naissance").Value.ToString
            DateTimePicker1.Text = DataGridView1.CurrentRow.Cells("date_naissance").Value.ToString
            txt_telephone.Text = DataGridView1.CurrentRow.Cells("telephone").Value.ToString
            txt_adresse.Text = DataGridView1.CurrentRow.Cells("adresse").Value.ToString
            PictureEdit1.EditValue = DataGridView1.CurrentRow.Cells("photo").FormattedValue
            'prins_object.retreivePhoto("photo", "tmembre", "num_membre", txt_id.Text, PictureEdit1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub init_theatre()
        txt_id_theatre.Text = ""
        txt_chaise_salle.Text = ""
        txt_nom_salle.Text = ""
        txt_id_salle.Text = ""
        txt_description_theatre.Text = ""
        txt_nom_theatre.Text = ""
    End Sub


    Dim id_theatre As Integer
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If (txt_nom_theatre.Text <> "" And txt_description_theatre.Text <> "") Then
            Try

                Dim th As theatre_class
                th = New theatre_class
                th.Id1 = id_theatre
                th.Description1 = txt_description_theatre.Text
                th.Nom_theatre1 = txt_nom_theatre.Text

                prins_object.operation_theatre(th)
                init_theatre()
                'prins_object.GetTablegrid("tmembre", GridControl1)
                prins_object.GetTablegrid("theatre", GridControl1)
                'prins_object.GetTable("theatre", DataGridView1)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Else
            MessageBox.Show("les champs sont requis")

        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If (txt_description_theatre.Text <> "" And txt_nom_theatre.Text <> "") Then
            Try
                Dim th As theatre_class
                th = New theatre_class
                th.Id1 = Integer.Parse(txt_id_theatre.Text)
                th.Description1 = txt_description_theatre.Text
                th.Nom_theatre1 = txt_nom_theatre.Text

                prins_object.operation_theatre(th)
                init_theatre()
                prins_object.GetTablegrid("theatre", GridControl1)
                'prins_object.GetTable("client", DataGridView1)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Else
            MessageBox.Show("les champs sont requis")

        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            Dim réponse As DialogResult = MessageBox.Show("Voulez-vous vraiment ce theatre", "Suppression", MessageBoxButtons.YesNo,
MessageBoxIcon.Question)
            If réponse = DialogResult.Yes Then
                prins_object.Supprimer("theatre", "id_theatre", Integer.Parse(txt_id_theatre.Text))
                prins_object.GetTablegrid("theatre", GridControl1)
                'prins_object.GetTablegrid("tmembre", GridControl1)
                init_theatre()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GridView1_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        Try
            txt_id_theatre.Text = GridView1.GetRowCellValue(e.RowHandle, "id_theatre").ToString
            txt_nom_theatre.Text = GridView1.GetRowCellValue(e.RowHandle, "nom_theatre").ToString
            txt_description_theatre.Text = GridView1.GetRowCellValue(e.RowHandle, "descriptionn").ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Dim id_salle As Integer
    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        If (txt_nom_salle.Text <> "" And txt_chaise_salle.Text <> "") Then
            Try
                Dim sal As salle_class
                sal = New salle_class
                sal.Id1 = id_salle
                sal.Nom_salle1 = txt_nom_salle.Text
                sal.Chaise_disponible1 = Integer.Parse(txt_chaise_salle.Text)

                prins_object.operation_salle(sal)
                init_theatre()
                prins_object.GetTablegrid("salle", GridControl2)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Else
            MessageBox.Show("les champs sont requis")

        End If
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        If (txt_nom_salle.Text <> "" And txt_chaise_salle.Text <> "") Then
            Try
                Dim sal As salle_class
                sal = New salle_class
                sal.Id1 = Integer.Parse(txt_id_theatre.Text)
                sal.Nom_salle1 = txt_nom_salle.Text
                sal.Chaise_disponible1 = Integer.Parse(txt_chaise_salle.Text)
                prins_object.operation_salle(sal)
                init_theatre()
                prins_object.GetTablegrid("salle", GridControl2)
                'prins_object.GetTable("client", DataGridView1)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Else
            MessageBox.Show("les champs sont requis")

        End If
    End Sub

    Private Sub GridView2_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView2.RowClick
        Try
            txt_id_salle.Text = GridView1.GetRowCellValue(e.RowHandle, "id_salle").ToString
            txt_nom_salle.Text = GridView1.GetRowCellValue(e.RowHandle, "nom_salle").ToString
            txt_chaise_salle.Text = GridView1.GetRowCellValue(e.RowHandle, "chaise_disponible").ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub refreshing()
        Try

            init_client()
            init_theatre()
            init_programme()
            init_programmation()
            init_billet()
            init_paiement()

            cb_salle.Items.Clear()
            cb_theatre.Items.Clear()
            cb_programme.Items.Clear()
            cb_type_billet.Items.Clear()
            cb_client.Items.Clear()
            cb_programmation.Items.Clear()
            cb_billet.Items.Clear()

            prins_object.chargementComboBox(cb_salle, "nom_salle", "salle")
            prins_object.chargementComboBox(cb_theatre, "nom_theatre", "theatre")
            prins_object.chargementComboBox(cb_programme, "id_programme", "programme")
            prins_object.chargementComboBox(cb_type_billet, "designation", "type_billet")
            prins_object.chargementComboBox(cb_client, "nom", "client")
            prins_object.chargementComboBox(cb_programmation, "id_programmation", "programmation")
            prins_object.chargementComboBoxTestExist(cb_billet, "id_billet", "select distinct id_billet from billet where check_paie=0")


            prins_object.GetTable("client", DataGridView1)
            prins_object.GetTablegrid("theatre", GridControl1)
            prins_object.GetTablegrid("salle", GridControl2)
            prins_object.GetTablegrid("programme_table_view", GridControl3)
            prins_object.GetTablegrid("programmation_table_view", GridControl4)
            prins_object.GetTablegrid("billet_table_view", GridControl5)
            prins_object.GetTablegrid("paiement", GridControl6)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Try
            refreshing()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Dim id_pro As Integer

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles SimpleButton9.Click
        Try
            If (date_ceremony.Text <> "" And cb_salle.Text <> "" And cb_theatre.Text <> "" And txt_heure_debut.Text <> "" And txt_heure_fin.Text <> "") Then
                Dim pr As programme_classe
                pr = New programme_classe
                pr.Id_programme1 = id_pro
                pr.Date_cer1 = DateTime.Parse(date_ceremony.Text)
                pr.Heure_begin1 = Decimal.Parse(txt_heure_debut.Text)
                pr.Heure_end1 = Decimal.Parse(txt_heure_fin.Text)

                pr.Ref_sall1 = Integer.Parse(prins_object.GetID("id_salle", "salle", "nom_salle", cb_salle.Text))
                pr.Ref_theat1 = Integer.Parse(prins_object.GetID("id_theatre", "theatre", "nom_theatre", cb_theatre.Text))

                prins_object.operation_programme(pr)
                prins_object.GetTablegrid("programme_table_view", GridControl3)
                init_programme()
            Else
                MessageBox.Show("les chams doivent etre tous remplis")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub init_programme()
        date_ceremony.Text = ""
        txt_heure_debut.Text = ""
        txt_heure_fin.Text = ""
        cb_salle.Text = ""
        cb_theatre.Text = ""
        txt_id_programme.Text = ""
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click

    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        Try
            If (txt_id_programme.Text <> "" And date_ceremony.Text <> "" And cb_salle.Text <> "" And cb_theatre.Text <> "" And txt_heure_debut.Text <> "" And txt_heure_fin.Text <> "") Then
                Dim pro As programme_classe
                pro = New programme_classe
                pro.Id_programme1 = Integer.Parse(txt_id_programme.Text)
                pro.Date_cer1 = DateTime.Parse(date_ceremony.Text)
                pro.Heure_begin1 = Decimal.Parse(txt_heure_debut.Text)
                pro.Heure_end1 = Decimal.Parse(txt_heure_fin.Text)
                pro.Ref_sall1 = Integer.Parse(prins_object.GetID("id_salle", "salle", "nom_salle", cb_salle.Text))
                pro.Ref_theat1 = Integer.Parse(prins_object.GetID("id_theatre", "theatre", "nom_theatre", cb_theatre.Text))

                prins_object.operation_programme(pro)
                prins_object.GetTablegrid("programme_table_view", GridControl3)
                init_programme()
            Else
                MessageBox.Show("les chams doivent etre tous remplis")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GridView3_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView3.RowClick
        Try
            txt_id_programme.Text = GridView3.GetRowCellValue(e.RowHandle, "id_programme").ToString
            date_ceremony.Text = GridView3.GetRowCellValue(e.RowHandle, "date_ceremony").ToString
            txt_heure_debut.Text = GridView3.GetRowCellValue(e.RowHandle, "heure_debut").ToString
            txt_heure_fin.Text = GridView3.GetRowCellValue(e.RowHandle, "heure_fin").ToString
            cb_theatre.Text = GridView3.GetRowCellValue(e.RowHandle, "nom_theatre").ToString
            cb_salle.Text = GridView3.GetRowCellValue(e.RowHandle, "nom_salle").ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        Try
            Dim réponse As DialogResult = MessageBox.Show("Voulez-vous vraiment ce programme", "Suppression", MessageBoxButtons.YesNo,
MessageBoxIcon.Question)
            If réponse = DialogResult.Yes Then
                prins_object.Supprimer("programme", "id_programme", Integer.Parse(txt_id_programme.Text))
                prins_object.GetTablegrid("programme_table_view", GridControl3)
                init_programme()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Try
            Dim ech As New frm_settings
            ech.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Dim id_progr As Integer
    Private Sub SimpleButton12_Click(sender As Object, e As EventArgs) Handles SimpleButton12.Click
        Try
            If (cb_programme.Text <> "" And cb_type_billet.Text <> "" And txt_prix_programmation.Text <> "") Then
                Dim pro As programmation_class
                pro = New programmation_class
                pro.Id1 = id_progr
                pro.Prix1 = Decimal.Parse(txt_prix_programmation.Text)


                pro.Ref_programme1 = Integer.Parse(cb_programme.Text)

                pro.Ref_type_billet1 = Integer.Parse(prins_object.GetID("id_type_billet", "type_billet", "designation", cb_type_billet.Text))

                prins_object.operation_programmation(pro)
                prins_object.GetTablegrid("programmation_table_view", GridControl4)
                init_programmation()
            Else
                MessageBox.Show("les chams doivent etre tous remplis")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub init_programmation()
        txt_id_programmation.Text = ""
        cb_type_billet.Text = ""
        cb_programme.Text = ""
    End Sub

    Private Sub cb_programmation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_programmation.SelectedIndexChanged
        Try
            prins_object.afficherprix(cb_programmation, txt_prix_a_payer, Integer.Parse(cb_programmation.Text))

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txt_reduction_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_reduction.KeyUp
        Try
            Dim prix As Decimal
            prix = Decimal.Parse(txt_prix_a_payer.Text)
            Dim red As Decimal
            red = Decimal.Parse(txt_reduction.Text)
            If (red > prix) Then

                MessageBox.Show("ohhh attention la reduction doit etre inferieur au prix", "Invalide", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Dim id_billet As Integer
    Private Sub SimpleButton15_Click(sender As Object, e As EventArgs) Handles SimpleButton15.Click
        If (txt_reduction.Text > txt_prix_a_payer.Text) Then
            MessageBox.Show("ohhh attention la reduction doit etre inferieur au prix", "Invalide", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Try
                If (cb_programmation.Text <> "" And cb_client.Text <> "" And txt_reduction.Text <> "" And txt_prix_a_payer.Text <> "") Then
                    Dim pro As billet_class
                    pro = New billet_class
                    pro.Id1 = id_billet
                    pro.Prix_a_paye1 = Decimal.Parse(txt_prix_a_payer.Text)
                    pro.Reduction1 = Decimal.Parse(txt_reduction.Text)
                    pro.Ref_client1 = Integer.Parse(prins_object.GetID("id_client", "client", "nom", cb_client.Text))
                    pro.Date_achat1 = Now()
                    pro.Check_paie1 = False
                    pro.Ref_programmation1 = Integer.Parse(cb_programmation.Text)
                    Dim num, place_dispo As Integer
                    num = prins_object.Getplace()
                    place_dispo = prins_object.GetPlaceNumberExist
                    If (num > place_dispo) Then
                        MessageBox.Show("ohhh attention les places sont completes pour cette manifestation", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        pro.Numero_chaise1 = num
                        prins_object.operation_billet(pro)
                        prins_object.GetTablegrid("billet_table_view", GridControl5)
                    End If

                    init_billet()
                Else
                    MessageBox.Show("les champs doivent etre tous remplis")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub
    Sub init_billet()
        txt_id_billet.Text = ""
        txt_prix_a_payer.Text = ""
        cb_programmation.Text = ""
        cb_client.Text = ""
        txt_reduction.Text = ""

    End Sub
    Dim id_paie As Integer
    Private Sub SimpleButton16_Click(sender As Object, e As EventArgs) Handles SimpleButton16.Click

        Try
            If (cb_billet.Text <> "" And date_paie.Text <> "" And txt_montant_paye.Text <> "" And txt_designation.Text <> "") Then
                Dim pro As paiement_class
                pro = New paiement_class

                If (txt_montant_paye.Text < txt_montant_a_payer.Text) Then

                    MessageBox.Show("desole complete le montant(pas de dette)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Else
                    pro.Id1 = id_paie
                    pro.Date_paiement1 = DateTime.Parse(date_paie.Text)
                    pro.Designation1 = txt_designation.Text
                    pro.Ref_billet1 = Integer.Parse(cb_billet.Text)
                    pro.Montant1 = Decimal.Parse(txt_montant_paye.Text)

                    update_etat_billet(cb_billet, "update billet set check_paie=1 where id_billet=")
                    prins_object.operation_paiement(pro)
                    prins_object.GetTablegrid("paiement", GridControl6)
                    init_paiement()
                End If


            Else
                MessageBox.Show("les chams doivent etre tous remplis")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub update_etat_billet(ref As ComboBox, req As String)
        Try
            Dim reference As String
            reference = ref.Text
            cnx.connect()
            con = New SqlConnection(cnx.chemin)
            con.Open()
            cmd = New SqlCommand(req & reference, con)
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub init_paiement()
        txt_id_paiement.Text = ""
        txt_designation.Text = ""
        txt_montant_paye.Text = ""
        txt_montant_a_payer.Text = ""
        date_ceremony.Text = ""
    End Sub

    Private Sub cb_billet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_billet.SelectedIndexChanged
        Try
            prins_object.afficherprixApayerBillet(cb_billet, txt_montant_a_payer, Integer.Parse(cb_billet.Text))

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GridView4_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView4.RowClick
        Try
            txt_id_programmation.Text = GridView1.GetRowCellValue(e.RowHandle, "id_programmation").ToString
            cb_programme.Text = GridView1.GetRowCellValue(e.RowHandle, "id_programme").ToString
            cb_type_billet.Text = GridView1.GetRowCellValue(e.RowHandle, "designation").ToString
            txt_prix_programmation.Text = GridView1.GetRowCellValue(e.RowHandle, "prix").ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GridView5_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView5.RowClick
        Try
            txt_id_billet.Text = GridView5.GetRowCellValue(e.RowHandle, "id_billet").ToString
            txt_prix_a_payer.Text = GridView5.GetRowCellValue(e.RowHandle, "prix_a_payer").ToString
            cb_client.Text = GridView5.GetRowCellValue(e.RowHandle, "nom").ToString
            txt_reduction.Text = GridView5.GetRowCellValue(e.RowHandle, "reduction").ToString
            cb_programmation.Text = GridView5.GetRowCellValue(e.RowHandle, "id_programmation").ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton20_Click(sender As Object, e As EventArgs) Handles SimpleButton20.Click
        If (txt_id_paiement.Text <> "") Then

            Try

                Dim rpt As rpt_recu = New rpt_recu()
                rpt.DataSource = prins_object.get_Report_X("paiement_view", "id_paiement", Integer.Parse(txt_id_paiement.Text))
                ' rpt.DataSource = prins_object.get_Report_Trier1("effectuer_view", "date_effectuer", Date.Parse(DateTimePicker3.Text), Date.Parse(DateTimePicker4.Text))
                'Using (ReportPrintTool printTool = New ReportPrintTool(rpt))
                Dim printTool As ReportPrintTool = New ReportPrintTool(rpt)
                printTool.ShowPreviewDialog()


                'End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("desole ID ne doit pas etre vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim use As New frm_user
        use.Show()

    End Sub

    Private Sub cb_theatre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_theatre.SelectedIndexChanged
        'Try
        '    Dim en As Integer
        '    en = Integer.Parse(prins_object.GetID("id_theatre", "theatre", "nom_theatre", cb_theatre.Text))
        '    txt_id_programme.Text = CStr(en)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub SimpleButton18_Click(sender As Object, e As EventArgs) Handles SimpleButton18.Click
        If (date_affiche.Text <> "") Then

            Try

                Dim rpt As rpt_affiche = New rpt_affiche()
                rpt.DataSource = prins_object.get_Report_X_with_date("afiche_view", "date_ceremony", Date.Parse(date_affiche.Text))
                ' rpt.DataSource = prins_object.get_Report_Trier1("effectuer_view", "date_effectuer", Date.Parse(DateTimePicker3.Text), Date.Parse(DateTimePicker4.Text))
                'Using (ReportPrintTool printTool = New ReportPrintTool(rpt))
                Dim printTool As ReportPrintTool = New ReportPrintTool(rpt)
                printTool.ShowPreviewDialog()


                'End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("desole veuillez selectionner la date", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If

    End Sub

    Private Sub SimpleButton19_Click(sender As Object, e As EventArgs) Handles SimpleButton19.Click
        If (txt_id_billet.Text <> "") Then

            Try

                Dim rpt As rpt_billet = New rpt_billet()
                rpt.DataSource = prins_object.get_Report_X("billet_view", "id_billet", Integer.Parse(txt_id_billet.Text))
                ' rpt.DataSource = prins_object.get_Report_Trier1("effectuer_view", "date_effectuer", Date.Parse(DateTimePicker3.Text), Date.Parse(DateTimePicker4.Text))
                'Using (ReportPrintTool printTool = New ReportPrintTool(rpt))
                Dim printTool As ReportPrintTool = New ReportPrintTool(rpt)
                printTool.ShowPreviewDialog()


                'End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("desole ID ne doit pas etre vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If
    End Sub

    Private Sub GridView6_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView6.RowClick
        Try
            txt_id_paiement.Text = GridView6.GetRowCellValue(e.RowHandle, "id_paiement").ToString
            txt_designation.Text = GridView6.GetRowCellValue(e.RowHandle, "designation").ToString
            date_paie.Text = GridView6.GetRowCellValue(e.RowHandle, "date_paiement").ToString
            cb_billet.Text = GridView6.GetRowCellValue(e.RowHandle, "ref_billet").ToString
            txt_montant_paye.Text = GridView6.GetRowCellValue(e.RowHandle, "montant").ToString
            ' txt_montant_a_payer.Text = GridView5.GetRowCellValue(e.RowHandle, "ref_programmation").ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton11_Click(sender As Object, e As EventArgs) Handles SimpleButton11.Click

    End Sub

    Private Sub SimpleButton10_Click(sender As Object, e As EventArgs) Handles SimpleButton10.Click

    End Sub

    Private Sub SimpleButton14_Click(sender As Object, e As EventArgs) Handles SimpleButton14.Click

    End Sub
End Class

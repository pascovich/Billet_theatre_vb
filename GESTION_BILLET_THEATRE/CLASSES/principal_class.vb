Imports System
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid

Public Class principal_class
    Dim con As New SqlConnection
    Dim cmd As SqlCommand
    Dim dt As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cnx As New connexion_class
    Dim memory As New MemoryStream
    Dim sp As New SqlParameter
    Public chem As New chemin_acces_classe

    Public Sub innitialise_connexion()

        'Try
        '    con = New SqlConnection("Data Source=PASCOVICH\ROOT;Initial Catalog=GESTION_BILLET;User ID=sa;Password=root")
        '    'con = New SqlConnection("Data Source='" + File.ReadAllText(chem.Server) + "';Initial Catalog='" + File.ReadAllText(chem.Database) + "';User ID='" + File.ReadAllText(chem.Username) + "';Password='" + File.ReadAllText(chem.Password) + "'")

        '    MessageBox.Show("La connexion a la BD a reussi")

        'Catch ex As Exception

        '    MessageBox.Show(ex.Message)

        'End Try
        Try
            cnx = New connexion_class()
            cnx.connect()
            con = New SqlConnection(cnx.chemin)
            ' MessageBox.Show("La connexion a la BD a reussi")
        Catch ex As Exception
            MessageBox.Show("l'un de vos fichiers de configuration est incorrect" + ex.Message)
        End Try
    End Sub

    Public Sub operation_user(use As user_class)
        Try
            innitialise_connexion()
            con.Open()
            cmd = New SqlCommand("execute pro_users @code,@username,@pwd", con)
            cmd.Parameters.AddWithValue("@code", use.Id_users1)
            cmd.Parameters.AddWithValue("@username", use.Username1)
            cmd.Parameters.AddWithValue("@pwd", use.Pwd1)
            cmd.ExecuteNonQuery()
            MessageBox.Show("operation reussi avec succes")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub
    Public Sub operation_billet(blt As billet_class)
        Try
            innitialise_connexion()
            con.Open()
            cmd = New SqlCommand("execute pro_billet @code,@reduction,@prix_a_payer,@numero_chaise,@ref_client,@ref_programmation,@date_achat,@check_paie", con)
            cmd.Parameters.AddWithValue("@code", blt.Id1)
            cmd.Parameters.AddWithValue("@reduction", blt.Reduction1)
            cmd.Parameters.AddWithValue("@prix_a_payer", blt.Prix_a_paye1)
            cmd.Parameters.AddWithValue("@numero_chaise", blt.Numero_chaise1)
            cmd.Parameters.AddWithValue("@ref_client", blt.Ref_client1)
            cmd.Parameters.AddWithValue("@ref_programmation", blt.Ref_programmation1)
            cmd.Parameters.AddWithValue("@date_achat", blt.Date_achat1)
            cmd.Parameters.AddWithValue("@check_paie", blt.Check_paie1)

            cmd.ExecuteNonQuery()
            MessageBox.Show("operation reussi avec succes")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub

    Public Sub operation_client(clt As client_class, pic As PictureEdit)
        Try
            innitialise_connexion()
            con.Open()
            cmd = New SqlCommand("execute pro_client @code,@nom,@postnom,@prenom,@sexe,@adresse,@date_naissance,@telephone,@photo", con)
            cmd.Parameters.AddWithValue("@code", clt.Id1)
            cmd.Parameters.AddWithValue("@nom", clt.Nom1)
            cmd.Parameters.AddWithValue("@postnom", clt.Postnom1)
            cmd.Parameters.AddWithValue("@prenom", clt.Prenom1)
            cmd.Parameters.AddWithValue("@sexe", clt.Sexe1)
            cmd.Parameters.AddWithValue("@adresse", clt.Adresse1)
            cmd.Parameters.AddWithValue("@date_naissance", clt.Date_naissance1)
            cmd.Parameters.AddWithValue("@telephone", clt.Telephone1)

            pic.Image.Save(memory, pic.Image.RawFormat)
            Dim im As Byte() = memory.GetBuffer()
            sp = New SqlParameter("@photo", SqlDbType.Image)
            sp.Value = im
            cmd.Parameters.Add(sp)

            cmd.ExecuteNonQuery()
            MessageBox.Show("operation reussi avec succes")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub

    Public Sub operation_paiement(paie As paiement_class)
        Try
            innitialise_connexion()
            con.Open()
            cmd = New SqlCommand("execute pro_paiement @code,@designation,@montant,@date_paiement,@ref_billet", con)
            cmd.Parameters.AddWithValue("@code", paie.Id1)
            cmd.Parameters.AddWithValue("@designation", paie.Designation1)
            cmd.Parameters.AddWithValue("@montant", paie.Montant1)
            cmd.Parameters.AddWithValue("@date_paiement", paie.Date_paiement1)
            cmd.Parameters.AddWithValue("@ref_billet", paie.Ref_billet1)
            cmd.ExecuteNonQuery()
            MessageBox.Show("operation reussi avec succes")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub

    Public Sub operation_programmation(pro As programmation_class)
        Try
            innitialise_connexion()
            con.Open()
            cmd = New SqlCommand("execute pro_programmation @code,@ref_type_billet,@ref_programme,@prix", con)
            cmd.Parameters.AddWithValue("@code", pro.Id1)
            cmd.Parameters.AddWithValue("@ref_type_billet", pro.Ref_type_billet1)
            cmd.Parameters.AddWithValue("@ref_programme", pro.Ref_programme1)
            cmd.Parameters.AddWithValue("@prix", pro.Prix1)
            cmd.ExecuteNonQuery()
            MessageBox.Show("operation reussi avec succes")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub

    Public Sub operation_programme(progr As programme_class)
        Try
            innitialise_connexion()
            con.Open()
            cmd = New SqlCommand("execute pro_programme @code,@date_ceremony,@heure_debut,@heure_fin,@ref_salle,@ref_theatre", con)
            cmd.Parameters.AddWithValue("@code", progr.Id1)
            cmd.Parameters.AddWithValue("@date_ceremony", progr.Date_ceremony1)
            cmd.Parameters.AddWithValue("@heure_debut", progr.Heure_debut1)
            cmd.Parameters.AddWithValue("@heure_fin", progr.Heure_fin1)
            cmd.Parameters.AddWithValue("@ref_salle", progr.Ref_salle1)
            cmd.Parameters.AddWithValue("@ref_theatre", progr.Ref_theatre1)
            cmd.ExecuteNonQuery()
            MessageBox.Show("operation reussi avec succes")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub

    Public Sub operation_salle(sal As salle_class)
        Try
            innitialise_connexion()
            con.Open()
            cmd = New SqlCommand("execute pro_salle @code,@nom_salle,@chaise_disponible", con)
            cmd.Parameters.AddWithValue("@code", sal.Id1)
            cmd.Parameters.AddWithValue("@nom_salle", sal.Nom_salle1)
            cmd.Parameters.AddWithValue("@chaise_disponible", sal.Chaise_disponible1)
            cmd.ExecuteNonQuery()
            MessageBox.Show("operation reussi avec succes")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub

    Public Sub operation_theatre(th As theatre_class)
        Try
            innitialise_connexion()
            con.Open()
            cmd = New SqlCommand("execute pro_theatre @code,@nom_theatre,@descriptionn", con)
            cmd.Parameters.AddWithValue("@code", th.Id1)
            cmd.Parameters.AddWithValue("@nom_theatre", th.Nom_theatre1)
            cmd.Parameters.AddWithValue("@descriptionn", th.Description1)
            cmd.ExecuteNonQuery()
            MessageBox.Show("operation reussi avec succes")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub

    Public Sub operation_type_billet(type_bil As type_billet_class)
        Try
            innitialise_connexion()
            con.Open()
            cmd = New SqlCommand("execute pro_type_billet @code,@designation", con)
            cmd.Parameters.AddWithValue("@code", type_bil.Id1)
            cmd.Parameters.AddWithValue("@designation", type_bil.Designation1)
            cmd.ExecuteNonQuery()
            MessageBox.Show("operation reussi avec succes")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub

    Public Sub afficherprix(cmb As System.Windows.Forms.ComboBox, prix As Label, reference As Integer)
        Try
            innitialise_connexion()

            If (con.State.ToString().Trim().ToLower().Equals("open")) Then
                con.Close()
            Else
                con.Open()
                cmd = con.CreateCommand()

                cmd.CommandText = "SELECT prix from programmation where id_programmation =@id_programmation"
                cmd.Parameters.AddWithValue("@id_programmation", reference)

                Dim rdd As IDataReader
                'rdd = New IDataReader
                rdd = cmd.ExecuteReader()
                While (rdd.Read)
                    prix.Text = rdd(0).ToString()
                End While
                rdd.Close()
                rdd.Dispose()
                cmd.Dispose()


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Public Sub afficherprixApayerBillet(cmb As System.Windows.Forms.ComboBox, prix As Label, reference As Integer)
        Try
            innitialise_connexion()

            If (con.State.ToString().Trim().ToLower().Equals("open")) Then
                con.Close()
            Else
                con.Open()
                cmd = con.CreateCommand()

                cmd.CommandText = "select DIFFERENCE(prix_a_payer,reduction) as total_apres_red from billet where id_billet =@id_billet"
                cmd.Parameters.AddWithValue("@id_billet", reference)

                Dim rdd As IDataReader
                'rdd = New IDataReader
                rdd = cmd.ExecuteReader()
                While (rdd.Read)
                    prix.Text = rdd(0).ToString()
                End While
                rdd.Close()
                rdd.Dispose()
                cmd.Dispose()


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Public Sub chargementComboBoxTestExist(cmb As System.Windows.Forms.ComboBox, nomChampselect As String, requete As String)
        innitialise_connexion()
        If (con.State.ToString().Trim().ToLower().Equals("open")) Then
            con.Close()
        Else
            con.Open()
            'cmd = New SqlCommand("select distinct id_consommer from tconsommation where etat_facture=0 ", con)
            cmd = New SqlCommand(requete, con)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While (dr.Read)
                cmb.Items.Add(dr(nomChampselect).ToString)
            End While
            con.Close()
            cmd.Dispose()

        End If
    End Sub



    'Public Sub retreivePhoto(champPhoto As String, nomTable As String, nomChampcode As String, value As String, pic As PictureEdit)
    '    Try
    '        innitialise_connexion()
    '        If (con.State.ToString().Trim().ToLower().Equals("open")) Then
    '            con.Close()
    '        Else
    '            con.Open()
    '            cmd = New SqlCommand("SELECT " + champPhoto + " from " + nomTable + " WHERE  " + nomChampcode + " = '" + value + "'", con)
    '            dt = New SqlDataAdapter(cmd)
    '            Dim result As Object
    '            result = cmd.ExecuteScalar()

    '            If (DBNull.Value <> (result)) Then
    '                Dim buffer As Byte()
    '                buffer = result
    '                memory = New MemoryStream(buffer)
    '                Dim Image As Image
    '                Image = Image.FromStream(memory)
    '                pic.Image = Image
    '            Else

    '            End If
    '        End If
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    Finally
    '        cmd.Dispose()
    '        con.Close()

    '    End Try
    'End Sub


    Sub GetTable(nomTable As String, datagrid As DataGridView)
        innitialise_connexion()
        If (con.State.ToString().Trim().ToLower().Equals("open")) Then
            con.Close()
        Else
            'Dim cmd As New SqlCommand
            cmd = con.CreateCommand()
            dt = New SqlDataAdapter("SELECT * FROM " + nomTable + "", con)
            ds = New DataSet()
            dt.Fill(ds, nomTable)
            con.Close()
            datagrid.DataSource = ds.Tables(nomTable)


        End If
    End Sub
    Sub GetTablegrid(nomTable As String, datagrid As GridControl)
        innitialise_connexion()
        If (con.State.ToString().Trim().ToLower().Equals("open")) Then
            con.Close()
        Else
            'Dim cmd As New SqlCommand
            cmd = con.CreateCommand()
            dt = New SqlDataAdapter("SELECT * FROM " + nomTable + "", con)
            ds = New DataSet()
            dt.Fill(ds, nomTable)
            con.Close()
            datagrid.DataSource = ds.Tables(nomTable)


        End If
    End Sub
    Sub setParameter(cmd As SqlCommand, name As String, type As DbType, length As Integer, paramValue As Object)
        Dim a As IDbDataParameter = cmd.CreateParameter()
        a.ParameterName = name
        a.Size = length
        a.DbType = type

        If (paramValue = "") Then
            If (a.IsNullable) Then

            Else
                a.DbType = DbType.String
            End If
            a.Value = DBNull.Value
        Else
            a.Value = paramValue
            cmd.Parameters.Add(a)
        End If

    End Sub
    Public Function GetID(champ As String, table As String, champcondition1 As String, valeur1 As String) As String
        Dim _id As String
        _id = String.Empty
        innitialise_connexion()
        If (con.State.ToString().Trim().ToLower().Equals("open")) Then
            con.Close()
        Else
            Try
                con.Open()
                'Dim cmd As SqlCommand
                cmd = New SqlCommand("SELECT DISTINCT " + champ + " FROM " + table + " WHERE " + champcondition1 + " = @valeur1", con)
                cmd.Parameters.Add(New SqlParameter("@valeur1", SqlDbType.NVarChar)).Value = valeur1
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader()
                While (dr.Read)
                    _id = dr(0).ToString()
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con.Close()

            End Try


        End If
        Return _id.ToString()
    End Function

    Public Function Getplace() As Integer
        Dim _id As String
        _id = String.Empty
        innitialise_connexion()
        If (con.State.ToString().Trim().ToLower().Equals("open")) Then
            con.Close()
        Else
            Try
                con.Open()
                'Dim cmd As SqlCommand
                cmd = New SqlCommand("select coalesce(max(numero_chaise),0) +1 from billet", con)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader()
                While (dr.Read)
                    _id = dr(0).ToString()
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con.Close()

            End Try


        End If
        Return Integer.Parse(_id)
    End Function
    Public Function GetPlaceNumberExist() As Integer
        Dim _id As String
        _id = String.Empty
        innitialise_connexion()
        If (con.State.ToString().Trim().ToLower().Equals("open")) Then
            con.Close()
        Else
            Try
                con.Open()
                'Dim cmd As SqlCommand
                cmd = New SqlCommand("select chaise_disponible from salle", con)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader()
                While (dr.Read)
                    _id = dr(0).ToString()
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con.Close()

            End Try
        End If
        Return Integer.Parse(_id)
    End Function

    Public Function GetNumFact() As String
        Dim _id As String
        _id = String.Empty
        innitialise_connexion()
        If (con.State.ToString().Trim().ToLower().Equals("open")) Then
            con.Close()
        Else
            Try
                con.Open()
                'Dim cmd As SqlCommand
                cmd = New SqlCommand("select CONCAT('NUM00',num) from get_num_paie", con)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader()
                While (dr.Read)
                    _id = dr(0).ToString()
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con.Close()

            End Try
        End If
        Return _id.ToString()

    End Function
    Public Sub Supprimer(nomTable As String, nomChamp As String, id As Integer)

        Try

            innitialise_connexion()
            con.Open()
            'Dim cmd As SqlCommand
            cmd = New SqlCommand("DELETE FROM " + nomTable + " WHERE  " + nomChamp + "=@Id", con)
            cmd.Parameters.AddWithValue("@Id", id)
            cmd.ExecuteNonQuery()
            MessageBox.Show("suppresion avec success")

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            con.Close()
            cmd.Dispose()
        End Try

    End Sub
    Public Sub rechercher(nomTable As String, nomCond As String, champSearch As String, datav As DataGridView)

        Try

            innitialise_connexion()
            If (con.State.ToString().ToLower().Equals("open")) Then
                con.Close()
            Else
                con.Open()
                'Dim cmd As SqlCommand
                cmd = con.CreateCommand()
                dt = New SqlDataAdapter("SELECT * FROM " + nomTable + " WHERE " + nomCond + " like '%" + champSearch + "%' ", con)
                ds = New DataSet()
                dt.Fill(ds, nomTable)
                con.Close()

                datav.DataSource = ds.Tables(nomTable)
            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub RemplirCombo(cb As System.Windows.Forms.ComboBox, nomTable As String, nomChamp As String, id As String, designation As String)
        innitialise_connexion()
        con.Open()
        Dim table As New DataTable()
        ' dt = New SqlDataAdapter(query, con)
        dt = New SqlDataAdapter("select distinct " + nomChamp + " from " + nomTable + "", con)
        dt.Fill(table)
        cb.ValueMember = id
        cb.DisplayMember = designation
        cb.DataSource = table
        con.Close()
    End Sub

    Public Sub chargementComboBox(cmb As System.Windows.Forms.ComboBox, nomChamp As String, nomTable As String)
        innitialise_connexion()
        If (con.State.ToString().Trim().ToLower().Equals("open")) Then
            con.Close()
        Else
            con.Open()
            cmd = New SqlCommand("select distinct " + nomChamp + " from " + nomTable + "", con)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While (dr.Read)
                cmb.Items.Add(dr(nomChamp).ToString)
            End While
            con.Close()
            cmd.Dispose()

        End If
    End Sub


    Public Sub convertion_dollard_franc(taux As System.Windows.Forms.ComboBox, prix As TextEdit, res As TextEdit)
        Try
            Dim tx As Decimal
            Dim px As Decimal
            tx = taux.Text
            px = prix.Text

            res.Text = (px * tx).ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Function get_Report_X(nomTable As String, nomchamp As String, valchamp As Integer) As DataSet
        Dim dst As DataSet
        Try
            innitialise_connexion()
            If (con.State.ToString().ToLower().Equals("open")) Then
                con.Close()
            Else
                con.Open()

                cmd = New SqlCommand("SELECT * FROM " + nomTable + " WHERE " + nomchamp + "=@valchamp", con)
                cmd.Parameters.AddWithValue("@valchamp", valchamp)
                dt = New SqlDataAdapter(cmd)
                dst = New DataSet()
                dt.Fill(dst, nomTable)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            dt.Dispose()
            con.Close()
        End Try

        Return dst
    End Function
    Public Function get_Report_XXX(nomTable As String, nomchamp As String, valchamp As String) As DataSet
        Dim dst As DataSet
        Try
            innitialise_connexion()
            If (con.State.ToString().ToLower().Equals("open")) Then
                con.Close()
            Else
                con.Open()

                cmd = New SqlCommand("SELECT * FROM " + nomTable + " WHERE " + nomchamp + "=@valchamp", con)
                cmd.Parameters.AddWithValue("@valchamp", valchamp)
                dt = New SqlDataAdapter(cmd)
                dst = New DataSet()
                dt.Fill(dst, nomTable)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            dt.Dispose()
            con.Close()
        End Try

        Return dst
    End Function


    Public Function get_Report_Trier1(nomTable As String, nomchamp As String, val1 As DateTime, val2 As DateTime) As DataSet
        Dim dst As DataSet
        Try
            innitialise_connexion()
            If (con.State.ToString().ToLower().Equals("open")) Then
                con.Close()
            Else
                con.Open()

                cmd = New SqlCommand("SELECT * FROM " + nomTable + " WHERE " + nomchamp + " between @date1 and @date2 ", con)
                cmd.Parameters.Add(New SqlParameter("@date1", SqlDbType.DateTime)).Value = val1
                cmd.Parameters.Add(New SqlParameter("@date2", SqlDbType.DateTime)).Value = val2
                'setParameter(cmd, "@date1", DbType.DateTime, 30, val1)
                'setParameter(cmd, "@date2", DbType.DateTime, 30, val2)
                dt = New SqlDataAdapter(cmd)
                dst = New DataSet()
                dt.Fill(dst, nomTable)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            dt.Dispose()
            con.Close()
        End Try
        Return dst
    End Function

    Public Function get_Report_S(nomTable As String, idTable As String) As DataSet
        Dim dst As DataSet
        Try
            innitialise_connexion()
            If (con.State.ToString().ToLower().Equals("open")) Then
                con.Close()
            Else
                con.Open()
                cmd = New SqlCommand("SELECT * FROM " + nomTable + " ORDER BY " + idTable + "", con)
                dt = New SqlDataAdapter(cmd)
                dst = New DataSet()
                dt.Fill(dst, nomTable)

            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            dt.Dispose()
            con.Close()
        End Try
        Return dst
    End Function

    Public Function get_Report_Trier(nomTable As String, nomchamp As String, val1 As DateTime, val2 As DateTime, champCondition1 As String, valeur1 As String) As DataSet

        Dim dst As DataSet
        Try
            innitialise_connexion()
            If (con.State.ToString().ToLower().Equals("open")) Then
                con.Close()
            Else
                con.Open()
                cmd = New SqlCommand("SELECT * FROM " + nomTable + " WHERE (" + nomchamp + " between @date1 and @date2) AND " + champCondition1 + " = @valeur1 ", con)
                cmd.Parameters.Add(New SqlParameter("@date1", SqlDbType.DateTime)).Value = val1
                cmd.Parameters.Add(New SqlParameter("@date2", SqlDbType.DateTime)).Value = val2
                cmd.Parameters.Add(New SqlParameter(" @valeur1", SqlDbType.NVarChar)).Value = valeur1
                dt = New SqlDataAdapter(cmd)
                dst = New DataSet()
                dt.Fill(dst, nomTable)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            dt.Dispose()
            con.Close()
        End Try
        Return dst
    End Function




End Class

Imports System.Data.SqlClient
Imports System.IO

Public Class configuration_frm

    Public chem As New chemin_acces_classe

    Public InitialDirectory As String = "C:\BASE_DE_DONNE_VB"

    Public Server As New FileInfo(chem.Server)
    Public Database As New FileInfo(chem.Database)
    Public Username As New FileInfo(chem.Username)
    Public Password As New FileInfo(chem.Password)
    Public con As New SqlConnection
    Private Sub CreateDirectory()

        Try
            Dim dirinfo As DirectoryInfo
            dirinfo = New DirectoryInfo(Me.InitialDirectory)
            If (Not Directory.Exists(Me.InitialDirectory)) Then
                Directory.CreateDirectory(Me.InitialDirectory)
                dirinfo.Attributes = FileAttributes.Hidden
            Else
                MessageBox.Show("le dossier existe deja")

            End If
        Catch ex As Exception
            Throw New Exception("Error de creation" + ex.Message)
        End Try

    End Sub
    Private Sub btn_back_login_Click(sender As Object, e As EventArgs) Handles btn_back_login.Click
        Try
            Dim log As New frm_login
            log.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub pass_conf_CheckedChanged(sender As Object, e As EventArgs) Handles pass_conf.CheckedChanged
        If (pass_conf.Checked) Then
            txt_pwd_config.isPassword = False

        Else
            txt_pwd_config.isPassword = True
        End If
    End Sub

    Private Sub configuration_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_configurer_Click(sender As Object, e As EventArgs) Handles btn_configurer.Click

        Dim bo As Boolean = True
        Try
            If (bo = True) Then
                If (txt_nom_serveur.Text.Equals("") Or txt_nom_BD.Text.Equals("") Or txt_nom_user.Text.Equals("") Or txt_pwd_config.Text.Equals("")) Then
                    MessageBox.Show("REMPLISSEZ TOUS LES CHAMPS S.V.P !")
                Else
                    Me.CreateDirectory()
                    File.WriteAllText(Server.FullName, txt_nom_serveur.Text)
                    File.WriteAllText(Database.FullName, txt_nom_BD.Text)
                    File.WriteAllText(Username.FullName, txt_nom_user.Text)
                    File.WriteAllText(Password.FullName, txt_pwd_config.Text)
                    con = New SqlConnection("Data Source='" + File.ReadAllText(chem.Server) + "';Initial Catalog='" + File.ReadAllText(chem.Database) + "';User ID='" + File.ReadAllText(chem.Username) + "';Password='" + File.ReadAllText(chem.Password) + "'")

                    MessageBox.Show(Me, " LA CONNEXION AU SERVEUR A REUSSI ! ")

                    Dim lg As New frm_login
                    lg.Show()
                    Me.Hide()

                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
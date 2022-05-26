Imports System.Data.SqlClient
Imports System.IO

Public Class frm_login
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Public username As String
    Public pwd As String
    Public chem As New chemin_acces_classe
    Private Sub pass_conf_CheckedChanged(sender As Object, e As EventArgs) Handles pass_conf.CheckedChanged
        If (pass_conf.Checked) Then
            txt_pwd_config.isPassword = False

        Else
            txt_pwd_config.isPassword = True
        End If
    End Sub

    Private Sub simpleButton1_Click(sender As Object, e As EventArgs) Handles simpleButton1.Click
        If (txt_username.Text = "" Or txt_pwd_config.Text = "") Then
            MessageBox.Show(" REMPLISSEZ TOUS LES CHAMPS SVP ! ")
        Else

            Try

                con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "SELECT * FROM users WHERE username= '" + txt_username.Text + "'"
                cmd.ExecuteNonQuery()

                Dim Dr As SqlDataReader
                Dr = cmd.ExecuteReader

                If (Dr.Read) Then

                    If (Dr("pwd").Equals(txt_pwd_config.Text)) Then

                        Form1.Show()
                        username = txt_username.Text
                        Me.Hide()

                        'Fonctionuser = Cb_FONC.Text

                    Else

                        MessageBox.Show(" username ou password incorrect ! ")
                        txt_username.Text = ""
                        txt_pwd_config.Text = ""

                    End If

                Else

                    MessageBox.Show(" username ou password incorrect ! ")
                    txt_username.Text = ""
                    txt_pwd_config.Text = ""
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con.Close()

            End Try

        End If
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con = New SqlConnection("Data Source='" + File.ReadAllText(chem.Server) + "';Initial Catalog='" + File.ReadAllText(chem.Database) + "';User ID='" + File.ReadAllText(chem.Username) + "';Password='" + File.ReadAllText(chem.Password) + "'")

            'MessageBox.Show("La connexion a la BD a reussi")

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class
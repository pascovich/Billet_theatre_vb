Public Class frm_user
    Dim prins_object As principal_class

    Dim id As Integer
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Try
            prins_object = New principal_class
            If (txt_username.Text <> "" And txt_pwd_config.Text <> "" And txt_confirm.Text = txt_pwd_config.Text) Then
                Dim pro As user_class
                pro = New user_class
                pro.Id_users1 = id
                pro.Username1 = txt_username.Text
                pro.Pwd1 = txt_pwd_config.Text

                prins_object.operation_user(pro)
                prins_object.GetTablegrid("users", GridControl1)
                txt_username.Text = ""

            Else
                MessageBox.Show("les chams doivent etre tous remplis ou les pwd ne sont pas identiques")
            End If
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

    Private Sub frm_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prins_object.GetTablegrid("users", GridControl1)
    End Sub
End Class
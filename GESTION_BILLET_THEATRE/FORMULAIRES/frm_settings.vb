
Public Class frm_settings
    Dim prins_object As New principal_class
    Dim id_type As Integer
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Try
            If (txt_design.Text <> "") Then
                Dim pro As type_billet_class
                pro = New type_billet_class
                pro.Id1 = id_type
                pro.Designation1 = txt_design.Text
                prins_object.operation_type_billet(pro)
                prins_object.GetTablegrid("type_billet", GridControl1)
                txt_design.Text = ""
                txt_id_taux.Text = ""
            Else
                MessageBox.Show("les chams doivent etre tous remplis")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frm_settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prins_object.GetTablegrid("type_billet", GridControl1)
    End Sub
End Class
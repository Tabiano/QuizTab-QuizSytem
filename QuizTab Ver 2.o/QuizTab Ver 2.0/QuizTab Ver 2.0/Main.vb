Public Class Main

    Private Sub btn_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_logout.Click
        Dim response As Integer

        response = MessageBox.Show("Are you sure you want to LOG OUT?", "exit app", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = vbYes Then
            Front.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btn_enter1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enter1.Click
        qdetail.Show()
        Me.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        qdetail.Show()
        Me.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Managequestion.Show()
        Me.Enabled = False
    End Sub
End Class

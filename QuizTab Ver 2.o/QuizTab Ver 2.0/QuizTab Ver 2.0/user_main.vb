Public Class user_main

    Private Sub btn_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_logout.Click
        Dim response As Integer

        response = MessageBox.Show("Are you sure you want to LOG OUT?", "exit app", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = vbYes Then
            Front.Show()
            Me.Hide()
        End If
    End Sub
End Class
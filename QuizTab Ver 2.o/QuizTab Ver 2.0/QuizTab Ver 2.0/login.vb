Imports System.Windows.Forms
Imports System.Data.Odbc

Public Class login

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btn_login.Enabled = False
        btn_login.BackColor = Color.Silver
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub txt_username_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_username.KeyDown
        If e.KeyCode = 13 Then
            If txt_username.Text = "" Then
                MessageBox.Show("Enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_username.Focus()
            Else
                txt_password.Focus()
            End If
        End If
    End Sub

    Private Sub txt_password_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = 13 Then
            If txt_password.Text = "" Then
                MessageBox.Show("Enter Passkey", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_password.Focus()
            Else
                btn_login.Enabled = True
                btn_login.BackColor = Color.Lime
                btn_login.Focus()
            End If
        End If
    End Sub

    Private Sub cb_show_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_show.CheckedChanged
        If txt_password.UseSystemPasswordChar = False Then
            txt_password.UseSystemPasswordChar = True
            cb_show.BackColor = Color.Silver
        Else
            txt_password.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        connect_me()

        Dim mycmd1 As New OdbcCommand
        Dim readUser1 As OdbcDataReader
        Dim mycmd2 As New OdbcCommand
        Dim readUser2 As OdbcDataReader

        Dim uname1 As String
        Dim pass1 As String
        uname1 = txt_username.Text.Trim
        pass1 = txt_password.Text.Trim

        Dim uname2 As String
        Dim pass2 As String
        uname2 = txt_username.Text.Trim
        pass2 = txt_password.Text.Trim

        With mycmd1
            .Connection = con
            .CommandText = " select * from tbl_admin where USERNAME = '" & uname1 & "' and PASSWORD = '" & pass1 & "'"
            .ExecuteNonQuery()

        End With
        readUser1 = mycmd1.ExecuteReader

        With mycmd2
            .Connection = con
            .CommandText = " select * from tbl_user where USERNAME = '" & uname2 & "' and PASSWORD = '" & pass2 & "'"
            .ExecuteNonQuery()

        End With
        readUser2 = mycmd2.ExecuteReader

        If readUser1.HasRows Then
            readUser1.Read()

            txt_username.Clear()
            txt_password.Clear()

            btn_login.Enabled = False
            btn_login.BackColor = Color.Silver
            Main.Show()
            Me.Hide()
            Front.Hide()

        ElseIf readUser2.HasRows Then
            readUser2.Read()

            txt_username.Clear()
            txt_password.Clear()

            btn_login.Enabled = False
            btn_login.BackColor = Color.Silver
            user_main.Show()
            Me.Hide()
            Front.Hide()

        Else
            MessageBox.Show("User Does Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_username.Clear()
            txt_password.Clear()
            btn_login.Enabled = False
            btn_login.BackColor = Color.Silver
            txt_username.Focus()
        End If
    End Sub
End Class
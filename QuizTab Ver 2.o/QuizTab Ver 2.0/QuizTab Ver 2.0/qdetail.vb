Imports System.Windows.Forms
Imports System.Data.Odbc
Imports System.Globalization

Public Class qdetail

    Dim mycmd, mycmd1, mycmd2 As New OdbcCommand

    Private Sub qdetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btn_update.Enabled = False

        lb_date.Text = Date.Now.ToShortDateString

        connect_me()

        Dim id As Integer
        Dim cmd As New OdbcCommand("select ifnull(max(ID), 0) from tbl_qdetail", con)
        id = cmd.ExecuteScalar

        If id > 0 Then
            Call get_id()
        Else
            txt_id.Text = 1

        End If
    End Sub

    Public Sub get_id()
        Dim da As New OdbcDataAdapter("select max(ID) id from tbl_qdetail", con)
        Dim ds As New System.Data.DataSet
        da.Fill(ds)
        txt_id.Text = ds.Tables(0).Rows(0).Item("id") + 1
    End Sub


    Private Sub txt_sub_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_sub.KeyDown
        If e.KeyCode = 13 Then
            If txt_sub.Text = "" Then
                txt_sub.Focus()
            Else
                txt_qname.Focus()
            End If
        End If
    End Sub

    Private Sub txt_qname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_qname.KeyDown
        If e.KeyCode = 13 Then
            If txt_qname.Text = "" Then
                txt_qname.Focus()
            Else
                txt_pass.Focus()
            End If
        End If
    End Sub

    Private Sub txt_pass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_pass.KeyDown
        If e.KeyCode = 13 Then
            If txt_pass.Text = "" Then
                txt_pass.Focus()
            Else
                cb_mc.Focus()
            End If
        End If
    End Sub

    Private Sub btn_create_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_create.Click

        If txt_sub.Text = "" Or txt_qname.Text = "" Or txt_pass.Text = "" Then
            MessageBox.Show("Complete all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_sub.Focus()

        Else
            Dim id As String
            Dim subj As String
            Dim name As String
            Dim pass As String
            Dim d As String
            Dim d1 As Date


            id = txt_id.Text.Trim
            subj = txt_sub.Text.ToUpper.Trim
            name = txt_qname.Text.ToUpper.Trim
            pass = txt_pass.Text.ToUpper.Trim
            d = lb_date.Text
            d = Date.Parse(d1).ToString("yyy-MM-dd")

            con.Close()
            Try
                con.Open()
                Dim mycmd As New OdbcCommand

                With mycmd
                    .Connection = con
                    .CommandText = "Insert tbl_qdetail values ('" & id & "', '" & subj & "', '" & name & "', '" & pass & "', '" & d & "')"
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Save detail Success! Creating question", "QuizDetail", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_sub.Clear()
                txt_qname.Clear()
                txt_pass.Clear()

                Addq.Show()
                Main.Hide()
                Me.Hide()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click

        Dim close As Integer

        close = MessageBox.Show("All the data you enter cannot be saved!", "exit app", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If close = vbYes Then
            Main.Enabled = True
            Main.Show()
            txt_sub.Clear()
            txt_qname.Clear()
            txt_pass.Clear()
            Me.Hide()
        End If
    End Sub
End Class
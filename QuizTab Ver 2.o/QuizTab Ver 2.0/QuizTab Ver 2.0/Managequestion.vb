Imports System.Windows.Forms
Imports System.Data.Odbc

Public Class Managequestion

    Dim mycmd, mycmd1, mycmd2 As New OdbcCommand

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Main.Enabled = True
        Me.Hide()
    End Sub

    Private Sub Managequestion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect_me()

        Dim mycmd3 As New OdbcCommand("select * from `tbl_questions`", con)
        Dim da As New OdbcDataAdapter(mycmd3)
        Dim ds As New Data.DataSet

        da.Fill(ds, "tbl_questions")

        dg_quiz.DataSource = ds.Tables(0)
        dg_quiz.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dg_quiz.RowsDefaultCellStyle.BackColor = Drawing.Color.PaleGreen
        dg_quiz.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Snow
        dg_quiz.Refresh()
    End Sub

    Private Sub dg_quiz_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_quiz.CellContentClick
        Dim i As Integer
        i = dg_quiz.CurrentRow.Index

        Addq.lbl_num.Text = dg_quiz.Item(0, i).Value
        Addq.txt_question.Text = dg_quiz.Item(1, i).Value
        Addq.txt_oa.Text = dg_quiz.Item(2, i).Value
        Addq.txt_ob.Text = dg_quiz.Item(3, i).Value
        Addq.txt_oc.Text = dg_quiz.Item(4, i).Value
        Addq.txt_od.Text = dg_quiz.Item(5, i).Value

        btn_edit.Enabled = True
        btn_edit.BackColor = Color.Yellow
        btn_delete.Enabled = True
        btn_delete.BackColor = Color.Tomato
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim i3 As String
        Dim result3 As New DialogResult

        i3 = Addq.lbl_num.Text

        con.Close()

        Try
            con.Open()
            result3 = MessageBox.Show("Delete Question?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result3 = Windows.Forms.DialogResult.Yes Then
                With mycmd2
                    .Connection = con
                    .CommandText = "delete from tbl_questions where qnum = '" & i3 & "'"
                    .ExecuteNonQuery()

                End With
                MessageBox.Show("Delete Question Success !", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Addq.refreshMe()

            Addq.txt_question.Clear()
            Addq.txt_oa.Clear()
            Addq.txt_ob.Clear()
            Addq.txt_oc.Clear()
            Addq.txt_od.Clear()
            Addq.txt_ans.Clear()

            btn_delete.Enabled = False
            btn_delete.BackColor = Color.Silver
            btn_edit.Enabled = False
            btn_edit.BackColor = Color.Silver

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
End Class
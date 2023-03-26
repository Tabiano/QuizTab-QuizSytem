Imports System.Windows.Forms
Imports System.Data.Odbc

Public Class Addq

    Sub refreshMe()
        con.Close()

        Try
            con.Open()

            Dim mycmd3 As New OdbcCommand("select * from `tbl_questions`", con)
            Dim da As New OdbcDataAdapter(mycmd3)
            Dim ds As New Data.DataSet

            da.Fill(ds, "tbl_questions")

            Managequestion.dg_quiz.DataSource = ds.Tables(0)
            Managequestion.dg_quiz.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Managequestion.dg_quiz.RowsDefaultCellStyle.BackColor = Drawing.Color.PaleGreen
            Managequestion.dg_quiz.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Snow
            Managequestion.dg_quiz.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Addq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect_me()

        Dim qnum As Integer
        Dim cmd As New OdbcCommand("select ifnull(max(qnum), 0) from tbl_questions", con)
        qnum = cmd.ExecuteScalar

        If qnum > 0 Then
            Call get_id()
        Else
            lbl_num.Text = 1
        End If

    End Sub

    Public Sub get_id()
        Dim da As New OdbcDataAdapter("select max(qnum) qnum from tbl_questions", con)
        Dim ds As New System.Data.DataSet
        da.Fill(ds)
        lbl_num.Text = ds.Tables(0).Rows(0).Item("qnum") + 1
    End Sub

    Private Sub btn_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset.Click
        Dim reset As Integer

        reset = MessageBox.Show("will delete all the field?", "reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If reset = vbYes Then
            txt_question.Clear()
            txt_oa.Clear()
            txt_ob.Clear()
            txt_oc.Clear()
            txt_ans.Clear()
        End If
    End Sub

    Private Sub btn_addq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addq.Click

        If txt_question.Text = "" Or txt_oa.Text = "" Or txt_ob.Text = "" Or txt_oc.Text = "" Or txt_od.Text = "" Or txt_ans.Text = "" Then
            MessageBox.Show("Complete all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_question.Focus()

        Else
            Dim qnum As String
            Dim q As String
            Dim oa As String
            Dim ob As String
            Dim oc As String
            Dim od As String
            Dim ans As String

            qnum = lbl_num.Text.ToUpper.Trim
            q = txt_question.Text.ToUpper.Trim
            oa = txt_oa.Text.ToUpper.Trim
            ob = txt_ob.Text.ToUpper.Trim
            oc = txt_oc.Text.ToUpper.Trim
            od = txt_od.Text.ToUpper.Trim
            ans = txt_ans.Text.ToUpper.Trim

            con.Close()
            Try
                con.Open()
                Dim mycmd As New OdbcCommand

                With mycmd
                    .Connection = con
                    .CommandText = "Insert tbl_questions values ('" & qnum & "', '" & q & "', '" & oa & "', '" & ob & "', '" & oc & "', '" & od & "', '" & ans & "')"
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Add question!", "QuizDetail", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call get_id()
                txt_question.Clear()
                txt_oa.Clear()
                txt_ob.Clear()
                txt_oc.Clear()
                txt_od.Clear()
                txt_ans.Clear()

                txt_question.Focus()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub
End Class
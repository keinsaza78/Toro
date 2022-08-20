Public Class Form1
    Private Sub btOk_Click(sender As Object, e As EventArgs) Handles btOk.Click
        Dim Num, sum, i As Integer
        Dim ans As String
        ans = ""
        If tbNum.Text = "" Then
            MsgBox("กรุณาใส่ข้อมูลตัวเลขก่อน", MsgBoxStyle.Exclamation, "ข้อมูลผิดพลาด")
            tbNum.Focus()
        Else
            If IsNumeric(tbNum.Text) Then
                Num = Val(tbNum.Text)
                For i = 1 To 12
                    sum = Num * i
                    ans += Num & "x" & i & " = " & sum & vbCrLf
                Next i
                MsgBox(ans)
            Else
                MsgBox("กรุณาใส่ข้อมูลตัวเลขเท่านั้น", MsgBoxStyle.Exclamation, "ข้อมูลผิดพลาด")
                tbNum.Focus()
            End If 'check numeric error

        End If 'check blank error
    End Sub

    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btExit.Click
        Dim bt_Exit As MsgBoxResult
        bt_Exit = MsgBox("จบการทำงานใช่หรือไม่ ?", MsgBoxStyle.YesNo, "จบการทำงาน")
        If bt_Exit = MsgBoxResult.Yes Then
            MsgBox("เลิกการทำงาน.....", MsgBoxStyle.Exclamation, "จบการทำงาน")
            Application.Exit()
        Else
            bt_Exit = MsgBoxResult.No
            tbNum.Focus()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        tbNum.Text = ""
        tbNum.Focus()
    End Sub
End Class

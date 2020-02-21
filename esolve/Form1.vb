Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TableLayoutPanel1.BackColor = Color.FromArgb(100, 0, 0, 0)
        Panel1.BackColor = Color.FromArgb(130, 0, 0, 0)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If TableLayoutPanel1.Visible = True Then
            TableLayoutPanel1.Visible = False
        ElseIf TableLayoutPanel1.Visible = False Then
            TableLayoutPanel1.Visible = True
        Else
            TableLayoutPanel1.Visible = False
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class

Public Class Form1

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

        Dim result As Integer = MessageBox.Show("ARE YOU SURE ABOUT THAT?", "  LEAVING???", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim frm = New Form2
            frm.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim A, B, C As Integer
        A = Int(Rnd() * 255)
        B = Int(Rnd() * 255)
        C = Int(Rnd() * 255)
        Label1.ForeColor = Color.FromArgb(A, B, C)
    End Sub
End Class

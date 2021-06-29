Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Button25.Hide()
        Button30.Hide()
        Button29.Hide()
        Button28.Hide()
        Button27.Hide()
        Button26.Hide()

        PictureBox1.Hide()
        PictureBox2.Hide()
        PictureBox3.Hide()
        PictureBox4.Hide()

        PictureBox5.Hide()



    End Sub

    Private Sub Label18_Click(sender As System.Object, e As System.EventArgs) Handles Label18.Click

    End Sub

    Private Sub Label25_Click(sender As System.Object, e As System.EventArgs) Handles Label25.Click

    End Sub

    Private Sub Label22_Click(sender As System.Object, e As System.EventArgs) Handles Label22.Click

    End Sub

    Private Sub Label23_Click(sender As System.Object, e As System.EventArgs) Handles Label23.Click

    End Sub
    Private button1_count As Integer = 0

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click




        button1_count = button1_count + 1

        If button1_count = 1 Then Button1.BackColor = Color.Black
        If button1_count = 2 Then Button1.BackColor = Color.Yellow
        If button1_count = 3 Then Button1.BackColor = Color.Red
        If button1_count = 4 Then Button1.BackColor = Color.Blue

        If button1_count = 5 Then Button1.BackColor = Color.Black
        If button1_count = 6 Then Button1.BackColor = Color.Yellow
        If button1_count = 7 Then Button1.BackColor = Color.Red
        If button1_count = 8 Then Button1.BackColor = Color.Blue

        If button1_count = 9 Then Button1.BackColor = Color.Black
        If button1_count = 10 Then Button1.BackColor = Color.Yellow
        If button1_count = 11 Then Button1.BackColor = Color.Red
        If button1_count = 12 Then Button1.BackColor = Color.Blue

        If button1_count = 13 Then Button1.BackColor = Color.Black
        If button1_count = 14 Then Button1.BackColor = Color.Yellow
        If button1_count = 15 Then Button1.BackColor = Color.Red
        If button1_count = 16 Then Button1.BackColor = Color.Blue

        If button1_count = 17 Then Button1.BackColor = Color.Black
        If button1_count = 18 Then Button1.BackColor = Color.Yellow
        If button1_count = 19 Then Button1.BackColor = Color.Red
        If button1_count = 20 Then Button1.BackColor = Color.Blue







    End Sub

    Private Sub Button31_Click(sender As System.Object, e As System.EventArgs) Handles Button31.Click

        Dim result As Integer = MessageBox.Show(" ARE YOU SURE ABOUT THAT?", " QUITTING???", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Close()
            Form1.Show()
            Me.Hide()
        End If
    End Sub
    Private button4_count As Integer = 0
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

        button4_count = button4_count + 1



        If button4_count = 1 Then Button4.BackColor = Color.Black
        If button4_count = 2 Then Button4.BackColor = Color.Yellow
        If button4_count = 3 Then Button4.BackColor = Color.Red
        If button4_count = 4 Then Button4.BackColor = Color.Blue

        If button4_count = 5 Then Button4.BackColor = Color.Black
        If button4_count = 6 Then Button4.BackColor = Color.Yellow
        If button4_count = 7 Then Button4.BackColor = Color.Red
        If button4_count = 8 Then Button4.BackColor = Color.Blue

        If button4_count = 9 Then Button4.BackColor = Color.Black
        If button4_count = 10 Then Button4.BackColor = Color.Yellow
        If button4_count = 11 Then Button4.BackColor = Color.Red
        If button4_count = 12 Then Button4.BackColor = Color.Blue

        If button4_count = 13 Then Button4.BackColor = Color.Black
        If button4_count = 14 Then Button4.BackColor = Color.Yellow
        If button4_count = 15 Then Button4.BackColor = Color.Red
        If button4_count = 16 Then Button4.BackColor = Color.Blue

        If button4_count = 17 Then Button4.BackColor = Color.Black
        If button4_count = 18 Then Button4.BackColor = Color.Yellow
        If button4_count = 19 Then Button4.BackColor = Color.Red
        If button4_count = 20 Then Button4.BackColor = Color.Blue



    End Sub
    Private button3_count As Integer = 0
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        button3_count = button3_count + 1



        If button3_count = 1 Then Button3.BackColor = Color.Black
        If button3_count = 2 Then Button3.BackColor = Color.Yellow
        If button3_count = 3 Then Button3.BackColor = Color.Red
        If button3_count = 4 Then Button3.BackColor = Color.Blue

        If button3_count = 5 Then Button3.BackColor = Color.Black
        If button3_count = 6 Then Button3.BackColor = Color.Yellow
        If button3_count = 7 Then Button3.BackColor = Color.Red
        If button3_count = 8 Then Button3.BackColor = Color.Blue

        If button3_count = 9 Then Button3.BackColor = Color.Black
        If button3_count = 10 Then Button3.BackColor = Color.Yellow
        If button3_count = 11 Then Button3.BackColor = Color.Red
        If button3_count = 12 Then Button3.BackColor = Color.Blue

        If button3_count = 13 Then Button3.BackColor = Color.Black
        If button3_count = 14 Then Button3.BackColor = Color.Yellow
        If button3_count = 15 Then Button3.BackColor = Color.Red
        If button3_count = 16 Then Button3.BackColor = Color.Blue

        If button3_count = 17 Then Button3.BackColor = Color.Black
        If button3_count = 18 Then Button3.BackColor = Color.Yellow
        If button3_count = 19 Then Button3.BackColor = Color.Red
        If button3_count = 20 Then Button3.BackColor = Color.Blue

    End Sub
    Private button2_count As Integer = 0
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        button2_count = button2_count + 1

        If button2_count = 1 Then Button2.BackColor = Color.Black
        If button2_count = 2 Then Button2.BackColor = Color.Yellow
        If button2_count = 3 Then Button2.BackColor = Color.Red
        If button2_count = 4 Then Button2.BackColor = Color.Blue

        If button2_count = 5 Then Button2.BackColor = Color.Black
        If button2_count = 6 Then Button2.BackColor = Color.Yellow
        If button2_count = 7 Then Button2.BackColor = Color.Red
        If button2_count = 8 Then Button2.BackColor = Color.Blue

        If button2_count = 9 Then Button2.BackColor = Color.Black
        If button2_count = 10 Then Button2.BackColor = Color.Yellow
        If button2_count = 11 Then Button2.BackColor = Color.Red
        If button2_count = 12 Then Button2.BackColor = Color.Blue

        If button2_count = 13 Then Button2.BackColor = Color.Black
        If button2_count = 14 Then Button2.BackColor = Color.Yellow
        If button2_count = 15 Then Button2.BackColor = Color.Red
        If button2_count = 16 Then Button2.BackColor = Color.Blue

        If button2_count = 17 Then Button2.BackColor = Color.Black
        If button2_count = 18 Then Button2.BackColor = Color.Yellow
        If button2_count = 19 Then Button2.BackColor = Color.Red
        If button2_count = 20 Then Button2.BackColor = Color.Blue

    End Sub
    Private button8_count As Integer = 0
    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        button8_count = button8_count + 1

        If button8_count = 1 Then Button8.BackColor = Color.Black
        If button8_count = 2 Then Button8.BackColor = Color.Yellow
        If button8_count = 3 Then Button8.BackColor = Color.Red
        If button8_count = 4 Then Button8.BackColor = Color.Blue

        If button8_count = 5 Then Button8.BackColor = Color.Black
        If button8_count = 6 Then Button8.BackColor = Color.Yellow
        If button8_count = 7 Then Button8.BackColor = Color.Red
        If button8_count = 8 Then Button8.BackColor = Color.Blue

        If button8_count = 9 Then Button8.BackColor = Color.Black
        If button8_count = 10 Then Button8.BackColor = Color.Yellow
        If button8_count = 11 Then Button8.BackColor = Color.Red
        If button8_count = 12 Then Button8.BackColor = Color.Blue

        If button8_count = 13 Then Button8.BackColor = Color.Black
        If button8_count = 14 Then Button8.BackColor = Color.Yellow
        If button8_count = 15 Then Button8.BackColor = Color.Red
        If button8_count = 16 Then Button8.BackColor = Color.Blue

        If button8_count = 17 Then Button8.BackColor = Color.Black
        If button8_count = 18 Then Button8.BackColor = Color.Yellow
        If button8_count = 19 Then Button8.BackColor = Color.Red
        If button8_count = 20 Then Button8.BackColor = Color.Blue

    End Sub
    Private button14_count As Integer = 0
    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        button14_count = button14_count + 1

        If button14_count = 1 Then Button14.BackColor = Color.Black
        If button14_count = 2 Then Button14.BackColor = Color.Yellow
        If button14_count = 3 Then Button14.BackColor = Color.Red
        If button14_count = 4 Then Button14.BackColor = Color.Blue

        If button14_count = 5 Then Button14.BackColor = Color.Black
        If button14_count = 6 Then Button14.BackColor = Color.Yellow
        If button14_count = 7 Then Button14.BackColor = Color.Red
        If button14_count = 8 Then Button14.BackColor = Color.Blue

        If button14_count = 9 Then Button14.BackColor = Color.Black
        If button14_count = 10 Then Button14.BackColor = Color.Yellow
        If button14_count = 11 Then Button14.BackColor = Color.Red
        If button14_count = 12 Then Button14.BackColor = Color.Blue

        If button14_count = 13 Then Button14.BackColor = Color.Black
        If button14_count = 14 Then Button14.BackColor = Color.Yellow
        If button14_count = 15 Then Button14.BackColor = Color.Red
        If button14_count = 16 Then Button14.BackColor = Color.Blue

        If button14_count = 17 Then Button14.BackColor = Color.Black
        If button14_count = 18 Then Button14.BackColor = Color.Yellow
        If button14_count = 19 Then Button14.BackColor = Color.Red
        If button14_count = 20 Then Button14.BackColor = Color.Blue

    End Sub
    Private button18_count As Integer = 0
    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        button18_count = button18_count + 1

        If button18_count = 1 Then Button18.BackColor = Color.Black
        If button18_count = 2 Then Button18.BackColor = Color.Yellow
        If button18_count = 3 Then Button18.BackColor = Color.Red
        If button18_count = 4 Then Button18.BackColor = Color.Blue

        If button18_count = 5 Then Button18.BackColor = Color.Black
        If button18_count = 6 Then Button18.BackColor = Color.Yellow
        If button18_count = 7 Then Button18.BackColor = Color.Red
        If button18_count = 8 Then Button18.BackColor = Color.Blue

        If button18_count = 9 Then Button18.BackColor = Color.Black
        If button18_count = 10 Then Button18.BackColor = Color.Yellow
        If button18_count = 11 Then Button18.BackColor = Color.Red
        If button18_count = 12 Then Button18.BackColor = Color.Blue

        If button18_count = 13 Then Button18.BackColor = Color.Black
        If button18_count = 14 Then Button18.BackColor = Color.Yellow
        If button18_count = 15 Then Button18.BackColor = Color.Red
        If button18_count = 16 Then Button18.BackColor = Color.Blue

        If button18_count = 17 Then Button18.BackColor = Color.Black
        If button18_count = 18 Then Button18.BackColor = Color.Yellow
        If button18_count = 19 Then Button18.BackColor = Color.Red
        If button18_count = 20 Then Button18.BackColor = Color.Blue

    End Sub
    Private button24_count As Integer = 0
    Private Sub Button24_Click(sender As System.Object, e As System.EventArgs) Handles Button24.Click
        button24_count = button24_count + 1


        If button24_count = 1 Then Button24.BackColor = Color.Black
        If button24_count = 2 Then Button24.BackColor = Color.Yellow
        If button24_count = 3 Then Button24.BackColor = Color.Red
        If button24_count = 4 Then Button24.BackColor = Color.Blue

        If button24_count = 5 Then Button24.BackColor = Color.Black
        If button24_count = 6 Then Button24.BackColor = Color.Yellow
        If button24_count = 7 Then Button24.BackColor = Color.Red
        If button24_count = 8 Then Button24.BackColor = Color.Blue

        If button24_count = 9 Then Button24.BackColor = Color.Black
        If button24_count = 10 Then Button24.BackColor = Color.Yellow
        If button24_count = 11 Then Button24.BackColor = Color.Red
        If button24_count = 12 Then Button24.BackColor = Color.Blue

        If button24_count = 13 Then Button24.BackColor = Color.Black
        If button24_count = 14 Then Button24.BackColor = Color.Yellow
        If button24_count = 15 Then Button24.BackColor = Color.Red
        If button24_count = 16 Then Button24.BackColor = Color.Blue

        If button24_count = 17 Then Button24.BackColor = Color.Black
        If button24_count = 18 Then Button24.BackColor = Color.Yellow
        If button24_count = 19 Then Button24.BackColor = Color.Red
        If button24_count = 20 Then Button24.BackColor = Color.Blue

    End Sub
    Private button7_count As Integer = 0
    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        button7_count = button7_count + 1

        If button7_count = 1 Then Button7.BackColor = Color.Black
        If button7_count = 2 Then Button7.BackColor = Color.Yellow
        If button7_count = 3 Then Button7.BackColor = Color.Red
        If button7_count = 4 Then Button7.BackColor = Color.Blue

        If button7_count = 5 Then Button7.BackColor = Color.Black
        If button7_count = 6 Then Button7.BackColor = Color.Yellow
        If button7_count = 7 Then Button7.BackColor = Color.Red
        If button7_count = 8 Then Button7.BackColor = Color.Blue

        If button7_count = 9 Then Button7.BackColor = Color.Black
        If button7_count = 10 Then Button7.BackColor = Color.Yellow
        If button7_count = 11 Then Button7.BackColor = Color.Red
        If button7_count = 12 Then Button7.BackColor = Color.Blue

        If button7_count = 13 Then Button7.BackColor = Color.Black
        If button7_count = 14 Then Button7.BackColor = Color.Yellow
        If button7_count = 15 Then Button7.BackColor = Color.Red
        If button7_count = 16 Then Button7.BackColor = Color.Blue

        If button7_count = 17 Then Button7.BackColor = Color.Black
        If button7_count = 18 Then Button7.BackColor = Color.Yellow
        If button7_count = 19 Then Button7.BackColor = Color.Red
        If button7_count = 20 Then Button7.BackColor = Color.Blue

    End Sub
    Private button13_count As Integer = 0
    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        button13_count = button13_count + 1



        If button13_count = 1 Then Button13.BackColor = Color.Black
        If button13_count = 2 Then Button13.BackColor = Color.Yellow
        If button13_count = 3 Then Button13.BackColor = Color.Red
        If button13_count = 4 Then Button13.BackColor = Color.Blue

        If button13_count = 5 Then Button13.BackColor = Color.Black
        If button13_count = 6 Then Button13.BackColor = Color.Yellow
        If button13_count = 7 Then Button13.BackColor = Color.Red
        If button13_count = 8 Then Button13.BackColor = Color.Blue

        If button13_count = 9 Then Button13.BackColor = Color.Black
        If button13_count = 10 Then Button13.BackColor = Color.Yellow
        If button13_count = 11 Then Button13.BackColor = Color.Red
        If button13_count = 12 Then Button13.BackColor = Color.Blue

        If button13_count = 13 Then Button13.BackColor = Color.Black
        If button13_count = 14 Then Button13.BackColor = Color.Yellow
        If button13_count = 15 Then Button13.BackColor = Color.Red
        If button13_count = 16 Then Button13.BackColor = Color.Blue

        If button13_count = 17 Then Button13.BackColor = Color.Black
        If button13_count = 18 Then Button13.BackColor = Color.Yellow
        If button13_count = 19 Then Button13.BackColor = Color.Red
        If button13_count = 20 Then Button13.BackColor = Color.Blue


    End Sub
    Private button19_count As Integer = 0
    Private Sub Button19_Click(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        button19_count = button19_count + 1

        If button19_count = 1 Then Button19.BackColor = Color.Black
        If button19_count = 2 Then Button19.BackColor = Color.Yellow
        If button19_count = 3 Then Button19.BackColor = Color.Red
        If button19_count = 4 Then Button19.BackColor = Color.Blue

        If button19_count = 5 Then Button19.BackColor = Color.Black
        If button19_count = 6 Then Button19.BackColor = Color.Yellow
        If button19_count = 7 Then Button19.BackColor = Color.Red
        If button19_count = 8 Then Button19.BackColor = Color.Blue

        If button19_count = 9 Then Button19.BackColor = Color.Black
        If button19_count = 10 Then Button19.BackColor = Color.Yellow
        If button19_count = 11 Then Button19.BackColor = Color.Red
        If button19_count = 12 Then Button19.BackColor = Color.Blue

        If button19_count = 13 Then Button19.BackColor = Color.Black
        If button19_count = 14 Then Button19.BackColor = Color.Yellow
        If button19_count = 15 Then Button19.BackColor = Color.Red
        If button19_count = 16 Then Button19.BackColor = Color.Blue

        If button19_count = 17 Then Button19.BackColor = Color.Black
        If button19_count = 18 Then Button19.BackColor = Color.Yellow
        If button19_count = 19 Then Button19.BackColor = Color.Red
        If button19_count = 20 Then Button19.BackColor = Color.Blue

    End Sub
    Private button23_count As Integer = 0
    Private Sub Button23_Click(sender As System.Object, e As System.EventArgs) Handles Button23.Click
        button23_count = button23_count + 1

        If button23_count = 1 Then Button23.BackColor = Color.Black
        If button23_count = 2 Then Button23.BackColor = Color.Yellow
        If button23_count = 3 Then Button23.BackColor = Color.Red
        If button23_count = 4 Then Button23.BackColor = Color.Blue

        If button23_count = 5 Then Button23.BackColor = Color.Black
        If button23_count = 6 Then Button23.BackColor = Color.Yellow
        If button23_count = 7 Then Button23.BackColor = Color.Red
        If button23_count = 8 Then Button23.BackColor = Color.Blue

        If button23_count = 9 Then Button23.BackColor = Color.Black
        If button23_count = 10 Then Button23.BackColor = Color.Yellow
        If button23_count = 11 Then Button23.BackColor = Color.Red
        If button23_count = 12 Then Button23.BackColor = Color.Blue

        If button23_count = 13 Then Button23.BackColor = Color.Black
        If button23_count = 14 Then Button23.BackColor = Color.Yellow
        If button23_count = 15 Then Button23.BackColor = Color.Red
        If button23_count = 16 Then Button23.BackColor = Color.Blue
    End Sub
    Private button6_count As Integer = 0
    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        button6_count = button6_count + 1


        If button6_count = 1 Then Button6.BackColor = Color.Black
        If button6_count = 2 Then Button6.BackColor = Color.Yellow
        If button6_count = 3 Then Button6.BackColor = Color.Red
        If button6_count = 4 Then Button6.BackColor = Color.Blue

        If button6_count = 5 Then Button6.BackColor = Color.Black
        If button6_count = 6 Then Button6.BackColor = Color.Yellow
        If button6_count = 7 Then Button6.BackColor = Color.Red
        If button6_count = 8 Then Button6.BackColor = Color.Blue

        If button6_count = 9 Then Button6.BackColor = Color.Black
        If button6_count = 10 Then Button6.BackColor = Color.Yellow
        If button6_count = 11 Then Button6.BackColor = Color.Red
        If button6_count = 12 Then Button6.BackColor = Color.Blue

        If button6_count = 13 Then Button6.BackColor = Color.Black
        If button6_count = 14 Then Button6.BackColor = Color.Yellow
        If button6_count = 15 Then Button6.BackColor = Color.Red
        If button6_count = 16 Then Button6.BackColor = Color.Blue

        If button6_count = 17 Then Button6.BackColor = Color.Black
        If button6_count = 18 Then Button6.BackColor = Color.Yellow
        If button6_count = 19 Then Button6.BackColor = Color.Red
        If button6_count = 20 Then Button6.BackColor = Color.Blue


    End Sub
    Private button12_count As Integer = 0
    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click

        button12_count = button12_count + 1

        If button12_count = 1 Then Button12.BackColor = Color.Black
        If button12_count = 2 Then Button12.BackColor = Color.Yellow
        If button2_count = 3 Then Button12.BackColor = Color.Red
        If button12_count = 4 Then Button12.BackColor = Color.Blue

        If button12_count = 5 Then Button12.BackColor = Color.Black
        If button12_count = 6 Then Button12.BackColor = Color.Yellow
        If button12_count = 7 Then Button12.BackColor = Color.Red
        If button12_count = 8 Then Button12.BackColor = Color.Blue

        If button12_count = 9 Then Button12.BackColor = Color.Black
        If button12_count = 10 Then Button12.BackColor = Color.Yellow
        If button12_count = 11 Then Button12.BackColor = Color.Red
        If button12_count = 12 Then Button12.BackColor = Color.Blue

        If button12_count = 13 Then Button12.BackColor = Color.Black
        If button12_count = 14 Then Button12.BackColor = Color.Yellow
        If button12_count = 15 Then Button12.BackColor = Color.Red
        If button12_count = 16 Then Button12.BackColor = Color.Blue

        If button12_count = 17 Then Button12.BackColor = Color.Black
        If button12_count = 18 Then Button12.BackColor = Color.Yellow
        If button12_count = 19 Then Button12.BackColor = Color.Red
        If button12_count = 20 Then Button12.BackColor = Color.Blue
    End Sub
    Private button17_count As Integer = 0
    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        button17_count = button17_count + 1

        If button17_count = 1 Then Button17.BackColor = Color.Black
        If button17_count = 2 Then Button17.BackColor = Color.Yellow
        If button17_count = 3 Then Button17.BackColor = Color.Red
        If button17_count = 4 Then Button17.BackColor = Color.Blue

        If button17_count = 5 Then Button17.BackColor = Color.Black
        If button17_count = 6 Then Button17.BackColor = Color.Yellow
        If button17_count = 7 Then Button17.BackColor = Color.Red
        If button17_count = 8 Then Button17.BackColor = Color.Blue

        If button17_count = 9 Then Button17.BackColor = Color.Black
        If button17_count = 10 Then Button17.BackColor = Color.Yellow
        If button17_count = 11 Then Button17.BackColor = Color.Red
        If button17_count = 12 Then Button17.BackColor = Color.Blue

        If button17_count = 13 Then Button17.BackColor = Color.Black
        If button17_count = 14 Then Button17.BackColor = Color.Yellow
        If button17_count = 15 Then Button17.BackColor = Color.Red
        If button17_count = 16 Then Button17.BackColor = Color.Blue

        If button17_count = 17 Then Button17.BackColor = Color.Black
        If button17_count = 18 Then Button17.BackColor = Color.Yellow
        If button17_count = 19 Then Button17.BackColor = Color.Red
        If button17_count = 20 Then Button17.BackColor = Color.Blue
    End Sub
    Private button22_count As Integer = 0
    Private Sub Button22_Click(sender As System.Object, e As System.EventArgs) Handles Button22.Click
        button22_count = button22_count + 1

        If button22_count = 1 Then Button22.BackColor = Color.Black
        If button22_count = 2 Then Button22.BackColor = Color.Yellow
        If button22_count = 3 Then Button22.BackColor = Color.Red
        If button22_count = 4 Then Button22.BackColor = Color.Blue

        If button22_count = 5 Then Button22.BackColor = Color.Black
        If button22_count = 6 Then Button22.BackColor = Color.Yellow
        If button22_count = 7 Then Button22.BackColor = Color.Red
        If button22_count = 8 Then Button22.BackColor = Color.Blue

        If button22_count = 9 Then Button22.BackColor = Color.Black
        If button22_count = 10 Then Button22.BackColor = Color.Yellow
        If button22_count = 11 Then Button22.BackColor = Color.Red
        If button22_count = 12 Then Button22.BackColor = Color.Blue

        If button22_count = 13 Then Button22.BackColor = Color.Black
        If button22_count = 14 Then Button22.BackColor = Color.Yellow
        If button22_count = 15 Then Button22.BackColor = Color.Red
        If button22_count = 16 Then Button22.BackColor = Color.Blue

        If button22_count = 17 Then Button22.BackColor = Color.Black
        If button22_count = 18 Then Button22.BackColor = Color.Yellow
        If button22_count = 19 Then Button22.BackColor = Color.Red
        If button22_count = 20 Then Button22.BackColor = Color.Blue


    End Sub
    Private button5_count As Integer = 0
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        button5_count = button5_count + 1

        If button5_count = 1 Then Button5.BackColor = Color.Black
        If button5_count = 2 Then Button5.BackColor = Color.Yellow
        If button5_count = 3 Then Button5.BackColor = Color.Red
        If button5_count = 4 Then Button5.BackColor = Color.Blue

        If button5_count = 5 Then Button5.BackColor = Color.Black
        If button5_count = 6 Then Button5.BackColor = Color.Yellow
        If button5_count = 7 Then Button5.BackColor = Color.Red
        If button5_count = 8 Then Button5.BackColor = Color.Blue

        If button5_count = 9 Then Button5.BackColor = Color.Black
        If button5_count = 10 Then Button5.BackColor = Color.Yellow
        If button5_count = 11 Then Button5.BackColor = Color.Red
        If button5_count = 12 Then Button5.BackColor = Color.Blue

        If button5_count = 13 Then Button5.BackColor = Color.Black
        If button5_count = 14 Then Button5.BackColor = Color.Yellow
        If button5_count = 15 Then Button5.BackColor = Color.Red
        If button5_count = 16 Then Button5.BackColor = Color.Blue

        If button5_count = 17 Then Button5.BackColor = Color.Black
        If button5_count = 18 Then Button5.BackColor = Color.Yellow
        If button5_count = 19 Then Button5.BackColor = Color.Red
        If button5_count = 20 Then Button5.BackColor = Color.Blue

    End Sub
    Private button11_count As Integer = 0
    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        button11_count = button11_count + 1

        If button11_count = 1 Then Button11.BackColor = Color.Black
        If button11_count = 2 Then Button11.BackColor = Color.Yellow
        If button11_count = 3 Then Button11.BackColor = Color.Red
        If button11_count = 4 Then Button11.BackColor = Color.Blue

        If button11_count = 5 Then Button11.BackColor = Color.Black
        If button11_count = 6 Then Button11.BackColor = Color.Yellow
        If button11_count = 7 Then Button11.BackColor = Color.Red
        If button11_count = 8 Then Button11.BackColor = Color.Blue

        If button11_count = 9 Then Button11.BackColor = Color.Black
        If button11_count = 10 Then Button11.BackColor = Color.Yellow
        If button11_count = 11 Then Button11.BackColor = Color.Red
        If button11_count = 12 Then Button11.BackColor = Color.Blue

        If button11_count = 13 Then Button11.BackColor = Color.Black
        If button11_count = 14 Then Button11.BackColor = Color.Yellow
        If button11_count = 15 Then Button11.BackColor = Color.Red
        If button11_count = 16 Then Button11.BackColor = Color.Blue

        If button11_count = 17 Then Button11.BackColor = Color.Black
        If button11_count = 18 Then Button11.BackColor = Color.Yellow
        If button11_count = 19 Then Button11.BackColor = Color.Red
        If button11_count = 20 Then Button11.BackColor = Color.Blue



    End Sub
    Private button16_count As Integer = 0
    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        button16_count = button16_count + 1

        If button16_count = 1 Then Button16.BackColor = Color.Black
        If button16_count = 2 Then Button16.BackColor = Color.Yellow
        If button16_count = 3 Then Button16.BackColor = Color.Red
        If button16_count = 4 Then Button16.BackColor = Color.Blue

        If button16_count = 5 Then Button16.BackColor = Color.Black
        If button16_count = 6 Then Button16.BackColor = Color.Yellow
        If button16_count = 7 Then Button16.BackColor = Color.Red
        If button16_count = 8 Then Button16.BackColor = Color.Blue

        If button16_count = 9 Then Button16.BackColor = Color.Black
        If button16_count = 10 Then Button16.BackColor = Color.Yellow
        If button16_count = 11 Then Button16.BackColor = Color.Red
        If button16_count = 12 Then Button16.BackColor = Color.Blue

        If button16_count = 13 Then Button16.BackColor = Color.Black
        If button16_count = 14 Then Button16.BackColor = Color.Yellow
        If button16_count = 15 Then Button16.BackColor = Color.Red
        If button16_count = 16 Then Button16.BackColor = Color.Blue

        If button16_count = 17 Then Button16.BackColor = Color.Black
        If button16_count = 18 Then Button16.BackColor = Color.Yellow
        If button16_count = 19 Then Button16.BackColor = Color.Red
        If button16_count = 20 Then Button16.BackColor = Color.Blue

    End Sub
    Private button21_count As Integer = 0
    Private Sub Button21_Click(sender As System.Object, e As System.EventArgs) Handles Button21.Click
        button21_count = button21_count + 1

        If button21_count = 1 Then Button21.BackColor = Color.Black
        If button21_count = 2 Then Button21.BackColor = Color.Yellow
        If button21_count = 3 Then Button21.BackColor = Color.Red
        If button21_count = 4 Then Button21.BackColor = Color.Blue

        If button21_count = 5 Then Button21.BackColor = Color.Black
        If button21_count = 6 Then Button21.BackColor = Color.Yellow
        If button21_count = 7 Then Button21.BackColor = Color.Red
        If button21_count = 8 Then Button21.BackColor = Color.Blue

        If button21_count = 9 Then Button21.BackColor = Color.Black
        If button21_count = 10 Then Button21.BackColor = Color.Yellow
        If button21_count = 11 Then Button21.BackColor = Color.Red
        If button21_count = 12 Then Button21.BackColor = Color.Blue

        If button21_count = 13 Then Button21.BackColor = Color.Black
        If button21_count = 14 Then Button21.BackColor = Color.Yellow
        If button21_count = 15 Then Button21.BackColor = Color.Red
        If button21_count = 16 Then Button21.BackColor = Color.Blue

        If button21_count = 17 Then Button21.BackColor = Color.Black
        If button21_count = 18 Then Button21.BackColor = Color.Yellow
        If button21_count = 19 Then Button21.BackColor = Color.Red
        If button21_count = 20 Then Button21.BackColor = Color.Blue

    End Sub
    Private button9_count As Integer = 0
    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        button9_count = button9_count + 1

        If button9_count = 1 Then Button9.BackColor = Color.Black
        If button9_count = 2 Then Button9.BackColor = Color.Yellow
        If button9_count = 3 Then Button9.BackColor = Color.Red
        If button9_count = 4 Then Button9.BackColor = Color.Blue

        If button19_count = 5 Then Button9.BackColor = Color.Black
        If button19_count = 6 Then Button9.BackColor = Color.Yellow
        If button19_count = 7 Then Button9.BackColor = Color.Red
        If button19_count = 8 Then Button9.BackColor = Color.Blue

        If button9_count = 9 Then Button9.BackColor = Color.Black
        If button9_count = 10 Then Button9.BackColor = Color.Yellow
        If button9_count = 11 Then Button9.BackColor = Color.Red
        If button9_count = 12 Then Button9.BackColor = Color.Blue

        If button9_count = 13 Then Button9.BackColor = Color.Black
        If button9_count = 14 Then Button9.BackColor = Color.Yellow
        If button9_count = 15 Then Button9.BackColor = Color.Red
        If button9_count = 16 Then Button9.BackColor = Color.Blue

        If button9_count = 17 Then Button9.BackColor = Color.Black
        If button9_count = 18 Then Button9.BackColor = Color.Yellow
        If button9_count = 19 Then Button9.BackColor = Color.Red
        If button9_count = 20 Then Button9.BackColor = Color.Blue

    End Sub
    Private button10_count As Integer = 0
    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        button10_count = button10_count + 1

        If button10_count = 1 Then Button10.BackColor = Color.Black
        If button10_count = 2 Then Button10.BackColor = Color.Yellow
        If button10_count = 3 Then Button10.BackColor = Color.Red
        If button10_count = 4 Then Button10.BackColor = Color.Blue

        If button10_count = 5 Then Button10.BackColor = Color.Black
        If button10_count = 6 Then Button10.BackColor = Color.Yellow
        If button10_count = 7 Then Button10.BackColor = Color.Red
        If button10_count = 8 Then Button10.BackColor = Color.Blue

        If button10_count = 9 Then Button10.BackColor = Color.Black
        If button10_count = 10 Then Button10.BackColor = Color.Yellow
        If button10_count = 11 Then Button10.BackColor = Color.Red
        If button10_count = 12 Then Button10.BackColor = Color.Blue

        If button10_count = 13 Then Button10.BackColor = Color.Black
        If button10_count = 14 Then Button10.BackColor = Color.Yellow
        If button10_count = 15 Then Button10.BackColor = Color.Red
        If button10_count = 16 Then Button10.BackColor = Color.Blue

        If button10_count = 17 Then Button10.BackColor = Color.Black
        If button10_count = 18 Then Button10.BackColor = Color.Yellow
        If button10_count = 19 Then Button10.BackColor = Color.Red
        If button10_count = 20 Then Button10.BackColor = Color.Blue


    End Sub
    Private button15_count As Integer = 0
    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        button15_count = button15_count + 1

        If button15_count = 1 Then Button15.BackColor = Color.Black
        If button15_count = 2 Then Button15.BackColor = Color.Yellow
        If button15_count = 3 Then Button15.BackColor = Color.Red
        If button15_count = 4 Then Button15.BackColor = Color.Blue

        If button15_count = 5 Then Button15.BackColor = Color.Black
        If button15_count = 6 Then Button15.BackColor = Color.Yellow
        If button15_count = 7 Then Button15.BackColor = Color.Red
        If button15_count = 8 Then Button15.BackColor = Color.Blue

        If button15_count = 9 Then Button15.BackColor = Color.Black
        If button15_count = 10 Then Button15.BackColor = Color.Yellow
        If button15_count = 11 Then Button15.BackColor = Color.Red
        If button15_count = 12 Then Button15.BackColor = Color.Blue

        If button15_count = 13 Then Button15.BackColor = Color.Black
        If button15_count = 14 Then Button15.BackColor = Color.Yellow
        If button15_count = 15 Then Button15.BackColor = Color.Red
        If button15_count = 16 Then Button15.BackColor = Color.Blue

        If button15_count = 17 Then Button15.BackColor = Color.Black
        If button15_count = 18 Then Button15.BackColor = Color.Yellow
        If button15_count = 19 Then Button15.BackColor = Color.Red
        If button15_count = 20 Then Button15.BackColor = Color.Blue

    End Sub
    Private button20_count As Integer = 0
    Private Sub Button20_Click(sender As System.Object, e As System.EventArgs) Handles Button20.Click
        button20_count = button20_count + 1

        If button20_count = 1 Then Button20.BackColor = Color.Black
        If button20_count = 2 Then Button20.BackColor = Color.Yellow
        If button20_count = 3 Then Button20.BackColor = Color.Red
        If button20_count = 4 Then Button20.BackColor = Color.Blue

        If button20_count = 5 Then Button20.BackColor = Color.Black
        If button20_count = 6 Then Button20.BackColor = Color.Yellow
        If button20_count = 7 Then Button20.BackColor = Color.Red
        If button20_count = 8 Then Button20.BackColor = Color.Blue

        If button20_count = 9 Then Button20.BackColor = Color.Black
        If button20_count = 10 Then Button20.BackColor = Color.Yellow
        If button20_count = 11 Then Button20.BackColor = Color.Red
        If button20_count = 12 Then Button20.BackColor = Color.Blue

        If button2_count = 13 Then Button20.BackColor = Color.Black
        If button2_count = 14 Then Button20.BackColor = Color.Yellow
        If button2_count = 15 Then Button20.BackColor = Color.Red
        If button2_count = 16 Then Button20.BackColor = Color.Blue

        If button20_count = 17 Then Button20.BackColor = Color.Black
        If button20_count = 18 Then Button20.BackColor = Color.Yellow
        If button20_count = 19 Then Button20.BackColor = Color.Red
        If button20_count = 20 Then Button20.BackColor = Color.Blue
    End Sub

    Private Sub RectangleShape1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button32_Click(sender As System.Object, e As System.EventArgs) Handles Button32.Click
        Dim rd As New Random()
        Dim num As Integer
        Dim numb As Integer
        Dim numc As Integer
        Dim numd As Integer

        num = Int(Rnd() * 4) + 1
        numb = Int(Rnd() * 4) + 1
        numc = Int(Rnd() * 4) + 1
        numd = Int(Rnd() * 4) + 1



        If num = 1 Then
            Me.PictureBox1.BackColor = Color.Red
        ElseIf num = 2 Then
            Me.PictureBox1.BackColor = Color.Black
        ElseIf num = 3 Then
            Me.PictureBox1.BackColor = Color.Yellow
        ElseIf num = 4 Then
            Me.PictureBox1.BackColor = Color.Blue
        End If


        If numb = 1 Then
            Me.PictureBox2.BackColor = Color.Red
        ElseIf numb = 2 Then
            Me.PictureBox2.BackColor = Color.Black
        ElseIf numb = 3 Then
            Me.PictureBox2.BackColor = Color.Yellow
        ElseIf numb = 4 Then
            Me.PictureBox2.BackColor = Color.Blue
        End If


        If numc = 1 Then
            Me.PictureBox3.BackColor = Color.Red
        ElseIf numc = 2 Then
            Me.PictureBox3.BackColor = Color.Black
        ElseIf numc = 3 Then
            Me.PictureBox3.BackColor = Color.Yellow
        ElseIf numc = 4 Then
            Me.PictureBox3.BackColor = Color.Blue
        End If


        If numd = 1 Then
            Me.PictureBox4.BackColor = Color.Red
        ElseIf numd = 2 Then
            Me.PictureBox4.BackColor = Color.Black
        ElseIf numd = 3 Then
            Me.PictureBox4.BackColor = Color.Yellow
        ElseIf numd = 4 Then
            Me.PictureBox4.BackColor = Color.Blue
        End If

        Button32.Hide()

        Button25.Show()
        Button29.Show()
        Button30.Show()
        Button28.Show()
        Button26.Show()
        Button27.Show()

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim A, B, C As Integer
        A = Int(Rnd() * 255)
        B = Int(Rnd() * 255)
        C = Int(Rnd() * 255)
        Label1.ForeColor = Color.FromArgb(A, B, C)
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button25_Click(sender As System.Object, e As System.EventArgs) Handles Button25.Click


        If Button1.BackColor = PictureBox5.BackColor Or Button4.BackColor = PictureBox5.BackColor Or
            Button3.BackColor = PictureBox5.BackColor Or Button2.BackColor = PictureBox5.BackColor Then

            MsgBox("please select a color")
        End If





        If Button1.BackColor <> PictureBox5.BackColor And Button4.BackColor <> PictureBox5.BackColor And
            Button3.BackColor <> PictureBox5.BackColor And Button2.BackColor <> PictureBox5.BackColor Then

            Button1.Enabled = False
            Button4.Enabled = False
            Button3.Enabled = False
            Button2.Enabled = False

        End If

        If Button1.BackColor = PictureBox1.BackColor Then Label2.Text = "check"
        If Button4.BackColor = PictureBox2.BackColor Then Label3.Text = "check"
        If Button3.BackColor = PictureBox3.BackColor Then Label4.Text = "check"
        If Button2.BackColor = PictureBox4.BackColor Then Label5.Text = "check"

        If Button1.BackColor = PictureBox1.BackColor And Button4.BackColor = PictureBox2.BackColor And
           Button3.BackColor = PictureBox3.BackColor And Button2.BackColor = PictureBox4.BackColor Then

            PictureBox1.Show()
            PictureBox2.Show()
            PictureBox3.Show()
            PictureBox4.Show()

            
            Dim result As Integer = MessageBox.Show(" TRY AGAIN?", "  YOU WON", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Close()
                Form1.Show()
                Me.Hide()

            ElseIf result = DialogResult.Yes Then
                Dim frm = New Form2
                frm.Show()
                Me.Close()
            End If


        End If
    End Sub

    Private Sub Button30_Click(sender As System.Object, e As System.EventArgs) Handles Button30.Click

        If Button8.BackColor = PictureBox5.BackColor Or Button14.BackColor = PictureBox5.BackColor Or
            Button18.BackColor = PictureBox5.BackColor Or Button24.BackColor = PictureBox5.BackColor Then

            MsgBox("please select a color")
        End If

        If Button8.BackColor = PictureBox1.BackColor Then Label6.Text = "check"
        If Button14.BackColor = PictureBox2.BackColor Then Label7.Text = "check"
        If Button18.BackColor = PictureBox3.BackColor Then Label8.Text = "check"
        If Button24.BackColor = PictureBox4.BackColor Then Label9.Text = "check"

        If Button8.BackColor <> PictureBox5.BackColor And Button14.BackColor <> PictureBox5.BackColor And
        Button18.BackColor <> PictureBox5.BackColor And Button24.BackColor <> PictureBox5.BackColor Then


            Button8.Enabled = False
            Button14.Enabled = False
            Button18.Enabled = False
            Button24.Enabled = False
        End If

        If Button8.BackColor = PictureBox1.BackColor And Button14.BackColor = PictureBox2.BackColor And
           Button18.BackColor = PictureBox3.BackColor And Button24.BackColor = PictureBox4.BackColor Then
            PictureBox1.Show()
            PictureBox2.Show()
            PictureBox3.Show()
            PictureBox4.Show()

            Dim result As Integer = MessageBox.Show(" TRY AGAIN?", "  YOU WON", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Close()
                Form1.Show()
                Me.Hide()

            ElseIf result = DialogResult.Yes Then
                Dim frm = New Form2
                frm.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Button29_Click(sender As System.Object, e As System.EventArgs) Handles Button29.Click

        If Button7.BackColor = PictureBox5.BackColor Or Button13.BackColor = PictureBox5.BackColor Or
            Button19.BackColor = PictureBox5.BackColor Or Button23.BackColor = PictureBox5.BackColor Then

            MsgBox("please select a color")
        End If

        If Button7.BackColor = PictureBox1.BackColor Then Label10.Text = "check"
        If Button13.BackColor = PictureBox2.BackColor Then Label11.Text = "check"
        If Button19.BackColor = PictureBox3.BackColor Then Label12.Text = "check"
        If Button23.BackColor = PictureBox4.BackColor Then Label13.Text = "check"

        If Button7.BackColor <> PictureBox5.BackColor And Button13.BackColor <> PictureBox5.BackColor And
            Button19.BackColor <> PictureBox5.BackColor And Button23.BackColor <> PictureBox5.BackColor Then

            Button7.Enabled = False
            Button13.Enabled = False
            Button19.Enabled = False
            Button23.Enabled = False

        End If

        If Button7.BackColor = PictureBox1.BackColor And Button13.BackColor = PictureBox2.BackColor And
           Button19.BackColor = PictureBox3.BackColor And Button23.BackColor = PictureBox4.BackColor Then

            PictureBox1.Show()
            PictureBox2.Show()
            PictureBox3.Show()
            PictureBox4.Show()


            Dim result As Integer = MessageBox.Show(" TRY AGAIN?", "  YOU WON", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Close()
                Form1.Show()
                Me.Hide()

            ElseIf result = DialogResult.Yes Then
                Dim frm = New Form2
                frm.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Button28_Click(sender As System.Object, e As System.EventArgs) Handles Button28.Click

        If Button6.BackColor = PictureBox5.BackColor Or Button12.BackColor = PictureBox5.BackColor Or
            Button17.BackColor = PictureBox5.BackColor Or Button22.BackColor = PictureBox5.BackColor Then

            MsgBox("please select a color")
        End If

        If Button6.BackColor = PictureBox1.BackColor Then Label14.Text = "check"
        If Button12.BackColor = PictureBox2.BackColor Then Label15.Text = "check"
        If Button17.BackColor = PictureBox3.BackColor Then Label16.Text = "check"
        If Button22.BackColor = PictureBox4.BackColor Then Label17.Text = "check"

        If Button6.BackColor <> PictureBox5.BackColor And Button12.BackColor <> PictureBox5.BackColor And
            Button17.BackColor <> PictureBox5.BackColor And Button22.BackColor <> PictureBox5.BackColor Then

            Button6.Enabled = False
            Button12.Enabled = False
            Button17.Enabled = False
            Button22.Enabled = False

        End If

        If Button6.BackColor = PictureBox1.BackColor And Button12.BackColor = PictureBox2.BackColor And
           Button17.BackColor = PictureBox3.BackColor And Button22.BackColor = PictureBox4.BackColor Then

            PictureBox1.Show()
            PictureBox2.Show()
            PictureBox3.Show()
            PictureBox4.Show()

            Dim result As Integer = MessageBox.Show(" TRY AGAIN?", "  YOU WON", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Close()
                Form1.Show()
                Me.Hide()

            ElseIf result = DialogResult.Yes Then
                Dim frm = New Form2
                frm.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Button27_Click(sender As System.Object, e As System.EventArgs) Handles Button27.Click

        If Button5.BackColor = PictureBox5.BackColor Or Button11.BackColor = PictureBox5.BackColor Or
            Button16.BackColor = PictureBox5.BackColor Or Button21.BackColor = PictureBox5.BackColor Then

            MsgBox("please select a color")
        End If

        If Button5.BackColor = PictureBox1.BackColor Then Label18.Text = "check"
        If Button11.BackColor = PictureBox2.BackColor Then Label19.Text = "check"
        If Button16.BackColor = PictureBox3.BackColor Then Label20.Text = "check"
        If Button21.BackColor = PictureBox4.BackColor Then Label21.Text = "check"

        If Button5.BackColor <> PictureBox5.BackColor And Button11.BackColor <> PictureBox5.BackColor And
            Button16.BackColor <> PictureBox5.BackColor And Button21.BackColor <> PictureBox5.BackColor Then

            Button5.Enabled = False
            Button11.Enabled = False
            Button16.Enabled = False
            Button21.Enabled = False
        End If

        If Button5.BackColor = PictureBox1.BackColor And Button11.BackColor = PictureBox2.BackColor And
           Button16.BackColor = PictureBox3.BackColor And Button21.BackColor = PictureBox4.BackColor Then

            PictureBox1.Show()
            PictureBox2.Show()
            PictureBox3.Show()
            PictureBox4.Show()

            Dim result As Integer = MessageBox.Show(" TRY AGAIN?", "  YOU WON", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Close()
                Form1.Show()
                Me.Hide()

            ElseIf result = DialogResult.Yes Then
                Dim frm = New Form2
                frm.Show()
                Me.Close()
            End If



        End If
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button26_Click(sender As System.Object, e As System.EventArgs) Handles Button26.Click

        If Button9.BackColor = PictureBox5.BackColor Or Button10.BackColor = PictureBox5.BackColor Or
            Button15.BackColor = PictureBox5.BackColor Or Button20.BackColor = PictureBox5.BackColor Then

            MsgBox("please select a color")
        End If

        If Button9.BackColor = PictureBox1.BackColor Then Label22.Text = "check"
        If Button10.BackColor = PictureBox2.BackColor Then Label23.Text = "check"
        If Button15.BackColor = PictureBox3.BackColor Then Label24.Text = "check"
        If Button20.BackColor = PictureBox4.BackColor Then Label25.Text = "check"

        If Button9.BackColor <> PictureBox5.BackColor And Button10.BackColor <> PictureBox5.BackColor And
            Button15.BackColor <> PictureBox5.BackColor And Button20.BackColor <> PictureBox5.BackColor Then

            Button9.Enabled = False
            Button10.Enabled = False
            Button15.Enabled = False
            Button20.Enabled = False
        End If

        If Button9.BackColor = PictureBox1.BackColor And Button10.BackColor = PictureBox2.BackColor And
           Button15.BackColor <> PictureBox3.BackColor And Button20.BackColor <> PictureBox4.BackColor Then

            PictureBox1.Show()
            PictureBox2.Show()
            PictureBox3.Show()
            PictureBox4.Show()

            Dim result As Integer = MessageBox.Show(" TRY AGAIN?", "  YOU LOST", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Close()
                Form1.Show()
                Me.Hide()

            ElseIf result = DialogResult.Yes Then
                Dim frm = New Form2
                frm.Show()
                Me.Close()
            End If

        End If

        If Button9.BackColor <> PictureBox1.BackColor And Button10.BackColor = PictureBox2.BackColor And
      Button15.BackColor = PictureBox3.BackColor And Button20.BackColor = PictureBox4.BackColor Then

            PictureBox1.Show()
            PictureBox2.Show()
            PictureBox3.Show()

            Dim result As Integer = MessageBox.Show(" TRY AGAIN?", "  YOU LOST", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Close()
                Form1.Show()
                Me.Hide()

            ElseIf result = DialogResult.Yes Then
                Dim frm = New Form2
                frm.Show()
                Me.Close()
            End If

        End If

        If Button9.BackColor <> PictureBox1.BackColor And Button10.BackColor = PictureBox2.BackColor And
          Button15.BackColor = PictureBox3.BackColor And Button20.BackColor <> PictureBox4.BackColor Then

            PictureBox1.Show()
            PictureBox2.Show()
            PictureBox3.Show()
            PictureBox4.Show()

            Dim result As Integer = MessageBox.Show(" TRY AGAIN?", "  YOU LOST", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Close()
                Form1.Show()
                Me.Hide()

            ElseIf result = DialogResult.Yes Then
                Dim frm = New Form2
                frm.Show()
                Me.Close()
            End If


        End If

        If Button9.BackColor = PictureBox1.BackColor And Button10.BackColor <> PictureBox2.BackColor And
      Button15.BackColor <> PictureBox3.BackColor And Button20.BackColor = PictureBox4.BackColor Then

            PictureBox1.Show()
            PictureBox2.Show()
            PictureBox3.Show()
            PictureBox4.Show()

            Dim result As Integer = MessageBox.Show(" TRY AGAIN?", "  YOU LOST", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Close()
                Form1.Show()
                Me.Hide()

            ElseIf result = DialogResult.Yes Then
                Dim frm = New Form2
                frm.Show()
                Me.Close()
            End If


        End If

        If Button9.BackColor = PictureBox1.BackColor And Button10.BackColor <> PictureBox2.BackColor And
          Button15.BackColor <> PictureBox3.BackColor And Button20.BackColor <> PictureBox4.BackColor Then


            PictureBox1.Show()
            PictureBox2.Show()
            PictureBox3.Show()
            PictureBox4.Show()


            Dim result As Integer = MessageBox.Show(" TRY AGAIN?", "  YOU LOST", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Close()
                Form1.Show()
                Me.Hide()

            ElseIf result = DialogResult.Yes Then
                Dim frm = New Form2
                frm.Show()
                Me.Close()
            End If

        End If


        If Button9.BackColor <> PictureBox1.BackColor And Button10.BackColor = PictureBox2.BackColor And
     Button15.BackColor <> PictureBox3.BackColor And Button20.BackColor <> PictureBox4.BackColor Then

            PictureBox1.Show()
            PictureBox2.Show()
            PictureBox3.Show()
            PictureBox4.Show()
            
            Dim result As Integer = MessageBox.Show(" TRY AGAIN?", "  YOU LOST", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Close()
                Form1.Show()
                Me.Hide()

            ElseIf result = DialogResult.Yes Then
                Dim frm = New Form2
                frm.Show()
                Me.Close()
            End If

        End If

        If Button9.BackColor <> PictureBox1.BackColor And Button10.BackColor <> PictureBox2.BackColor And
         Button15.BackColor = PictureBox3.BackColor And Button20.BackColor <> PictureBox4.BackColor Then

            PictureBox1.Show()
            PictureBox2.Show()
            PictureBox3.Show()
            PictureBox4.Show()

            Dim result As Integer = MessageBox.Show(" TRY AGAIN?", "  YOU LOST", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Close()
                Form1.Show()
                Me.Hide()

            ElseIf result = DialogResult.Yes Then
                Dim frm = New Form2
                frm.Show()
                Me.Close()
            End If

        End If

        If Button9.BackColor <> PictureBox1.BackColor And Button10.BackColor <> PictureBox2.BackColor And
         Button15.BackColor <> PictureBox3.BackColor And Button20.BackColor = PictureBox4.BackColor Then

            PictureBox1.Show()
            PictureBox2.Show()
            PictureBox3.Show()
            PictureBox4.Show()

            Dim result As Integer = MessageBox.Show(" TRY AGAIN?", "  YOU LOST", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Close()
                Form1.Show()
                Me.Hide()

            ElseIf result = DialogResult.Yes Then
                Dim frm = New Form2
                frm.Show()
                Me.Close()
            End If



        End If

        If Button9.BackColor = PictureBox1.BackColor And Button10.BackColor = PictureBox2.BackColor And
           Button15.BackColor = PictureBox3.BackColor And Button20.BackColor = PictureBox4.BackColor Then

            PictureBox1.Show()
            PictureBox2.Show()
            PictureBox3.Show()
            PictureBox4.Show()

            MsgBox("YOU WIN!")
            Form1.Show()
            Me.Hide()






        End If
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button33_Click(sender As System.Object, e As System.EventArgs) Handles Button33.Click

        Dim frm = New Form2
            frm.Show()
            Me.Close()




    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click


    End Sub
End Class
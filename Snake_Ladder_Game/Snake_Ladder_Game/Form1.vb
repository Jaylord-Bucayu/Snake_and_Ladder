Public Class Form1

    Dim n As Integer

    Dim n2 As Integer

    Dim player1Cell As Integer
    Dim player2Cell As Integer


    Dim t2 As Integer
    Dim t As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button1.Visible = False


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        t = 0

        Do
            Dice.Refresh()

            Dim MyPen As Pen


            MyPen = New Pen(Drawing.Color.DarkCyan, 10)
            Dim MyGraphics As Graphics = Dice.CreateGraphics
            n = Int(6 * Rnd()) + 1

            Select Case n
                Case 1
                    MyGraphics.DrawEllipse(MyPen, 80, 80, 10, 10)
                Case 2
                    MyGraphics.DrawEllipse(MyPen, 40, 40, 10, 10)
                    MyGraphics.DrawEllipse(MyPen, 120, 120, 10, 10)
                Case 3
                    MyGraphics.DrawEllipse(MyPen, 40, 40, 10, 10)
                    MyGraphics.DrawEllipse(MyPen, 80, 80, 10, 10)
                    MyGraphics.DrawEllipse(MyPen, 120, 120, 10, 10)
                Case 4
                    MyGraphics.DrawEllipse(MyPen, 40, 40, 10, 10)
                    MyGraphics.DrawEllipse(MyPen, 120, 40, 10, 10)
                    MyGraphics.DrawEllipse(MyPen, 40, 120, 10, 10)
                    MyGraphics.DrawEllipse(MyPen, 120, 120, 10, 10)
                Case 5
                    MyGraphics.DrawEllipse(MyPen, 40, 40, 10, 10)
                    MyGraphics.DrawEllipse(MyPen, 120, 40, 10, 10)
                    MyGraphics.DrawEllipse(MyPen, 80, 80, 10, 10)
                    MyGraphics.DrawEllipse(MyPen, 40, 120, 10, 10)
                    MyGraphics.DrawEllipse(MyPen, 120, 120, 10, 10)
                Case 6
                    MyGraphics.DrawEllipse(MyPen, 40, 40, 10, 10)
                    MyGraphics.DrawEllipse(MyPen, 120, 40, 10, 10)
                    MyGraphics.DrawEllipse(MyPen, 40, 80, 10, 10)
                    MyGraphics.DrawEllipse(MyPen, 120, 80, 10, 10)
                    MyGraphics.DrawEllipse(MyPen, 40, 120, 10, 10)
                    MyGraphics.DrawEllipse(MyPen, 120, 120, 10, 10)



            End Select
            t = t + 1


            Label1.Text = n.ToString() + " plus move"

        Loop Until t > 1000
        player1Cell += n



        If (player1Cell = 9) Then
            Image1.Top = 430
            Image1.Left -= 60
            player1Cell = 28

        ElseIf (player1Cell = 33) Then
            Image1.Top = 380
            Image1.Left -= 60 * (n2 - 1)

        ElseIf (player1Cell = 38) Then

            Image1.Left -= 60 * n2

        ElseIf (player1Cell = 42) Then
            Image1.Top = 320
            Image1.Left -= 60 * (n2 - 1)

        ElseIf (player1Cell = 51) Then
            Image1.Top = 270
            Image1.Left += 120


        ElseIf (player1Cell = 57) Then
            Image1.Left -= 60 * (n2 + 2)
        ElseIf (player1Cell = 60) Then
            Image1.Left -= 60 * n

        ElseIf (player1Cell = 62) Then
            Image1.Top = 220
            Image1.Left += 60 * (n - 1)

        Else
            Image1.Left += 60 * n
        End If




        Label2.Text = "Position " + player1Cell.ToString()



        Timer1.Stop()






    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False
        Button2.Visible = True
        Timer2.Stop()

        Timer1.Start()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Visible = False
        Button1.Visible = True
        Timer1.Stop()

        Timer2.Start()





    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick


        t2 = 0

        Do
            Dice2.Refresh()

            Dim MyPen2 As Pen


            MyPen2 = New Pen(Drawing.Color.DarkCyan, 10)
            Dim MyGraphics2 As Graphics = Dice2.CreateGraphics
            n2 = Int(5 * Rnd()) + 2

            Select Case n2
                Case 1
                    MyGraphics2.DrawEllipse(MyPen2, 80, 80, 10, 10)
                Case 2
                    MyGraphics2.DrawEllipse(MyPen2, 40, 40, 10, 10)
                    MyGraphics2.DrawEllipse(MyPen2, 120, 120, 10, 10)
                Case 3
                    MyGraphics2.DrawEllipse(MyPen2, 40, 40, 10, 10)
                    MyGraphics2.DrawEllipse(MyPen2, 80, 80, 10, 10)
                    MyGraphics2.DrawEllipse(MyPen2, 120, 120, 10, 10)
                Case 4
                    MyGraphics2.DrawEllipse(MyPen2, 40, 40, 10, 10)
                    MyGraphics2.DrawEllipse(MyPen2, 120, 40, 10, 10)
                    MyGraphics2.DrawEllipse(MyPen2, 40, 120, 10, 10)
                    MyGraphics2.DrawEllipse(MyPen2, 120, 120, 10, 10)
                Case 5
                    MyGraphics2.DrawEllipse(MyPen2, 40, 40, 10, 10)
                    MyGraphics2.DrawEllipse(MyPen2, 120, 40, 10, 10)
                    MyGraphics2.DrawEllipse(MyPen2, 80, 80, 10, 10)
                    MyGraphics2.DrawEllipse(MyPen2, 40, 120, 10, 10)
                    MyGraphics2.DrawEllipse(MyPen2, 120, 120, 10, 10)
                Case 6
                    MyGraphics2.DrawEllipse(MyPen2, 40, 40, 10, 10)
                    MyGraphics2.DrawEllipse(MyPen2, 120, 40, 10, 10)
                    MyGraphics2.DrawEllipse(MyPen2, 40, 80, 10, 10)
                    MyGraphics2.DrawEllipse(MyPen2, 120, 80, 10, 10)
                    MyGraphics2.DrawEllipse(MyPen2, 40, 120, 10, 10)
                    MyGraphics2.DrawEllipse(MyPen2, 120, 120, 10, 10)



            End Select
            t2 += 1


            Label1.Text = n2.ToString() + " plus move"
        Loop Until t2 > 1000
        player2Cell += n2



        If (player2Cell = 9) Then
            Image2.Top = 430
            Image2.Left += 60
            player2Cell = 28


        ElseIf (player2Cell = 33) Then

            Image2.Top = 380



        ElseIf (player2Cell = 36) Then

            Image2.Left -= 60 * n2

        ElseIf (player2Cell = 39) Then
            Image2.Left -= 60 * n2

        ElseIf (player2Cell = 44) Then
            Image2.Top = 320
            Image2.Left += 120

        ElseIf (player2Cell = 52) Then
            Image2.Top = 270

        ElseIf (player2Cell = 55) Then
            Image2.Left -= 60 * n2

        ElseIf (player2Cell = 60) Then
            Image2.Left -= 60 * n2


        ElseIf (player2Cell = 64) Then
            Image2.Top = 220
            Image2.Left += 60 * (n2 - 1)

        ElseIf (player2Cell = 72) Then
            Image2.Top = 170
            Image2.Left += 60 * (n2 - 3)

        ElseIf (player2Cell = 78) Then
            Image2.Top = 50
            Image2.Left -= 60 * (n2 - 1)
            player2Cell = 97
        ElseIf (player2Cell > 97) Then

            Image2.Left -= 60 * n2

            Timer1.Stop()
            Timer2.Stop()

            Dim result As DialogResult = MessageBox.Show("Player 2 Wins", "Snake and Ladder", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                MessageBox.Show("Cancel pressed")



            ElseIf result = DialogResult.Yes Then
                player1Cell = 0
                player2Cell = 0
                t = 0
                t2 = 0
                n = 0
                n2 = 0
                Image1.Top = 530
                Image1.Left -= 60 * 4
                Image2.Left = 60
                Image2.Top = 530
            End If




        Else
            Image2.Left += 60 * n2
        End If




        Label3.Text = "Position " + player2Cell.ToString()




        Timer2.Stop()



    End Sub
End Class

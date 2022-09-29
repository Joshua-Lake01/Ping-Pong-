Public Class Form1
    Dim counter1 As Integer
    Dim counter2 As Integer
    Dim ballupint As Decimal
    Dim ballleftint As Decimal
    Dim fheight As Integer
    Dim rpaddleheight As Integer
    Dim rpaddletop As Integer
    Dim r1 As Integer
    Dim r2 As Integer
    Dim c1 As Integer




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label15.Text = 5
        c1 = 5
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label15.Visible = False
        counter1 = 0
        counter2 = 0


        ballupint = -3
        ballleftint = 3

    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = "w" Then
            LeftpaddleUp.Enabled = True

        End If
        If e.KeyChar = "s" Then
            LeftpaddleDown.Enabled = True
        End If





    End Sub

    Private Sub LeftpaddleUp_Tick(sender As Object, e As EventArgs) Handles LeftpaddleUp.Tick
        If leftpaddle.Top <= 0 Then
            LeftpaddleUp.Enabled = False
        Else
            leftpaddle.Top = leftpaddle.Top - 9
            LeftpaddleUp.Enabled = False
        End If
    End Sub

    Private Sub LeftpaddleDown_Tick(sender As Object, e As EventArgs) Handles LeftpaddleDown.Tick
        If leftpaddle.Top >= Me.Height - 125 Then
            LeftpaddleDown.Enabled = False
        Else
            leftpaddle.Top = leftpaddle.Top + 9
            LeftpaddleDown.Enabled = False
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles rightpaddle.Click

    End Sub

    Private Sub RightPaddleUp_Tick(sender As Object, e As EventArgs) Handles RightPaddleUp.Tick
        Dim rpaddlecorrection As Integer
        Dim rnd1 As Decimal
        Dim ballhit As Boolean

        rpaddlecorrection = rightpaddle.Top
        rpaddlecorrection = rpaddlecorrection - 40
        If c1 >= 5 Then
            If rightpaddle.Top <= 0 Then
                RightPaddleUp.Enabled = False
                RightPaddleDown.Enabled = True
            Else

                rpaddlecorrection = ball.Top - 4
                rightpaddle.Top = rpaddlecorrection

            End If
        End If
        'If c1 < 5 Then
        '    If rightpaddle.Top <= 0 Then
        '        RightPaddleUp.Enabled = False
        '        RightPaddleDown.Enabled = True
        '    Else
        '        rightpaddle.Top = rightpaddle.Top - 4

        '    End If


        'If c1 < 5 Then
        '    If rightpaddle.Top <= 0 Then
        '        RightPaddleUp.Enabled = False
        '        RightPaddleDown.Enabled = True
        '    Else
        '        If rnd1 > 0.5 Then
        '            rightpaddle.Top = rightpaddle.Top - 4
        '        Else
        '            rpaddlecorrection = ball.Top - 4
        '            rightpaddle.Top = rpaddlecorrection
        '        End If
        '    End If
        'End If

        If c1 < 5 Then
            If rightpaddle.Top <= 0 Then
                RightPaddleUp.Enabled = False
                RightPaddleDown.Enabled = True

            Else

                If ball.Top = rightpaddle.Top Then
                    ballhit = True
                    Randomize()
                    rnd1 = Rnd()
                    If rnd1 > 0.75 Then
                        rightpaddle.Top = rightpaddle.Top - 4

                    Else
                        rpaddlecorrection = ball.Top - 4
                        rightpaddle.Top = rpaddlecorrection
                    End If
                Else
                    ballhit = False
                End If

                If ballhit = False Then

                    rightpaddle.Top = rightpaddle.Top - 4

                End If


            End If
        End If


    End Sub

    Private Sub RightPaddleDown_Tick(sender As Object, e As EventArgs) Handles RightPaddleDown.Tick
        If c1 >= 5 Then
            If rightpaddle.Top >= Me.Height - 125 Then
                RightPaddleDown.Enabled = False
                RightPaddleUp.Enabled = True
            Else
                rightpaddle.Top = ball.Top + 4

            End If
        End If
        If c1 < 5 Then
            If rightpaddle.Top >= Me.Height - 125 Then
                RightPaddleDown.Enabled = False
                RightPaddleUp.Enabled = True
            Else
                rightpaddle.Top = rightpaddle.Top + 4

            End If
        End If

    End Sub

    Private Sub Ballmovement_Tick(sender As Object, e As EventArgs) Handles Ballmovement.Tick


        If ball.Top <= 1 Then
            ballupint = -1 * ballupint
        End If

        If ball.Top >= Me.Height - 53 Then
            ballupint = -1 * ballupint
        End If

        If ball.Left <= 0 Then
            counter1 = counter1 + 1
            Label1.Text = counter1
            ball.Top = Me.Height * 0.5
            ball.Left = Me.Width * 0.5
        End If
        If ball.Left >= Me.Width - 30 Then
            counter2 = counter2 + 1
            Label2.Text = counter2
            ball.Top = Me.Height * 0.5
            ball.Left = Me.Width * 0.5
        End If

        fheight = Me.Height
        rpaddleheight = rightpaddle.Height
        rpaddletop = rightpaddle.Top

        If ball.Top > rpaddletop - 8 Then
            If ball.Top < rpaddletop + rpaddleheight + 8 Then
                If ball.Left + 10 >= rightpaddle.Left Then
                    ballleftint = -1 * ballleftint
                End If
            End If
        End If

        If ball.Top > leftpaddle.Top - 8 Then
            If ball.Top < leftpaddle.Top + leftpaddle.Height + 8 Then
                If ball.Left < leftpaddle.Width + leftpaddle.Left Then

                    ballleftint = -1 * ballleftint
                End If
            End If
        End If

        ball.Left = ball.Left + ballleftint
        ball.Top = ball.Top + ballupint


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        ballupint = +1
        ballleftint = -1

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        ballupint = -1
        ballleftint = +1

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Ballmovement.Enabled = True
        RightPaddleDown.Enabled = True

        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Close()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True

        Label15.Visible = True
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False

        Label15.Visible = False

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        If c1 = 0 Then

        Else
            c1 = c1 - 1
            ballupint = ballupint * 0.75
            ballleftint = ballleftint * 0.75
        End If

        Label15.Text = c1
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

        c1 = c1 + 1
        ballupint = ballupint * 1.25
        ballleftint = ballleftint * 1.25
        Label15.Text = c1

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Ballmovement.Enabled = False
        RightPaddleDown.Enabled = False
        RightPaddleUp.Enabled = False
    End Sub
End Class


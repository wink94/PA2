Public Class Form1

    Private Shared count As Integer = 0

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim user1Name, user1PWD, user2Name, user2PWD, user3Name, user3PWD As String

        'user-name password tikkak define krla login eke haduwe 

        'login eka gana wisttara krla na hariyta.... thyna lesima widiyta haduwe'


        user1Name = "qwer"
        user1PWD = "123"

        user2Name = "asd"
        user2PWD = "456"

        user3Name = "zxc"
        user3PWD = "789"

        If ((user1Name = txtUserName.Text And user1PWD = txtPWD.Text) Or (user2Name = txtUserName.Text And user2PWD = txtPWD.Text) Or (user3Name = txtUserName.Text And user3PWD = txtPWD.Text)) Then

            If (count = 5) Then                         '5 parak count ekke gnnwa nattn invalid login ekk nis ain wenwa
                MessageBox.Show("login expired")
                Dispose()
            Else
                count = 0

                Dim nextForm As Form2 = New Form2
                nextForm.Show()

            End If

        Else
            If (count = 3) Then
                MessageBox.Show("login expired")
                Dispose()
            Else
                MessageBox.Show("login invalid")
                count += 1

            End If

        End If

    End Sub


End Class

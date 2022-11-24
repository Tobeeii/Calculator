
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim num As Integer
    Dim nummy As String = String.Empty
    Dim num2 As Integer
    Dim coperation As String = String.Empty
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If num <> Nothing Then
            TextBox1.Text = Convert.ToInt32(TextBox1.Text) * 10 + 2

        Else
            num = 2
            TextBox1.Text = 2
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If num <> Nothing Then
            TextBox1.Text = Convert.ToInt32(TextBox1.Text) * 10 + 5

        Else
            num = 5
            TextBox1.Text = 5
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If num <> Nothing Then
            TextBox1.Text = Convert.ToInt32(TextBox1.Text) * 10 + 3

        Else
            num = 3
            TextBox1.Text = 3
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'num = 1
        'TextBox1.Text = 1
        If num <> Nothing Then
            TextBox1.Text = Convert.ToInt32(TextBox1.Text) * 10 + 1

        Else
            num = 1
            TextBox1.Text = 1
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If num <> Nothing Then
            TextBox1.Text = Convert.ToInt32(TextBox1.Text) * 10 + 8

        Else
            num = 8
            TextBox1.Text = 8
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If num <> Nothing Then
            TextBox1.Text = Convert.ToInt32(TextBox1.Text) * 10 + 7

        Else
            num = 7
            TextBox1.Text = 7
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If num <> Nothing Then
            TextBox1.Text = Convert.ToInt32(TextBox1.Text) * 10 + 4

        Else
            num = 4
            TextBox1.Text = 4
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If num <> Nothing Then
            TextBox1.Text = Convert.ToInt32(TextBox1.Text) * 10 + 6

        Else
            num = 6
            TextBox1.Text = 6
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If num <> Nothing Then
            TextBox1.Text = Convert.ToInt32(TextBox1.Text) * 10 + 9

        Else
            num = 9
            TextBox1.Text = 9
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If num <> Nothing Then
            TextBox1.Text = Convert.ToInt32(TextBox1.Text) * 10 + 0

        Else
            num = 0
            TextBox1.Text = 0
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        num2 = num
        coperation = "+"
        num = Nothing
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If coperation = "+" Then

            num2 = num + num2
            TextBox1.Text = num 2
        End If
    End Sub
End Class

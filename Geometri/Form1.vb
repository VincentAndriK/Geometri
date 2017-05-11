Public Class Form1

    Dim a, b, c As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OvalShape1.Show()
        RectangleShape1.Show()
        RectangleShape2.Hide()
        RectangleShape3.Hide()
        RectangleShape4.Hide()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        OvalShape1.Show()
        RectangleShape1.Show()
        RectangleShape2.Hide()
        RectangleShape3.Hide()
        RectangleShape4.Hide()
        TextBox2.Show()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        OvalShape1.Hide()
        RectangleShape1.Show()
        RectangleShape2.Hide()
        RectangleShape3.Hide()
        RectangleShape4.Hide()
        TextBox2.Show()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        OvalShape1.Show()
        RectangleShape1.Hide()
        RectangleShape2.Show()
        RectangleShape3.Hide()
        RectangleShape4.Hide()
        TextBox2.Hide()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        OvalShape1.Show()
        RectangleShape1.Hide()
        RectangleShape2.Hide()
        RectangleShape3.Hide()
        RectangleShape4.Hide()
        TextBox2.Hide()
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        OvalShape1.Show()
        RectangleShape1.Hide()
        RectangleShape2.Show()
        RectangleShape3.Show()
        RectangleShape4.Hide()
        TextBox2.Hide()
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        OvalShape1.Hide()
        RectangleShape1.Hide()
        RectangleShape2.Hide()
        RectangleShape3.Hide()
        RectangleShape4.Show()
        TextBox2.Hide()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled() = True
            MessageBox.Show("Isikan Angka Saja", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled() = True
            MessageBox.Show("Isikan Angka Saja", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            Label1.Text = ""
            a = Integer.Parse(TextBox1.Text)
            b = Integer.Parse(TextBox2.Text)
            c = (a * b) + (0.5 * (Math.PI * b * b))
            Label1.Text = "Luas : " + c.ToString()
        End If
        If RadioButton2.Checked Then
            Label1.Text = ""
            a = Integer.Parse(TextBox1.Text)
            b = Integer.Parse(TextBox2.Text)
            c = a * b
            Label1.Text = "Luas : " + c.ToString()
        End If
        If RadioButton4.Checked Then
            Label1.Text = ""
            a = Integer.Parse(TextBox1.Text)
            c = (Math.PI * a * a)
            Label1.Text = "Luas : " + c.ToString()
        End If
        If RadioButton3.Checked Then
            Label1.Text = ""
            a = Integer.Parse(TextBox1.Text)
            c = 0.5 * (Math.PI * a * a)
            Label1.Text = "Luas : " + c.ToString()
        End If
        If RadioButton5.Checked Then
            Label1.Text = ""
            a = Integer.Parse(TextBox1.Text)
            c = 0.25 * (Math.PI * a * a)
            Label1.Text = "Luas : " + c.ToString()
        End If
        If RadioButton6.Checked Then
            Label1.Text = ""
            a = Integer.Parse(TextBox1.Text)
            c = a * a
            Label1.Text = "Luas : " + c.ToString()
        End If
    End Sub
End Class
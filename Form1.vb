Public Class Forms

    Private Sub lblTextBox_Click(sender As Object, e As EventArgs) Handles lblTextBox.Click
        gpbTextBox.Visible = True
        gpbTextBox.Location = New Point(12, 73)
        gpbNumeric.Visible = False
        gpbComboBox.Visible = False
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        gpbComboBox.Visible = True
        gpbComboBox.Location = New Point(12, 73)
        gpbNumeric.Visible = False
        gpbTextBox.Visible = False
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        gpbNumeric.Visible = True
        gpbNumeric.Location = New Point(12, 73)
        gpbComboBox.Visible = False
        gpbTextBox.Visible = False
    End Sub
End Class

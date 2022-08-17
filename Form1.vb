Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim F As New OpenFileDialog
        If F.ShowDialog = DialogResult.OK Then
            RichTextBox1.LoadFile(F.FileName, RichTextBoxStreamType.RichText)
            TextBox1.Text = F.FileName
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog.FileOk

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim F As New SaveFileDialog
        F.Filter = "FORMATO TEXTO RIC´-RICO /*.RTF"
        If F.ShowDialog = DialogResult.OK Then
            RichTextBox1.SaveFile(F.FileName, RichTextBoxStreamType.RichText)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim F As New FontDialog
        F.ShowDialog()
        RichTextBox1.Font = F.Font
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim F As New ColorDialog
        F.ShowDialog()
        RichTextBox1.ForeColor = F.Color
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim F As New OpenFileDialog

        If F.ShowDialog = DialogResult.OK Then
            Dim imagen As Bitmap = New Bitmap(F.FileName)
            Clipboard.SetImage(imagen)
            RichTextBox1.Paste()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Array tooltip
        Dim TL(8) As ToolTip
        For i = 0 To 8
            TL(i) = New ToolTip
        Next
        TL(0).SetToolTip(Me.Button3, "Fuente")
        TL(1).SetToolTip(Me.Button4, "Color")
        TL(2).SetToolTip(Me.Button5, "Abrir imagen")
        TL(3).SetToolTip(Me.Button6, "Izquierda")
        TL(3).SetToolTip(Me.Button7, "Centro")
        TL(3).SetToolTip(Me.Button8, "Derecha")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim F As New FontDialog
        Me.RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
    End Sub
End Class

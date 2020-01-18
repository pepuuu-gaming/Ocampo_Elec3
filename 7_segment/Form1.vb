Public Class Form1
    Dim s As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'Timer1.Interval = 1000
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.BackColor = Color.Gray
        Label2.BackColor = Color.Gray
        Label3.BackColor = Color.Gray
        Label4.BackColor = Color.Gray
        Label5.BackColor = Color.Gray
        Label6.BackColor = Color.Gray
        Label7.BackColor = Color.Gray
        If s > 9 Then
            Timer1.Stop()
        Else
            Debug.Write(s)
            If s = 0 Then
                Label1.BackColor = Color.Green
                Label2.BackColor = Color.Green
                Label3.BackColor = Color.Gray
                Label4.BackColor = Color.Green
                Label5.BackColor = Color.Green
                Label6.BackColor = Color.Green
                Label7.BackColor = Color.Green
            ElseIf s = 1 Then
                Label1.BackColor = Color.Gray
                Label2.BackColor = Color.Gray
                Label3.BackColor = Color.Gray
                Label4.BackColor = Color.Gray
                Label5.BackColor = Color.Green
                Label6.BackColor = Color.Green
                Label7.BackColor = Color.Gray
            ElseIf s = 2 Then
                Label1.BackColor = Color.Green
                Label2.BackColor = Color.Green
                Label3.BackColor = Color.Green
                Label4.BackColor = Color.Green
                Label5.BackColor = Color.Green
                Label6.BackColor = Color.Gray
                Label7.BackColor = Color.Gray
            ElseIf s = 3 Then
                Label1.BackColor = Color.Green
                Label2.BackColor = Color.Green
                Label3.BackColor = Color.Green
                Label4.BackColor = Color.Gray
                Label5.BackColor = Color.Green
                Label6.BackColor = Color.Green
                Label7.BackColor = Color.Gray
            ElseIf s = 4 Then
                Label1.BackColor = Color.Gray
                Label2.BackColor = Color.Gray
                Label3.BackColor = Color.Green
                Label4.BackColor = Color.Gray
                Label5.BackColor = Color.Green
                Label6.BackColor = Color.Green
                Label7.BackColor = Color.Green
            ElseIf s = 5 Then
                Label1.BackColor = Color.Green
                Label2.BackColor = Color.Green
                Label3.BackColor = Color.Green
                Label4.BackColor = Color.Gray
                Label5.BackColor = Color.Gray
                Label6.BackColor = Color.Green
                Label7.BackColor = Color.Green
            ElseIf s = 6 Then
                Label1.BackColor = Color.Green
                Label2.BackColor = Color.Green
                Label3.BackColor = Color.Green
                Label4.BackColor = Color.Green
                Label5.BackColor = Color.Gray
                Label6.BackColor = Color.Green
                Label7.BackColor = Color.Green
            ElseIf s = 7 Then
                Label1.BackColor = Color.Gray
                Label2.BackColor = Color.Green
                Label3.BackColor = Color.Gray
                Label4.BackColor = Color.Gray
                Label5.BackColor = Color.Green
                Label6.BackColor = Color.Green
                Label7.BackColor = Color.Gray
            ElseIf s = 8 Then
                Label1.BackColor = Color.Green
                Label2.BackColor = Color.Green
                Label3.BackColor = Color.Green
                Label4.BackColor = Color.Green
                Label5.BackColor = Color.Green
                Label6.BackColor = Color.Green
                Label7.BackColor = Color.Green
            ElseIf s = 9 Then
                Label1.BackColor = Color.Gray
                Label2.BackColor = Color.Green
                Label3.BackColor = Color.Green
                Label4.BackColor = Color.Gray
                Label5.BackColor = Color.Green
                Label6.BackColor = Color.Green
                Label7.BackColor = Color.Green
            End If
        End If
        s = s + 1

    End Sub
End Class

Public Class Form1
    Dim n As SByte = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

        If n = 0 Then
            Label1.BackColor = Color.Green
            Label2.BackColor = Color.Green
            Label3.BackColor = Color.Gray
            Label4.BackColor = Color.Green
            Label5.BackColor = Color.Green
            Label6.BackColor = Color.Green
            Label7.BackColor = Color.Green
        ElseIf n = 1 Then
            Label1.BackColor = Color.Gray
            Label2.BackColor = Color.Gray
            Label3.BackColor = Color.Gray
            Label4.BackColor = Color.Gray
            Label5.BackColor = Color.Gray
            Label6.BackColor = Color.Green
            Label7.BackColor = Color.Green
        ElseIf n = 2 Then
            Label1.BackColor = Color.Green
            Label2.BackColor = Color.Gray
            Label3.BackColor = Color.Green
            Label4.BackColor = Color.Green
            Label5.BackColor = Color.Green
            Label6.BackColor = Color.Green
            Label7.BackColor = Color.Gray
        ElseIf n = 3 Then
            Label1.BackColor = Color.Green
            Label2.BackColor = Color.Gray
            Label3.BackColor = Color.Green
            Label4.BackColor = Color.Green
            Label5.BackColor = Color.Gray
            Label6.BackColor = Color.Green
            Label7.BackColor = Color.Green
        ElseIf n = 4 Then
            Label1.BackColor = Color.Gray
            Label2.BackColor = Color.Green
            Label3.BackColor = Color.Green
            Label4.BackColor = Color.Gray
            Label5.BackColor = Color.Gray
            Label6.BackColor = Color.Green
            Label7.BackColor = Color.Green
        ElseIf n = 5 Then
            Label1.BackColor = Color.Green
            Label2.BackColor = Color.Green
            Label3.BackColor = Color.Green
            Label4.BackColor = Color.Green
            Label5.BackColor = Color.Gray
            Label6.BackColor = Color.Gray
            Label7.BackColor = Color.Green
        ElseIf n = 6 Then
            Label1.BackColor = Color.Green
            Label2.BackColor = Color.Green
            Label3.BackColor = Color.Green
            Label4.BackColor = Color.Green
            Label5.BackColor = Color.Green
            Label6.BackColor = Color.Gray
            Label7.BackColor = Color.Green
        ElseIf n = 7 Then
            Label1.BackColor = Color.Green
            Label2.BackColor = Color.Gray
            Label3.BackColor = Color.Gray
            Label4.BackColor = Color.Gray
            Label5.BackColor = Color.Gray
            Label6.BackColor = Color.Green
            Label7.BackColor = Color.Green
        ElseIf n = 8 Then
            Label1.BackColor = Color.Green
            Label2.BackColor = Color.Green
            Label3.BackColor = Color.Green
            Label4.BackColor = Color.Green
            Label5.BackColor = Color.Green
            Label6.BackColor = Color.Green
            Label7.BackColor = Color.Green
        ElseIf n = 9 Then
            Label1.BackColor = Color.Green
            Label2.BackColor = Color.Green
            Label3.BackColor = Color.Green
            Label4.BackColor = Color.Green
            Label5.BackColor = Color.Gray
            Label6.BackColor = Color.Green
            Label7.BackColor = Color.Green
        Else
            Timer1.Stop()
            n = -1
        End If
        n += 1
    End Sub
End Class

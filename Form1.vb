Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Visible = True
        Button2.Visible = False
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Visible = False
        Label43.Visible = True
        Timer1.Interval = 10000
        Timer1.Start()
        Timer2.Interval = 20000
        Timer2.Start()
        Timer3.Interval = 30000
        Timer3.Start()
        Timer4.Interval = 40000
        Timer4.Start()
        Timer5.Interval = 50000
        Timer5.Start()
        Timer6.Interval = 60000
        Timer6.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label43.Visible = False
        Label11.Visible = True
        Label2.Visible = False
        Label42.Visible = True
        Label13.Text = "P1 has been executed and is now exiting!"
        Label13.ForeColor = Color.Black
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label11.Visible = False
        Label42.Visible = False
        Label10.Visible = True
        Label3.Visible = False
        Label41.Visible = True
        Label13.Text = "P2 has been executed and is now exiting!"
        Label13.ForeColor = Color.Blue
        Timer2.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label10.Visible = False
        Label41.Visible = False
        Label9.Visible = True
        Label4.Visible = False
        Label40.Visible = True
        Label13.Text = "P3 has been executed and is now exiting!"
        Label13.ForeColor = Color.Red
        Timer3.Stop()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Label9.Visible = False
        Label40.Visible = False
        Label8.Visible = True
        Label5.Visible = False
        Label39.Visible = True
        Label13.Text = "P4 has been executed and is now exiting!"
        Label13.ForeColor = Color.Black
        Timer4.Stop()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Label8.Visible = False
        Label39.Visible = False
        Label7.Visible = True
        Label13.Text = "P5 has been executed and is now exiting!"
        Label13.ForeColor = Color.Blue
        Timer5.Stop()
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Label7.Visible = False
        Button1.Visible = False
        Button2.Visible = True
        Label13.Text = ""
        MsgBox("All Processes have been executed", MsgBoxStyle.Exclamation)
        Timer6.Stop()
    End Sub
End Class

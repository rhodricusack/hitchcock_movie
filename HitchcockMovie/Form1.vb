Imports System.IO
Imports System.Reflection
Public Class Form1
    Dim intPulsesReceived = 0
    Const intNumDummies = 3

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        AxWindowsMediaPlayer1.Visible = False
        lblCountDown.Text = (intNumDummies - intPulsesReceived).ToString
    End Sub



    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.S Or e.KeyCode = Keys.D5 Then
            intPulsesReceived = intPulsesReceived + 1
            lblCountDown.Text = (intNumDummies - intPulsesReceived).ToString
            If intNumDummies = intPulsesReceived Then
                lblCountDown.Visible = False
                Label1.Visible = False
                AxWindowsMediaPlayer1.Visible = True
                '                AxWindowsMediaPlayer1.windowlessVideo = True
                AxWindowsMediaPlayer1.settings.autoStart = True
                AxWindowsMediaPlayer1.URL = "bbyd_v3.mp4"
            End If
        End If
    End Sub

    Private Sub AxWindowsMediaPlayer1_StatusChange(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.StatusChange
        If AxWindowsMediaPlayer1.status = 3 Then
            AxWindowsMediaPlayer1.fullScreen = True
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class



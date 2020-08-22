Public Class ClipShot
    Private Sub ClipShot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ShowInTaskbar = False
        NotifyIcon.ShowBalloonTip(500, "Welcome", "Have a good day !!", ToolTipIcon.None)
    End Sub

    Private Sub ClipBoard_Click(sender As Object, e As EventArgs) Handles ClipBoard.Click
        Dim fileName, path, date1, date2 As String


        path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        fileName = path & "\" & "notes" & ".log"

        If Not (My.Computer.FileSystem.FileExists(fileName)) Then
            System.IO.File.Create(fileName).Dispose()
        End If
        'toDo : add one liner

        Dim textFileStream As New IO.FileStream(fileName, IO.FileMode.Append, IO.FileAccess.Write, IO.FileShare.None)
        Dim myFileWriter As New IO.StreamWriter(textFileStream)
        myFileWriter.WriteLine("===========================")
        date1 = DateTime.Now.ToLongDateString()
        date2 = date1.Substring(date1.Length - 6)
        date1 = date1.Replace(date2, "****")

        myFileWriter.WriteLine("****" & date1)
        myFileWriter.WriteLine("===========================")
        myFileWriter.WriteLine(My.Computer.Clipboard.GetText())
        myFileWriter.Close()
        textFileStream.Close()

        NotifyIcon.ShowBalloonTip(500, "Clipboard", fileName, ToolTipIcon.None)
    End Sub

    Private Sub Screenshot_Click(sender As Object, e As EventArgs) Handles Screenshot.Click
        Dim fileName, path As String
        path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        fileName = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        fileName = fileName.Replace("-", "_")
        fileName = fileName.Replace(":", "_")
        fileName = fileName.Replace(" ", "_")
        path = path & "\snap"
        fileName = path & "\" & fileName & ".jpg"
        fileName = fileName.Replace("\", "\\")
        If Not (My.Computer.FileSystem.DirectoryExists(path)) Then
            My.Computer.FileSystem.CreateDirectory(path)
        End If

        Dim s As Screen = Screen.PrimaryScreen
        Dim img As New Bitmap(s.Bounds.Width, s.Bounds.Height)
        Dim gr As Graphics = Graphics.FromImage(img)
        gr.CopyFromScreen(s.Bounds.Location, Point.Empty, s.Bounds.Size)

        img.Save(fileName, Imaging.ImageFormat.Jpeg)

        NotifyIcon.ShowBalloonTip(500, "Screenshot captured", fileName, ToolTipIcon.None)
    End Sub

    Private Sub eExit_Click(sender As Object, e As EventArgs) Handles eExit.Click
        NotifyIcon.ShowBalloonTip(500, "Bye Bye", "See you later", ToolTipIcon.None)
        Application.Exit()
    End Sub
End Class

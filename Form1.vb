
Public Class ClipShot
    Dim profilePath As String
    Dim profileFilename As String
    Dim profileName As String
    Dim profile1Path As String = "\snap"
    Dim profile2Path As String = "\snap1"
    Dim profile1Filename As String = "notes"
    Dim profile2Filename As String = "notes1"
    Dim profile1Name As String = "Sudhish"
    Dim profile2Name As String = "Ashish"
    'profile1 is for son, profile2 is for father

    Private Sub ClipShot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ShowInTaskbar = False

        Me.BackColor = Color.LightSkyBlue
        profilePath = profile1Path
        profileFilename = profile1Filename
        profileName = profile1Name
        NotifyIcon.ShowBalloonTip(50, "Welcome", profileName, ToolTipIcon.None)
    End Sub

    Private Sub ClipBoard_Click(sender As Object, e As EventArgs) Handles ClipBoard.Click
        Dim fileName, path, date1, date2 As String


        path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        fileName = path & "\" & profileFilename & ".log"

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

        NotifyIcon.ShowBalloonTip(50, "Clipboard", fileName, ToolTipIcon.None)
    End Sub

    Private Sub Screenshot_Click(sender As Object, e As EventArgs) Handles Screenshot.Click
        Dim fileName, path As String


        path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        fileName = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        fileName = fileName.Replace("-", "_")
        fileName = fileName.Replace(":", "_")
        fileName = fileName.Replace(" ", "_")
        path = path & profilePath
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

        NotifyIcon.ShowBalloonTip(50, "Screenshot captured", fileName, ToolTipIcon.None)
    End Sub

    Private Sub eExit_Click(sender As Object, e As EventArgs) Handles eExit.Click
        NotifyIcon.ShowBalloonTip(50, "Bye Bye", profileName, ToolTipIcon.Info)
        Application.Exit()
    End Sub

    Private Sub NotifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon.MouseDoubleClick
        Dim Msg, Style, Title, Response
        Msg = "Change the profile to father ?"    ' Define message.
        Style = vbYesNo   ' Define buttons.
        Title = "Select Profile"    ' Define title.

        ' Display message.
        Response = MsgBox(Msg, Style, Title)
        If Response = vbYes Then    ' User chose Yes.
            profilePath = profile2Path
            profileFilename = profile2Filename
            profileName = profile2Name
            Me.BackColor = Color.Red
            NotifyIcon.ShowBalloonTip(50, "Profile switched to ", profileName, ToolTipIcon.Info)
        Else    ' User chose No.
            profilePath = profile1Path
            profileFilename = profile1Filename
            profileName = profile1Name
            Me.BackColor = Color.LightSkyBlue
            NotifyIcon.ShowBalloonTip(50, "Profile switched to ", profileName, ToolTipIcon.Info)
        End If
    End Sub


End Class

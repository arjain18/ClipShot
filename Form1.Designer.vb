<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClipShot
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClipShot))
        Me.ClipBoard = New System.Windows.Forms.PictureBox()
        Me.Screenshot = New System.Windows.Forms.PictureBox()
        Me.eExit = New System.Windows.Forms.PictureBox()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.ClipBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Screenshot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClipBoard
        '
        Me.ClipBoard.BackColor = System.Drawing.Color.White
        Me.ClipBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClipBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ClipBoard.Image = CType(resources.GetObject("ClipBoard.Image"), System.Drawing.Image)
        Me.ClipBoard.Location = New System.Drawing.Point(2, 1)
        Me.ClipBoard.Name = "ClipBoard"
        Me.ClipBoard.Size = New System.Drawing.Size(50, 50)
        Me.ClipBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ClipBoard.TabIndex = 0
        Me.ClipBoard.TabStop = False
        '
        'Screenshot
        '
        Me.Screenshot.BackColor = System.Drawing.Color.White
        Me.Screenshot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Screenshot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Screenshot.Image = CType(resources.GetObject("Screenshot.Image"), System.Drawing.Image)
        Me.Screenshot.Location = New System.Drawing.Point(58, 1)
        Me.Screenshot.Name = "Screenshot"
        Me.Screenshot.Size = New System.Drawing.Size(50, 50)
        Me.Screenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Screenshot.TabIndex = 1
        Me.Screenshot.TabStop = False
        '
        'eExit
        '
        Me.eExit.BackColor = System.Drawing.Color.White
        Me.eExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.eExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.eExit.Image = CType(resources.GetObject("eExit.Image"), System.Drawing.Image)
        Me.eExit.Location = New System.Drawing.Point(114, 1)
        Me.eExit.Name = "eExit"
        Me.eExit.Size = New System.Drawing.Size(50, 50)
        Me.eExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.eExit.TabIndex = 2
        Me.eExit.TabStop = False
        '
        'NotifyIcon
        '
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "NotifyIcon"
        Me.NotifyIcon.Visible = True
        '
        'ClipShot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(167, 52)
        Me.Controls.Add(Me.eExit)
        Me.Controls.Add(Me.Screenshot)
        Me.Controls.Add(Me.ClipBoard)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 0)
        Me.Name = "ClipShot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        CType(Me.ClipBoard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Screenshot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ClipBoard As PictureBox
    Friend WithEvents Screenshot As PictureBox
    Friend WithEvents eExit As PictureBox
    Friend WithEvents NotifyIcon As NotifyIcon
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        avatar = New PictureBox()
        Timer1 = New Timer(components)
        enemy = New PictureBox()
        Brick = New PictureBox()
        enemy2 = New PictureBox()
        CType(avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(Brick, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' avatar
        ' 
        avatar.Image = CType(resources.GetObject("avatar.Image"), Image)
        avatar.Location = New Point(313, 210)
        avatar.Name = "avatar"
        avatar.Size = New Size(91, 125)
        avatar.SizeMode = PictureBoxSizeMode.StretchImage
        avatar.TabIndex = 0
        avatar.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' enemy
        ' 
        enemy.Image = My.Resources.Resources.trumppppppppp1
        enemy.Location = New Point(709, -4)
        enemy.Name = "enemy"
        enemy.Size = New Size(90, 100)
        enemy.SizeMode = PictureBoxSizeMode.StretchImage
        enemy.TabIndex = 1
        enemy.TabStop = False
        ' 
        ' Brick
        ' 
        Brick.Image = CType(resources.GetObject("Brick.Image"), Image)
        Brick.Location = New Point(459, 260)
        Brick.Name = "Brick"
        Brick.Size = New Size(66, 75)
        Brick.SizeMode = PictureBoxSizeMode.StretchImage
        Brick.TabIndex = 2
        Brick.TabStop = False
        ' 
        ' enemy2
        ' 
        enemy2.Image = My.Resources.Resources.joeeeeeeeeee
        enemy2.Location = New Point(613, -4)
        enemy2.Name = "enemy2"
        enemy2.Size = New Size(90, 100)
        enemy2.SizeMode = PictureBoxSizeMode.StretchImage
        enemy2.TabIndex = 3
        enemy2.TabStop = False
        ' 
        ' form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(enemy2)
        Controls.Add(Brick)
        Controls.Add(enemy)
        Controls.Add(avatar)
        Name = "form1"
        Text = "Form1"
        CType(avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy, ComponentModel.ISupportInitialize).EndInit()
        CType(Brick, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents avatar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents enemy As PictureBox
    Friend WithEvents Brick As PictureBox
    Friend WithEvents enemy2 As PictureBox

End Class

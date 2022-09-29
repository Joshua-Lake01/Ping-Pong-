<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LeftpaddleUp = New System.Windows.Forms.Timer(Me.components)
        Me.LeftpaddleDown = New System.Windows.Forms.Timer(Me.components)
        Me.RightPaddleUp = New System.Windows.Forms.Timer(Me.components)
        Me.RightPaddleDown = New System.Windows.Forms.Timer(Me.components)
        Me.Ballmovement = New System.Windows.Forms.Timer(Me.components)
        Me.leftpaddle = New System.Windows.Forms.PictureBox()
        Me.rightpaddle = New System.Windows.Forms.PictureBox()
        Me.ball = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.leftpaddle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rightpaddle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ball, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LeftpaddleUp
        '
        Me.LeftpaddleUp.Interval = 1
        '
        'LeftpaddleDown
        '
        Me.LeftpaddleDown.Interval = 1
        '
        'RightPaddleUp
        '
        Me.RightPaddleUp.Enabled = True
        Me.RightPaddleUp.Interval = 5
        '
        'RightPaddleDown
        '
        Me.RightPaddleDown.Interval = 5
        '
        'Ballmovement
        '
        Me.Ballmovement.Enabled = True
        Me.Ballmovement.Interval = 7
        '
        'leftpaddle
        '
        Me.leftpaddle.BackColor = System.Drawing.SystemColors.Control
        Me.leftpaddle.Location = New System.Drawing.Point(12, 264)
        Me.leftpaddle.Name = "leftpaddle"
        Me.leftpaddle.Size = New System.Drawing.Size(44, 165)
        Me.leftpaddle.TabIndex = 3
        Me.leftpaddle.TabStop = False
        '
        'rightpaddle
        '
        Me.rightpaddle.BackColor = System.Drawing.SystemColors.Control
        Me.rightpaddle.Location = New System.Drawing.Point(1119, 264)
        Me.rightpaddle.Name = "rightpaddle"
        Me.rightpaddle.Size = New System.Drawing.Size(44, 165)
        Me.rightpaddle.TabIndex = 4
        Me.rightpaddle.TabStop = False
        '
        'ball
        '
        Me.ball.BackColor = System.Drawing.SystemColors.Control
        Me.ball.Location = New System.Drawing.Point(562, 331)
        Me.ball.Name = "ball"
        Me.ball.Size = New System.Drawing.Size(29, 31)
        Me.ball.TabIndex = 5
        Me.ball.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(1117, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 51)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(12, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 51)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(374, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(397, 73)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "MAIN MENU"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(481, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 42)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "RESUME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(517, 496)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 42)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "QUIT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Lime
        Me.Label6.Location = New System.Drawing.Point(495, 387)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 42)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Settings"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Lime
        Me.Label7.Location = New System.Drawing.Point(495, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 42)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Dificulty"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Lime
        Me.Label8.Location = New System.Drawing.Point(506, 387)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 42)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Colour"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Lime
        Me.Label9.Location = New System.Drawing.Point(526, 496)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 42)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Exit"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Lime
        Me.Label10.Location = New System.Drawing.Point(392, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(353, 73)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "SETTINGS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Lime
        Me.Label11.Location = New System.Drawing.Point(517, 301)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 42)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "<"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Lime
        Me.Label12.Location = New System.Drawing.Point(583, 301)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 42)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = ">"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Lime
        Me.Label15.Location = New System.Drawing.Point(552, 301)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 42)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Lime
        Me.Label13.Location = New System.Drawing.Point(12, 688)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 42)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Menu"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1198, 739)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ball)
        Me.Controls.Add(Me.rightpaddle)
        Me.Controls.Add(Me.leftpaddle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.leftpaddle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rightpaddle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ball, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LeftpaddleUp As Timer
    Friend WithEvents LeftpaddleDown As Timer
    Friend WithEvents RightPaddleUp As Timer
    Friend WithEvents RightPaddleDown As Timer
    Friend WithEvents Ballmovement As Timer
    Friend WithEvents leftpaddle As PictureBox
    Friend WithEvents rightpaddle As PictureBox
    Friend WithEvents ball As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Label13 As Label
End Class

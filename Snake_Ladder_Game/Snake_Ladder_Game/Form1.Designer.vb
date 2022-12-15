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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Image1 = New System.Windows.Forms.PictureBox()
        Me.Dice = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dice2 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Image2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(48, 57)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(807, 657)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(900, 306)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 70)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Player 1 Role Dice"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(900, 423)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 70)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Player 2 Role Dice"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Image1
        '
        Me.Image1.BackColor = System.Drawing.Color.White
        Me.Image1.BackgroundImage = CType(resources.GetObject("Image1.BackgroundImage"), System.Drawing.Image)
        Me.Image1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Image1.Location = New System.Drawing.Point(72, 655)
        Me.Image1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(45, 43)
        Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image1.TabIndex = 3
        Me.Image1.TabStop = False
        '
        'Dice
        '
        Me.Dice.BackColor = System.Drawing.Color.White
        Me.Dice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dice.Location = New System.Drawing.Point(900, 57)
        Me.Dice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Dice.Name = "Dice"
        Me.Dice.Size = New System.Drawing.Size(227, 199)
        Me.Dice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice.TabIndex = 4
        Me.Dice.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(44, 748)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 36)
        Me.Label1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1028, 334)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Position 0"
        '
        'Dice2
        '
        Me.Dice2.BackColor = System.Drawing.Color.White
        Me.Dice2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dice2.Location = New System.Drawing.Point(900, 514)
        Me.Dice2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Dice2.Name = "Dice2"
        Me.Dice2.Size = New System.Drawing.Size(227, 199)
        Me.Dice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice2.TabIndex = 7
        Me.Dice2.TabStop = False
        '
        'Timer2
        '
        '
        'Image2
        '
        Me.Image2.BackColor = System.Drawing.Color.Black
        Me.Image2.BackgroundImage = CType(resources.GetObject("Image2.BackgroundImage"), System.Drawing.Image)
        Me.Image2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Image2.Location = New System.Drawing.Point(72, 671)
        Me.Image2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Image2.Name = "Image2"
        Me.Image2.Size = New System.Drawing.Size(45, 43)
        Me.Image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image2.TabIndex = 8
        Me.Image2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1028, 450)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Position 0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1185, 822)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Image2)
        Me.Controls.Add(Me.Dice2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Dice)
        Me.Controls.Add(Me.Image1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Image1 As PictureBox
    Friend WithEvents Dice As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Dice2 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Image2 As PictureBox
    Friend WithEvents Label3 As Label
End Class

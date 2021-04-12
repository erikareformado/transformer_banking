<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manual_menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manual_menu))
        Me.RichTextBox_Manual = New System.Windows.Forms.RichTextBox()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.PictureBox_Legend = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.picturebox_minimize = New System.Windows.Forms.PictureBox()
        Me.picturebox_close = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel.SuspendLayout()
        CType(Me.PictureBox_Legend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.picturebox_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picturebox_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox_Manual
        '
        Me.RichTextBox_Manual.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.RichTextBox_Manual.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox_Manual.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox_Manual.ForeColor = System.Drawing.Color.White
        Me.RichTextBox_Manual.Location = New System.Drawing.Point(40, 33)
        Me.RichTextBox_Manual.Name = "RichTextBox_Manual"
        Me.RichTextBox_Manual.ReadOnly = True
        Me.RichTextBox_Manual.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.RichTextBox_Manual.Size = New System.Drawing.Size(1041, 418)
        Me.RichTextBox_Manual.TabIndex = 16
        Me.RichTextBox_Manual.Text = resources.GetString("RichTextBox_Manual.Text")
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.RichTextBox_Manual)
        Me.Panel.Location = New System.Drawing.Point(4, 52)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(1079, 454)
        Me.Panel.TabIndex = 22
        '
        'PictureBox_Legend
        '
        Me.PictureBox_Legend.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox_Legend.BackgroundImage = CType(resources.GetObject("PictureBox_Legend.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox_Legend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_Legend.Location = New System.Drawing.Point(309, 101)
        Me.PictureBox_Legend.Name = "PictureBox_Legend"
        Me.PictureBox_Legend.Size = New System.Drawing.Size(562, 463)
        Me.PictureBox_Legend.TabIndex = 18
        Me.PictureBox_Legend.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(992, 516)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(39, 33)
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(949, 516)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 33)
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.picturebox_minimize)
        Me.Panel2.Controls.Add(Me.picturebox_close)
        Me.Panel2.Controls.Add(Me.PictureBox6)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(1, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1082, 63)
        Me.Panel2.TabIndex = 23
        '
        'picturebox_minimize
        '
        Me.picturebox_minimize.BackgroundImage = CType(resources.GetObject("picturebox_minimize.BackgroundImage"), System.Drawing.Image)
        Me.picturebox_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picturebox_minimize.Location = New System.Drawing.Point(1000, 21)
        Me.picturebox_minimize.Name = "picturebox_minimize"
        Me.picturebox_minimize.Size = New System.Drawing.Size(44, 25)
        Me.picturebox_minimize.TabIndex = 24
        Me.picturebox_minimize.TabStop = False
        '
        'picturebox_close
        '
        Me.picturebox_close.BackgroundImage = CType(resources.GetObject("picturebox_close.BackgroundImage"), System.Drawing.Image)
        Me.picturebox_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picturebox_close.Location = New System.Drawing.Point(1037, 21)
        Me.picturebox_close.Name = "picturebox_close"
        Me.picturebox_close.Size = New System.Drawing.Size(35, 22)
        Me.picturebox_close.TabIndex = 25
        Me.picturebox_close.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox6.Location = New System.Drawing.Point(967, 20)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(38, 30)
        Me.PictureBox6.TabIndex = 26
        Me.PictureBox6.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 25.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(79, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 46)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "MANUAL"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(21, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 57)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'manual_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1085, 561)
        Me.Controls.Add(Me.PictureBox_Legend)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "manual_menu"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "manual"
        Me.Panel.ResumeLayout(False)
        CType(Me.PictureBox_Legend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picturebox_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picturebox_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBox_Manual As RichTextBox
    Friend WithEvents Panel As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents picturebox_minimize As PictureBox
    Friend WithEvents picturebox_close As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox_Legend As PictureBox
End Class

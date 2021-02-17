<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.panel_all = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.picturebox_minimize = New System.Windows.Forms.PictureBox()
        Me.picturebox_close = New System.Windows.Forms.PictureBox()
        Me.lbl_connection_type = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.picturebox_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picturebox_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_all
        '
        Me.panel_all.AutoScroll = True
        Me.panel_all.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.panel_all.Location = New System.Drawing.Point(0, 49)
        Me.panel_all.Name = "panel_all"
        Me.panel_all.Size = New System.Drawing.Size(1125, 653)
        Me.panel_all.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.picturebox_minimize)
        Me.Panel2.Controls.Add(Me.picturebox_close)
        Me.Panel2.Controls.Add(Me.lbl_connection_type)
        Me.Panel2.Controls.Add(Me.PictureBox6)
        Me.Panel2.Location = New System.Drawing.Point(-1, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1129, 63)
        Me.Panel2.TabIndex = 16
        '
        'picturebox_minimize
        '
        Me.picturebox_minimize.BackgroundImage = CType(resources.GetObject("picturebox_minimize.BackgroundImage"), System.Drawing.Image)
        Me.picturebox_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picturebox_minimize.Location = New System.Drawing.Point(1041, 19)
        Me.picturebox_minimize.Name = "picturebox_minimize"
        Me.picturebox_minimize.Size = New System.Drawing.Size(44, 25)
        Me.picturebox_minimize.TabIndex = 27
        Me.picturebox_minimize.TabStop = False
        '
        'picturebox_close
        '
        Me.picturebox_close.BackgroundImage = CType(resources.GetObject("picturebox_close.BackgroundImage"), System.Drawing.Image)
        Me.picturebox_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picturebox_close.Location = New System.Drawing.Point(1078, 19)
        Me.picturebox_close.Name = "picturebox_close"
        Me.picturebox_close.Size = New System.Drawing.Size(35, 22)
        Me.picturebox_close.TabIndex = 28
        Me.picturebox_close.TabStop = False
        '
        'lbl_connection_type
        '
        Me.lbl_connection_type.AutoSize = True
        Me.lbl_connection_type.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_connection_type.ForeColor = System.Drawing.Color.Transparent
        Me.lbl_connection_type.Location = New System.Drawing.Point(15, 10)
        Me.lbl_connection_type.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_connection_type.Name = "lbl_connection_type"
        Me.lbl_connection_type.Size = New System.Drawing.Size(381, 45)
        Me.lbl_connection_type.TabIndex = 5
        Me.lbl_connection_type.Text = "WYE-WYE CONNECTION"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox6.Location = New System.Drawing.Point(1008, 18)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(38, 30)
        Me.PictureBox6.TabIndex = 29
        Me.PictureBox6.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1124, 700)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panel_all)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transformer Banking Trainer"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picturebox_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picturebox_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_all As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_connection_type As Label
    Friend WithEvents picturebox_minimize As PictureBox
    Friend WithEvents picturebox_close As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
End Class

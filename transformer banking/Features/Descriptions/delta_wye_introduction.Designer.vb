<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class delta_wye_introduction
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(delta_wye_introduction))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.panel_delta_wye = New System.Windows.Forms.Panel()
        Me.btn_back_wye = New System.Windows.Forms.Button()
        Me.btn_next_wye = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_delta_wye.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(19, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(492, 557)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.White
        Me.RichTextBox1.Location = New System.Drawing.Point(517, 30)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(574, 529)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'panel_delta_wye
        '
        Me.panel_delta_wye.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.panel_delta_wye.Controls.Add(Me.btn_back_wye)
        Me.panel_delta_wye.Controls.Add(Me.btn_next_wye)
        Me.panel_delta_wye.Controls.Add(Me.PictureBox1)
        Me.panel_delta_wye.Controls.Add(Me.RichTextBox1)
        Me.panel_delta_wye.Location = New System.Drawing.Point(0, 0)
        Me.panel_delta_wye.Name = "panel_delta_wye"
        Me.panel_delta_wye.Size = New System.Drawing.Size(1112, 644)
        Me.panel_delta_wye.TabIndex = 3
        '
        'btn_back_wye
        '
        Me.btn_back_wye.BackColor = System.Drawing.Color.Red
        Me.btn_back_wye.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_back_wye.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_wye.ForeColor = System.Drawing.Color.White
        Me.btn_back_wye.Location = New System.Drawing.Point(980, 585)
        Me.btn_back_wye.Name = "btn_back_wye"
        Me.btn_back_wye.Size = New System.Drawing.Size(111, 43)
        Me.btn_back_wye.TabIndex = 37
        Me.btn_back_wye.Text = "Back"
        Me.btn_back_wye.UseVisualStyleBackColor = False
        '
        'btn_next_wye
        '
        Me.btn_next_wye.BackColor = System.Drawing.Color.Black
        Me.btn_next_wye.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_next_wye.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next_wye.ForeColor = System.Drawing.Color.Red
        Me.btn_next_wye.Location = New System.Drawing.Point(848, 585)
        Me.btn_next_wye.Name = "btn_next_wye"
        Me.btn_next_wye.Size = New System.Drawing.Size(111, 43)
        Me.btn_next_wye.TabIndex = 36
        Me.btn_next_wye.Text = "Next"
        Me.btn_next_wye.UseVisualStyleBackColor = False
        '
        'delta_wye_introduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panel_delta_wye)
        Me.Name = "delta_wye_introduction"
        Me.Size = New System.Drawing.Size(1112, 644)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_delta_wye.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents panel_delta_wye As Panel
    Friend WithEvents btn_back_wye As Button
    Friend WithEvents btn_next_wye As Button
End Class

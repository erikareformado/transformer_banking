<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Output
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
        Me.txt_exam = New System.Windows.Forms.RichTextBox()
        Me.pic_primary = New System.Windows.Forms.PictureBox()
        Me.pic_secondary = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_difference_apparent = New System.Windows.Forms.TextBox()
        Me.txt_computed_apparent = New System.Windows.Forms.TextBox()
        Me.txt_measure_apparent = New System.Windows.Forms.TextBox()
        Me.txt_difference_cp = New System.Windows.Forms.TextBox()
        Me.txt_computed_cp = New System.Windows.Forms.TextBox()
        Me.txt_measure_cp = New System.Windows.Forms.TextBox()
        Me.txt_difference_cl = New System.Windows.Forms.TextBox()
        Me.txt_computed_cl = New System.Windows.Forms.TextBox()
        Me.txt_measure_cl = New System.Windows.Forms.TextBox()
        Me.txt_difference_vp = New System.Windows.Forms.TextBox()
        Me.txt_computed_vp = New System.Windows.Forms.TextBox()
        Me.txt_measure_vp = New System.Windows.Forms.TextBox()
        Me.txt_difference_vl = New System.Windows.Forms.TextBox()
        Me.txt_computed_vl = New System.Windows.Forms.TextBox()
        Me.txt_measure_vl = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.lbl_exam = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_difference_real = New System.Windows.Forms.TextBox()
        Me.txt_computed_sec_real = New System.Windows.Forms.TextBox()
        Me.txt_measure_sec_real = New System.Windows.Forms.TextBox()
        Me.txt_difference_sec_cp = New System.Windows.Forms.TextBox()
        Me.txt_computed_sec_cp = New System.Windows.Forms.TextBox()
        Me.txt_measure_sec_cp = New System.Windows.Forms.TextBox()
        Me.txt_difference_sec_cl = New System.Windows.Forms.TextBox()
        Me.txt_computed_sec_cl = New System.Windows.Forms.TextBox()
        Me.txt_measure_sec_cl = New System.Windows.Forms.TextBox()
        Me.txt_difference_sec_vp = New System.Windows.Forms.TextBox()
        Me.txt_computed_sec_vp = New System.Windows.Forms.TextBox()
        Me.txt_measure_sec_vp = New System.Windows.Forms.TextBox()
        Me.txt_difference_sec_vl = New System.Windows.Forms.TextBox()
        Me.txt_computed_sec_vl = New System.Windows.Forms.TextBox()
        Me.txt_measure_sec_vl = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_srcode = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_section = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.dt_date = New System.Windows.Forms.DateTimePicker()
        Me.btn_done = New System.Windows.Forms.Button()
        Me.btn_try_again = New System.Windows.Forms.Button()
        CType(Me.pic_primary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_secondary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_exam
        '
        Me.txt_exam.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txt_exam.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_exam.ForeColor = System.Drawing.Color.White
        Me.txt_exam.Location = New System.Drawing.Point(157, 148)
        Me.txt_exam.Name = "txt_exam"
        Me.txt_exam.Size = New System.Drawing.Size(484, 133)
        Me.txt_exam.TabIndex = 147
        Me.txt_exam.Text = ""
        '
        'pic_primary
        '
        Me.pic_primary.Location = New System.Drawing.Point(25, 310)
        Me.pic_primary.Name = "pic_primary"
        Me.pic_primary.Size = New System.Drawing.Size(359, 161)
        Me.pic_primary.TabIndex = 148
        Me.pic_primary.TabStop = False
        '
        'pic_secondary
        '
        Me.pic_secondary.Location = New System.Drawing.Point(390, 310)
        Me.pic_secondary.Name = "pic_secondary"
        Me.pic_secondary.Size = New System.Drawing.Size(359, 161)
        Me.pic_secondary.TabIndex = 149
        Me.pic_secondary.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txt_difference_apparent)
        Me.Panel1.Controls.Add(Me.txt_computed_apparent)
        Me.Panel1.Controls.Add(Me.txt_measure_apparent)
        Me.Panel1.Controls.Add(Me.txt_difference_cp)
        Me.Panel1.Controls.Add(Me.txt_computed_cp)
        Me.Panel1.Controls.Add(Me.txt_measure_cp)
        Me.Panel1.Controls.Add(Me.txt_difference_cl)
        Me.Panel1.Controls.Add(Me.txt_computed_cl)
        Me.Panel1.Controls.Add(Me.txt_measure_cl)
        Me.Panel1.Controls.Add(Me.txt_difference_vp)
        Me.Panel1.Controls.Add(Me.txt_computed_vp)
        Me.Panel1.Controls.Add(Me.txt_measure_vp)
        Me.Panel1.Controls.Add(Me.txt_difference_vl)
        Me.Panel1.Controls.Add(Me.txt_computed_vl)
        Me.Panel1.Controls.Add(Me.txt_measure_vl)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(25, 515)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(687, 177)
        Me.Panel1.TabIndex = 150
        '
        'txt_difference_apparent
        '
        Me.txt_difference_apparent.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_difference_apparent.Location = New System.Drawing.Point(560, 139)
        Me.txt_difference_apparent.Multiline = True
        Me.txt_difference_apparent.Name = "txt_difference_apparent"
        Me.txt_difference_apparent.ReadOnly = True
        Me.txt_difference_apparent.Size = New System.Drawing.Size(100, 28)
        Me.txt_difference_apparent.TabIndex = 148
        Me.txt_difference_apparent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_computed_apparent
        '
        Me.txt_computed_apparent.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_computed_apparent.Location = New System.Drawing.Point(560, 102)
        Me.txt_computed_apparent.Multiline = True
        Me.txt_computed_apparent.Name = "txt_computed_apparent"
        Me.txt_computed_apparent.Size = New System.Drawing.Size(100, 28)
        Me.txt_computed_apparent.TabIndex = 147
        Me.txt_computed_apparent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_measure_apparent
        '
        Me.txt_measure_apparent.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_measure_apparent.Location = New System.Drawing.Point(560, 63)
        Me.txt_measure_apparent.Multiline = True
        Me.txt_measure_apparent.Name = "txt_measure_apparent"
        Me.txt_measure_apparent.ReadOnly = True
        Me.txt_measure_apparent.Size = New System.Drawing.Size(100, 28)
        Me.txt_measure_apparent.TabIndex = 146
        Me.txt_measure_apparent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_difference_cp
        '
        Me.txt_difference_cp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_difference_cp.Location = New System.Drawing.Point(452, 138)
        Me.txt_difference_cp.Multiline = True
        Me.txt_difference_cp.Name = "txt_difference_cp"
        Me.txt_difference_cp.ReadOnly = True
        Me.txt_difference_cp.Size = New System.Drawing.Size(100, 28)
        Me.txt_difference_cp.TabIndex = 145
        Me.txt_difference_cp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_computed_cp
        '
        Me.txt_computed_cp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_computed_cp.Location = New System.Drawing.Point(454, 102)
        Me.txt_computed_cp.Multiline = True
        Me.txt_computed_cp.Name = "txt_computed_cp"
        Me.txt_computed_cp.Size = New System.Drawing.Size(100, 28)
        Me.txt_computed_cp.TabIndex = 144
        Me.txt_computed_cp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_measure_cp
        '
        Me.txt_measure_cp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_measure_cp.Location = New System.Drawing.Point(454, 63)
        Me.txt_measure_cp.Multiline = True
        Me.txt_measure_cp.Name = "txt_measure_cp"
        Me.txt_measure_cp.ReadOnly = True
        Me.txt_measure_cp.Size = New System.Drawing.Size(100, 28)
        Me.txt_measure_cp.TabIndex = 143
        Me.txt_measure_cp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_difference_cl
        '
        Me.txt_difference_cl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_difference_cl.Location = New System.Drawing.Point(346, 138)
        Me.txt_difference_cl.Multiline = True
        Me.txt_difference_cl.Name = "txt_difference_cl"
        Me.txt_difference_cl.ReadOnly = True
        Me.txt_difference_cl.Size = New System.Drawing.Size(100, 28)
        Me.txt_difference_cl.TabIndex = 142
        Me.txt_difference_cl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_computed_cl
        '
        Me.txt_computed_cl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_computed_cl.Location = New System.Drawing.Point(346, 102)
        Me.txt_computed_cl.Multiline = True
        Me.txt_computed_cl.Name = "txt_computed_cl"
        Me.txt_computed_cl.Size = New System.Drawing.Size(100, 28)
        Me.txt_computed_cl.TabIndex = 141
        Me.txt_computed_cl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_measure_cl
        '
        Me.txt_measure_cl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_measure_cl.Location = New System.Drawing.Point(346, 63)
        Me.txt_measure_cl.Multiline = True
        Me.txt_measure_cl.Name = "txt_measure_cl"
        Me.txt_measure_cl.ReadOnly = True
        Me.txt_measure_cl.Size = New System.Drawing.Size(100, 28)
        Me.txt_measure_cl.TabIndex = 140
        Me.txt_measure_cl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_difference_vp
        '
        Me.txt_difference_vp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_difference_vp.Location = New System.Drawing.Point(240, 138)
        Me.txt_difference_vp.Multiline = True
        Me.txt_difference_vp.Name = "txt_difference_vp"
        Me.txt_difference_vp.ReadOnly = True
        Me.txt_difference_vp.Size = New System.Drawing.Size(100, 28)
        Me.txt_difference_vp.TabIndex = 139
        Me.txt_difference_vp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_computed_vp
        '
        Me.txt_computed_vp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_computed_vp.Location = New System.Drawing.Point(240, 102)
        Me.txt_computed_vp.Multiline = True
        Me.txt_computed_vp.Name = "txt_computed_vp"
        Me.txt_computed_vp.Size = New System.Drawing.Size(100, 28)
        Me.txt_computed_vp.TabIndex = 138
        Me.txt_computed_vp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_measure_vp
        '
        Me.txt_measure_vp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_measure_vp.Location = New System.Drawing.Point(240, 63)
        Me.txt_measure_vp.Multiline = True
        Me.txt_measure_vp.Name = "txt_measure_vp"
        Me.txt_measure_vp.ReadOnly = True
        Me.txt_measure_vp.Size = New System.Drawing.Size(100, 28)
        Me.txt_measure_vp.TabIndex = 137
        Me.txt_measure_vp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_difference_vl
        '
        Me.txt_difference_vl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_difference_vl.Location = New System.Drawing.Point(131, 138)
        Me.txt_difference_vl.Multiline = True
        Me.txt_difference_vl.Name = "txt_difference_vl"
        Me.txt_difference_vl.ReadOnly = True
        Me.txt_difference_vl.Size = New System.Drawing.Size(100, 28)
        Me.txt_difference_vl.TabIndex = 136
        Me.txt_difference_vl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_computed_vl
        '
        Me.txt_computed_vl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_computed_vl.Location = New System.Drawing.Point(131, 102)
        Me.txt_computed_vl.Multiline = True
        Me.txt_computed_vl.Name = "txt_computed_vl"
        Me.txt_computed_vl.Size = New System.Drawing.Size(100, 28)
        Me.txt_computed_vl.TabIndex = 135
        Me.txt_computed_vl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_measure_vl
        '
        Me.txt_measure_vl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_measure_vl.Location = New System.Drawing.Point(131, 63)
        Me.txt_measure_vl.Multiline = True
        Me.txt_measure_vl.Name = "txt_measure_vl"
        Me.txt_measure_vl.ReadOnly = True
        Me.txt_measure_vl.Size = New System.Drawing.Size(100, 28)
        Me.txt_measure_vl.TabIndex = 134
        Me.txt_measure_vl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(15, 141)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 15)
        Me.Label10.TabIndex = 133
        Me.Label10.Text = "% Difference"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(26, 104)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 15)
        Me.Label9.TabIndex = 132
        Me.Label9.Text = "Computed"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(26, 70)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 15)
        Me.Label8.TabIndex = 131
        Me.Label8.Text = "Measured" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(562, 15)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 30)
        Me.Label7.TabIndex = 130
        Me.Label7.Text = "or Total Apparent" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Power" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(467, 23)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 129
        Me.Label6.Text = "Phase Current"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(361, 15)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 30)
        Me.Label5.TabIndex = 128
        Me.Label5.Text = "Line to Line" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Current" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(246, 23)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 15)
        Me.Label4.TabIndex = 127
        Me.Label4.Text = "Phase Voltage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(151, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 30)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "Line to Line" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Voltage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(15, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 45)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "High Voltage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Primary Side" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(26, 484)
        Me.Label35.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(195, 28)
        Me.Label35.TabIndex = 124
        Me.Label35.Text = "DATA AND RESULT"
        '
        'lbl_exam
        '
        Me.lbl_exam.AutoSize = True
        Me.lbl_exam.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_exam.ForeColor = System.Drawing.Color.White
        Me.lbl_exam.Location = New System.Drawing.Point(367, 105)
        Me.lbl_exam.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_exam.Name = "lbl_exam"
        Me.lbl_exam.Size = New System.Drawing.Size(81, 28)
        Me.lbl_exam.TabIndex = 151
        Me.lbl_exam.Text = "Exam 1"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txt_difference_real)
        Me.Panel2.Controls.Add(Me.txt_computed_sec_real)
        Me.Panel2.Controls.Add(Me.txt_measure_sec_real)
        Me.Panel2.Controls.Add(Me.txt_difference_sec_cp)
        Me.Panel2.Controls.Add(Me.txt_computed_sec_cp)
        Me.Panel2.Controls.Add(Me.txt_measure_sec_cp)
        Me.Panel2.Controls.Add(Me.txt_difference_sec_cl)
        Me.Panel2.Controls.Add(Me.txt_computed_sec_cl)
        Me.Panel2.Controls.Add(Me.txt_measure_sec_cl)
        Me.Panel2.Controls.Add(Me.txt_difference_sec_vp)
        Me.Panel2.Controls.Add(Me.txt_computed_sec_vp)
        Me.Panel2.Controls.Add(Me.txt_measure_sec_vp)
        Me.Panel2.Controls.Add(Me.txt_difference_sec_vl)
        Me.Panel2.Controls.Add(Me.txt_computed_sec_vl)
        Me.Panel2.Controls.Add(Me.txt_measure_sec_vl)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Location = New System.Drawing.Point(25, 714)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(687, 177)
        Me.Panel2.TabIndex = 152
        '
        'txt_difference_real
        '
        Me.txt_difference_real.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_difference_real.Location = New System.Drawing.Point(558, 137)
        Me.txt_difference_real.Multiline = True
        Me.txt_difference_real.Name = "txt_difference_real"
        Me.txt_difference_real.ReadOnly = True
        Me.txt_difference_real.Size = New System.Drawing.Size(100, 28)
        Me.txt_difference_real.TabIndex = 148
        Me.txt_difference_real.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_computed_sec_real
        '
        Me.txt_computed_sec_real.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_computed_sec_real.Location = New System.Drawing.Point(560, 99)
        Me.txt_computed_sec_real.Multiline = True
        Me.txt_computed_sec_real.Name = "txt_computed_sec_real"
        Me.txt_computed_sec_real.Size = New System.Drawing.Size(100, 28)
        Me.txt_computed_sec_real.TabIndex = 147
        Me.txt_computed_sec_real.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_measure_sec_real
        '
        Me.txt_measure_sec_real.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_measure_sec_real.Location = New System.Drawing.Point(560, 60)
        Me.txt_measure_sec_real.Multiline = True
        Me.txt_measure_sec_real.Name = "txt_measure_sec_real"
        Me.txt_measure_sec_real.ReadOnly = True
        Me.txt_measure_sec_real.Size = New System.Drawing.Size(100, 28)
        Me.txt_measure_sec_real.TabIndex = 146
        Me.txt_measure_sec_real.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_difference_sec_cp
        '
        Me.txt_difference_sec_cp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_difference_sec_cp.Location = New System.Drawing.Point(452, 137)
        Me.txt_difference_sec_cp.Multiline = True
        Me.txt_difference_sec_cp.Name = "txt_difference_sec_cp"
        Me.txt_difference_sec_cp.ReadOnly = True
        Me.txt_difference_sec_cp.Size = New System.Drawing.Size(100, 28)
        Me.txt_difference_sec_cp.TabIndex = 145
        Me.txt_difference_sec_cp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_computed_sec_cp
        '
        Me.txt_computed_sec_cp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_computed_sec_cp.Location = New System.Drawing.Point(454, 99)
        Me.txt_computed_sec_cp.Multiline = True
        Me.txt_computed_sec_cp.Name = "txt_computed_sec_cp"
        Me.txt_computed_sec_cp.Size = New System.Drawing.Size(100, 28)
        Me.txt_computed_sec_cp.TabIndex = 144
        Me.txt_computed_sec_cp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_measure_sec_cp
        '
        Me.txt_measure_sec_cp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_measure_sec_cp.Location = New System.Drawing.Point(454, 60)
        Me.txt_measure_sec_cp.Multiline = True
        Me.txt_measure_sec_cp.Name = "txt_measure_sec_cp"
        Me.txt_measure_sec_cp.ReadOnly = True
        Me.txt_measure_sec_cp.Size = New System.Drawing.Size(100, 28)
        Me.txt_measure_sec_cp.TabIndex = 143
        Me.txt_measure_sec_cp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_difference_sec_cl
        '
        Me.txt_difference_sec_cl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_difference_sec_cl.Location = New System.Drawing.Point(346, 137)
        Me.txt_difference_sec_cl.Multiline = True
        Me.txt_difference_sec_cl.Name = "txt_difference_sec_cl"
        Me.txt_difference_sec_cl.ReadOnly = True
        Me.txt_difference_sec_cl.Size = New System.Drawing.Size(100, 28)
        Me.txt_difference_sec_cl.TabIndex = 142
        Me.txt_difference_sec_cl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_computed_sec_cl
        '
        Me.txt_computed_sec_cl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_computed_sec_cl.Location = New System.Drawing.Point(346, 99)
        Me.txt_computed_sec_cl.Multiline = True
        Me.txt_computed_sec_cl.Name = "txt_computed_sec_cl"
        Me.txt_computed_sec_cl.Size = New System.Drawing.Size(100, 28)
        Me.txt_computed_sec_cl.TabIndex = 141
        Me.txt_computed_sec_cl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_measure_sec_cl
        '
        Me.txt_measure_sec_cl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_measure_sec_cl.Location = New System.Drawing.Point(346, 60)
        Me.txt_measure_sec_cl.Multiline = True
        Me.txt_measure_sec_cl.Name = "txt_measure_sec_cl"
        Me.txt_measure_sec_cl.ReadOnly = True
        Me.txt_measure_sec_cl.Size = New System.Drawing.Size(100, 28)
        Me.txt_measure_sec_cl.TabIndex = 140
        Me.txt_measure_sec_cl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_difference_sec_vp
        '
        Me.txt_difference_sec_vp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_difference_sec_vp.Location = New System.Drawing.Point(240, 137)
        Me.txt_difference_sec_vp.Multiline = True
        Me.txt_difference_sec_vp.Name = "txt_difference_sec_vp"
        Me.txt_difference_sec_vp.ReadOnly = True
        Me.txt_difference_sec_vp.Size = New System.Drawing.Size(100, 28)
        Me.txt_difference_sec_vp.TabIndex = 139
        Me.txt_difference_sec_vp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_computed_sec_vp
        '
        Me.txt_computed_sec_vp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_computed_sec_vp.Location = New System.Drawing.Point(240, 99)
        Me.txt_computed_sec_vp.Multiline = True
        Me.txt_computed_sec_vp.Name = "txt_computed_sec_vp"
        Me.txt_computed_sec_vp.Size = New System.Drawing.Size(100, 28)
        Me.txt_computed_sec_vp.TabIndex = 138
        Me.txt_computed_sec_vp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_measure_sec_vp
        '
        Me.txt_measure_sec_vp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_measure_sec_vp.Location = New System.Drawing.Point(240, 60)
        Me.txt_measure_sec_vp.Multiline = True
        Me.txt_measure_sec_vp.Name = "txt_measure_sec_vp"
        Me.txt_measure_sec_vp.ReadOnly = True
        Me.txt_measure_sec_vp.Size = New System.Drawing.Size(100, 28)
        Me.txt_measure_sec_vp.TabIndex = 137
        Me.txt_measure_sec_vp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_difference_sec_vl
        '
        Me.txt_difference_sec_vl.AcceptsReturn = True
        Me.txt_difference_sec_vl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_difference_sec_vl.Location = New System.Drawing.Point(131, 137)
        Me.txt_difference_sec_vl.Multiline = True
        Me.txt_difference_sec_vl.Name = "txt_difference_sec_vl"
        Me.txt_difference_sec_vl.ReadOnly = True
        Me.txt_difference_sec_vl.Size = New System.Drawing.Size(100, 28)
        Me.txt_difference_sec_vl.TabIndex = 136
        Me.txt_difference_sec_vl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_computed_sec_vl
        '
        Me.txt_computed_sec_vl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_computed_sec_vl.Location = New System.Drawing.Point(131, 99)
        Me.txt_computed_sec_vl.Multiline = True
        Me.txt_computed_sec_vl.Name = "txt_computed_sec_vl"
        Me.txt_computed_sec_vl.Size = New System.Drawing.Size(100, 28)
        Me.txt_computed_sec_vl.TabIndex = 135
        Me.txt_computed_sec_vl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_measure_sec_vl
        '
        Me.txt_measure_sec_vl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_measure_sec_vl.Location = New System.Drawing.Point(131, 60)
        Me.txt_measure_sec_vl.Multiline = True
        Me.txt_measure_sec_vl.Name = "txt_measure_sec_vl"
        Me.txt_measure_sec_vl.ReadOnly = True
        Me.txt_measure_sec_vl.Size = New System.Drawing.Size(100, 28)
        Me.txt_measure_sec_vl.TabIndex = 134
        Me.txt_measure_sec_vl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(15, 140)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 15)
        Me.Label11.TabIndex = 133
        Me.Label11.Text = "% Difference"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(26, 101)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 15)
        Me.Label12.TabIndex = 132
        Me.Label12.Text = "Computed"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(26, 67)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 15)
        Me.Label13.TabIndex = 131
        Me.Label13.Text = "Measured" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(572, 12)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 30)
        Me.Label14.TabIndex = 130
        Me.Label14.Text = "or Total Real" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Power" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(467, 20)
        Me.Label15.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 15)
        Me.Label15.TabIndex = 129
        Me.Label15.Text = "Phase Current"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(361, 12)
        Me.Label16.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 30)
        Me.Label16.TabIndex = 128
        Me.Label16.Text = "Line to Line" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Current" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(246, 20)
        Me.Label17.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 15)
        Me.Label17.TabIndex = 127
        Me.Label17.Text = "Phase Voltage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(151, 12)
        Me.Label18.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 30)
        Me.Label18.TabIndex = 126
        Me.Label18.Text = "Line to Line" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Voltage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(15, 5)
        Me.Label19.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 45)
        Me.Label19.TabIndex = 125
        Me.Label19.Text = "Low Voltage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Primary Side" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(73, 12)
        Me.txt_name.Multiline = True
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(205, 28)
        Me.txt_name.TabIndex = 154
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(24, 19)
        Me.Label20.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 15)
        Me.Label20.TabIndex = 153
        Me.Label20.Text = "Name:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_srcode
        '
        Me.txt_srcode.Location = New System.Drawing.Point(73, 46)
        Me.txt_srcode.Multiline = True
        Me.txt_srcode.Name = "txt_srcode"
        Me.txt_srcode.Size = New System.Drawing.Size(205, 28)
        Me.txt_srcode.TabIndex = 156
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(13, 53)
        Me.Label21.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 15)
        Me.Label21.TabIndex = 155
        Me.Label21.Text = "SR Code:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(502, 19)
        Me.Label22.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(52, 15)
        Me.Label22.TabIndex = 157
        Me.Label22.Text = "Section:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_section
        '
        Me.txt_section.Location = New System.Drawing.Point(560, 12)
        Me.txt_section.Multiline = True
        Me.txt_section.Name = "txt_section"
        Me.txt_section.Size = New System.Drawing.Size(205, 28)
        Me.txt_section.TabIndex = 158
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(517, 53)
        Me.Label23.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(37, 15)
        Me.Label23.TabIndex = 159
        Me.Label23.Text = "Date:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dt_date
        '
        Me.dt_date.CustomFormat = "MM/dd/yyyy"
        Me.dt_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_date.Location = New System.Drawing.Point(560, 48)
        Me.dt_date.Name = "dt_date"
        Me.dt_date.Size = New System.Drawing.Size(200, 20)
        Me.dt_date.TabIndex = 160
        '
        'btn_done
        '
        Me.btn_done.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_done.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_done.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_done.ForeColor = System.Drawing.Color.White
        Me.btn_done.Location = New System.Drawing.Point(236, 906)
        Me.btn_done.Name = "btn_done"
        Me.btn_done.Size = New System.Drawing.Size(163, 45)
        Me.btn_done.TabIndex = 161
        Me.btn_done.Text = "EXPORT"
        Me.btn_done.UseVisualStyleBackColor = False
        '
        'btn_try_again
        '
        Me.btn_try_again.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_try_again.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_try_again.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_try_again.ForeColor = System.Drawing.Color.Red
        Me.btn_try_again.Location = New System.Drawing.Point(415, 906)
        Me.btn_try_again.Name = "btn_try_again"
        Me.btn_try_again.Size = New System.Drawing.Size(163, 45)
        Me.btn_try_again.TabIndex = 162
        Me.btn_try_again.Text = "CANCEL"
        Me.btn_try_again.UseVisualStyleBackColor = False
        '
        'Output
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(783, 513)
        Me.Controls.Add(Me.btn_try_again)
        Me.Controls.Add(Me.btn_done)
        Me.Controls.Add(Me.dt_date)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txt_section)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txt_srcode)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lbl_exam)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pic_secondary)
        Me.Controls.Add(Me.pic_primary)
        Me.Controls.Add(Me.txt_exam)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Output"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DATA AND RESULTS"
        CType(Me.pic_primary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_secondary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_exam As RichTextBox
    Friend WithEvents pic_primary As PictureBox
    Friend WithEvents pic_secondary As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_difference_apparent As TextBox
    Friend WithEvents txt_computed_apparent As TextBox
    Friend WithEvents txt_measure_apparent As TextBox
    Friend WithEvents txt_difference_cp As TextBox
    Friend WithEvents txt_computed_cp As TextBox
    Friend WithEvents txt_measure_cp As TextBox
    Friend WithEvents txt_difference_cl As TextBox
    Friend WithEvents txt_computed_cl As TextBox
    Friend WithEvents txt_measure_cl As TextBox
    Friend WithEvents txt_difference_vp As TextBox
    Friend WithEvents txt_computed_vp As TextBox
    Friend WithEvents txt_measure_vp As TextBox
    Friend WithEvents txt_difference_vl As TextBox
    Friend WithEvents txt_computed_vl As TextBox
    Friend WithEvents txt_measure_vl As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents lbl_exam As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_difference_real As TextBox
    Friend WithEvents txt_computed_sec_real As TextBox
    Friend WithEvents txt_measure_sec_real As TextBox
    Friend WithEvents txt_difference_sec_cp As TextBox
    Friend WithEvents txt_computed_sec_cp As TextBox
    Friend WithEvents txt_measure_sec_cp As TextBox
    Friend WithEvents txt_difference_sec_cl As TextBox
    Friend WithEvents txt_computed_sec_cl As TextBox
    Friend WithEvents txt_measure_sec_cl As TextBox
    Friend WithEvents txt_difference_sec_vp As TextBox
    Friend WithEvents txt_computed_sec_vp As TextBox
    Friend WithEvents txt_measure_sec_vp As TextBox
    Friend WithEvents txt_difference_sec_vl As TextBox
    Friend WithEvents txt_computed_sec_vl As TextBox
    Friend WithEvents txt_measure_sec_vl As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_srcode As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txt_section As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents dt_date As DateTimePicker
    Friend WithEvents btn_done As Button
    Friend WithEvents btn_try_again As Button
End Class

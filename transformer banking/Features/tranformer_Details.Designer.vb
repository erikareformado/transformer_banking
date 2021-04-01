<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tranformer_Details
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
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_done = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panel_delta_wye = New System.Windows.Forms.Panel()
        Me.txt_secondary_voltage = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_primary_voltage = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_rating = New System.Windows.Forms.ComboBox()
        Me.cmb_polarity = New System.Windows.Forms.ComboBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbox_frequency = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.panel_delta_wye.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Red
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_back.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_back.ForeColor = System.Drawing.Color.AliceBlue
        Me.btn_back.Location = New System.Drawing.Point(586, 445)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(108, 40)
        Me.btn_back.TabIndex = 27
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_done
        '
        Me.btn_done.BackColor = System.Drawing.Color.Black
        Me.btn_done.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_done.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_done.ForeColor = System.Drawing.Color.Red
        Me.btn_done.Location = New System.Drawing.Point(468, 445)
        Me.btn_done.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn_done.Name = "btn_done"
        Me.btn_done.Size = New System.Drawing.Size(108, 40)
        Me.btn_done.TabIndex = 26
        Me.btn_done.Text = "Done"
        Me.btn_done.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(433, 87)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 29)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "EDIT TRANSFORMER"
        '
        'panel_delta_wye
        '
        Me.panel_delta_wye.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.panel_delta_wye.Controls.Add(Me.txt_secondary_voltage)
        Me.panel_delta_wye.Controls.Add(Me.Label8)
        Me.panel_delta_wye.Controls.Add(Me.txt_primary_voltage)
        Me.panel_delta_wye.Controls.Add(Me.Label7)
        Me.panel_delta_wye.Controls.Add(Me.cmb_rating)
        Me.panel_delta_wye.Controls.Add(Me.cmb_polarity)
        Me.panel_delta_wye.Controls.Add(Me.TextBox5)
        Me.panel_delta_wye.Controls.Add(Me.Label6)
        Me.panel_delta_wye.Controls.Add(Me.txtbox_frequency)
        Me.panel_delta_wye.Controls.Add(Me.Label5)
        Me.panel_delta_wye.Controls.Add(Me.Label4)
        Me.panel_delta_wye.Controls.Add(Me.Label3)
        Me.panel_delta_wye.Controls.Add(Me.TextBox1)
        Me.panel_delta_wye.Controls.Add(Me.Label9)
        Me.panel_delta_wye.Location = New System.Drawing.Point(240, 101)
        Me.panel_delta_wye.Name = "panel_delta_wye"
        Me.panel_delta_wye.Size = New System.Drawing.Size(651, 337)
        Me.panel_delta_wye.TabIndex = 28
        '
        'txt_secondary_voltage
        '
        Me.txt_secondary_voltage.BackColor = System.Drawing.Color.Snow
        Me.txt_secondary_voltage.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_secondary_voltage.Location = New System.Drawing.Point(211, 118)
        Me.txt_secondary_voltage.Multiline = True
        Me.txt_secondary_voltage.Name = "txt_secondary_voltage"
        Me.txt_secondary_voltage.Size = New System.Drawing.Size(315, 28)
        Me.txt_secondary_voltage.TabIndex = 29
        Me.txt_secondary_voltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(53, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 21)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Secondary Voltage:"
        '
        'txt_primary_voltage
        '
        Me.txt_primary_voltage.BackColor = System.Drawing.Color.Snow
        Me.txt_primary_voltage.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_primary_voltage.Location = New System.Drawing.Point(211, 84)
        Me.txt_primary_voltage.Multiline = True
        Me.txt_primary_voltage.Name = "txt_primary_voltage"
        Me.txt_primary_voltage.Size = New System.Drawing.Size(315, 28)
        Me.txt_primary_voltage.TabIndex = 27
        Me.txt_primary_voltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(75, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 21)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Primary Voltage:"
        '
        'cmb_rating
        '
        Me.cmb_rating.BackColor = System.Drawing.Color.Snow
        Me.cmb_rating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_rating.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmb_rating.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_rating.FormattingEnabled = True
        Me.cmb_rating.Items.AddRange(New Object() {"10 kVA", "25 kVA", "37.5 kVA", "50 kVA", "75 kVA"})
        Me.cmb_rating.Location = New System.Drawing.Point(211, 191)
        Me.cmb_rating.Name = "cmb_rating"
        Me.cmb_rating.Size = New System.Drawing.Size(315, 33)
        Me.cmb_rating.TabIndex = 25
        '
        'cmb_polarity
        '
        Me.cmb_polarity.BackColor = System.Drawing.Color.Snow
        Me.cmb_polarity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_polarity.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmb_polarity.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_polarity.FormattingEnabled = True
        Me.cmb_polarity.Items.AddRange(New Object() {"Additive", "Subtractive"})
        Me.cmb_polarity.Location = New System.Drawing.Point(211, 152)
        Me.cmb_polarity.Name = "cmb_polarity"
        Me.cmb_polarity.Size = New System.Drawing.Size(315, 33)
        Me.cmb_polarity.TabIndex = 24
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Snow
        Me.TextBox5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(211, 264)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(315, 28)
        Me.TextBox5.TabIndex = 23
        Me.TextBox5.Text = "2%"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(92, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 21)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "% Impedance:"
        '
        'txtbox_frequency
        '
        Me.txtbox_frequency.BackColor = System.Drawing.Color.Snow
        Me.txtbox_frequency.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_frequency.Location = New System.Drawing.Point(211, 230)
        Me.txtbox_frequency.Multiline = True
        Me.txtbox_frequency.Name = "txtbox_frequency"
        Me.txtbox_frequency.ReadOnly = True
        Me.txtbox_frequency.Size = New System.Drawing.Size(315, 28)
        Me.txtbox_frequency.TabIndex = 21
        Me.txtbox_frequency.Text = "60%"
        Me.txtbox_frequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(108, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 21)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Frequency:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(137, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 21)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Rating:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(137, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 21)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Polarity:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Snow
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(211, 50)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(315, 28)
        Me.TextBox1.TabIndex = 17
        Me.TextBox1.Text = "Distribution Transformer"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(42, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 21)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Type of Transformer:"
        '
        'tranformer_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.panel_delta_wye)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_done)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "tranformer_Details"
        Me.Size = New System.Drawing.Size(1112, 644)
        Me.panel_delta_wye.ResumeLayout(False)
        Me.panel_delta_wye.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_done As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents panel_delta_wye As Panel
    Friend WithEvents txt_secondary_voltage As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_primary_voltage As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_rating As ComboBox
    Friend WithEvents cmb_polarity As ComboBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbox_frequency As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
End Class

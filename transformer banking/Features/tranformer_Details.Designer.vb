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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel_delta_wye = New System.Windows.Forms.Panel()
        Me.cmb_rating = New System.Windows.Forms.ComboBox()
        Me.cmb_polarity = New System.Windows.Forms.ComboBox()
        Me.txt_impedance = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_frequency = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_type_transformer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_done = New System.Windows.Forms.Button()
        Me.panel_delta_wye.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(430, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 29)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "EDIT TRANSFORMER"
        '
        'panel_delta_wye
        '
        Me.panel_delta_wye.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.panel_delta_wye.Controls.Add(Me.cmb_rating)
        Me.panel_delta_wye.Controls.Add(Me.cmb_polarity)
        Me.panel_delta_wye.Controls.Add(Me.txt_impedance)
        Me.panel_delta_wye.Controls.Add(Me.Label6)
        Me.panel_delta_wye.Controls.Add(Me.txt_frequency)
        Me.panel_delta_wye.Controls.Add(Me.Label5)
        Me.panel_delta_wye.Controls.Add(Me.Label4)
        Me.panel_delta_wye.Controls.Add(Me.Label3)
        Me.panel_delta_wye.Controls.Add(Me.txt_type_transformer)
        Me.panel_delta_wye.Controls.Add(Me.Label2)
        Me.panel_delta_wye.Location = New System.Drawing.Point(236, 52)
        Me.panel_delta_wye.Name = "panel_delta_wye"
        Me.panel_delta_wye.Size = New System.Drawing.Size(639, 494)
        Me.panel_delta_wye.TabIndex = 17
        '
        'cmb_rating
        '
        Me.cmb_rating.BackColor = System.Drawing.Color.Snow
        Me.cmb_rating.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmb_rating.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.cmb_rating.FormattingEnabled = True
        Me.cmb_rating.Items.AddRange(New Object() {"10 kVA", "25 kVA", "37.5 kVA", "50 kVA", "75 kVA"})
        Me.cmb_rating.Location = New System.Drawing.Point(191, 242)
        Me.cmb_rating.Name = "cmb_rating"
        Me.cmb_rating.Size = New System.Drawing.Size(416, 36)
        Me.cmb_rating.TabIndex = 25
        '
        'cmb_polarity
        '
        Me.cmb_polarity.BackColor = System.Drawing.Color.Snow
        Me.cmb_polarity.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmb_polarity.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.cmb_polarity.FormattingEnabled = True
        Me.cmb_polarity.Items.AddRange(New Object() {"Additive", "Subtractive"})
        Me.cmb_polarity.Location = New System.Drawing.Point(191, 160)
        Me.cmb_polarity.Name = "cmb_polarity"
        Me.cmb_polarity.Size = New System.Drawing.Size(416, 36)
        Me.cmb_polarity.TabIndex = 24
        '
        'txt_impedance
        '
        Me.txt_impedance.BackColor = System.Drawing.Color.Snow
        Me.txt_impedance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_impedance.Location = New System.Drawing.Point(191, 401)
        Me.txt_impedance.Multiline = True
        Me.txt_impedance.Name = "txt_impedance"
        Me.txt_impedance.Size = New System.Drawing.Size(416, 32)
        Me.txt_impedance.TabIndex = 23
        Me.txt_impedance.Text = "2%"
        Me.txt_impedance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(71, 407)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 21)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "% Impedance:"
        '
        'txt_frequency
        '
        Me.txt_frequency.BackColor = System.Drawing.Color.Snow
        Me.txt_frequency.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_frequency.Location = New System.Drawing.Point(191, 323)
        Me.txt_frequency.Multiline = True
        Me.txt_frequency.Name = "txt_frequency"
        Me.txt_frequency.ReadOnly = True
        Me.txt_frequency.Size = New System.Drawing.Size(416, 32)
        Me.txt_frequency.TabIndex = 21
        Me.txt_frequency.Text = "60"
        Me.txt_frequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(95, 328)
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
        Me.Label4.Location = New System.Drawing.Point(122, 247)
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
        Me.Label3.Location = New System.Drawing.Point(118, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 21)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Polarity:"
        '
        'txt_type_transformer
        '
        Me.txt_type_transformer.BackColor = System.Drawing.Color.Snow
        Me.txt_type_transformer.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_type_transformer.Location = New System.Drawing.Point(191, 79)
        Me.txt_type_transformer.Multiline = True
        Me.txt_type_transformer.Name = "txt_type_transformer"
        Me.txt_type_transformer.Size = New System.Drawing.Size(416, 32)
        Me.txt_type_transformer.TabIndex = 17
        Me.txt_type_transformer.Text = "Distribution Transformer"
        Me.txt_type_transformer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 21)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Type of Transformer:"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Red
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_back.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_back.ForeColor = System.Drawing.Color.AliceBlue
        Me.btn_back.Location = New System.Drawing.Point(983, 577)
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
        Me.btn_done.Location = New System.Drawing.Point(865, 577)
        Me.btn_done.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn_done.Name = "btn_done"
        Me.btn_done.Size = New System.Drawing.Size(108, 40)
        Me.btn_done.TabIndex = 26
        Me.btn_done.Text = "Done"
        Me.btn_done.UseVisualStyleBackColor = False
        '
        'tranformer_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Controls.Add(Me.Label1)
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

    Friend WithEvents Label1 As Label
    Friend WithEvents panel_delta_wye As Panel
    Friend WithEvents cmb_rating As ComboBox
    Friend WithEvents cmb_polarity As ComboBox
    Friend WithEvents txt_impedance As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_frequency As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_type_transformer As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_done As Button
End Class

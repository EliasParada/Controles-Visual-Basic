<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forms
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTextBox = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gpbTextBox = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.gpbComboBox = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gpbNumeric = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gpbTextBox.SuspendLayout()
        Me.gpbComboBox.SuspendLayout()
        Me.gpbNumeric.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Controles Visual Basic"
        '
        'lblTextBox
        '
        Me.lblTextBox.AutoSize = True
        Me.lblTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblTextBox.Location = New System.Drawing.Point(46, 48)
        Me.lblTextBox.Name = "lblTextBox"
        Me.lblTextBox.Size = New System.Drawing.Size(68, 22)
        Me.lblTextBox.TabIndex = 1
        Me.lblTextBox.Text = "TextBox"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(120, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ComboBox"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(215, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "NumericUpDown"
        '
        'gpbTextBox
        '
        Me.gpbTextBox.Controls.Add(Me.Label6)
        Me.gpbTextBox.Controls.Add(Me.Label5)
        Me.gpbTextBox.Controls.Add(Me.TextBox2)
        Me.gpbTextBox.Controls.Add(Me.TextBox1)
        Me.gpbTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbTextBox.Location = New System.Drawing.Point(12, 73)
        Me.gpbTextBox.Name = "gpbTextBox"
        Me.gpbTextBox.Size = New System.Drawing.Size(352, 214)
        Me.gpbTextBox.TabIndex = 4
        Me.gpbTextBox.TabStop = False
        Me.gpbTextBox.Text = "TextBox"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(90, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "TextBox en multiples lineas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(90, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "TextBox en una sola linea"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(93, 106)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(151, 82)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(93, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(151, 20)
        Me.TextBox1.TabIndex = 0
        '
        'gpbComboBox
        '
        Me.gpbComboBox.Controls.Add(Me.Label8)
        Me.gpbComboBox.Controls.Add(Me.ComboBox3)
        Me.gpbComboBox.Controls.Add(Me.ComboBox2)
        Me.gpbComboBox.Controls.Add(Me.ComboBox1)
        Me.gpbComboBox.Controls.Add(Me.Label7)
        Me.gpbComboBox.Controls.Add(Me.Label2)
        Me.gpbComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbComboBox.Location = New System.Drawing.Point(377, 73)
        Me.gpbComboBox.Name = "gpbComboBox"
        Me.gpbComboBox.Size = New System.Drawing.Size(352, 214)
        Me.gpbComboBox.TabIndex = 5
        Me.gpbComboBox.TabStop = False
        Me.gpbComboBox.Text = "ComboBox"
        Me.gpbComboBox.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(107, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "ComboBox con Simple"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Manzanas", "Peras", "Sandias", "Melones"})
        Me.ComboBox3.Location = New System.Drawing.Point(110, 116)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 85)
        Me.ComboBox3.TabIndex = 6
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Patatas", "Zanahorias", "Yuca"})
        Me.ComboBox2.Location = New System.Drawing.Point(206, 54)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Amburguesa", "Pizza", "Pollo", "Lechuga"})
        Me.ComboBox1.Location = New System.Drawing.Point(18, 54)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(172, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "ComboBox con DropDownList"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ComboBox en DropDown"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(114, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "NumericUpDown"
        '
        'gpbNumeric
        '
        Me.gpbNumeric.Controls.Add(Me.Label10)
        Me.gpbNumeric.Controls.Add(Me.NumericUpDown2)
        Me.gpbNumeric.Controls.Add(Me.NumericUpDown1)
        Me.gpbNumeric.Controls.Add(Me.Label9)
        Me.gpbNumeric.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbNumeric.Location = New System.Drawing.Point(23, 292)
        Me.gpbNumeric.Name = "gpbNumeric"
        Me.gpbNumeric.Size = New System.Drawing.Size(352, 214)
        Me.gpbNumeric.TabIndex = 8
        Me.gpbNumeric.TabStop = False
        Me.gpbNumeric.Text = "NumericUpDown"
        Me.gpbNumeric.Visible = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(108, 55)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 8
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(108, 117)
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown2.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(67, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(219, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "NumericUpDown con limite menor a 0"
        '
        'Forms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(387, 299)
        Me.Controls.Add(Me.gpbNumeric)
        Me.Controls.Add(Me.gpbComboBox)
        Me.Controls.Add(Me.gpbTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Forms"
        Me.Text = "Controles Visual Basic"
        Me.gpbTextBox.ResumeLayout(False)
        Me.gpbTextBox.PerformLayout()
        Me.gpbComboBox.ResumeLayout(False)
        Me.gpbComboBox.PerformLayout()
        Me.gpbNumeric.ResumeLayout(False)
        Me.gpbNumeric.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblTextBox As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents gpbTextBox As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents gpbComboBox As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents gpbNumeric As GroupBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label10 As Label
End Class

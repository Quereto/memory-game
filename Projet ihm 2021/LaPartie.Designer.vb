<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LaPartie
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LaPartieLabel = New System.Windows.Forms.LinkLabel()
        Me.JoueurActuel = New System.Windows.Forms.Label()
        Me.labelVotrepseudo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTimers = New System.Windows.Forms.Label()
        Me.txtTemps = New System.Windows.Forms.Label()
        Me.txtAbandon = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnAide2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LaPartieLabel
        '
        Me.LaPartieLabel.AutoSize = True
        Me.LaPartieLabel.Location = New System.Drawing.Point(680, 16)
        Me.LaPartieLabel.Name = "LaPartieLabel"
        Me.LaPartieLabel.Size = New System.Drawing.Size(46, 13)
        Me.LaPartieLabel.TabIndex = 0
        Me.LaPartieLabel.TabStop = True
        Me.LaPartieLabel.Text = "LaPartie"
        Me.LaPartieLabel.Visible = False
        '
        'JoueurActuel
        '
        Me.JoueurActuel.AutoSize = True
        Me.JoueurActuel.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JoueurActuel.Location = New System.Drawing.Point(135, 29)
        Me.JoueurActuel.Name = "JoueurActuel"
        Me.JoueurActuel.Size = New System.Drawing.Size(148, 21)
        Me.JoueurActuel.TabIndex = 1
        Me.JoueurActuel.Text = "LabelJoueurActuel"
        '
        'labelVotrepseudo
        '
        Me.labelVotrepseudo.AutoSize = True
        Me.labelVotrepseudo.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelVotrepseudo.Location = New System.Drawing.Point(6, 29)
        Me.labelVotrepseudo.Name = "labelVotrepseudo"
        Me.labelVotrepseudo.Size = New System.Drawing.Size(123, 21)
        Me.labelVotrepseudo.TabIndex = 2
        Me.labelVotrepseudo.Text = "Votre pseudo :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAide2)
        Me.GroupBox1.Controls.Add(Me.txtTimers)
        Me.GroupBox1.Controls.Add(Me.txtTemps)
        Me.GroupBox1.Controls.Add(Me.txtAbandon)
        Me.GroupBox1.Controls.Add(Me.labelVotrepseudo)
        Me.GroupBox1.Controls.Add(Me.JoueurActuel)
        Me.GroupBox1.Controls.Add(Me.LaPartieLabel)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(534, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info joueur"
        '
        'txtTimers
        '
        Me.txtTimers.AutoSize = True
        Me.txtTimers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimers.Location = New System.Drawing.Point(477, 16)
        Me.txtTimers.Name = "txtTimers"
        Me.txtTimers.Size = New System.Drawing.Size(45, 16)
        Me.txtTimers.TabIndex = 5
        Me.txtTimers.Text = "temps"
        '
        'txtTemps
        '
        Me.txtTemps.AutoSize = True
        Me.txtTemps.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemps.Location = New System.Drawing.Point(415, 13)
        Me.txtTemps.Name = "txtTemps"
        Me.txtTemps.Size = New System.Drawing.Size(56, 17)
        Me.txtTemps.TabIndex = 4
        Me.txtTemps.Text = "Temps :"
        '
        'txtAbandon
        '
        Me.txtAbandon.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbandon.Location = New System.Drawing.Point(444, 38)
        Me.txtAbandon.Name = "txtAbandon"
        Me.txtAbandon.Size = New System.Drawing.Size(78, 34)
        Me.txtAbandon.TabIndex = 3
        Me.txtAbandon.Text = "Abandon"
        Me.txtAbandon.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label20, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label19, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label18, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Webdings", 75.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 100)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(534, 441)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Label20
        '
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label20.Font = New System.Drawing.Font("Webdings", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label20.Location = New System.Drawing.Point(429, 329)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 110)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "c"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label19.Font = New System.Drawing.Font("Webdings", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label19.Location = New System.Drawing.Point(323, 329)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(98, 110)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "c"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label18.Font = New System.Drawing.Font("Webdings", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label18.Location = New System.Drawing.Point(217, 329)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(98, 110)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "c"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Font = New System.Drawing.Font("Webdings", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label17.Location = New System.Drawing.Point(111, 329)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 110)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "c"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.Font = New System.Drawing.Font("Webdings", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label16.Location = New System.Drawing.Point(5, 329)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 110)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "c"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Font = New System.Drawing.Font("Webdings", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label15.Location = New System.Drawing.Point(429, 220)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 107)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "c"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Font = New System.Drawing.Font("Webdings", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label14.Location = New System.Drawing.Point(323, 220)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 107)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "c"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("Webdings", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label13.Location = New System.Drawing.Point(217, 220)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 107)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "c"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("Webdings", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label12.Location = New System.Drawing.Point(111, 220)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 107)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "c"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Webdings", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 220)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 107)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "c"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Webdings", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label10.Location = New System.Drawing.Point(429, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 107)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "c"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Webdings", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label9.Location = New System.Drawing.Point(323, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 107)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "c"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Webdings", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label8.Location = New System.Drawing.Point(217, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 107)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "c"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Webdings", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label7.Location = New System.Drawing.Point(111, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 107)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "c"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Webdings", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 107)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "c"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Webdings", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label5.Location = New System.Drawing.Point(429, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 107)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "c"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Webdings", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label4.Location = New System.Drawing.Point(323, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 107)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "c"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Webdings", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label3.Location = New System.Drawing.Point(217, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 107)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "c"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Webdings", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label2.Location = New System.Drawing.Point(111, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 107)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "c"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Webdings", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 107)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "c"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'btnAide2
        '
        Me.btnAide2.Location = New System.Drawing.Point(10, 62)
        Me.btnAide2.Name = "btnAide2"
        Me.btnAide2.Size = New System.Drawing.Size(60, 23)
        Me.btnAide2.TabIndex = 6
        Me.btnAide2.Text = "Aide"
        Me.btnAide2.UseVisualStyleBackColor = True
        '
        'LaPartie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 541)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LaPartie"
        Me.Text = "LaPartie"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LaPartieLabel As LinkLabel
    Friend WithEvents JoueurActuel As Label
    Friend WithEvents labelVotrepseudo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAbandon As Button
    Friend WithEvents txtTemps As Label
    Friend WithEvents txtTimers As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btnAide2 As Button
End Class

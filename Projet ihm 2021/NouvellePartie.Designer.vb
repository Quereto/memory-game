<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NouvellePartie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NouvellePartie))
        Me.NouvellePartieLabel = New System.Windows.Forms.LinkLabel()
        Me.imageLogo = New System.Windows.Forms.PictureBox()
        Me.ComboxPseudo = New System.Windows.Forms.ComboBox()
        Me.btnLancement = New System.Windows.Forms.Button()
        Me.TextVotrePseudo = New System.Windows.Forms.Label()
        Me.btnAide = New System.Windows.Forms.Button()
        CType(Me.imageLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NouvellePartieLabel
        '
        Me.NouvellePartieLabel.AutoSize = True
        Me.NouvellePartieLabel.Location = New System.Drawing.Point(668, 228)
        Me.NouvellePartieLabel.Name = "NouvellePartieLabel"
        Me.NouvellePartieLabel.Size = New System.Drawing.Size(120, 13)
        Me.NouvellePartieLabel.TabIndex = 0
        Me.NouvellePartieLabel.TabStop = True
        Me.NouvellePartieLabel.Text = "RedirectionMenuJoueur"
        Me.NouvellePartieLabel.Visible = False
        '
        'imageLogo
        '
        Me.imageLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.imageLogo.Image = CType(resources.GetObject("imageLogo.Image"), System.Drawing.Image)
        Me.imageLogo.Location = New System.Drawing.Point(0, 0)
        Me.imageLogo.Name = "imageLogo"
        Me.imageLogo.Size = New System.Drawing.Size(800, 225)
        Me.imageLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.imageLogo.TabIndex = 2
        Me.imageLogo.TabStop = False
        '
        'ComboxPseudo
        '
        Me.ComboxPseudo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboxPseudo.FormattingEnabled = True
        Me.ComboxPseudo.Location = New System.Drawing.Point(85, 283)
        Me.ComboxPseudo.Name = "ComboxPseudo"
        Me.ComboxPseudo.Size = New System.Drawing.Size(422, 28)
        Me.ComboxPseudo.TabIndex = 3
        '
        'btnLancement
        '
        Me.btnLancement.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLancement.Location = New System.Drawing.Point(619, 361)
        Me.btnLancement.Name = "btnLancement"
        Me.btnLancement.Size = New System.Drawing.Size(169, 77)
        Me.btnLancement.TabIndex = 4
        Me.btnLancement.Text = "Validé et lancer la partie !"
        Me.btnLancement.UseVisualStyleBackColor = True
        '
        'TextVotrePseudo
        '
        Me.TextVotrePseudo.AutoSize = True
        Me.TextVotrePseudo.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextVotrePseudo.Location = New System.Drawing.Point(12, 255)
        Me.TextVotrePseudo.Name = "TextVotrePseudo"
        Me.TextVotrePseudo.Size = New System.Drawing.Size(559, 25)
        Me.TextVotrePseudo.TabIndex = 6
        Me.TextVotrePseudo.Text = "Veuillez entrer un pseudo ou sélectionner un déjà enregistrer"
        '
        'btnAide
        '
        Me.btnAide.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAide.Location = New System.Drawing.Point(12, 413)
        Me.btnAide.Name = "btnAide"
        Me.btnAide.Size = New System.Drawing.Size(59, 33)
        Me.btnAide.TabIndex = 7
        Me.btnAide.Text = "Aide"
        Me.btnAide.UseVisualStyleBackColor = True
        '
        'NouvellePartie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAide)
        Me.Controls.Add(Me.TextVotrePseudo)
        Me.Controls.Add(Me.btnLancement)
        Me.Controls.Add(Me.ComboxPseudo)
        Me.Controls.Add(Me.imageLogo)
        Me.Controls.Add(Me.NouvellePartieLabel)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "NouvellePartie"
        Me.Text = "NouvellePartie"
        CType(Me.imageLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NouvellePartieLabel As LinkLabel
    Friend WithEvents imageLogo As PictureBox
    Friend WithEvents ComboxPseudo As ComboBox
    Friend WithEvents btnLancement As Button
    Friend WithEvents TextVotrePseudo As Label
    Friend WithEvents btnAide As Button
End Class

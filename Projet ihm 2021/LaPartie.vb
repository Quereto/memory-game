Public Class LaPartie

    Dim random As New Random

    Private PremierClique As Label = Nothing
    Private SecondClique As Label = Nothing


    Private TargetDT As DateTime
    Private CountDOwnFrom As TimeSpan = TimeSpan.FromMinutes(1)


    'List permettent d'attribuer une lettre pour chaque emplacements de place ce qui permet avec la police Webdings qui est une police d'emotes '
    Private icons = New List(Of String) From {"!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z", "h", "h", "ü", "ü"}

    Private Sub PseudoJoueurActuel_Click(sender As Object, e As EventArgs)
        'affiche le nom du pseudo sur la page'
        JoueurActuel.Text = NouvellePartie.ComboxPseudo.Text

    End Sub

    Private Sub AttributionIcons()

        'attribut pour chaque label une icone de facon aléatoire '
        For Each control In TableLayoutPanel1.Controls
            Dim iconLabel = TryCast(control, Label)
            If iconLabel IsNot Nothing Then
                Dim nbrRandom = random.Next(icons.Count)
                iconLabel.Text = icons(nbrRandom)
                iconLabel.ForeColor = iconLabel.BackColor
                icons.RemoveAt(nbrRandom)
            End If
        Next

    End Sub


    'charge au lancement du formulaire quelque variable nécessaire au bon fonctionnement du jeu'
    Private Sub LaPartie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AttributionIcons()
        Timer2.Interval = 100
        TargetDT = DateTime.Now.Add(CountDOwnFrom)
        JoueurActuel.Text = NouvellePartie.ComboxPseudo.Text
    End Sub


    'permet de rendre les labels cliquable'
    Private Sub label_Click(ByVal sender As System.Object,
                        ByVal e As System.EventArgs) Handles Label20.Click,
    Label19.Click, Label18.Click, Label17.Click, Label16.Click, Label15.Click, Label14.Click,
    Label13.Click, Label12.Click, Label11.Click, Label10.Click, Label9.Click, Label8.Click,
    Label7.Click, Label6.Click, Label5.Click, Label4.Click, Label3.Click, Label2.Click, Label1.Click,
    MyBase.Click

        'lancement du timers afin de retourner les cartes qui ne vont pas de pair une fois les deux clique du joueur fait'
        If Timer1.Enabled Then Exit Sub

        Dim clickedLabel = TryCast(sender, Label)

        If clickedLabel IsNot Nothing Then

            If clickedLabel.ForeColor = Color.Black Then
                Exit Sub
            End If


            If PremierClique Is Nothing Then
                PremierClique = clickedLabel
                PremierClique.ForeColor = Color.Black
                Exit Sub
            End If


            SecondClique = clickedLabel
            SecondClique.ForeColor = Color.Black

            ' Check si le joueur a gagner
            VérifWin()

            If PremierClique.Text = SecondClique.Text Then
                PremierClique = Nothing
                SecondClique = Nothing
                Exit Sub
            End If

            Timer1.Start()
        End If
    End Sub

    'timers qui permet de retourner plus ou moins longtemps les cartes une fois les deux clique utiliser '
    Private Sub Timer1_Tick() Handles Timer1.Tick

        Timer1.Stop()

        PremierClique.ForeColor = PremierClique.BackColor
        SecondClique.ForeColor = SecondClique.BackColor

        PremierClique = Nothing
        SecondClique = Nothing

    End Sub


    'Vérifie si le joueur a gagner '
    'vérifie si aucune carte retourner est présente sur le plateau'
    Private Sub VérifWin()

        For Each control In TableLayoutPanel1.Controls
            Dim iconLabel = TryCast(control, Label)
            If iconLabel IsNot Nothing AndAlso
               iconLabel.ForeColor = iconLabel.BackColor Then
                Exit Sub
            End If
        Next
        Timer2.Stop()
        MessageBox.Show("Félicitation vous avez gagner")
        Close()

    End Sub

    Private Sub txtAbandon_Click(sender As Object, e As EventArgs) Handles txtAbandon.Click
        If MessageBox.Show("Êtes-vous sûr(e) de vouloir abandonner vous allez retourner au menu principal ?", "Demande de confirmation",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Close()
        End If
    End Sub


    'permet de mettre en place un timers'
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim tps As TimeSpan = TargetDT.Subtract(DateTime.Now)
        If tps.TotalMilliseconds > 0 Then
            txtTimers.Text = tps.ToString("mm\:ss")
        Else
            txtTimers.Text = "00:00"
            Timer2.Stop()
            MessageBox.Show("le temps est écoulé vous allez est rediriger vers le menu principal")
            Close()
        End If
    End Sub

    Private Sub btnAide2_Click(sender As Object, e As EventArgs) Handles btnAide2.Click
        MsgBox("Les règles du jeu sont simple vous aurez plusieurs cartes retourner en face de vous pouvez retourner seulement 2 cartes a la fois pour pouvoir gagner vous devez trouver toutes les pair de cartes avant que le temps soit fini bonne chance !")
    End Sub
End Class
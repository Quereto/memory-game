Imports System.Text.RegularExpressions
Imports System.IO



Public Class NouvellePartie

    Dim PseudoSelectionner As String 'permet de stocker le nom de l'utilisateur afin de l'enregistrer dans un fichier plupart'
    Dim Parties As List(Of DonnesAEnregistrer) = New List(Of DonnesAEnregistrer) 'Permet d'appeler la classe DonnesAEnregistrer afin d'enregistrer le nom du l'utilsateur dans un fichier'

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim F1 As New Form1()
        F1.Show()
    End Sub


    'crée lors du lancement du formulaire un sous dossiers saves permettent de stocker les docs.txt des joueurs enregistrer lors d'une session'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Not Directory.Exists("../../../saves/")) Then
            Directory.CreateDirectory("../../../saves/")
        End If


        'Permet de recharger les docs.txt afin de recharger la liste des pseudo déjà enregistrer'
        'Note c'est dernier partie c'est pas utiliser du a un manque de temps nous avons pris la décisions de laisser cette partie du code meme si elle est pas utiliser '
        Dim nomsDesFichiers = My.Computer.FileSystem.GetFiles("../../../saves/", FileIO.SearchOption.SearchTopLevelOnly, "*.JR")

        For Each nom In nomsDesFichiers
            Dim partie = New DonnesAEnregistrer()
            partie.charger(nom)

        Next
    End Sub


    Private Sub btnLancement_Click(sender As Object, e As EventArgs) Handles btnLancement.Click
        'vérifie si le pseudo rentrer par l'utilisateur comporte plus de 3 caractère'
        If ComboxPseudo.Text.Length <= 3 Then
            MsgBox("Votre pseudo doit contenir au moins 3 charactères")
        Else

            MsgBox("Votre pseudo '" + ComboxPseudo.Text + "' a bien était enregistrer")
            ComboxPseudo.Items.Add(ComboxPseudo.Text)
            PseudoSelectionner = ComboxPseudo.Text
            'stock le nom du joueur entrée'
            Dim nom = PseudoSelectionner
            Dim partie = New DonnesAEnregistrer()
            'enregistre le nom du joueur dans la classe enregistrement'
            partie.nom = nom
            partie.sauvegarder("../../../saves/")

            Dim F3 As New LaPartie()
            F3.Show()
        End If



    End Sub

    Private Sub btnAide_Click(sender As Object, e As EventArgs) Handles btnAide.Click
        MsgBox("Les règles du jeu sont simple vous aurez plusieurs cartes retourner en face de vous pouvez retourner seulement 2 cartes a la fois pour pouvoir gagner vous devez trouver toutes les pair de cartes avant que le temps soit fini bonne chance !")
    End Sub
End Class
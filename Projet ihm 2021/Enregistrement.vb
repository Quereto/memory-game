Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO


<Serializable()>
Public Class DonnesAEnregistrer
    Public nom As String


    'crée un fichier .JR (.txt) contenant les noms des utilsateurs par sessions '
    Public Sub sauvegarder(dirPath As String)
        Dim path As String = dirPath & nom & ".JR"
        Dim Serialiseur As New BinaryFormatter

        Try
            Dim FluxDeFichier As FileStream = File.OpenWrite(path)
            Serialiseur.Serialize(FluxDeFichier, Me)
            FluxDeFichier.Close()
        Catch err As Exception
            MessageBox.Show("L'opération a échoué: " & err.Message)
        End Try
    End Sub

    'recharge les fichiers pré sauvegarder dans les docs.txt mais n'est pas encore implementer dans le code permettent de recharger la liste '
    Public Sub charger(path As String)
        If File.Exists(path) = False Then
            Return
        End If

        Dim FluxDeFichier As Stream = File.OpenRead(path)
        Dim Deserialiseur As New BinaryFormatter
        Dim instance As DonnesAEnregistrer = New DonnesAEnregistrer()
        instance = CType(Deserialiseur.Deserialize(FluxDeFichier), DonnesAEnregistrer)
        FluxDeFichier.Close()

        Me.nom = instance.nom

    End Sub
End Class